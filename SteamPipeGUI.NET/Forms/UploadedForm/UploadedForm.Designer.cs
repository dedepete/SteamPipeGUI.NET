namespace SteamPipeGUI.NET
{
    partial class UploadedForm
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
            this.message = new System.Windows.Forms.Label();
            this.finishButton = new System.Windows.Forms.Button();
            this.previewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(64, 9);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(441, 26);
            this.message.TabIndex = 0;
            this.message.Text = "Congratulations! Build ID `{0}` has just been uploaded for Application `{1}` with" +
    "out any errors.\r\nWould you like to publish the Build into `default` branch?";
            this.message.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(150, 48);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(131, 23);
            this.finishButton.TabIndex = 1;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(287, 48);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(131, 23);
            this.previewButton.TabIndex = 2;
            this.previewButton.Text = "Preview on Steamworks";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // UploadedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 80);
            this.ControlBox = false;
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UploadedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Success";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button previewButton;
    }
}