using System;
using System.Windows.Forms;

namespace Raint
{
    static class Program
    {
        static public string Serial_id;
        static public bool goTrial = false;
        static public bool time_is_over = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Properties.Settings.Default.Reset();
            Serial_id = HardwareInfo.GetHWID();
            Properties.Settings.Default.Serial_Id = Serial_id;
            Properties.Settings.Default.Save();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Properties.Settings.Default.License != CryptoPack.SHA1_Salted(Serial_id + Properties.Settings.Default.Email))
            {
                Application.Run(new TrialMessage_and_Activation());
                if (goTrial && !time_is_over)
                {
                    Application.Run(new MainWindow());
                } else if(Properties.Settings.Default.License == CryptoPack.SHA1_Salted(Serial_id + Properties.Settings.Default.Email))
                {
                    Application.Run(new MainWindow());
                }
            }
            else
            {
                goTrial = false;
                Application.Run(new MainWindow());
            }
        }
    }
}



