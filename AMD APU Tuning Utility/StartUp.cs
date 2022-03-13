using AMD_APU_Tuning_Utility.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMD_APU_Tuning_Utility
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
            this.Opacity = 0;
        }

        bool firstBoot = (bool)Settings.Default["firstBoot"];
        bool update = false;
        bool canRun = false;
        bool goodPath = false;

        string CPUName = "";

        double i = 0;

        private void StartUp_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            lblMessage.Text = "";
            this.Run1();
            this.TopMost = true;
            this.ShowInTaskbar = false;


            BackColor = Color.Black;
            TransparencyKey = Color.Black;
            FormBorderStyle = FormBorderStyle.None;

            if (firstBoot == true)
            {
                lblMessage.Text = "Checking AATU directory";
                Thread.Sleep(1000);
                string path = Directory.GetCurrentDirectory();
                if (path.Contains("win32") || path.Contains("system32"))
                {
                    DialogResult dialog = MessageBox.Show("AATU has detected that it has opened in " + path + " on first boot of application, please restart AATU so it can get the proper storage location of application", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (dialog == DialogResult.OK)
                    {
                        Application.Exit();

                    }
                    else if (dialog == DialogResult.None)
                    {
                        Application.Exit();
                    }
                    goodPath = false;
                }
                else
                {
                    Settings.Default["Path"] = path.ToString();
                    Settings.Default["firstBoot"] = false;
                    Settings.Default.Save();
                    goodPath = true;
                }
            }
            else
            {
                lblMessage.Text = "Checking AATU directory";
                Thread.Sleep(1000);
                string path = (string)Settings.Default["Path"];
                if (path.Contains("win32") || path.Contains("system32"))
                {
                    Settings.Default["Path"] = "";
                    Settings.Default["firstBoot"] = true;
                    Settings.Default.Save();

                    DialogResult dialog = MessageBox.Show("AATU has detected that it has opened in " + path + " on first boot of application, please restart AATU so it can get the proper storage location of application", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (dialog == DialogResult.OK)
                    {
                        Application.Exit();

                    }
                    else if (dialog == DialogResult.None)
                    {
                        Application.Exit();
                    }
                    goodPath = false;
                }
                else
                {
                    goodPath = true;
                }
            }
        }

        public void CheckCompat()
        {
            lblMessage.Text = "Checking System Compatibility";

            //Get CPU name
            ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");
            foreach (ManagementObject obj in myProcessorObject.Get())
            {
                CPUName = obj["Name"].ToString();
            }

            if (CPUName.Contains("Ryzen") || CPUName.Contains("Athlon"))
            {
                if (CPUName.Contains("G") || CPUName.Contains("V") || CPUName.Contains("HX") || CPUName.Contains("HS") || CPUName.Contains("H") || CPUName.Contains("U") || CPUName.Contains("E") || CPUName.Contains("e") || CPUName.Contains("Z") || CPUName.Contains("C"))
                {
                    canRun = true;
                }
                else
                {
                    canRun = false;
                }
            }
            else if (CPUName.Contains("Van Gogh") || CPUName.Contains("3020e") || CPUName.Contains("3015e") || CPUName.Contains("3050e") || CPUName.Contains("3020E") || CPUName.Contains("3015E") || CPUName.Contains("AMD Custom APU 0405") ||  CPUName.Contains("3050E"))
            {
                canRun = true;
            }
            else
            {
                canRun = false;
            }

            if (canRun == true)
            {
                Thread.Sleep(2000);
                CheckUpdate();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Incompatible processor detected: \n" + CPUName + "\n Your processor is not compatible with AMD APU Tuning Utility. This is because AMD APU Tuning Utility has detected that your processor is not a Zen based APU.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dialog == DialogResult.OK)
                {
                    Application.Exit();

                } else if (dialog == DialogResult.None)
                {
                    Application.Exit();
                }
            }

        }
        public void CheckUpdate()
        {
            lblMessage.Text = "Checking for Updates";
            if (update != true)
            {
                Thread.Sleep(3000);
                OpenMainForm.Enabled = true;
            }
            
        }
        private void FormOpacity_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 0.98 && this.Opacity != 0.98)
            {
                this.Opacity = i;
            }
            else
            {
                this.Opacity = 0.98;
                FormOpacity.Enabled = false;

                if (goodPath == true)
                {
                    CheckCompat();
                }
            }
            i = i + 0.10;
        }

        private void OpenMainForm_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity = i;
            }
            else
            {
                OpenMainForm.Enabled = false;
                this.Opacity = 0;
                this.TopMost = false;
                this.WindowState = FormWindowState.Minimized;

                if (Program.IsAdministrator())
                {
                    Form1 form = new Form1();
                    form.Show();
                }

                this.Hide();
            }
            i = i - 0.10;
        }

        private void Run1()
        {
            if (!Program.IsAdministrator())
            {
                // Restart and run as admin
                var exeName = Process.GetCurrentProcess().MainModule.FileName;
                ProcessStartInfo startInfo = new ProcessStartInfo(exeName);
                startInfo.Verb = "runas";
                startInfo.Arguments = "restart";
                Process.Start(startInfo);
                Application.Exit();
            }
        }
    }
}
