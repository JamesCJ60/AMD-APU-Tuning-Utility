using AMD_APU_Tuning_Utility.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMD_APU_Tuning_Utility
{
    public partial class ROG : UserControl
    {
        public static ROG _instance;
        public static ROG Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ROG();
                return _instance;
            }
        }

        public ROG()
        {
            InitializeComponent();
        }

        int topBar1 = 0;
        int topBar2 = 180;
        int topBar3 = 166;

        int sideBar1 = 0;
        int sideBar2 = 110;
        int sideBar3 = 106;

        string path = (string)Settings.Default["Path"];
        string path2 = (string)Settings.Default["Path"];
        string args = (string)Settings.Default["Args"];
        string director = (string)Settings.Default["Path"];
        string imageName;

        private void ROG_Load(object sender, EventArgs e)
        {
            this.updateTheme();
            path = path + "//bin//atrofac-cli.exe";
            path2 = path2 + "//bin//Notification.exe";


            if (args == "" || args == null)
            {
                bal();
            }
            else if (args.Contains("fan"))
            {
                man();
            }
            else if (args.Contains("windows"))
            {
                win();
            }
            else if (args.Contains("silent"))
            {
                silent();
            }
            else if (args.Contains("performance"))
            {
                bal();
            }
            else if (args.Contains("turbo"))
            {
                turbo();
            }
            
            nudCPU1.Value = (int)Settings.Default["CPU1"];
            nudCPU2.Value = (int)Settings.Default["CPU2"];
            nudCPU3.Value = (int)Settings.Default["CPU3"];
            nudCPU4.Value = (int)Settings.Default["CPU4"];
            nudCPU5.Value = (int)Settings.Default["CPU5"];
            nudCPU6.Value = (int)Settings.Default["CPU6"];
            nudCPU7.Value = (int)Settings.Default["CPU7"];
            nudCPU8.Value = (int)Settings.Default["CPU8"];

            nudGPU1.Value = (int)Settings.Default["GPU1"];
            nudGPU2.Value = (int)Settings.Default["GPU2"];
            nudGPU3.Value = (int)Settings.Default["GPU3"];
            nudGPU4.Value = (int)Settings.Default["GPU4"];
            nudGPU5.Value = (int)Settings.Default["GPU5"];
            nudGPU6.Value = (int)Settings.Default["GPU6"];
            nudGPU7.Value = (int)Settings.Default["GPU7"];
            nudGPU8.Value = (int)Settings.Default["GPU8"];


        }

        private void updateTheme()
        {
            bool useGPUSettings = (bool)Settings.Default["useGPUSettings"];
            bool useDefaultTheme = (bool)Settings.Default["useDefaultTheme"];
            if (!useDefaultTheme)
            {
                topBar1 = (int)Settings.Default["topBar1"];
                topBar2 = (int)Settings.Default["topBar2"];
                topBar3 = (int)Settings.Default["topBar3"];

                sideBar1 = (int)Settings.Default["sideBar1"];
                sideBar2 = (int)Settings.Default["sideBar2"];
                sideBar3 = (int)Settings.Default["sideBar3"];
            }
            else
            {
                topBar1 = 0;
                topBar2 = 180;
                topBar3 = 166;

                sideBar1 = 0;
                sideBar2 = 110;
                sideBar3 = 106;
            }

            btnWindows.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnSilent.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnBal.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnTurbo.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnMan.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnApply.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);

        }

        private void Theme_Tick(object sender, EventArgs e)
        {
            this.updateTheme();
        }

        private void btnWindows_Click(object sender, EventArgs e)
        {
            win();

            apply();
        }

        private void btnSilent_Click(object sender, EventArgs e)
        {
            silent();

            apply();
        }

        private void btnBal_Click(object sender, EventArgs e)
        {
            bal();

            apply();
        }

        private void btnTurbo_Click(object sender, EventArgs e)
        {
            turbo();

            apply();
        }

        private void btnMan_Click(object sender, EventArgs e)
        {
            man();
        }

        public void apply()
        {
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = path;
                startInfo.Arguments = args;
                process.StartInfo = startInfo;
                process.Start();

                Settings.Default["Args"] = args;
                Settings.Default.Save();

                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = path2;
                startInfo.Arguments = "https://media.discordapp.net/attachments/711708420281204768/813512272935780412/AATU-LOGO.png?width=697&height=676 Applied-Successfully! Your-power-plan-has-been-applied-successfully";
                process.StartInfo = startInfo;
                process.Start();
            }
            catch
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = path2;
                startInfo.Arguments = "https://media.discordapp.net/attachments/711708420281204768/813512272935780412/AATU-LOGO.png?width=697&height=676 Error! Something-went-wrong-when-applying-your-power-plan-:(";
                process.StartInfo = startInfo;
                process.Start();
            }
        }

        public void turbo()
        {
            args = "plan turbo";
            imageName = "Turbo";
            pbModes.Visible = true;
            changeImage();
            pnMan.Visible = false;

            btnTurbo.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btnMan.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            btnBal.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            btnSilent.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            btnWindows.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
        }

        public void bal()
        {
            args = "plan performance";
            imageName = "Bal";
            changeImage();
            pbModes.Visible = true;
            pnMan.Visible = false;

            btnTurbo.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            btnMan.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            btnBal.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btnSilent.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            btnWindows.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
        }

        public void silent()
        {
            args = "plan silent";
            imageName = "Silent";
            changeImage();
            pbModes.Visible = true;
            pnMan.Visible = false;

            btnTurbo.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            btnMan.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            btnBal.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            btnSilent.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btnWindows.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
        }

        public void win()
        {
            args = "plan windows";
            imageName = "Windows";
            changeImage();
            pbModes.Visible = true;
            pnMan.Visible = false;

            btnTurbo.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            btnMan.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            btnBal.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            btnSilent.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            btnWindows.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
        }
        public void man()
        {
            pnMan.Visible = true;
            pbModes.Visible = false;
            
            btnTurbo.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            btnMan.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btnBal.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            btnSilent.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            btnWindows.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            int[] CPU = new int[10];
            int[] GPU = new int[10];

           CPU[1] = (int)nudCPU1.Value;
            CPU[2] = (int)nudCPU2.Value;
            CPU[3] = (int)nudCPU3.Value;
            CPU[4] = (int)nudCPU4.Value;
            CPU[5] = (int)nudCPU5.Value;
            CPU[6] = (int)nudCPU6.Value;
            CPU[7] = (int)nudCPU7.Value;
            CPU[8] = (int)nudCPU8.Value;

            GPU[1] = (int)nudGPU1.Value;
            GPU[2] = (int)nudGPU2.Value;
            GPU[3] = (int)nudGPU3.Value;
            GPU[4] = (int)nudGPU4.Value;
            GPU[5] = (int)nudGPU5.Value;
            GPU[6] = (int)nudGPU6.Value;
            GPU[7] = (int)nudGPU7.Value;
            GPU[8] = (int)nudGPU8.Value;

            Settings.Default["CPU1"] = (int)nudCPU1.Value;
            Settings.Default["CPU2"] = (int)nudCPU2.Value;
            Settings.Default["CPU3"] = (int)nudCPU3.Value;
            Settings.Default["CPU4"] = (int)nudCPU4.Value;
            Settings.Default["CPU5"] = (int)nudCPU5.Value;
            Settings.Default["CPU6"] = (int)nudCPU6.Value;
            Settings.Default["CPU7"] = (int)nudCPU7.Value;
            Settings.Default["CPU8"] = (int)nudCPU8.Value;

            Settings.Default["GPU1"] = (int)nudGPU1.Value;
            Settings.Default["GPU2"] = (int)nudGPU2.Value;
            Settings.Default["GPU3"] = (int)nudGPU3.Value;
            Settings.Default["GPU4"] = (int)nudGPU4.Value;
            Settings.Default["GPU5"] = (int)nudGPU5.Value;
            Settings.Default["GPU6"] = (int)nudGPU6.Value;
            Settings.Default["GPU7"] = (int)nudGPU7.Value;
            Settings.Default["GPU8"] = (int)nudGPU8.Value;

            Settings.Default.Save();

            args = "fan --plan windows --cpu 30c:"+ CPU[1] + "%,40c:"+ CPU[2] + "%,50c:"+ CPU[3] + "%,60c:"+ CPU[4] + "%,70c:"+ CPU[5] + "%,80c:"+ CPU[6] + "%,90c:"+ CPU[7] + "%,100c:"+ CPU[8] + "% --gpu 30c:"+ GPU[1] + "%,40c:"+ GPU[2] + "%,50c:"+ GPU[3] + "%,60c:"+ GPU[4] + "%,70c:"+ GPU[5] + "%,80c:"+ GPU[6] + "%,90c:"+ GPU[7] + "%,100c:"+ GPU[8] + "%";
            apply();
        }

        public void changeImage()
        {
            Image image = Image.FromFile(director + "\\images\\" + imageName + ".png");
            pbModes.Image = new Bitmap(image);
        }
    }
}
