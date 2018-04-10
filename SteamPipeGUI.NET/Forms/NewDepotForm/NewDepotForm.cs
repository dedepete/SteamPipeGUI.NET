using System.Windows.Forms;

namespace SteamPipeGUI.NET
{
    public partial class AddDepotForm : Form
    {
        public AddDepotForm()
        {
            InitializeComponent();
        }

        private void depotId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                addButton.PerformClick();
            }
        }
    }
}
