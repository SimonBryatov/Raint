using System;
using System.Windows.Forms;

namespace Raint
{
    public partial class TrialMessage_and_Activation : Form
    { TimeSpan trial_time, current_time;
        public TrialMessage_and_Activation()
        {
            string Serial_id = Program.Serial_id;

            InitializeComponent();
            textBox_Serial_Id.Text = Serial_id;
            trial_time = new TimeSpan(3, 0, 0, 0);
            current_time = new TimeSpan(0, 0, Convert.ToInt32(Properties.Settings.Default.Seconds)/123);
            trial_time = trial_time.Subtract(current_time);
            TimeLeft.Text = trial_time.ToString();
            if (trial_time.TotalSeconds <=0)
            {
                Program.time_is_over = false;
                label_Continue.Text = "Activate Full Version To Continue!";
                label_or.Text = "";
                label_TimeFormat.Hide();
                TimeLeft.Text = "Trial time is expired!";
                button_Go_Trial.Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TrialMessage_and_Activation_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button_Go_Trial_MouseClick(object sender, MouseEventArgs e)
        {
            if (trial_time.TotalSeconds > 0)
            {
                Program.goTrial = true;
                this.Close();
            }
        }

        private void button_Activate_Click(object sender, EventArgs e)
        {
            string license = CryptoPack.SHA1_Salted(textBox_Serial_Id.Text + textBox_Email.Text);
            if (textBox_Serial_Key.Text == license)
            {
                Program.goTrial = false;
                Program.time_is_over = false;
                Properties.Settings.Default.License = license;
                Properties.Settings.Default.Email = textBox_Email.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Full Version is Activated!", "Thank you!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } else MessageBox.Show("Enter valid Serial Key!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
