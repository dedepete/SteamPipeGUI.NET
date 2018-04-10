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
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sdkTip = new System.Windows.Forms.Label();
            this.passTip = new System.Windows.Forms.Label();
            this.usernameTip = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.steamcmdPathTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.localTip = new System.Windows.Forms.Label();
            this.contentTip = new System.Windows.Forms.Label();
            this.outputTip = new System.Windows.Forms.Label();
            this.appIdTip = new System.Windows.Forms.Label();
            this.localServerTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.appIdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.depotGroupBox = new System.Windows.Forms.GroupBox();
            this.depotRevertButton = new System.Windows.Forms.Button();
            this.depotSaveButton = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.depotContentRootPath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.FileMappingGrid = new System.Windows.Forms.DataGridView();
            this.LocalPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepotPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recursive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.ExclusionsDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depotRemoveButton = new System.Windows.Forms.Button();
            this.AddNewDepotButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.depotListBox = new System.Windows.Forms.ListBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.descBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.liveComboBox = new System.Windows.Forms.ComboBox();
            this.buildUploadButton = new System.Windows.Forms.Button();
            this.buildPreviewButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buildReloadEnviButton = new System.Windows.Forms.Button();
            this.infoTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.depotGroupBox.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileMappingGrid)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExclusionsDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logBox
            // 
            this.logBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logBox.HideSelection = false;
            this.logBox.Location = new System.Drawing.Point(0, 271);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(766, 91);
            this.logBox.TabIndex = 0;
            this.logBox.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(766, 271);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(758, 242);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Build Configuration";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.sdkTip);
            this.groupBox2.Controls.Add(this.passTip);
            this.groupBox2.Controls.Add(this.usernameTip);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.steamcmdPathTextBox);
            this.groupBox2.Controls.Add(this.usernameTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.passwordTextBox);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(744, 102);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main Configuration";
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(391, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "STEAMCMD.EXE Path:";
            // 
            // steamcmdPathTextBox
            // 
            this.steamcmdPathTextBox.Location = new System.Drawing.Point(178, 71);
            this.steamcmdPathTextBox.Name = "steamcmdPathTextBox";
            this.steamcmdPathTextBox.Size = new System.Drawing.Size(207, 20);
            this.steamcmdPathTextBox.TabIndex = 4;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(178, 19);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(207, 20);
            this.usernameTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Steam Password (optional):";
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.localTip);
            this.groupBox1.Controls.Add(this.contentTip);
            this.groupBox1.Controls.Add(this.outputTip);
            this.groupBox1.Controls.Add(this.appIdTip);
            this.groupBox1.Controls.Add(this.localServerTextBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.contentTextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.outputTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.appIdBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 123);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Build Configuration";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Local Server Path:";
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(180, 71);
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(207, 20);
            this.contentTextBox.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Content Directory:";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(180, 45);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(207, 20);
            this.outputTextBox.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Output Directory:";
            this.infoTip.SetToolTip(this.label9, "Зрада");
            // 
            // appIdBox
            // 
            this.appIdBox.Location = new System.Drawing.Point(180, 19);
            this.appIdBox.Name = "appIdBox";
            this.appIdBox.Size = new System.Drawing.Size(77, 20);
            this.appIdBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "AppID:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.depotGroupBox);
            this.tabPage2.Controls.Add(this.AddNewDepotButton);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.depotListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(758, 242);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Depot Managment";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // depotGroupBox
            // 
            this.depotGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.depotGroupBox.Controls.Add(this.depotRevertButton);
            this.depotGroupBox.Controls.Add(this.depotSaveButton);
            this.depotGroupBox.Controls.Add(this.tabControl2);
            this.depotGroupBox.Controls.Add(this.depotRemoveButton);
            this.depotGroupBox.Location = new System.Drawing.Point(114, 14);
            this.depotGroupBox.Name = "depotGroupBox";
            this.depotGroupBox.Size = new System.Drawing.Size(636, 225);
            this.depotGroupBox.TabIndex = 3;
            this.depotGroupBox.TabStop = false;
            this.depotGroupBox.Text = "Depot \'1000\'";
            // 
            // depotRevertButton
            // 
            this.depotRevertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.depotRevertButton.Enabled = false;
            this.depotRevertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depotRevertButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.depotRevertButton.Location = new System.Drawing.Point(432, 196);
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
            this.depotSaveButton.Location = new System.Drawing.Point(532, 196);
            this.depotSaveButton.Name = "depotSaveButton";
            this.depotSaveButton.Size = new System.Drawing.Size(94, 23);
            this.depotSaveButton.TabIndex = 6;
            this.depotSaveButton.Text = "Save";
            this.depotSaveButton.UseVisualStyleBackColor = true;
            this.depotSaveButton.Click += new System.EventHandler(this.depotSaveButton_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(3, 16);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(630, 180);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.Tag = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.depotContentRootPath);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(622, 151);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Basic Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.FileMappingGrid);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(622, 151);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "File Mappings";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            this.FileMappingGrid.Size = new System.Drawing.Size(616, 145);
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
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.ExclusionsDataGrid);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(622, 151);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Exclusions";
            this.tabPage5.UseVisualStyleBackColor = true;
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
            this.ExclusionsDataGrid.Size = new System.Drawing.Size(616, 145);
            this.ExclusionsDataGrid.TabIndex = 1;
            this.ExclusionsDataGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Grid_CellBeginEdit);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "FileExclusion Pattern/Full Path";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ToolTipText = "This can be a full path, or a path relative to ContentRoot.";
            // 
            // depotRemoveButton
            // 
            this.depotRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.depotRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depotRemoveButton.ForeColor = System.Drawing.Color.Maroon;
            this.depotRemoveButton.Location = new System.Drawing.Point(7, 196);
            this.depotRemoveButton.Name = "depotRemoveButton";
            this.depotRemoveButton.Size = new System.Drawing.Size(124, 23);
            this.depotRemoveButton.TabIndex = 5;
            this.depotRemoveButton.Text = "Remove this Depot";
            this.depotRemoveButton.UseVisualStyleBackColor = true;
            this.depotRemoveButton.Click += new System.EventHandler(this.depotRemoveButton_Click);
            // 
            // AddNewDepotButton
            // 
            this.AddNewDepotButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNewDepotButton.Location = new System.Drawing.Point(8, 216);
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
            this.depotListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.depotListBox.FormattingEnabled = true;
            this.depotListBox.Location = new System.Drawing.Point(8, 14);
            this.depotListBox.Name = "depotListBox";
            this.depotListBox.Size = new System.Drawing.Size(100, 186);
            this.depotListBox.TabIndex = 0;
            this.depotListBox.SelectedIndexChanged += new System.EventHandler(this.depotListBox_SelectedIndexChanged);
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(758, 242);
            this.tabPage7.TabIndex = 3;
            this.tabPage7.Text = "About";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Build Description:";
            // 
            // descBox
            // 
            this.descBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descBox.Location = new System.Drawing.Point(104, 8);
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(295, 20);
            this.descBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Set Live on non-Default branch:";
            // 
            // liveComboBox
            // 
            this.liveComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.liveComboBox.FormattingEnabled = true;
            this.liveComboBox.Location = new System.Drawing.Point(182, 37);
            this.liveComboBox.Name = "liveComboBox";
            this.liveComboBox.Size = new System.Drawing.Size(217, 21);
            this.liveComboBox.TabIndex = 6;
            // 
            // buildUploadButton
            // 
            this.buildUploadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buildUploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buildUploadButton.Location = new System.Drawing.Point(647, 35);
            this.buildUploadButton.Name = "buildUploadButton";
            this.buildUploadButton.Size = new System.Drawing.Size(109, 23);
            this.buildUploadButton.TabIndex = 7;
            this.buildUploadButton.Text = "Upload";
            this.buildUploadButton.UseVisualStyleBackColor = true;
            this.buildUploadButton.Click += new System.EventHandler(this.buildUploadButton_Click);
            // 
            // buildPreviewButton
            // 
            this.buildPreviewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buildPreviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buildPreviewButton.Location = new System.Drawing.Point(566, 35);
            this.buildPreviewButton.Name = "buildPreviewButton";
            this.buildPreviewButton.Size = new System.Drawing.Size(75, 23);
            this.buildPreviewButton.TabIndex = 8;
            this.buildPreviewButton.Text = "Preview";
            this.buildPreviewButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buildReloadEnviButton);
            this.panel1.Controls.Add(this.buildPreviewButton);
            this.panel1.Controls.Add(this.buildUploadButton);
            this.panel1.Controls.Add(this.liveComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.descBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 70);
            this.panel1.TabIndex = 2;
            // 
            // buildReloadEnviButton
            // 
            this.buildReloadEnviButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buildReloadEnviButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buildReloadEnviButton.Location = new System.Drawing.Point(446, 35);
            this.buildReloadEnviButton.Name = "buildReloadEnviButton";
            this.buildReloadEnviButton.Size = new System.Drawing.Size(114, 23);
            this.buildReloadEnviButton.TabIndex = 9;
            this.buildReloadEnviButton.Text = "Reload Environment";
            this.buildReloadEnviButton.UseVisualStyleBackColor = true;
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
            this.ClientSize = new System.Drawing.Size(766, 432);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.depotGroupBox.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FileMappingGrid)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExclusionsDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox appIdBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox steamcmdPathTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox liveComboBox;
        private System.Windows.Forms.Button buildUploadButton;
        private System.Windows.Forms.Button buildPreviewButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox depotListBox;
        private System.Windows.Forms.GroupBox depotGroupBox;
        private System.Windows.Forms.Button AddNewDepotButton;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button depotRemoveButton;
        private System.Windows.Forms.TextBox depotContentRootPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button buildReloadEnviButton;
        private System.Windows.Forms.DataGridView FileMappingGrid;
        private System.Windows.Forms.DataGridView ExclusionsDataGrid;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button depotSaveButton;
        private System.Windows.Forms.Button depotRevertButton;
        private System.Windows.Forms.TextBox localServerTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

