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
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
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
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(10, 38);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(77, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddButton.Location = new System.Drawing.Point(93, 38);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(77, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // AddDepotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 69);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.depotIdLabel);
            this.Controls.Add(this.depotId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDepotForm";
            this.Text = "Create New Depot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label depotIdLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        public System.Windows.Forms.TextBox depotId;
    }
}