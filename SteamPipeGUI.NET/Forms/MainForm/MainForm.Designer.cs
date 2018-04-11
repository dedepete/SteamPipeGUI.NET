namespace SteamPipeGUI.NET
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.buildConfigPage = new System.Windows.Forms.TabPage();
            this.mainConfigGroup = new System.Windows.Forms.GroupBox();
            this.sdkTip = new System.Windows.Forms.Label();
            this.passTip = new System.Windows.Forms.Label();
            this.usernameTip = new System.Windows.Forms.Label();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.cmdPathLabel = new System.Windows.Forms.Label();
            this.steamcmdPathTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.buildConfigGroup = new System.Windows.Forms.GroupBox();
            this.localTip = new System.Windows.Forms.Label();
            this.contentTip = new System.Windows.Forms.Label();
            this.outputTip = new System.Windows.Forms.Label();
            this.appIdTip = new System.Windows.Forms.Label();
            this.localServerTextBox = new System.Windows.Forms.TextBox();
            this.localServerLabel = new System.Windows.Forms.Label();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.contentDirLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.outputDirLabel = new System.Windows.Forms.Label();
            this.appIdBox = new System.Windows.Forms.TextBox();
            this.appIdLabel = new System.Windows.Forms.Label();
            this.depotManagmentPage = new System.Windows.Forms.TabPage();
            this.depotGroup = new System.Windows.Forms.GroupBox();
            this.depotRevertButton = new System.Windows.Forms.Button();
            this.depotSaveButton = new System.Windows.Forms.Button();
            this.depotTabControl = new System.Windows.Forms.TabControl();
            this.depotBasicPage = new System.Windows.Forms.TabPage();
            this.depotContentRootPath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.depotMappingsPage = new System.Windows.Forms.TabPage();
            this.FileMappingGrid = new System.Windows.Forms.DataGridView();
            this.LocalPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepotPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recursive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.depotExclusionsPage = new System.Windows.Forms.TabPage();
            this.ExclusionsDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depotRemoveButton = new System.Windows.Forms.Button();
            this.AddNewDepotButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.depotListBox = new System.Windows.Forms.ListBox();
            this.aboutPage = new System.Windows.Forms.TabPage();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.jsonLink = new System.Windows.Forms.LinkLabel();
            this.vdfLink = new System.Windows.Forms.LinkLabel();
            this.jsonLabel = new System.Windows.Forms.Label();
            this.vdfLabel = new System.Windows.Forms.Label();
            this.poweredWithLabel = new System.Windows.Forms.Label();
            this.myLink = new System.Windows.Forms.LinkLabel();
            this.developedByLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.buildDescLabel = new System.Windows.Forms.Label();
            this.descBox = new System.Windows.Forms.TextBox();
            this.setLiveLabel = new System.Windows.Forms.Label();
            this.setLiveComboBox = new System.Windows.Forms.ComboBox();
            this.uploadButton = new System.Windows.Forms.Button();
            this.previewButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.reloadEnviButton = new System.Windows.Forms.Button();
            this.infoTip = new System.Windows.Forms.ToolTip(this.components);
            this.mainTabControl.SuspendLayout();
            this.buildConfigPage.SuspendLayout();
            this.mainConfigGroup.SuspendLayout();
            this.buildConfigGroup.SuspendLayout();
            this.depotManagmentPage.SuspendLayout();
            this.depotGroup.SuspendLayout();
            this.depotTabControl.SuspendLayout();
            this.depotBasicPage.SuspendLayout();
            this.depotMappingsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileMappingGrid)).BeginInit();
            this.depotExclusionsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExclusionsDataGrid)).BeginInit();
            this.aboutPage.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // logBox
            // 
            this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logBox.HideSelection = false;
            this.logBox.Location = new System.Drawing.Point(0, 268);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(784, 94);
            this.logBox.TabIndex = 0;
            this.logBox.Text = "";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.mainTabControl.Controls.Add(this.buildConfigPage);
            this.mainTabControl.Controls.Add(this.depotManagmentPage);
            this.mainTabControl.Controls.Add(this.aboutPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(784, 362);
            this.mainTabControl.TabIndex = 1;
            // 
            // buildConfigPage
            // 
            this.buildConfigPage.Controls.Add(this.mainConfigGroup);
            this.buildConfigPage.Controls.Add(this.buildConfigGroup);
            this.buildConfigPage.Location = new System.Drawing.Point(4, 25);
            this.buildConfigPage.Name = "buildConfigPage";
            this.buildConfigPage.Padding = new System.Windows.Forms.Padding(3);
            this.buildConfigPage.Size = new System.Drawing.Size(776, 333);
            this.buildConfigPage.TabIndex = 0;
            this.buildConfigPage.Text = "Build Configuration";
            this.buildConfigPage.UseVisualStyleBackColor = true;
            // 
            // mainConfigGroup
            // 
            this.mainConfigGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainConfigGroup.Controls.Add(this.sdkTip);
            this.mainConfigGroup.Controls.Add(this.passTip);
            this.mainConfigGroup.Controls.Add(this.usernameTip);
            this.mainConfigGroup.Controls.Add(this.showPasswordCheckBox);
            this.mainConfigGroup.Controls.Add(this.browseButton);
            this.mainConfigGroup.Controls.Add(this.cmdPathLabel);
            this.mainConfigGroup.Controls.Add(this.steamcmdPathTextBox);
            this.mainConfigGroup.Controls.Add(this.usernameTextBox);
            this.mainConfigGroup.Controls.Add(this.passwordLabel);
            this.mainConfigGroup.Controls.Add(this.label4);
            this.mainConfigGroup.Controls.Add(this.passwordTextBox);
            this.mainConfigGroup.Location = new System.Drawing.Point(8, 6);
            this.mainConfigGroup.Name = "mainConfigGroup";
            this.mainConfigGroup.Size = new System.Drawing.Size(762, 102);
            this.mainConfigGroup.TabIndex = 5;
            this.mainConfigGroup.TabStop = false;
            this.mainConfigGroup.Text = "Main Configuration";
            // 
            // sdkTip
            // 
            this.sdkTip.AutoSize = true;
            this.sdkTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sdkTip.Location = new System.Drawing.Point(140, 74);
            this.sdkTip.Name = "sdkTip";
            this.sdkTip.Size = new System.Drawing.Size(25, 13);
            this.sdkTip.TabIndex = 10;
            this.sdkTip.Text = "( ? )";
            this.infoTip.SetToolTip(this.sdkTip, "Path to the STEAMCMD.EXE from Steamworks SDK.");
            // 
            // passTip
            // 
            this.passTip.AutoSize = true;
            this.passTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passTip.Location = new System.Drawing.Point(140, 48);
            this.passTip.Name = "passTip";
            this.passTip.Size = new System.Drawing.Size(25, 13);
            this.passTip.TabIndex = 9;
            this.passTip.Text = "( ? )";
            this.infoTip.SetToolTip(this.passTip, "Steam Password of account with the permission to upload builds on Steam.\r\n\r\n[Opti" +
        "onal] If Steam remembers your last session.");
            // 
            // usernameTip
            // 
            this.usernameTip.AutoSize = true;
            this.usernameTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTip.Location = new System.Drawing.Point(140, 22);
            this.usernameTip.Name = "usernameTip";
            this.usernameTip.Size = new System.Drawing.Size(25, 13);
            this.usernameTip.TabIndex = 8;
            this.usernameTip.Text = "( ? )";
            this.infoTip.SetToolTip(this.usernameTip, "Steam Username of account with the permission to upload builds on Steam.");
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(391, 47);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(102, 17);
            this.showPasswordCheckBox.TabIndex = 7;
            this.showPasswordCheckBox.Text = "Show Password";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(391, 69);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 6;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // cmdPathLabel
            // 
            this.cmdPathLabel.AutoSize = true;
            this.cmdPathLabel.Location = new System.Drawing.Point(10, 74);
            this.cmdPathLabel.Name = "cmdPathLabel";
            this.cmdPathLabel.Size = new System.Drawing.Size(120, 13);
            this.cmdPathLabel.TabIndex = 5;
            this.cmdPathLabel.Text = "STEAMCMD.EXE Path:";
            // 
            // steamcmdPathTextBox
            // 
            this.steamcmdPathTextBox.Location = new System.Drawing.Point(178, 71);
            this.steamcmdPathTextBox.Name = "steamcmdPathTextBox";
            this.steamcmdPathTextBox.Size = new System.Drawing.Size(207, 20);
            this.steamcmdPathTextBox.TabIndex = 4;
            this.steamcmdPathTextBox.TextChanged += new System.EventHandler(this.steamcmdPathTextBox_TextChanged);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(178, 19);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(207, 20);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.steamcmdPathTextBox_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(10, 48);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(135, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Steam Password (optional):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Steam Username:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(178, 45);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(207, 20);
            this.passwordTextBox.TabIndex = 2;
            // 
            // buildConfigGroup
            // 
            this.buildConfigGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buildConfigGroup.Controls.Add(this.localTip);
            this.buildConfigGroup.Controls.Add(this.contentTip);
            this.buildConfigGroup.Controls.Add(this.outputTip);
            this.buildConfigGroup.Controls.Add(this.appIdTip);
            this.buildConfigGroup.Controls.Add(this.localServerTextBox);
            this.buildConfigGroup.Controls.Add(this.localServerLabel);
            this.buildConfigGroup.Controls.Add(this.contentTextBox);
            this.buildConfigGroup.Controls.Add(this.contentDirLabel);
            this.buildConfigGroup.Controls.Add(this.outputTextBox);
            this.buildConfigGroup.Controls.Add(this.outputDirLabel);
            this.buildConfigGroup.Controls.Add(this.appIdBox);
            this.buildConfigGroup.Controls.Add(this.appIdLabel);
            this.buildConfigGroup.Location = new System.Drawing.Point(6, 114);
            this.buildConfigGroup.Name = "buildConfigGroup";
            this.buildConfigGroup.Size = new System.Drawing.Size(764, 123);
            this.buildConfigGroup.TabIndex = 4;
            this.buildConfigGroup.TabStop = false;
            this.buildConfigGroup.Text = "Build Configuration";
            // 
            // localTip
            // 
            this.localTip.AutoSize = true;
            this.localTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.localTip.Location = new System.Drawing.Point(142, 100);
            this.localTip.Name = "localTip";
            this.localTip.Size = new System.Drawing.Size(25, 13);
            this.localTip.TabIndex = 14;
            this.localTip.Text = "( ? )";
            this.infoTip.SetToolTip(this.localTip, "Path to a local content server.\r\n\r\n[Default] Empty.");
            // 
            // contentTip
            // 
            this.contentTip.AutoSize = true;
            this.contentTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contentTip.Location = new System.Drawing.Point(142, 74);
            this.contentTip.Name = "contentTip";
            this.contentTip.Size = new System.Drawing.Size(25, 13);
            this.contentTip.TabIndex = 13;
            this.contentTip.Text = "( ? )";
            this.infoTip.SetToolTip(this.contentTip, "Content directory path.\r\n\r\n[Default] \'..\\content\\\'");
            // 
            // outputTip
            // 
            this.outputTip.AutoSize = true;
            this.outputTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputTip.Location = new System.Drawing.Point(142, 48);
            this.outputTip.Name = "outputTip";
            this.outputTip.Size = new System.Drawing.Size(25, 13);
            this.outputTip.TabIndex = 12;
            this.outputTip.Text = "( ? )";
            this.infoTip.SetToolTip(this.outputTip, "Output directory path.\r\n\r\n[Default] \'..\\output\\\'");
            // 
            // appIdTip
            // 
            this.appIdTip.AutoSize = true;
            this.appIdTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appIdTip.Location = new System.Drawing.Point(142, 22);
            this.appIdTip.Name = "appIdTip";
            this.appIdTip.Size = new System.Drawing.Size(25, 13);
            this.appIdTip.TabIndex = 11;
            this.appIdTip.Text = "( ? )";
            this.infoTip.SetToolTip(this.appIdTip, "Application\'s APPID.\r\n\r\n[Default] Spacewar\'s one (480)");
            // 
            // localServerTextBox
            // 
            this.localServerTextBox.Location = new System.Drawing.Point(180, 97);
            this.localServerTextBox.Name = "localServerTextBox";
            this.localServerTextBox.Size = new System.Drawing.Size(207, 20);
            this.localServerTextBox.TabIndex = 6;
            // 
            // localServerLabel
            // 
            this.localServerLabel.AutoSize = true;
            this.localServerLabel.Location = new System.Drawing.Point(10, 100);
            this.localServerLabel.Name = "localServerLabel";
            this.localServerLabel.Size = new System.Drawing.Size(95, 13);
            this.localServerLabel.TabIndex = 7;
            this.localServerLabel.Text = "Local Server Path:";
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(180, 71);
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(207, 20);
            this.contentTextBox.TabIndex = 4;
            // 
            // contentDirLabel
            // 
            this.contentDirLabel.AutoSize = true;
            this.contentDirLabel.Location = new System.Drawing.Point(10, 74);
            this.contentDirLabel.Name = "contentDirLabel";
            this.contentDirLabel.Size = new System.Drawing.Size(92, 13);
            this.contentDirLabel.TabIndex = 5;
            this.contentDirLabel.Text = "Content Directory:";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(180, 45);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(207, 20);
            this.outputTextBox.TabIndex = 2;
            // 
            // outputDirLabel
            // 
            this.outputDirLabel.AutoSize = true;
            this.outputDirLabel.Location = new System.Drawing.Point(10, 48);
            this.outputDirLabel.Name = "outputDirLabel";
            this.outputDirLabel.Size = new System.Drawing.Size(87, 13);
            this.outputDirLabel.TabIndex = 3;
            this.outputDirLabel.Text = "Output Directory:";
            this.infoTip.SetToolTip(this.outputDirLabel, "Зрада");
            // 
            // appIdBox
            // 
            this.appIdBox.Location = new System.Drawing.Point(180, 19);
            this.appIdBox.Name = "appIdBox";
            this.appIdBox.Size = new System.Drawing.Size(77, 20);
            this.appIdBox.TabIndex = 0;
            // 
            // appIdLabel
            // 
            this.appIdLabel.AutoSize = true;
            this.appIdLabel.Location = new System.Drawing.Point(10, 22);
            this.appIdLabel.Name = "appIdLabel";
            this.appIdLabel.Size = new System.Drawing.Size(40, 13);
            this.appIdLabel.TabIndex = 1;
            this.appIdLabel.Text = "AppID:";
            // 
            // depotManagmentPage
            // 
            this.depotManagmentPage.Controls.Add(this.depotGroup);
            this.depotManagmentPage.Controls.Add(this.AddNewDepotButton);
            this.depotManagmentPage.Controls.Add(this.label7);
            this.depotManagmentPage.Controls.Add(this.depotListBox);
            this.depotManagmentPage.Location = new System.Drawing.Point(4, 25);
            this.depotManagmentPage.Name = "depotManagmentPage";
            this.depotManagmentPage.Padding = new System.Windows.Forms.Padding(3);
            this.depotManagmentPage.Size = new System.Drawing.Size(776, 333);
            this.depotManagmentPage.TabIndex = 1;
            this.depotManagmentPage.Text = "Depot Managment";
            this.depotManagmentPage.UseVisualStyleBackColor = true;
            // 
            // depotGroup
            // 
            this.depotGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.depotGroup.Controls.Add(this.depotRevertButton);
            this.depotGroup.Controls.Add(this.depotSaveButton);
            this.depotGroup.Controls.Add(this.depotTabControl);
            this.depotGroup.Controls.Add(this.depotRemoveButton);
            this.depotGroup.Location = new System.Drawing.Point(114, 6);
            this.depotGroup.Name = "depotGroup";
            this.depotGroup.Size = new System.Drawing.Size(654, 231);
            this.depotGroup.TabIndex = 3;
            this.depotGroup.TabStop = false;
            this.depotGroup.Text = "Depot \'1000\'";
            // 
            // depotRevertButton
            // 
            this.depotRevertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.depotRevertButton.Enabled = false;
            this.depotRevertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depotRevertButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.depotRevertButton.Location = new System.Drawing.Point(453, 202);
            this.depotRevertButton.Name = "depotRevertButton";
            this.depotRevertButton.Size = new System.Drawing.Size(94, 23);
            this.depotRevertButton.TabIndex = 7;
            this.depotRevertButton.Text = "Revert Changes";
            this.depotRevertButton.UseVisualStyleBackColor = true;
            this.depotRevertButton.Click += new System.EventHandler(this.depotRevertButton_Click);
            // 
            // depotSaveButton
            // 
            this.depotSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.depotSaveButton.Enabled = false;
            this.depotSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depotSaveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.depotSaveButton.Location = new System.Drawing.Point(553, 202);
            this.depotSaveButton.Name = "depotSaveButton";
            this.depotSaveButton.Size = new System.Drawing.Size(94, 23);
            this.depotSaveButton.TabIndex = 6;
            this.depotSaveButton.Text = "Save";
            this.depotSaveButton.UseVisualStyleBackColor = true;
            this.depotSaveButton.Click += new System.EventHandler(this.depotSaveButton_Click);
            // 
            // depotTabControl
            // 
            this.depotTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.depotTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.depotTabControl.Controls.Add(this.depotBasicPage);
            this.depotTabControl.Controls.Add(this.depotMappingsPage);
            this.depotTabControl.Controls.Add(this.depotExclusionsPage);
            this.depotTabControl.Location = new System.Drawing.Point(3, 16);
            this.depotTabControl.Name = "depotTabControl";
            this.depotTabControl.SelectedIndex = 0;
            this.depotTabControl.Size = new System.Drawing.Size(648, 180);
            this.depotTabControl.TabIndex = 0;
            this.depotTabControl.Tag = "";
            // 
            // depotBasicPage
            // 
            this.depotBasicPage.Controls.Add(this.depotContentRootPath);
            this.depotBasicPage.Controls.Add(this.label8);
            this.depotBasicPage.Location = new System.Drawing.Point(4, 25);
            this.depotBasicPage.Name = "depotBasicPage";
            this.depotBasicPage.Padding = new System.Windows.Forms.Padding(3);
            this.depotBasicPage.Size = new System.Drawing.Size(640, 151);
            this.depotBasicPage.TabIndex = 0;
            this.depotBasicPage.Text = "Basic Settings";
            this.depotBasicPage.UseVisualStyleBackColor = true;
            // 
            // depotContentRootPath
            // 
            this.depotContentRootPath.Location = new System.Drawing.Point(84, 4);
            this.depotContentRootPath.Name = "depotContentRootPath";
            this.depotContentRootPath.Size = new System.Drawing.Size(207, 20);
            this.depotContentRootPath.TabIndex = 3;
            this.depotContentRootPath.TextChanged += new System.EventHandler(this.depotContentRootPath_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Content Root:";
            // 
            // depotMappingsPage
            // 
            this.depotMappingsPage.Controls.Add(this.FileMappingGrid);
            this.depotMappingsPage.Location = new System.Drawing.Point(4, 25);
            this.depotMappingsPage.Name = "depotMappingsPage";
            this.depotMappingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.depotMappingsPage.Size = new System.Drawing.Size(640, 151);
            this.depotMappingsPage.TabIndex = 1;
            this.depotMappingsPage.Text = "File Mappings";
            this.depotMappingsPage.UseVisualStyleBackColor = true;
            // 
            // FileMappingGrid
            // 
            this.FileMappingGrid.AllowUserToResizeColumns = false;
            this.FileMappingGrid.AllowUserToResizeRows = false;
            this.FileMappingGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FileMappingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FileMappingGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LocalPath,
            this.DepotPath,
            this.Recursive});
            this.FileMappingGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileMappingGrid.Location = new System.Drawing.Point(3, 3);
            this.FileMappingGrid.Name = "FileMappingGrid";
            this.FileMappingGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FileMappingGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FileMappingGrid.ShowCellErrors = false;
            this.FileMappingGrid.ShowEditingIcon = false;
            this.FileMappingGrid.ShowRowErrors = false;
            this.FileMappingGrid.Size = new System.Drawing.Size(634, 145);
            this.FileMappingGrid.TabIndex = 0;
            this.FileMappingGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Grid_CellBeginEdit);
            this.FileMappingGrid.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.FileMappingGrid_DefaultValuesNeeded);
            // 
            // LocalPath
            // 
            this.LocalPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LocalPath.HeaderText = "Local Path";
            this.LocalPath.Name = "LocalPath";
            this.LocalPath.ToolTipText = "This can be a full path, or a path relative to ContentRoot.";
            // 
            // DepotPath
            // 
            this.DepotPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DepotPath.HeaderText = "Depot Path";
            this.DepotPath.Name = "DepotPath";
            this.DepotPath.ToolTipText = "This is a path relative to the install folder of your game.";
            // 
            // Recursive
            // 
            this.Recursive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Recursive.FalseValue = "0";
            this.Recursive.HeaderText = "Recursive";
            this.Recursive.IndeterminateValue = "1";
            this.Recursive.MinimumWidth = 65;
            this.Recursive.Name = "Recursive";
            this.Recursive.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Recursive.ToolTipText = "If LocalPath contains wildcards, setting this means that all matching files withi" +
    "n subdirectories of LocalPath will also be included.";
            this.Recursive.TrueValue = "1";
            this.Recursive.Width = 65;
            // 
            // depotExclusionsPage
            // 
            this.depotExclusionsPage.Controls.Add(this.ExclusionsDataGrid);
            this.depotExclusionsPage.Location = new System.Drawing.Point(4, 25);
            this.depotExclusionsPage.Name = "depotExclusionsPage";
            this.depotExclusionsPage.Padding = new System.Windows.Forms.Padding(3);
            this.depotExclusionsPage.Size = new System.Drawing.Size(640, 151);
            this.depotExclusionsPage.TabIndex = 2;
            this.depotExclusionsPage.Text = "Exclusions";
            this.depotExclusionsPage.UseVisualStyleBackColor = true;
            // 
            // ExclusionsDataGrid
            // 
            this.ExclusionsDataGrid.AllowUserToResizeColumns = false;
            this.ExclusionsDataGrid.AllowUserToResizeRows = false;
            this.ExclusionsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExclusionsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExclusionsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.ExclusionsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExclusionsDataGrid.Location = new System.Drawing.Point(3, 3);
            this.ExclusionsDataGrid.Name = "ExclusionsDataGrid";
            this.ExclusionsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExclusionsDataGrid.ShowCellErrors = false;
            this.ExclusionsDataGrid.ShowEditingIcon = false;
            this.ExclusionsDataGrid.ShowRowErrors = false;
            this.ExclusionsDataGrid.Size = new System.Drawing.Size(634, 145);
            this.ExclusionsDataGrid.TabIndex = 1;
            this.ExclusionsDataGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Grid_CellBeginEdit);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Exclusion Pattern / Exact Path";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ToolTipText = "This can be a full path, or a path relative to ContentRoot.";
            // 
            // depotRemoveButton
            // 
            this.depotRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.depotRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depotRemoveButton.ForeColor = System.Drawing.Color.Maroon;
            this.depotRemoveButton.Location = new System.Drawing.Point(6, 202);
            this.depotRemoveButton.Name = "depotRemoveButton";
            this.depotRemoveButton.Size = new System.Drawing.Size(124, 23);
            this.depotRemoveButton.TabIndex = 5;
            this.depotRemoveButton.Text = "Remove this Depot";
            this.depotRemoveButton.UseVisualStyleBackColor = true;
            this.depotRemoveButton.Click += new System.EventHandler(this.depotRemoveButton_Click);
            // 
            // AddNewDepotButton
            // 
            this.AddNewDepotButton.Location = new System.Drawing.Point(8, 208);
            this.AddNewDepotButton.Name = "AddNewDepotButton";
            this.AddNewDepotButton.Size = new System.Drawing.Size(100, 23);
            this.AddNewDepotButton.TabIndex = 2;
            this.AddNewDepotButton.Text = "Add";
            this.AddNewDepotButton.UseVisualStyleBackColor = true;
            this.AddNewDepotButton.Click += new System.EventHandler(this.AddNewDepotButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Depots:";
            // 
            // depotListBox
            // 
            this.depotListBox.FormattingEnabled = true;
            this.depotListBox.Location = new System.Drawing.Point(8, 14);
            this.depotListBox.Name = "depotListBox";
            this.depotListBox.Size = new System.Drawing.Size(100, 186);
            this.depotListBox.TabIndex = 0;
            this.depotListBox.SelectedIndexChanged += new System.EventHandler(this.depotListBox_SelectedIndexChanged);
            // 
            // aboutPage
            // 
            this.aboutPage.Controls.Add(this.copyrightLabel);
            this.aboutPage.Controls.Add(this.jsonLink);
            this.aboutPage.Controls.Add(this.vdfLink);
            this.aboutPage.Controls.Add(this.jsonLabel);
            this.aboutPage.Controls.Add(this.vdfLabel);
            this.aboutPage.Controls.Add(this.poweredWithLabel);
            this.aboutPage.Controls.Add(this.myLink);
            this.aboutPage.Controls.Add(this.developedByLabel);
            this.aboutPage.Controls.Add(this.descLabel);
            this.aboutPage.Controls.Add(this.versionLabel);
            this.aboutPage.Controls.Add(this.productNameLabel);
            this.aboutPage.Location = new System.Drawing.Point(4, 25);
            this.aboutPage.Name = "aboutPage";
            this.aboutPage.Padding = new System.Windows.Forms.Padding(3);
            this.aboutPage.Size = new System.Drawing.Size(776, 333);
            this.aboutPage.TabIndex = 3;
            this.aboutPage.Text = "About";
            this.aboutPage.UseVisualStyleBackColor = true;
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(11, 186);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(611, 39);
            this.copyrightLabel.TabIndex = 10;
            this.copyrightLabel.Text = resources.GetString("copyrightLabel.Text");
            // 
            // jsonLink
            // 
            this.jsonLink.AutoSize = true;
            this.jsonLink.Location = new System.Drawing.Point(102, 157);
            this.jsonLink.Name = "jsonLink";
            this.jsonLink.Size = new System.Drawing.Size(229, 13);
            this.jsonLink.TabIndex = 9;
            this.jsonLink.TabStop = true;
            this.jsonLink.Text = "https://github.com/JamesNK/Newtonsoft.Json";
            this.jsonLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // vdfLink
            // 
            this.vdfLink.AutoSize = true;
            this.vdfLink.Location = new System.Drawing.Point(102, 142);
            this.vdfLink.Name = "vdfLink";
            this.vdfLink.Size = new System.Drawing.Size(226, 13);
            this.vdfLink.TabIndex = 8;
            this.vdfLink.TabStop = true;
            this.vdfLink.Text = "https://github.com/shravan2x/Gameloop.Vdf/";
            this.vdfLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // jsonLabel
            // 
            this.jsonLabel.AutoSize = true;
            this.jsonLabel.Location = new System.Drawing.Point(39, 157);
            this.jsonLabel.Name = "jsonLabel";
            this.jsonLabel.Size = new System.Drawing.Size(57, 13);
            this.jsonLabel.TabIndex = 7;
            this.jsonLabel.Text = "Json.NET:";
            // 
            // vdfLabel
            // 
            this.vdfLabel.AutoSize = true;
            this.vdfLabel.Location = new System.Drawing.Point(39, 142);
            this.vdfLabel.Name = "vdfLabel";
            this.vdfLabel.Size = new System.Drawing.Size(51, 13);
            this.vdfLabel.TabIndex = 6;
            this.vdfLabel.Text = "Vdf.NET:";
            // 
            // poweredWithLabel
            // 
            this.poweredWithLabel.AutoSize = true;
            this.poweredWithLabel.Location = new System.Drawing.Point(11, 126);
            this.poweredWithLabel.Name = "poweredWithLabel";
            this.poweredWithLabel.Size = new System.Drawing.Size(163, 13);
            this.poweredWithLabel.TabIndex = 5;
            this.poweredWithLabel.Text = "Powered with third-party projects:";
            // 
            // myLink
            // 
            this.myLink.AutoSize = true;
            this.myLink.Location = new System.Drawing.Point(39, 95);
            this.myLink.Name = "myLink";
            this.myLink.Size = new System.Drawing.Size(145, 13);
            this.myLink.TabIndex = 4;
            this.myLink.TabStop = true;
            this.myLink.Text = "https://github.com/dedepete";
            this.myLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // developedByLabel
            // 
            this.developedByLabel.AutoSize = true;
            this.developedByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.developedByLabel.Location = new System.Drawing.Point(11, 66);
            this.developedByLabel.Name = "developedByLabel";
            this.developedByLabel.Size = new System.Drawing.Size(283, 26);
            this.developedByLabel.TabIndex = 3;
            this.developedByLabel.Text = "Developed by Igor \'dedepete\' Popov from Pirozhok Studio.\r\nSoftware licensed under" +
    " MIT.";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descLabel.Location = new System.Drawing.Point(272, 16);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(400, 16);
            this.descLabel.TabIndex = 2;
            this.descLabel.Text = "— an enhanced (and much buggy) experience of using SteamPipe.";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(186, 34);
            this.versionLabel.MinimumSize = new System.Drawing.Size(80, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(80, 13);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "18.0.0.0";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productNameLabel.Location = new System.Drawing.Point(8, 3);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(258, 31);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "SteamPipeGUI.NET";
            // 
            // buildDescLabel
            // 
            this.buildDescLabel.AutoSize = true;
            this.buildDescLabel.Location = new System.Drawing.Point(9, 11);
            this.buildDescLabel.Name = "buildDescLabel";
            this.buildDescLabel.Size = new System.Drawing.Size(89, 13);
            this.buildDescLabel.TabIndex = 3;
            this.buildDescLabel.Text = "Build Description:";
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(104, 8);
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(293, 20);
            this.descBox.TabIndex = 2;
            // 
            // setLiveLabel
            // 
            this.setLiveLabel.AutoSize = true;
            this.setLiveLabel.Location = new System.Drawing.Point(9, 40);
            this.setLiveLabel.Name = "setLiveLabel";
            this.setLiveLabel.Size = new System.Drawing.Size(158, 13);
            this.setLiveLabel.TabIndex = 5;
            this.setLiveLabel.Text = "Set Live on non-Default branch:";
            // 
            // setLiveComboBox
            // 
            this.setLiveComboBox.FormattingEnabled = true;
            this.setLiveComboBox.Location = new System.Drawing.Point(182, 37);
            this.setLiveComboBox.Name = "setLiveComboBox";
            this.setLiveComboBox.Size = new System.Drawing.Size(215, 21);
            this.setLiveComboBox.TabIndex = 6;
            // 
            // uploadButton
            // 
            this.uploadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uploadButton.Enabled = false;
            this.uploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uploadButton.Location = new System.Drawing.Point(663, 36);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(109, 23);
            this.uploadButton.TabIndex = 7;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.buildUploadButton_Click);
            // 
            // previewButton
            // 
            this.previewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.previewButton.Enabled = false;
            this.previewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.previewButton.Location = new System.Drawing.Point(582, 36);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(75, 23);
            this.previewButton.TabIndex = 8;
            this.previewButton.Text = "Preview";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.buildPreviewButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.statusStrip);
            this.mainPanel.Controls.Add(this.reloadEnviButton);
            this.mainPanel.Controls.Add(this.previewButton);
            this.mainPanel.Controls.Add(this.uploadButton);
            this.mainPanel.Controls.Add(this.setLiveComboBox);
            this.mainPanel.Controls.Add(this.buildDescLabel);
            this.mainPanel.Controls.Add(this.setLiveLabel);
            this.mainPanel.Controls.Add(this.descBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanel.Location = new System.Drawing.Point(0, 362);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(784, 83);
            this.mainPanel.TabIndex = 2;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar,
            this.statusLabel});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip.Location = new System.Drawing.Point(0, 62);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 21);
            this.statusStrip.TabIndex = 10;
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(100, 15);
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(42, 15);
            this.statusLabel.Text = "Ready!";
            // 
            // reloadEnviButton
            // 
            this.reloadEnviButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reloadEnviButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reloadEnviButton.Location = new System.Drawing.Point(462, 36);
            this.reloadEnviButton.Name = "reloadEnviButton";
            this.reloadEnviButton.Size = new System.Drawing.Size(114, 23);
            this.reloadEnviButton.TabIndex = 9;
            this.reloadEnviButton.Text = "Reload Environment";
            this.reloadEnviButton.UseVisualStyleBackColor = true;
            this.reloadEnviButton.Click += new System.EventHandler(this.buildReloadEnviButton_Click);
            // 
            // infoTip
            // 
            this.infoTip.ShowAlways = true;
            this.infoTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.infoTip.ToolTipTitle = "Info";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 445);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.mainPanel);
            this.MinimumSize = new System.Drawing.Size(736, 484);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SteamPipeGUI.NET";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.mainTabControl.ResumeLayout(false);
            this.buildConfigPage.ResumeLayout(false);
            this.mainConfigGroup.ResumeLayout(false);
            this.mainConfigGroup.PerformLayout();
            this.buildConfigGroup.ResumeLayout(false);
            this.buildConfigGroup.PerformLayout();
            this.depotManagmentPage.ResumeLayout(false);
            this.depotManagmentPage.PerformLayout();
            this.depotGroup.ResumeLayout(false);
            this.depotTabControl.ResumeLayout(false);
            this.depotBasicPage.ResumeLayout(false);
            this.depotBasicPage.PerformLayout();
            this.depotMappingsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FileMappingGrid)).EndInit();
            this.depotExclusionsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExclusionsDataGrid)).EndInit();
            this.aboutPage.ResumeLayout(false);
            this.aboutPage.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage buildConfigPage;
        private System.Windows.Forms.Label buildDescLabel;
        private System.Windows.Forms.TextBox descBox;
        private System.Windows.Forms.Label appIdLabel;
        private System.Windows.Forms.TextBox appIdBox;
        private System.Windows.Forms.TabPage depotManagmentPage;
        private System.Windows.Forms.GroupBox mainConfigGroup;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label cmdPathLabel;
        private System.Windows.Forms.TextBox steamcmdPathTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.GroupBox buildConfigGroup;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private System.Windows.Forms.Label setLiveLabel;
        private System.Windows.Forms.ComboBox setLiveComboBox;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox depotListBox;
        private System.Windows.Forms.GroupBox depotGroup;
        private System.Windows.Forms.Button AddNewDepotButton;
        private System.Windows.Forms.TabControl depotTabControl;
        private System.Windows.Forms.TabPage depotBasicPage;
        private System.Windows.Forms.Button depotRemoveButton;
        private System.Windows.Forms.TextBox depotContentRootPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage depotMappingsPage;
        private System.Windows.Forms.TabPage depotExclusionsPage;
        private System.Windows.Forms.Button reloadEnviButton;
        private System.Windows.Forms.DataGridView FileMappingGrid;
        private System.Windows.Forms.DataGridView ExclusionsDataGrid;
        private System.Windows.Forms.TabPage aboutPage;
        private System.Windows.Forms.Button depotSaveButton;
        private System.Windows.Forms.Button depotRevertButton;
        private System.Windows.Forms.TextBox localServerTextBox;
        private System.Windows.Forms.Label localServerLabel;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.Label contentDirLabel;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label outputDirLabel;
        private System.Windows.Forms.ToolTip infoTip;
        private System.Windows.Forms.Label sdkTip;
        private System.Windows.Forms.Label passTip;
        private System.Windows.Forms.Label usernameTip;
        private System.Windows.Forms.Label localTip;
        private System.Windows.Forms.Label contentTip;
        private System.Windows.Forms.Label outputTip;
        private System.Windows.Forms.Label appIdTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepotPath;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Recursive;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.LinkLabel myLink;
        private System.Windows.Forms.Label developedByLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label jsonLabel;
        private System.Windows.Forms.Label vdfLabel;
        private System.Windows.Forms.Label poweredWithLabel;
        private System.Windows.Forms.LinkLabel jsonLink;
        private System.Windows.Forms.LinkLabel vdfLink;
        private System.Windows.Forms.Label copyrightLabel;
    }
}

