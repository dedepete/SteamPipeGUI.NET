using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamPipeGUI.NET.Forms
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
                AddButton.PerformClick();
            }
        }
    }
}
