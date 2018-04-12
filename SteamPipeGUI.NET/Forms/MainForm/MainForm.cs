using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SteamPipeGUI.NET
{
    public partial class MainForm : Form
    {
        private int _previousDepotIndex { get; set; }

        private string _previousBuildId { get; set; }

        private bool _isPreview { get; set; }

        private Process _steamcmdProcess;

        public MainForm()
        {
            InitializeComponent();
            Text = ProductName + " " + ProductVersion;
            versionLabel.Text = ProductVersion;
            LoadEnvironment();
            LoadConfiguration();
            AppendLog("Application initilized.");
        }

        private void LoadConfiguration()
        {
            if (!File.Exists(Application.StartupPath + @"\scripts\SteamPipeGUI.NET.Configuration.JSON")) {
                return;
            }
            Configuration configuration =
                JsonConvert.DeserializeObject<Configuration>(
                    File.ReadAllText(Application.StartupPath + @"\scripts\SteamPipeGUI.NET.Configuration.JSON"));
            setLiveComboBox.Items.AddRange(configuration.Branches);
            steamcmdPathTextBox.Text = configuration.SteamCmdPath;
            usernameTextBox.Text = configuration.SteamLogin;
        }

        private void SaveConfiguration()
        {
            Configuration configuration = new Configuration {
                Branches = setLiveComboBox.Items.Cast<object>().ToArray(),
                SteamCmdPath = steamcmdPathTextBox.Text,
                SteamLogin = usernameTextBox.Text
            };
            File.WriteAllText(Application.StartupPath + @"\scripts\SteamPipeGUI.NET.Configuration.JSON",
                JsonConvert.SerializeObject(configuration, Formatting.Indented));
        }

        private void AppendLog(string log)
        {
            AppendLog(log, false, false);
        }

        private void AppendLog(string log, bool isSteamCmd, bool isError)
        {
            if (InvokeRequired) {
                Invoke(new Action<string, bool, bool>(AppendLog), log, isSteamCmd, isError);
            } else {
                logBox.Text += (string.IsNullOrWhiteSpace(logBox.Text) ? string.Empty : Environment.NewLine) +
                               (!isSteamCmd
                                   ? "[SteamPipeGUI.NET]"
                                   : "[STEAMCMD.EXE]" + (isError ? "[ERROR]" : "[INFO]")) +
                               " " + log;
                logBox.SelectionStart = logBox.Text.Length;
                logBox.ScrollToCaret();
            }
        }

        private void ProcessSteamcmdLog(string log, bool isError)
        {
            if (string.IsNullOrEmpty(log)) {
                return;
            }
            AppendLog(log, true, isError);
            if (Regex.Match(log, @"Logging in user").Success && string.IsNullOrWhiteSpace(passwordTextBox.Text)) {
                string str = string.Empty, str1 = string.Empty;
                Invoke((MethodInvoker) delegate { str = logBox.Text; });
                Thread.Sleep(10000);
                Invoke((MethodInvoker) delegate { str1 = logBox.Text; });
                if (str != str1 || _steamcmdProcess.HasExited) {
                    return;
                }
            }
            Invoke((MethodInvoker) delegate {
                if (Regex.Match(log, @"Logging in user '(\w+)'").Success && string.IsNullOrWhiteSpace(passwordTextBox.Text)) {
                    InputForm form =
                        new InputForm($"password for '{Regex.Match(log, @"Logging in user '(\w+)'").Groups[1].Value}'",
                            true);
                    form.ShowDialog();
                    _steamcmdProcess.StandardInput.WriteLine(form.Result);
                    return;
                }

                if (Regex.Match(log, @"Enter the current code from your Steam Guard Mobile Authenticator app").Success) {
                    InputForm form = new InputForm("two-factor code", false);
                    form.ShowDialog();
                    _steamcmdProcess.StandardInput.WriteLine(form.Result);
                    return;
                }

                if (Regex.Match(log, @"Building depot (\w+)...").Success) {
                    statusBar.Style = ProgressBarStyle.Blocks;
                    statusBar.Value++;
                    statusLabel.Text =
                        $"Working with depot `{Regex.Match(log, @"Building depot (\w+)...").Groups[1].Value}` [{statusBar.Value}/{statusBar.Maximum}]...";
                    return;
                }

                if (Regex.Match(log, @"ERROR!").Success) {
                    SystemSounds.Asterisk.Play();
                    statusLabel.Text = "Error! Check out the logs.";
                    AppendLog("Build has probably been uploaded, but an error has occurred!");
                }

                if (Regex.Match(log, @"FAILED with result code (\w+)").Success) {
                    SystemSounds.Exclamation.Play();
                    statusLabel.Text = log;
                    AppendLog("The build was NOT uploaded! Check out the logs.");
                }

                if (Regex.Match(log, @"BuildID (\w+)").Success) {
                    statusBar.Value++;
                    statusLabel.Text =
                        $"Successfully uploaded! BuildID {Regex.Match(log, @"BuildID (\w+)").Groups[1].Value}.";
                    _previousBuildId = Regex.Match(log, @"BuildID (\w+)").Groups[1].Value;
                    AppendLog($"Build has been uploaded under ID `{_previousBuildId}`.");
                    new UploadedForm(appIdBox.Text, _previousBuildId).ShowDialog();
                }
            });
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_steamcmdProcess != null && !_steamcmdProcess.HasExited) {
                MessageBox.Show("STEAMCMD.EXE is still working.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                e.Cancel = true;
                return;
            }
            SaveConfiguration();
        }

        private void FileMappingGrid_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["LocalPath"].Value = ".";
            e.Row.Cells["DepotPath"].Value = ".";
            e.Row.Cells["Recursive"].Value = "1";
        }

        private void AddNewDepotButton_Click(object sender, EventArgs e)
        {
            if (depotSaveButton.Enabled) {
                if (MessageBox.Show("All unsaved changes will be lost. Are you sure want to continue?", "Warning",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) {
                    return;
                }
            }
            AddDepotForm form = new AddDepotForm();
            DialogResult result = form.ShowDialog();
            if (result != DialogResult.OK) {
                return;
            }
            if (depotListBox.Items.Contains(form.depotId.Text)) {
                return;
            }
            depotListBox.Items.Add(form.depotId.Text);
            Depot depot = new Depot(int.Parse(form.depotId.Text));
            File.WriteAllText(Application.StartupPath + $@"\scripts\depot_build_{depot.DepotId}.vdf", depot.ToString());
            depotSaveButton.Enabled = false;
            depotListBox.SelectedItem = form.depotId.Text;
            AppendLog($"Depot '{depot.DepotId}' created successfully.");
        }

        private void depotListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (depotSaveButton.Enabled) {
                if (depotListBox.SelectedIndex == _previousDepotIndex) {
                    return;
                }
                if (MessageBox.Show("All unsaved changes will be lost. Are you sure want to continue?", "Warning",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) {
                    depotListBox.SelectedIndex = _previousDepotIndex;
                    return;
                }
            }
            try {
                LoadDepot();
                depotSaveButton.Enabled = false;
                depotRevertButton.Enabled = false;
            }
            catch (Exception exception) {
                AppendLog($"An unhandled exception is occured:{Environment.NewLine}{exception}");
            }
        }

        private void depotSaveButton_Click(object sender, EventArgs e)
        {
            Depot depot = new Depot(int.Parse(depotListBox.SelectedItem.ToString())) {
                ContentRoot = depotContentRootPath.Text,
                FileMappings = new List<FileMapping>()
            };
            AppendLog($"Saving depot '{depot.DepotId}'...");
            foreach (
                DataGridViewRow row in FileMappingGrid.Rows.Cast<DataGridViewRow>().Where(x => x.Cells[0].Value != null)
            ) {
                depot.FileMappings.Add(new FileMapping {
                    LocalPath = row.Cells[0].Value.ToString(),
                    DepotPath = row.Cells[1].Value.ToString(),
                    Recursive = int.Parse(row.Cells[2].Value.ToString())
                });
            }
            depot.FileExclusions = new List<FileExclusion>();
            foreach (DataGridViewRow row in ExclusionsDataGrid.Rows) {
                if (row.Cells[0].Value == null) {
                    continue;
                }
                depot.FileExclusions.Add(new FileExclusion {
                    Pattern = row.Cells[0].Value.ToString()
                });
            }
            File.WriteAllText(Application.StartupPath + $@"\scripts\depot_build_{depot.DepotId}.vdf", depot.ToString());
            depotSaveButton.Enabled = depotRevertButton.Enabled = false;
            AppendLog($"Depot '{depot.DepotId}' saved successfully.");
        }

        private void LoadEnvironment()
        {
            depotListBox.Items.Clear();
            AppendLog("Preparing environment...");
            DirectoryInfo directoryInfos = new DirectoryInfo(Application.StartupPath + @"\scripts\");
            Regex regex = new Regex("depot_build_(.+).vdf");
            depotListBox.Items.AddRange((from x in directoryInfos.GetFiles()
                where regex.Match(x.Name).Success
                select regex.Match(x.Name).Groups[1].Value).ToArray<object>());
            AppendLog($"Loaded {depotListBox.Items.Count} depot(s).");
            regex = new Regex("app_build_(.+).vdf");
            string[] builds =
                directoryInfos.GetFiles().Where(x => regex.Match(x.Name).Success).Select(x => x.FullName).ToArray();
            if (builds.Length != 0) {
                LoadBuild(builds[0]);
                AppendLog("Loaded build from a file.");
            } else {
                LoadBuild(new Build(480));
                AppendLog("Loaded default build.");
            }
            if (depotListBox.Items.Count != 0) {
                depotListBox.SelectedIndex = 0;
            }
            depotSaveButton.Enabled = depotRevertButton.Enabled = false;
            AppendLog("Environment prepared successfully.");
        }

        private void LoadBuild(string path)
        {
            LoadBuild(new Build(path));
        }

        private void LoadBuild(Build build)
        {
            appIdBox.Text = build.AppId.ToString();
            descBox.Text = build.BuildDescription;
            setLiveComboBox.Text = build.SetLive;
            outputTextBox.Text = build.BuildOutput;
            contentTextBox.Text = build.ContentRoot;
            localServerTextBox.Text = build.Local;
        }

        private void LoadDepot()
        {
            depotGroup.Text = $"Depot '{depotListBox.SelectedItem}'";
            Depot selectedDepot =
                File.Exists(Application.StartupPath + $@"\scripts\depot_build_{depotListBox.SelectedItem}.vdf")
                    ? new Depot(Application.StartupPath + $@"\scripts\depot_build_{depotListBox.SelectedItem}.vdf")
                    : new Depot(int.Parse(depotListBox.SelectedItem.ToString()));
            depotContentRootPath.Text = selectedDepot.ContentRoot;
            FileMappingGrid.Rows.Clear();
            ExclusionsDataGrid.Rows.Clear();
            foreach (FileMapping fm in selectedDepot.FileMappings) {
                FileMappingGrid.Rows.Add(fm.LocalPath, fm.DepotPath, fm.Recursive);
            }
            foreach (FileExclusion ex in selectedDepot.FileExclusions) {
                ExclusionsDataGrid.Rows.Add(ex.Pattern);
            }
        }

        private void depotRemoveButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.No) {
                return;
            }
            AppendLog($"Removing depot '{depotListBox.SelectedItem}'...");
            File.Delete(Application.StartupPath + $@"\scripts\depot_build_{depotListBox.SelectedItem}.vdf");
            AppendLog($"Depot '{depotListBox.SelectedItem}' removed successfully.");
            depotListBox.Items.Remove(depotListBox.SelectedItem);
            if (depotListBox.Items.Count != 0) {
                depotListBox.SelectedIndex = 0;
            }
        }

        private void Grid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _previousDepotIndex = depotListBox.SelectedIndex;
            depotSaveButton.Enabled = depotRevertButton.Enabled = true;
        }

        private void depotContentRootPath_TextChanged(object sender, EventArgs e)
        {
            _previousDepotIndex = depotListBox.SelectedIndex;
            depotSaveButton.Enabled = true;
            depotRevertButton.Enabled = true;
        }

        private void depotRevertButton_Click(object sender, EventArgs e)
        {
            LoadDepot();
            AppendLog($"Changes for depot '{depotListBox.SelectedItem}' have been reverted.");
            depotSaveButton.Enabled = depotRevertButton.Enabled = false;
        }

        private void buildUploadButton_Click(object sender, EventArgs e)
        {
            if (uploadButton.Text == "Abort") {
                _steamcmdProcess.Kill();
                uploadButton.Enabled = false;
                return;
            }
            if (!File.Exists(steamcmdPathTextBox.Text)) {
                MessageBox.Show("STEAMCMD.EXE is not exist or the provided path is invalid.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (setLiveComboBox.Text == "default") {
                MessageBox.Show("Builds for `default` branch should be applied manually on Steamworks website.",
                    "Set Live", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                setLiveComboBox.Text = string.Empty;
            }
            if (!setLiveComboBox.Items.Contains(setLiveComboBox.Text)) {
                setLiveComboBox.Items.Add(setLiveComboBox.Text);
            }
            SaveConfiguration();
            AppendLog("Generating app_build...");
            Build build = new Build(int.Parse(appIdBox.Text)) {
                BuildDescription = descBox.Text,
                Depots = depotListBox.Items.Cast<string>().ToList(),
                SetLive = setLiveComboBox.Text,
                ContentRoot = contentTextBox.Text,
                BuildOutput = outputTextBox.Text,
                Local = localServerTextBox.Text,
                Preview = _isPreview
            };
            File.WriteAllText(Application.StartupPath + $@"\scripts\app_build_{appIdBox.Text}.vdf", build.ToString());
            AppendLog("Creating process...");
            ProcessStartInfo proc = new ProcessStartInfo {
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                RedirectStandardInput = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                FileName = steamcmdPathTextBox.Text,
                StandardErrorEncoding = Encoding.UTF8,
                WorkingDirectory = Application.StartupPath,
                Arguments =
                    $@"+login {usernameTextBox.Text +
                               (string.IsNullOrWhiteSpace(passwordTextBox.Text)
                                   ? string.Empty
                                   : " " + passwordTextBox.Text)} +run_app_build_http ""{Application
                                                                                             .StartupPath +
                                                                                         $@"\scripts\app_build_{appIdBox
                                                                                             .Text}.vdf"}"" +quit"
            };
            _steamcmdProcess = new Process {
                StartInfo = proc,
                EnableRaisingEvents = true
            };
            _steamcmdProcess.OutputDataReceived +=
                (s, args) => { new Thread(() => ProcessSteamcmdLog(args.Data, false)).Start();
                };
            _steamcmdProcess.ErrorDataReceived +=
                (s, args) => { new Thread(() => ProcessSteamcmdLog(args.Data, true)).Start();
                };
            _steamcmdProcess.Exited +=
                (s, args) => {
                    Invoke((MethodInvoker) delegate {
                        AppendLog($"Process has been finished with error code {_steamcmdProcess.ExitCode}.");
                        uploadButton.Enabled = true;
                        previewButton.Enabled = true;
                        reloadEnviButton.Enabled = true;
                        statusLabel.Text = "Ready!";
                        uploadButton.Text = "Upload";
                        statusBar.Style = ProgressBarStyle.Blocks;
                        statusBar.Value = 0;
                        _isPreview = false;
                    });
                };
            _steamcmdProcess.Start();
            _steamcmdProcess.BeginOutputReadLine();
            _steamcmdProcess.BeginErrorReadLine();
            AppendLog("Process has been launched.");
            previewButton.Enabled = false;
            reloadEnviButton.Enabled = false;
            statusLabel.Text = "Preparing things up...";
            statusBar.Value = 0;
            statusBar.Maximum = depotListBox.Items.Count + 1;
            statusBar.Style = ProgressBarStyle.Marquee;
            uploadButton.Text = "Abort";
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog {
                Filter = "STEAMCMD.EXE|STEAMCMD.EXE|All Files (*.*)|*.*",
                Multiselect = false
            };
            if (fileDialog.ShowDialog() == DialogResult.OK) {
                steamcmdPathTextBox.Text = fileDialog.FileName;
            }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = showPasswordCheckBox.Checked ? '\0' : '*';
        }

        private void steamcmdPathTextBox_TextChanged(object sender, EventArgs e)
        {
            bool enabled = !string.IsNullOrWhiteSpace(usernameTextBox.Text) &&
                           !string.IsNullOrWhiteSpace(steamcmdPathTextBox.Text);
            uploadButton.Enabled = enabled;
            previewButton.Enabled = enabled;
        }

        private void buildPreviewButton_Click(object sender, EventArgs e)
        {
            _isPreview = true;
            uploadButton.PerformClick();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start((sender as LinkLabel).Text);
        }

        private void buildReloadEnviButton_Click(object sender, EventArgs e)
        {
            LoadEnvironment();
        }
    }
}
