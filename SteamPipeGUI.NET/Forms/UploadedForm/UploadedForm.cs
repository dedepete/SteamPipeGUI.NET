using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SteamPipeGUI.NET
{
    public partial class UploadedForm : Form
    {
        private string _buildId { get; }
        private string _appId { get; }

        public UploadedForm(string appId, string buildId)
        {
            _buildId = buildId;
            _appId = appId;
            System.Media.SystemSounds.Beep.Play();
            InitializeComponent();
            Size = new Size(584, 119);
            message.Text = string.Format(message.Text, buildId, appId);
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            Process.Start($"https://partner.steamgames.com/apps/previewbuildchange/{_appId}/{_buildId}?betakey=default");
            Close();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
