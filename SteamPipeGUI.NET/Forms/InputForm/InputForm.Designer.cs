namespace SteamPipeGUI.NET
{
    partial class InputForm
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
            this.messagePanel = new System.Windows.Forms.Panel();
            this.message = new System.Windows.Forms.Label();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.messagePanel.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // messagePanel
            // 
            this.messagePanel.Controls.Add(this.message);
            this.messagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagePanel.Location = new System.Drawing.Point(0, 0);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(397, 44);
            this.messagePanel.TabIndex = 0;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.message.Location = new System.Drawing.Point(0, 0);
            this.message.MinimumSize = new System.Drawing.Size(397, 47);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(397, 47);
            this.message.TabIndex = 0;
            this.message.Text = "SteamCMD requested {0}.";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.inputBox);
            this.inputPanel.Controls.Add(this.okButton);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inputPanel.Location = new System.Drawing.Point(0, 44);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(397, 20);
            this.inputPanel.TabIndex = 1;
            // 
            // inputBox
            // 
            this.inputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputBox.Location = new System.Drawing.Point(0, 0);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(322, 20);
            this.inputBox.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.okButton.Location = new System.Drawing.Point(322, 0);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 20);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // InputForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 64);
            this.ControlBox = false;
            this.Controls.Add(this.messagePanel);
            this.Controls.Add(this.inputPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input";
            this.messagePanel.ResumeLayout(false);
            this.messagePanel.PerformLayout();
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button okButton;
    }
}