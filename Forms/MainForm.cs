using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SteamPipeGUI.NET.Forms;

namespace SteamPipeGUI.NET
{
    public partial class MainForm : Form
    {
        private int _previousDepotIndex { get; set; }

        public MainForm()
        {
            InitializeComponent();
            LoadEnvironment();
            AppendLog("Application initilized.");
        }

        private void AppendLog(string log)
        {
            logBox.Text += (string.IsNullOrWhiteSpace(logBox.Text) ? string.Empty : Environment.NewLine) +
                           "[SteamPipeGUI.NET] " + log;
            logBox.SelectionStart = logBox.Text.Length;
            logBox.ScrollToCaret();
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
                depotSaveButton.Enabled = depotRevertButton.Enabled = false;
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
            liveComboBox.Text = build.SetLive;
            outputTextBox.Text = build.BuildOutput;
            contentTextBox.Text = build.ContentRoot;
            localServerTextBox.Text = build.Local;
        }

        private void LoadDepot()
        {
            depotGroupBox.Text = $"Depot '{depotListBox.SelectedItem}'";
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
            depotSaveButton.Enabled = depotRevertButton.Enabled = true;
        }

        private void depotRevertButton_Click(object sender, EventArgs e)
        {
            LoadDepot();
            AppendLog($"Changes for depot '{depotListBox.SelectedItem}' have been reverted.");
            depotSaveButton.Enabled = depotRevertButton.Enabled = false;
        }

        private void buildUploadButton_Click(object sender, EventArgs e)
        {
            AppendLog("Generating app_build...");
            Build build = new Build(int.Parse(appIdBox.Text)) {
                BuildDescription = descBox.Text,
                Depots = depotListBox.Items.Cast<string>().ToList(),
                SetLive = liveComboBox.Text,
                ContentRoot = contentTextBox.Text,
                BuildOutput = outputTextBox.Text,
                Local = localServerTextBox.Text
            };
            File.WriteAllText(Application.StartupPath + $@"\scripts\app_build_{appIdBox.Text}.vdf", build.ToString());
            AppendLog("Creating process...");
            ProcessStartInfo proc = new ProcessStartInfo {
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                FileName = steamcmdPathTextBox.Text,
                StandardErrorEncoding = Encoding.UTF8,
                WorkingDirectory = Application.StartupPath,
                Arguments =
                    $@"+login {usernameTextBox.Text +
                               (string.IsNullOrWhiteSpace(passwordTextBox.Text)
                                   ? string.Empty
                                   : " " + passwordTextBox.Text)} +run_app_build_http ""{Application.StartupPath +
                                                                                         $@"\scripts\app_build_{appIdBox
                                                                                             .Text}.vdf"}"" +quit"
            };
            AppendLog(
                $"Process info:\n.FileName: {proc.FileName}\n.Arguments: {proc.Arguments.Replace(passwordTextBox.Text, $"<{new string('*', passwordTextBox.TextLength)}>")}");
        }
    }
}
