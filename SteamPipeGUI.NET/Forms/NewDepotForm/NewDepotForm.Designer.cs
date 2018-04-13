namespace SteamPipeGUI.NET
{
    partial class AddDepotForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.depotId = new System.Windows.Forms.TextBox();
            this.depotIdLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // depotId
            // 
            this.depotId.Location = new System.Drawing.Point(93, 12);
            this.depotId.Name = "depotId";
            this.depotId.Size = new System.Drawing.Size(77, 20);
            this.depotId.TabIndex = 1;
            this.depotId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.depotId_KeyUp);
            // 
            // depotIdLabel
            // 
            this.depotIdLabel.AutoSize = true;
            this.depotIdLabel.Location = new System.Drawing.Point(12, 15);
            this.depotIdLabel.Name = "depotIdLabel";
            this.depotIdLabel.Size = new System.Drawing.Size(53, 13);
            this.depotIdLabel.TabIndex = 2;
            this.depotIdLabel.Text = "Depot ID:";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(10, 38);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(77, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addButton.Location = new System.Drawing.Point(93, 38);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(77, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // AddDepotForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(180, 69);
            this.ControlBox = false;
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.depotIdLabel);
            this.Controls.Add(this.depotId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDepotForm";
            this.Text = "New Depot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label depotIdLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        public System.Windows.Forms.TextBox depotId;
    }
}