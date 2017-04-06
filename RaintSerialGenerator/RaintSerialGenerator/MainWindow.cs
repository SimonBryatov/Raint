
using System.Windows.Forms;

namespace RaintSerialGenerator
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerateHash_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_UniqueKey.Text = CryptoPack.SHA1_Salted(textbox_Serial_Id.Text + textBox_Email.Text);
        }
    }
}
