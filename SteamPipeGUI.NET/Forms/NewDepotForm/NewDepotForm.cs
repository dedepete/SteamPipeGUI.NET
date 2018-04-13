using System.Drawing;
using System.Windows.Forms;

namespace SteamPipeGUI.NET
{
    public partial class AddDepotForm : Form
    {
        public AddDepotForm()
        {
            InitializeComponent();
            Size = new Size(196, 108);
        }

        private void depotId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                addButton.PerformClick();
            }
        }
    }
}
