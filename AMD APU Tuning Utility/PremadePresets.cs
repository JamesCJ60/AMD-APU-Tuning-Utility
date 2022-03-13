using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMD_APU_Tuning_Utility.Properties;
using System.IO;
using System.Diagnostics;

namespace AMD_APU_Tuning_Utility
{
    public partial class PremadePresets : UserControl
    {
        public static PremadePresets _instance;
        public static PremadePresets Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PremadePresets();
                return _instance;
            }
        }
        public PremadePresets()
        {
            InitializeComponent();
        }

        bool useDefaultTheme = (bool)Settings.Default["useDefaultTheme"];
        bool connection = (bool) Settings.Default["Internet"];

        int topBar1 = 0;
        int topBar2 = 180;
        int topBar3 = 166;

        int sideBar1 = 0;
        int sideBar2 = 110;
        int sideBar3 = 106;

        int tempLimit;
        int CPUTDP;
        int longBoostTDP;
        int LongBoostDuration;
        int shortBoostTDP;
        int shortBoostDuration;
        int VRM;

        int maxCPUCores;
        int MaxCPUPerf;
        int boostMode;
        
        string RyzenADJ;

        string path;
        string path2;
        string series = (string)Settings.Default["Series"];

        bool SkinTemp = (bool)Settings.Default["SkinTemp"];

        private void PremadePresets_Load(object sender, EventArgs e)
        {

            
            





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

            btnApply.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnimport.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnSensors.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
        }

        private void Theme_Tick(object sender, EventArgs e)
        {
            connection = (bool)Settings.Default["Internet"];
            SkinTemp = (bool)Settings.Default["SkinTemp"];
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

            btnApply.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnimport.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnSensors.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
        }

        private void cbAPUSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            maxCPUCores = 100;
            MaxCPUPerf = 100;
            boostMode = 1;

            //clear preset drop down menu
            cbAPUPreset.Items.Clear();
            lbPresetValues.Items.Clear();
            //check to see what series is selected
            if (cbAPUSeries.Text == "Ryzen 2000 Series U")
            {
                //add series APUs
                cbAPUPreset.Items.Add("2200U");
                cbAPUPreset.Items.Add("2300U");
                cbAPUPreset.Items.Add("2500U");
                cbAPUPreset.Items.Add("2700U");
            } 
            else if (cbAPUSeries.Text == "Ryzen 3000 Series U")
            {

                cbAPUPreset.Items.Add("3200U");
                cbAPUPreset.Items.Add("3300U");
                cbAPUPreset.Items.Add("3500U");
                cbAPUPreset.Items.Add("3700U");
            }
            else if (cbAPUSeries.Text == "Ryzen 3000 Series H")
            {

                cbAPUPreset.Items.Add("3550H");
                cbAPUPreset.Items.Add("3750H");
            }
            else if (cbAPUSeries.Text == "Ryzen 4000 Series U")
            {

                cbAPUPreset.Items.Add("4300U");
                cbAPUPreset.Items.Add("4500U");
                cbAPUPreset.Items.Add("4600U");
                cbAPUPreset.Items.Add("4700U");
                cbAPUPreset.Items.Add("4800U");
            }
            else if (cbAPUSeries.Text == "Ryzen 4000 Series H/HS")
            {
                cbAPUPreset.Items.Add("4600H");
                cbAPUPreset.Items.Add("4800H");
                cbAPUPreset.Items.Add("4900H");
                cbAPUPreset.Items.Add("4600HS");
                cbAPUPreset.Items.Add("4800HS");
                cbAPUPreset.Items.Add("4900HS");
            }
            else if (cbAPUSeries.Text == "Ryzen 5000 Series U")
            {

                cbAPUPreset.Items.Add("5300U/5400U/5425U");
                cbAPUPreset.Items.Add("5500U");
                cbAPUPreset.Items.Add("5600U/5625U");
                cbAPUPreset.Items.Add("5700U");
                cbAPUPreset.Items.Add("5800U/5825U");
            }
            else if (cbAPUSeries.Text == "Ryzen 5000 Series H/HS/HX")
            {
                cbAPUPreset.Items.Add("5600H");
                cbAPUPreset.Items.Add("5800H");
                cbAPUPreset.Items.Add("5600HS");
                cbAPUPreset.Items.Add("5800HS");
                cbAPUPreset.Items.Add("5900HS");
                cbAPUPreset.Items.Add("5980HS");
                cbAPUPreset.Items.Add("5900HX");
                cbAPUPreset.Items.Add("5980HX");
                
            }
            else if (cbAPUSeries.Text == "Ryzen 6000 Series U")
            {
                cbAPUPreset.Items.Add("6600U");
                cbAPUPreset.Items.Add("6800U");
            }
            else if (cbAPUSeries.Text == "Ryzen 6000 Series H/HS/HX")
            {
                cbAPUPreset.Items.Add("6600H");
                cbAPUPreset.Items.Add("6800H");
                cbAPUPreset.Items.Add("6600HS");
                cbAPUPreset.Items.Add("6800HS");
                cbAPUPreset.Items.Add("6900HS");
                cbAPUPreset.Items.Add("6980HS");
                cbAPUPreset.Items.Add("6900HX");
                cbAPUPreset.Items.Add("6980HX");

            }
            else if (cbAPUSeries.Text == "AYA Neo (4500U)")
            {
                cbAPUPreset.Items.Add("Docked Mode (35w)");
                cbAPUPreset.Items.Add("Performance Mode (25w)");
                cbAPUPreset.Items.Add("Balanced Performance Mode (15w)");
                cbAPUPreset.Items.Add("Battery Mode (12w)");
                cbAPUPreset.Items.Add("2D Game Mode (8w)");

                lbPresetValues.Items.Clear();
            }
            else if (cbAPUSeries.Text == "AYA Neo (4800U)")
            {
                cbAPUPreset.Items.Add("Docked Mode (38w)");
                cbAPUPreset.Items.Add("Performance Mode (28w)");
                cbAPUPreset.Items.Add("Balanced Performance Mode (18w)");
                cbAPUPreset.Items.Add("Battery Mode (12w)");
                cbAPUPreset.Items.Add("2D Game Mode (8w)");

                lbPresetValues.Items.Clear();
            }
            else if (cbAPUSeries.Text == "AYA Neo Next")
            {
                cbAPUPreset.Items.Add("Docked Mode (35w)");
                cbAPUPreset.Items.Add("Performance Mode (25w)");
                cbAPUPreset.Items.Add("Balanced Performance Mode (15w)");
                cbAPUPreset.Items.Add("Battery Mode (12w)");
                cbAPUPreset.Items.Add("2D Game Mode (10w)");

                lbPresetValues.Items.Clear();
            }
            else if (cbAPUSeries.Text == "Steam Deck")
            {
                cbAPUPreset.Items.Add("Docked Mode (30w)");
                cbAPUPreset.Items.Add("Performance Mode (28w)");
                cbAPUPreset.Items.Add("Balanced Performance Mode (15w)");
                cbAPUPreset.Items.Add("Battery Mode (12w)");
                cbAPUPreset.Items.Add("2D Game Mode (8w)");

                lbPresetValues.Items.Clear();
            }
        }

        private void cbAPUPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbAPUPreset.Text == "2200U" || cbAPUPreset.Text == "3200U")
            {
                tempLimit = 95;
                CPUTDP = 20;
                LongBoostDuration = 900;
                longBoostTDP = 20;
                shortBoostDuration = 60;
                shortBoostTDP = 25;
                VRM = 45;
            } 
            else if (cbAPUPreset.Text == "2300U" || cbAPUPreset.Text == "2500U" || cbAPUPreset.Text == "2700U" || cbAPUPreset.Text == "3300U")
            {
                tempLimit = 95;
                CPUTDP = 25;
                LongBoostDuration = 900;
                longBoostTDP = 25;
                shortBoostDuration = 60;
                shortBoostTDP = 30;
                VRM = 50;
            }
            else if (cbAPUPreset.Text == "3500U")
            {
                tempLimit = 95;
                CPUTDP =30;
                LongBoostDuration = 900;
                longBoostTDP = 30;
                shortBoostDuration = 60;
                shortBoostTDP = 35;
                VRM = 50;
            }
            else if (cbAPUPreset.Text == "3550H")
            {
                tempLimit = 105;
                CPUTDP = 35;
                LongBoostDuration = 900;
                longBoostTDP = 35;
                shortBoostDuration = 60;
                shortBoostTDP = 40;
                VRM = 60;
            }
            else if (cbAPUPreset.Text == "3700U")
            {
                tempLimit = 95;
                CPUTDP = 35;
                LongBoostDuration = 900;
                longBoostTDP = 35;
                shortBoostDuration = 60;
                shortBoostTDP = 40;
                VRM = 60;
            }
            else if (cbAPUPreset.Text == "3750H")
            {
                tempLimit = 105;
                CPUTDP = 40;
                LongBoostDuration = 900;
                longBoostTDP = 40;
                shortBoostDuration = 60;
                shortBoostTDP = 50;
                VRM = 60;
            }
            else if (cbAPUPreset.Text == "4300U" || cbAPUPreset.Text == "4500U" || cbAPUPreset.Text == "4600U" || cbAPUPreset.Text == "4700U" || cbAPUPreset.Text == "4800U" || cbAPUPreset.Text == "5300U/5400U/5425U" || cbAPUPreset.Text == "5500U" || cbAPUPreset.Text == "5600U/5625U" || cbAPUPreset.Text == "5700U" || cbAPUPreset.Text == "5800U/5825U")
            {
                tempLimit = 95;
                CPUTDP = 25;
                LongBoostDuration = 75;
                longBoostTDP = 25;
                shortBoostDuration = 10;
                shortBoostTDP = 30;
                VRM = 85;
            }
            else if (cbAPUPreset.Text == "6600U")
            {
                tempLimit = 105;
                CPUTDP = 28;
                LongBoostDuration = 75;
                longBoostTDP = 30;
                shortBoostDuration = 10;
                shortBoostTDP = 38;
                VRM = 95;
            }
            else if ( cbAPUPreset.Text == "6800U")
            {
                tempLimit = 105;
                CPUTDP = 30;
                LongBoostDuration = 75;
                longBoostTDP = 32;
                shortBoostDuration = 10;
                shortBoostTDP = 40;
                VRM = 95;
            }
            else if (cbAPUPreset.Text == "4600H" || cbAPUPreset.Text == "5600H" || cbAPUPreset.Text == "6600H")
            {
                tempLimit = 105;
                CPUTDP = 55;
                LongBoostDuration = 75;
                longBoostTDP = 60;
                shortBoostDuration = 10;
                shortBoostTDP = 66;
                VRM = 95;
            }
            else if (cbAPUPreset.Text == "4800H" || cbAPUPreset.Text == "4900H" || cbAPUPreset.Text == "5800H" || cbAPUPreset.Text == "6800H")
            {
                tempLimit = 105;
                CPUTDP = 60;
                LongBoostDuration = 75;
                longBoostTDP = 62;
                shortBoostDuration = 10;
                shortBoostTDP = 68;
                VRM = 100;
            }
            else if (cbAPUPreset.Text == "5900HX" || cbAPUPreset.Text == "5980HX" || cbAPUPreset.Text == "6900HX" || cbAPUPreset.Text == "6980HX")
            {
                tempLimit = 105;
                CPUTDP = 72;
                LongBoostDuration = 75;
                longBoostTDP = 74;
                shortBoostDuration = 10;
                shortBoostTDP = 82;
                VRM = 105;
            }
            else if (cbAPUPreset.Text == "4600HS" || cbAPUPreset.Text == "5600HS")
            {
                tempLimit = 105;
                CPUTDP = 45;
                LongBoostDuration = 75;
                longBoostTDP = 50;
                shortBoostDuration = 10;
                shortBoostTDP = 56;
                VRM = 95;
            }
            else if (cbAPUPreset.Text == "4800HS" || cbAPUPreset.Text == "4900HS" || cbAPUPreset.Text == "5800HS")
            {
                tempLimit = 105;
                CPUTDP = 50;
                LongBoostDuration = 75;
                longBoostTDP = 52;
                shortBoostDuration = 10;
                shortBoostTDP = 58;
                VRM = 100;
            }
            else if (cbAPUPreset.Text == "5900HS" || cbAPUPreset.Text == "5980HS")
            {
                tempLimit = 105;
                CPUTDP = 52;
                LongBoostDuration = 75;
                longBoostTDP = 54;
                shortBoostDuration = 10;
                shortBoostTDP = 60;
                VRM = 100;
            }
            else if (cbAPUPreset.Text == "Docked Mode (30w)")
            {
                tempLimit = 105;
                CPUTDP = 30;
                LongBoostDuration = 5;
                longBoostTDP = 30;
                shortBoostDuration = 275;
                shortBoostTDP = 30;
                VRM = 80;
                maxCPUCores = 100;
                MaxCPUPerf = 100;
                boostMode = 1;

            }
            else if (cbAPUPreset.Text == "Docked Mode (35w)")
            {
                tempLimit = 105;
                CPUTDP = 35;
                LongBoostDuration = 5;
                longBoostTDP = 35;
                shortBoostDuration = 275;
                shortBoostTDP = 35;
                VRM = 80;
                maxCPUCores = 100;
                MaxCPUPerf = 100;
                boostMode = 1;

            }
            else if (cbAPUPreset.Text == "Docked Mode (38w)")
            {
                tempLimit = 105;
                CPUTDP = 38;
                LongBoostDuration = 5;
                longBoostTDP = 38;
                shortBoostDuration = 275;
                shortBoostTDP = 38;
                VRM = 80;
                maxCPUCores = 100;
                MaxCPUPerf = 100;
                boostMode = 1;

            }
            else if (cbAPUPreset.Text == "Performance Mode (25w)")
            {
                tempLimit = 105;
                CPUTDP = 25;
                LongBoostDuration = 5;
                longBoostTDP = 25;
                shortBoostDuration = 275;
                shortBoostTDP = 25;
                VRM = 60;
                maxCPUCores = 100;
                MaxCPUPerf = 87;
                boostMode = 1;

            }
            else if (cbAPUPreset.Text == "Performance Mode (28w)")
            {
                tempLimit = 105;
                CPUTDP = 28;
                LongBoostDuration = 5;
                longBoostTDP = 28;
                shortBoostDuration = 275;
                shortBoostTDP = 28;
                VRM = 60;
                maxCPUCores = 100;
                MaxCPUPerf = 87;
                boostMode = 1;

            }
            else if (cbAPUPreset.Text == "Balanced Performance Mode (15w)")
            {
                tempLimit = 105;
                CPUTDP = 15;
                LongBoostDuration = 5;
                longBoostTDP = 15;
                shortBoostDuration = 275;
                shortBoostTDP = 18;
                VRM = 50;
                maxCPUCores = 100;
                MaxCPUPerf = 70;
                boostMode = 0;
            }
            else if (cbAPUPreset.Text == "Battery Mode (12w)")
            {
                tempLimit = 105;
                CPUTDP = 12;
                LongBoostDuration = 5;
                longBoostTDP = 12;
                shortBoostDuration = 275;
                shortBoostTDP = 12;
                VRM = 50;
                maxCPUCores = 66;
                MaxCPUPerf = 53;
                boostMode = 0;
            }
            else if (cbAPUPreset.Text == "2D Game Mode (8w)")
            {
                tempLimit = 105;
                CPUTDP = 8;
                LongBoostDuration = 8;
                longBoostTDP = 8;
                shortBoostDuration = 275;
                shortBoostTDP = 5;
                VRM = 50;
                maxCPUCores = 66;
                MaxCPUPerf = 58;
                boostMode = 0;
            }
            else if (cbAPUPreset.Text == "2D Game Mode (10w)")
            {
                tempLimit = 105;
                CPUTDP = 10;
                LongBoostDuration = 8;
                longBoostTDP = 10;
                shortBoostDuration = 275;
                shortBoostTDP = 10;
                VRM = 50;
                maxCPUCores = 66;
                MaxCPUPerf = 58;
                boostMode = 0;
            }




            if (tempLimit > 100)
            {
                tempLimit = 100;
            }

            lbPresetValues.Items.Clear();
            lbPresetValues.Items.Add("--tctl-temp=" + tempLimit + " | Temp limit = " + tempLimit +"c");
            lbPresetValues.Items.Add("--stapm-limit="+ CPUTDP * 1000 + " | STAPM TDP = "+ CPUTDP +"w");
            lbPresetValues.Items.Add("--fast-limit="+ longBoostTDP * 1000 + " | Long/Fast Boost TDP = " + longBoostTDP + "w");
            lbPresetValues.Items.Add("--stapm-time=" + LongBoostDuration + " | Long/Fast Boost Duration = " + LongBoostDuration + "s");
            lbPresetValues.Items.Add("--slow-limit="+ shortBoostTDP * 1000 +" | Short/Slow Boost TDP = "+ shortBoostTDP +"w");
            lbPresetValues.Items.Add("--slow-time="+ shortBoostDuration +" | Short/Slow Boost Duration = " + shortBoostDuration +"s");
            lbPresetValues.Items.Add("--vrmmax-current="+ VRM * 1000 +" | VRM Current (A) = " + VRM);

            if(SkinTemp == true)
            {
                RyzenADJ = "--tctl-temp=" + tempLimit + " --apu-skin-temp=" + tempLimit + " --stapm-limit=" + CPUTDP * 1000 + " --fast-limit=" + longBoostTDP * 1000 + " --stapm-time=" + LongBoostDuration + " --slow-limit=" + shortBoostTDP * 1000 + " --slow-time=" + shortBoostDuration + " --vrmmax-current=" + VRM * 1000 + " --vrm-current=" + (VRM - 15) * 1000;

            }
            else
            {
                RyzenADJ = "--tctl-temp=" + tempLimit + " --stapm-limit=" + CPUTDP * 1000 + " --fast-limit=" + longBoostTDP * 1000 + " --stapm-time=" + LongBoostDuration + " --slow-limit=" + shortBoostTDP * 1000 + " --slow-time=" + shortBoostDuration + " --vrmmax-current=" + VRM * 1000 + " --vrm-current=" + (VRM - 15) * 1000;

            }

            btnimport.Enabled = true;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            path = (string)Settings.Default["Path"];
            path2 = (string)Settings.Default["Path"];
            path = path + "\\bin\\ryzenadj.exe";
            
            path2 = path2 + "\\bin\\Notification.exe";


            if (RyzenADJ == "" || RyzenADJ == null)
            {
                return;
            }
            else
            {
                try {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = path;
                    startInfo.Arguments = RyzenADJ;
                    process.StartInfo = startInfo;
                    process.Start();

                    Settings.Default["RyzenADJ"] = RyzenADJ;

                    if (connection == true)
                    {
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = path2;
                        startInfo.Arguments = "https://media.discordapp.net/attachments/711708420281204768/813512272935780412/AATU-LOGO.png?width=697&height=676 Applied-Successfully! Your-settings-have-been-applied-successfully";
                        process.StartInfo = startInfo;
                        process.Start();
                    }
                    else
                    {
                        MessageBox.Show("Your settings have been applied successfully", "Applied Successfully!");
                    }

                    Settings.Default.Save();
                }
                
                catch (Exception) 
                {
                    if (connection == true)
                    {
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = path2;
                        startInfo.Arguments = "https://media.discordapp.net/attachments/711708420281204768/813512272935780412/AATU-LOGO.png?width=697&height=676 Error! Something-went-wrong-when-applying-your-settings-:(";
                        process.StartInfo = startInfo;
                        process.Start();
                    } else
                    {
                        MessageBox.Show("Something went wrong when applying your settings :(", "Error!");
                    }
                }
            }
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            Settings.Default["TempLimit"] = tempLimit;
            Settings.Default["CPUTDP"] = CPUTDP;
            Settings.Default["LongBoostTDP"] = longBoostTDP;
            Settings.Default["LongBoostDuration"] = LongBoostDuration;
            Settings.Default["ShortBoostTDP"] = shortBoostTDP;
            Settings.Default["ShortBoostDuration"] = shortBoostDuration;

            Settings.Default["VRMMax"] = VRM;
            Settings.Default["Import"] = true;
            Settings.Default.Save();
        }
    }
}
