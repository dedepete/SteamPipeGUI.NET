using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace SteamPipeGUI.NET
{
    public partial class InputForm : Form
    {
        public string Result => inputBox.Text;

        public InputForm(string request, bool isPassword)
        {
            SystemSounds.Beep.Play();
            Size = new Size(413, 103);
            InitializeComponent();
            if (isPassword) {
                inputBox.PasswordChar = '*';
            }
            message.Text = string.Format(message.Text, request);
        }
    }
}
