using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AMD_APU_Tuing_Utility.Properties;
using Microsoft.Win32;
using IWshRuntimeLibrary;
using Shell32;
using DiscordRPC;
using System.Management;
using System.Data.SqlClient;
using System.Net.Configuration;
using System.Security.Principal;
using System.Diagnostics;
using System.Reflection;
using System.Windows;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;

namespace AMD_APU_Tuing_Utility
{

    public partial class Form1 : Form
    {
        int STAPM = 0;
        int boostTDP = 0;
        int shortTDP = 0;
        int boostDuration = 0;
        int shortDuration = 0;
        int VRMMax = 0;
        int fabricMin = 0;
        int fabricMax = 0;
        int temp = 0;
        //int PSI0Current = 0;
        string RyzenADJ = null;
        string direc;
        string CPUName;
        string PresetName;
        string RyzenADJOld;

        public Form1()
        {
            InitializeComponent();
        }


        public DiscordRpcClient client;
        //public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\james\source\repos\AMD APU Tuing Utility\AMD APU Tuing Utility\bin\Debug\AATUPresets.mdf;Integrated Security=True;Connect Timeout=30");
        public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\presets\AATUPresets.mdf;Integrated Security=True;Connect Timeout=30");
        private void Form1_Load(object sender, EventArgs e)
        {
            tbTemp.Text = Settings.Default["Temp"].ToString();
            tbSTAPM.Text = Settings.Default["STAPM"].ToString();
            tbLongDuration.Text = Settings.Default["BoostDuration"].ToString();
            tbLongTDP.Text = Settings.Default["BoostTDP"].ToString();
            tbShortDuration.Text = Settings.Default["ShortDuration"].ToString();
            tbShortTDP.Text = Settings.Default["ShortTDP"].ToString();
            tbMinMem.Text = Settings.Default["MinMem"].ToString();
            tbMaxMem.Text = Settings.Default["MaxMem"].ToString();
            tbVRM.Text = Settings.Default["VRM"].ToString();
            tbxPresetName.Text = Settings.Default["PresetName"].ToString();
            bool custom = Convert.ToBoolean(Settings.Default["Custom"]);
            bool applyLaunch = Convert.ToBoolean(Settings.Default["ApplyLaunch"]);
            bool startWin = Convert.ToBoolean(Settings.Default["StartWin"]);
            bool autoApply = Convert.ToBoolean(Settings.Default["AutoApply"]);
            if (custom == true)
            {
                gbCustom.Enabled = true;
                gbPreset.Enabled = false;
                cbPreset.Checked = false;
            }
            else
            {
                gbCustom.Enabled = false;
                gbPreset.Enabled = true;
                cbPreset.Checked = true;
            }

            if (applyLaunch == true)
            {
                direc = Directory.GetCurrentDirectory();
                RyzenADJ = Settings.Default["RyzenADJ"].ToString();
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = direc;
                startInfo.Arguments = RyzenADJ;
                process.StartInfo = startInfo;
                process.Start();
                cbApplyLaunch.Checked = true;
            }
            else
            {
                cbApplyLaunch.Checked = false;
            }
            if(autoApply == true)
            {
                cbAutoApply.Checked = true;
            } else
            {
                cbAutoApply.Checked = false;
            }
            

            ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");
            foreach (ManagementObject obj in myProcessorObject.Get())
            {
                CPUName = obj["Name"].ToString();
            }

            if (CPUName.Contains("3750H"))
            {
                CPUName = "APU: Ryzen 7 3750H";
            }

            else if (CPUName.Contains("3550H"))
            {
                CPUName = "APU: Ryzen 5 3550H";
            }

            else if (CPUName.Contains("3780U"))
            {
                CPUName = "APU: Ryzen 7 3780U";
            }

            else if (CPUName.Contains("3580U"))
            {
                CPUName = "APU: Ryzen 5 3580U";
            }

            else if (CPUName.Contains("3700U"))
            {
                CPUName = "APU: Ryzen 7 3700U";
            }

            else if (CPUName.Contains("3500U"))
            {
                CPUName = "APU: Ryzen 5 3500U";
            }

            else if (CPUName.Contains("3300U"))
            {
                CPUName = "APU: Ryzen 3 3300U";
            }

            else if (CPUName.Contains("3200U"))
            {
                CPUName = "APU: Ryzen 3 3200U";
            }

            else if (CPUName.Contains("2700U"))
            {
                CPUName = "APU: Ryzen 7 2700U";
            }

            else if (CPUName.Contains("2500U"))
            {
                CPUName = "APU: Ryzen 5 2500U";
            }

            else if (CPUName.Contains("2300U"))
            {
                CPUName = "APU: Ryzen 3 2300U";
            }

            else if (CPUName.Contains("2200U"))
            {
                CPUName = "APU: Ryzen 3 2200U";
            }

            else if (CPUName.Contains("4700U"))
            {
                CPUName = "APU: Ryzen 7 4700U";
            }
            else if (CPUName.Contains("4500U"))
            {
                CPUName = "APU: Ryzen 5 4500U";
            }
            else if (CPUName.Contains("4300U"))
            {
                CPUName = "APU: Ryzen 3 4300U";
            }
            else if (CPUName.Contains("3200U"))
            {
                CPUName = "APU: Ryzen 3 4200U";
            }

            else if (CPUName.Contains("4900U"))
            {
                CPUName = "APU: Ryzen 9 4900U";
            }
            else if (CPUName.Contains("4800U"))
            {
                CPUName = "APU: Ryzen 7 4800U";
            }
            else if (CPUName.Contains("4600U"))
            {
                CPUName = "APU: Ryzen 5 4600U";
            }

            else if (CPUName.Contains("4900H"))
            {
                CPUName = "APU: Ryzen 9 4900H";
            }
            else if (CPUName.Contains("4800H"))
            {
                CPUName = "APU: Ryzen 7 4800H";
            }
            else if (CPUName.Contains("4600H"))
            {
                CPUName = "APU: Ryzen 5 4600H";
            }

            else if (CPUName.Contains("4900HS"))
            {
                CPUName = "APU: Ryzen 9 4900HS";
            }
            else if (CPUName.Contains("4800HS"))
            {
                CPUName = "APU: Ryzen 7 4800HS";
            }
            else if (CPUName.Contains("4600HS"))
            {
                CPUName = "APU: Ryzen 5 4600HS";
            }
            else
            {
                CPUName = "APU: " + CPUName;
            }

            client = new DiscordRpcClient("761946503006388224");
            client.SetPresence(new DiscordRPC.RichPresence()
            {
                Details = "Version: 1.0.8.2",
                State = $"{CPUName}",
                Assets = new Assets()
                {
                    LargeImageKey = "icon"
                }
            });
            client.Initialize();


            cc();

        }

        public void cc()
        {
            cbxCustomPreset.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [table]";
            cmd.ExecuteNonQuery();


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cbxCustomPreset.Items.Add(dr["PresetName"].ToString());
            }
            con.Close();
        }


        private void btnApply_Click(object sender, EventArgs e)
        {
            direc = Directory.GetCurrentDirectory();
            direc = direc + "\\bin\\ryzenadj.exe";


            if (cbPreset.Checked == true)
            {
                Settings.Default["Custom"] = false;
                if (cbxPreset.Text == "3750H")
                {
                    temp = 105;
                    STAPM = 40000;
                    boostTDP = 40000;
                    boostDuration = 900;
                    shortTDP = 50000;
                    shortDuration = 60;
                    //fabricMin = 800;
                    //fabricMax = 1200;
                    VRMMax = 60000;

                    RyzenADJ = "--tctl-temp=" + temp + " --stapm-limit=" + STAPM + " --fast-limit=" + boostTDP + " --stapm-time=" + boostDuration + " --slow-limit=" + shortTDP + " --slow-time=" + shortDuration + " --vrmmax-current=" + VRMMax;

                    //MessageBox.Show(RyzenADJ);
                    //MessageBox.Show(dirc);


                }
                else if (cbxPreset.Text == "3550H")
                {
                    temp = 105;
                    STAPM = 35000;
                    boostTDP = 35000;
                    boostDuration = 900;
                    shortTDP = 40000;
                    shortDuration = 60;
                    //fabricMin = 800;
                    //fabricMax = 1200;
                    VRMMax = 60000;

                    RyzenADJ = "--tctl-temp=" + temp + " --stapm-limit=" + STAPM + " --fast-limit=" + boostTDP + " --stapm-time=" + boostDuration + " --slow-limit=" + shortTDP + " --slow-time=" + shortDuration + " --vrmmax-current=" + VRMMax;

                    //MessageBox.Show(RyzenADJ);


                }
                else if (cbxPreset.Text == "3500U")
                {
                    temp = 95;
                    STAPM = 30000;
                    boostTDP = 30000;
                    boostDuration = 900;
                    shortTDP = 35000;
                    shortDuration = 60;
                    //fabricMin = 800;
                    //fabricMax = 1200;
                    VRMMax = 50000;

                    RyzenADJ = "--tctl-temp=" + temp + " --stapm-limit=" + STAPM + " --fast-limit=" + boostTDP + " --stapm-time=" + boostDuration + " --slow-limit=" + shortTDP + " --slow-time=" + shortDuration + " --vrmmax-current=" + VRMMax;

                    //MessageBox.Show(RyzenADJ);


                }
                else if (cbxPreset.Text == "2500U")
                {
                    temp = 95;
                    STAPM = 25000;
                    boostTDP = 25000;
                    boostDuration = 900;
                    shortTDP = 30000;
                    shortDuration = 60;
                    //fabricMin = 800;
                    //fabricMax = 1200;
                    VRMMax = 50000;

                    RyzenADJ = "--tctl-temp=" + temp + " --stapm-limit=" + STAPM + " --fast-limit=" + boostTDP + " --stapm-time=" + boostDuration + " --slow-limit=" + shortTDP + " --slow-time=" + shortDuration + " --vrmmax-current=" + VRMMax;

                    //MessageBox.Show(RyzenADJ);


                }
                else if (cbxPreset.Text == "3700U")
                {
                    temp = 95;
                    STAPM = 30000;
                    boostTDP = 30000;
                    boostDuration = 900;
                    shortTDP = 40000;
                    shortDuration = 60;
                    //fabricMin = 800;
                    //fabricMax = 1200;
                    VRMMax = 50000;

                    RyzenADJ = "--tctl-temp=" + temp + " --stapm-limit=" + STAPM + " --fast-limit=" + boostTDP + " --stapm-time=" + boostDuration + " --slow-limit=" + shortTDP + " --slow-time=" + shortDuration + " --vrmmax-current=" + VRMMax;

                    //MessageBox.Show(RyzenADJ);


                }
                else if (cbxPreset.Text == "2700U")
                {
                    temp = 95;
                    STAPM = 25000;
                    boostTDP = 25000;
                    boostDuration = 900;
                    shortTDP = 30000;
                    shortDuration = 60;
                    //fabricMin = 800;
                    //fabricMax = 1200;
                    VRMMax = 50000;

                    RyzenADJ = "--tctl-temp=" + temp + " --stapm-limit=" + STAPM + " --fast-limit=" + boostTDP + " --stapm-time=" + boostDuration + " --slow-limit=" + shortTDP + " --slow-time=" + shortDuration + " --vrmmax-current=" + VRMMax;

                    //MessageBox.Show(RyzenADJ);


                }
                else if (cbxPreset.Text == "3300U")
                {
                    temp = 95;
                    STAPM = 25000;
                    boostTDP = 25000;
                    boostDuration = 900;
                    shortTDP = 30000;
                    shortDuration = 60;
                    //fabricMin = 800;
                    //fabricMax = 1200;
                    VRMMax = 50000;

                    RyzenADJ = "--tctl-temp=" + temp + " --stapm-limit=" + STAPM + " --fast-limit=" + boostTDP + " --stapm-time=" + boostDuration + " --slow-limit=" + shortTDP + " --slow-time=" + shortDuration + " --vrmmax-current=" + VRMMax;

                    //MessageBox.Show(RyzenADJ);


                }
                else if (cbxPreset.Text == "2300U")
                {
                    temp = 95;
                    STAPM = 25000;
                    boostTDP = 25000;
                    boostDuration = 900;
                    shortTDP = 30000;
                    shortDuration = 60;
                    //fabricMin = 800;
                    //fabricMax = 1200;
                    VRMMax = 50000;

                    RyzenADJ = "--tctl-temp=" + temp + " --stapm-limit=" + STAPM + " --fast-limit=" + boostTDP + " --stapm-time=" + boostDuration + " --slow-limit=" + shortTDP + " --slow-time=" + shortDuration + " --vrmmax-current=" + VRMMax;

                    //MessageBox.Show(RyzenADJ);


                }
                else if (cbxPreset.Text == "3200U")
                {
                    temp = 95;
                    STAPM = 20000;
                    boostTDP = 20000;
                    boostDuration = 900;
                    shortTDP = 25000;
                    shortDuration = 60;
                    //fabricMin = 800;
                    //fabricMax = 1200;
                    VRMMax = 45000;

                    RyzenADJ = "--tctl-temp=" + temp + " --stapm-limit=" + STAPM + " --fast-limit=" + boostTDP + " --stapm-time=" + boostDuration + " --slow-limit=" + shortTDP + " --slow-time=" + shortDuration + " --vrmmax-current=" + VRMMax;

                    //MessageBox.Show(RyzenADJ);


                }
                else if (cbxPreset.Text == "2200U")
                {
                    temp = 95;
                    STAPM = 20000;
                    boostTDP = 20000;
                    boostDuration = 900;
                    shortTDP = 25000;
                    shortDuration = 60;
                    //fabricMin = 800;
                    //fabricMax = 1200;
                    VRMMax = 45000;

                    RyzenADJ = "--tctl-temp=" + temp + " --stapm-limit=" + STAPM + " --fast-limit=" + boostTDP + " --stapm-time=" + boostDuration + " --slow-limit=" + shortTDP + " --slow-time=" + shortDuration + " --vrmmax-current=" + VRMMax;

                    //MessageBox.Show(RyzenADJ);


                }

                else if (cbxPreset.Text == "4500U" || cbxPreset.Text == "4700U")
                {
                    temp = 105;
                    STAPM = 30000;
                    boostTDP = 35000;
                    boostDuration = 900;
                    shortTDP = 44000;
                    shortDuration = 75;
                    //fabricMin = 800;
                    //fabricMax = 1200;
                    VRMMax = 95000;

                    RyzenADJ = "--tctl-temp=" + temp + " --stapm-limit=" + STAPM + " --fast-limit=" + boostTDP + " --stapm-time=" + boostDuration + " --slow-limit=" + shortTDP + " --slow-time=" + shortDuration + " --vrmmax-current=" + VRMMax;

                    //MessageBox.Show(RyzenADJ);


                }
                else if (cbxPreset.Text == "4800U" || cbxPreset.Text == "4600U")
                {
                    temp = 105;
                    STAPM = 35000;
                    boostTDP = 40000;
                    boostDuration = 900;
                    shortTDP = 48000;
                    shortDuration = 75;
                    //fabricMin = 800;
                    //fabricMax = 1200;
                    VRMMax = 95000;

                    RyzenADJ = "--tctl-temp=" + temp + " --stapm-limit=" + STAPM + " --fast-limit=" + boostTDP + " --stapm-time=" + boostDuration + " --slow-limit=" + shortTDP + " --slow-time=" + shortDuration + " --vrmmax-current=" + VRMMax;

                    //MessageBox.Show(RyzenADJ);


                }

                else if (cbxPreset.Text == "4800HS" || cbxPreset.Text == "4900HS")
                {
                    temp = 105;
                    STAPM = 45000;
                    boostTDP = 55000;
                    boostDuration = 900;
                    shortTDP = 65000;
                    shortDuration = 75;
                    //fabricMin = 800;
                    //fabricMax = 1200;
                    VRMMax = 105000;

                    RyzenADJ = "--tctl-temp=" + temp + " --stapm-limit=" + STAPM + " --fast-limit=" + boostTDP + " --stapm-time=" + boostDuration + " --slow-limit=" + shortTDP + " --slow-time=" + shortDuration + " --vrmmax-current=" + VRMMax;

                    //MessageBox.Show(RyzenADJ);


                }
                else if (cbxPreset.Text == "4600HS")
                {
                    temp = 105;
                    STAPM = 40000;
                    boostTDP = 50000;
                    boostDuration = 900;
                    shortTDP = 55000;
                    shortDuration = 75;
                    //fabricMin = 800;
                    //fabricMax = 1200;
                    VRMMax = 105000;

                    RyzenADJ = "--tctl-temp=" + temp + " --stapm-limit=" + STAPM + " --fast-limit=" + boostTDP + " --stapm-time=" + boostDuration + " --slow-limit=" + shortTDP + " --slow-time=" + shortDuration + " --vrmmax-current=" + VRMMax;

                    //MessageBox.Show(RyzenADJ);


                }

                else if (cbxPreset.Text == "4800H" || cbxPreset.Text == "4900H")
                {
                    temp = 105;
                    STAPM = 55000;
                    boostTDP = 75000;
                    boostDuration = 900;
                    shortTDP = 82000;
                    shortDuration = 75;
                    //fabricMin = 800;
                    //fabricMax = 1200;
                    VRMMax = 110000;

                    RyzenADJ = "--tctl-temp=" + temp + " --stapm-limit=" + STAPM + " --fast-limit=" + boostTDP + " --stapm-time=" + boostDuration + " --slow-limit=" + shortTDP + " --slow-time=" + shortDuration + " --vrmmax-current=" + VRMMax;

                    //MessageBox.Show(RyzenADJ);


                }
                else if (cbxPreset.Text == "4600H")
                {
                    temp = 105;
                    STAPM = 55000;
                    boostTDP = 65000;
                    boostDuration = 900;
                    shortTDP = 72000;
                    shortDuration = 75;
                    //fabricMin = 800;
                    //fabricMax = 1200;
                    VRMMax = 110000;

                    RyzenADJ = "--tctl-temp=" + temp + " --stapm-limit=" + STAPM + " --fast-limit=" + boostTDP + " --stapm-time=" + boostDuration + " --slow-limit=" + shortTDP + " --slow-time=" + shortDuration + " --vrmmax-current=" + VRMMax;

                    //MessageBox.Show(RyzenADJ);


                }

                else
                {
                    MessageBox.Show("Please use a valid preset from the preset list", "Important Note",
    MessageBoxButtons.OK,
    MessageBoxIcon.Exclamation,
    MessageBoxDefaultButton.Button1);
                }
                if (RyzenADJ == "" || RyzenADJ == null)
                {
                    return;
                }
                else
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = direc;
                    startInfo.Arguments = RyzenADJ;
                    process.StartInfo = startInfo;
                    process.Start();
                    Settings.Default["RyzenADJ"] = RyzenADJ;
                    MessageBox.Show("Your settings have been applied!", "Settings Applied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Settings.Default.Save();
                }
            }

            else if (cbCustom.Checked == true)
            {
                Settings.Default["Custom"] = true;
                RyzenADJ = "";
                Settings.Default["PresetName"] = tbxPresetName.Text;
                if (cb1.Checked == true)
                {
                    temp = Convert.ToInt32(tbTemp.Text);
                    Settings.Default["Temp"] = temp;
                    RyzenADJ = RyzenADJ + "--tctl-temp=" + temp + " ";
                }
                if (cb2.Checked == true)
                {
                    STAPM = Convert.ToInt32(tbSTAPM.Text);
                    Settings.Default["STAPM"] = STAPM;
                    RyzenADJ = RyzenADJ + "--stapm-limit=" + (STAPM * 1000) + " ";
                }
                if (cb3.Checked == true)
                {
                    boostDuration = Convert.ToInt32(tbLongDuration.Text);
                    Settings.Default["BoostDuration"] = boostDuration;
                    RyzenADJ = RyzenADJ + "--stapm-time=" + boostDuration + " ";
                }
                if (cb4.Checked == true)
                {
                    boostTDP = Convert.ToInt32(tbLongTDP.Text);
                    Settings.Default["BoostTDP"] = boostTDP;
                    RyzenADJ = RyzenADJ + "--slow-limit=" + (boostTDP * 1000) + " ";
                }
                if (cb5.Checked == true)
                {
                    shortDuration = Convert.ToInt32(tbShortDuration.Text);
                    Settings.Default["ShortDuration"] = shortDuration;
                    RyzenADJ = RyzenADJ + "--slow-time=" + shortDuration + " ";
                }
                if (cb6.Checked == true)
                {
                    shortTDP = Convert.ToInt32(tbShortTDP.Text);
                    Settings.Default["ShortTDP"] = shortTDP;
                    RyzenADJ = RyzenADJ + "--fast-limit=" + (shortTDP * 1000) + " ";
                }
                if (cb7.Checked == true)
                {
                    fabricMin = Convert.ToInt32(tbMinMem.Text);
                    Settings.Default["MinMem"] = fabricMin;
                    RyzenADJ = RyzenADJ + "--min-fclk-frequency=" + fabricMin + " ";
                }
                if (cb8.Checked == true)
                {
                    fabricMax = Convert.ToInt32(tbMaxMem.Text);
                    Settings.Default["MaxMem"] = fabricMax;
                    RyzenADJ = RyzenADJ + "--max-fclk-frequency=" + fabricMax + " ";
                }
                if (cb9.Checked == true)
                {
                    VRMMax = Convert.ToInt32(tbVRM.Text);
                    Settings.Default["VRM"] = VRMMax;
                    RyzenADJ = RyzenADJ + "--vrmmax-current=" + (VRMMax * 1000) + " ";
                }


                if (RyzenADJ == "" || RyzenADJ == null)
                {
                    return;
                }
                else
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = direc;
                    startInfo.Arguments = RyzenADJ;
                    process.StartInfo = startInfo;
                    process.Start();
                    //MessageBox.Show(RyzenADJ);
                    MessageBox.Show("Your settings have been applied!", "Settings Applied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Settings.Default["RyzenADJ"] = RyzenADJ;
                    Settings.Default.Save();

                }


            }
        }



        private void cbxPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPreset.Text == "3750H")
            {
                lbPresetValues.Items.Clear();
                lbPresetValues.Items.Add("--tctl-temp=105 | Temp limit = 105c");
                lbPresetValues.Items.Add("--stapm-limit=40000 | STAPM TDP = 40w");
                lbPresetValues.Items.Add("--fast-limit=45000 | Long Boost TDP = 45w");
                lbPresetValues.Items.Add("--stapm-time=900 | Long Boost Duration = 900s");
                lbPresetValues.Items.Add("--slow-limit=50000 | Short Boost TDP = 50w");
                lbPresetValues.Items.Add("--slow-time=60 | Short Boost Duration = 60s");
                lbPresetValues.Items.Add("--vrmmax-current=60000 | VRM Current (A) = 60");
            }
            else if (cbxPreset.Text == "3550H")
            {
                lbPresetValues.Items.Clear();
                lbPresetValues.Items.Add("--tctl-temp=105 | Temp limit = 105c");
                lbPresetValues.Items.Add("--stapm-limit=35000 | STAPM TDP = 35w");
                lbPresetValues.Items.Add("--fast-limit=40000 | Long Boost TDP = 40w");
                lbPresetValues.Items.Add("--stapm-time=900 | Long Boost Duration = 900s");
                lbPresetValues.Items.Add("--slow-limit=40000 | Short Boost TDP = 40w");
                lbPresetValues.Items.Add("--slow-time=60 | Short Boost Duration = 60s");
                lbPresetValues.Items.Add("--vrmmax-current=60000 | VRM Current (A) = 60");
            }
            else if (cbxPreset.Text == "3500U")
            {
                lbPresetValues.Items.Clear();
                lbPresetValues.Items.Add("--tctl-temp=95 | Temp limit = 95c");
                lbPresetValues.Items.Add("--stapm-limit=30000 | STAPM TDP = 30w");
                lbPresetValues.Items.Add("--fast-limit=30000 | Long Boost TDP = 30w");
                lbPresetValues.Items.Add("--stapm-time=900 | Long Boost Duration = 900s");
                lbPresetValues.Items.Add("--slow-limit=35000 | Short Boost TDP = 35w");
                lbPresetValues.Items.Add("--slow-time=60 | Short Boost Duration = 60s");
                lbPresetValues.Items.Add("--vrmmax-current=50000 | VRM Current (A) = 50");
            }
            else if (cbxPreset.Text == "2500U")
            {
                lbPresetValues.Items.Clear();
                lbPresetValues.Items.Add("--tctl-temp=95 | Temp limit = 95c");
                lbPresetValues.Items.Add("--stapm-limit=25000 | STAPM TDP = 25w");
                lbPresetValues.Items.Add("--fast-limit=25000 | Long Boost TDP = 25w");
                lbPresetValues.Items.Add("--stapm-time=900 | Long Boost Duration = 900s");
                lbPresetValues.Items.Add("--slow-limit=30000 | Short Boost TDP = 30w");
                lbPresetValues.Items.Add("--slow-time=60 | Short Boost Duration = 60s");
                lbPresetValues.Items.Add("--vrmmax-current=50000 | VRM Current (A) = 50");
            }
            else if (cbxPreset.Text == "3700U")
            {
                lbPresetValues.Items.Clear();
                lbPresetValues.Items.Add("--tctl-temp=95 | Temp limit = 95c");
                lbPresetValues.Items.Add("--stapm-limit=30000 | STAPM TDP = 30w");
                lbPresetValues.Items.Add("--fast-limit=30000 | Long Boost TDP = 30w");
                lbPresetValues.Items.Add("--stapm-time=900 | Long Boost Duration = 900s");
                lbPresetValues.Items.Add("--slow-limit=40000 | Short Boost TDP = 40w");
                lbPresetValues.Items.Add("--slow-time=60 | Short Boost Duration = 60s");
                lbPresetValues.Items.Add("--vrmmax-current=50000 | VRM Current (A) = 50");
            }
            else if (cbxPreset.Text == "2700U")
            {
                lbPresetValues.Items.Clear();
                lbPresetValues.Items.Add("--tctl-temp=95 | Temp limit = 95c");
                lbPresetValues.Items.Add("--stapm-limit=25000 | STAPM TDP = 25w");
                lbPresetValues.Items.Add("--fast-limit=25000 | Long Boost TDP = 25w");
                lbPresetValues.Items.Add("--stapm-time=900 | Long Boost Duration = 900s");
                lbPresetValues.Items.Add("--slow-limit=30000 | Short Boost TDP = 30w");
                lbPresetValues.Items.Add("--slow-time=60 | Short Boost Duration = 60s");
                lbPresetValues.Items.Add("--vrmmax-current=50000 | VRM Current (A) = 50");
            }
            else if (cbxPreset.Text == "3300U")
            {
                lbPresetValues.Items.Clear();
                lbPresetValues.Items.Add("--tctl-temp=95 | Temp limit = 95c");
                lbPresetValues.Items.Add("--stapm-limit=25000 | STAPM TDP = 25w");
                lbPresetValues.Items.Add("--fast-limit=25000 | Long Boost TDP = 25w");
                lbPresetValues.Items.Add("--stapm-time=900 | Long Boost Duration = 900s");
                lbPresetValues.Items.Add("--slow-limit=30000 | Short Boost TDP = 30w");
                lbPresetValues.Items.Add("--slow-time=60 | Short Boost Duration = 60s");
                lbPresetValues.Items.Add("--vrmmax-current=50000 | VRM Current (A) = 50");
            }
            else if (cbxPreset.Text == "2300U")
            {
                lbPresetValues.Items.Clear();
                lbPresetValues.Items.Add("--tctl-temp=95 | Temp limit = 95c");
                lbPresetValues.Items.Add("--stapm-limit=25000 | STAPM TDP = 25w");
                lbPresetValues.Items.Add("--fast-limit=25000 | Long Boost TDP = 25w");
                lbPresetValues.Items.Add("--stapm-time=900 | Long Boost Duration = 900s");
                lbPresetValues.Items.Add("--slow-limit=30000 | Short Boost TDP = 30w");
                lbPresetValues.Items.Add("--slow-time=60 | Short Boost Duration = 60s");
                lbPresetValues.Items.Add("--vrmmax-current=50000 | VRM Current (A) = 50");
            }
            else if (cbxPreset.Text == "3200U")
            {
                lbPresetValues.Items.Clear();
                lbPresetValues.Items.Add("--tctl-temp=95 | Temp limit = 95c");
                lbPresetValues.Items.Add("--stapm-limit=20000 | STAPM TDP = 20w");
                lbPresetValues.Items.Add("--fast-limit=20000 | Long Boost TDP = 20w");
                lbPresetValues.Items.Add("--stapm-time=900 | Long Boost Duration = 900s");
                lbPresetValues.Items.Add("--slow-limit=25000 | Short Boost TDP = 25w");
                lbPresetValues.Items.Add("--slow-time=60 | Short Boost Duration = 60s");
                lbPresetValues.Items.Add("--vrmmax-current=45000 | VRM Current (A) = 45");
            }
            else if (cbxPreset.Text == "2200U")
            {
                lbPresetValues.Items.Clear();
                lbPresetValues.Items.Add("--tctl-temp=95 | Temp limit = 95c");
                lbPresetValues.Items.Add("--stapm-limit=20000 | STAPM TDP = 20w");
                lbPresetValues.Items.Add("--fast-limit=20000 | Long Boost TDP = 20w");
                lbPresetValues.Items.Add("--stapm-time=900 | Long Boost Duration = 900s");
                lbPresetValues.Items.Add("--slow-limit=25000 | Short Boost TDP = 25w");
                lbPresetValues.Items.Add("--slow-time=60 | Short Boost Duration = 60s");
                lbPresetValues.Items.Add("--vrmmax-current=45000 | VRM Current (A) = 45");
            }

            else if (cbxPreset.Text == "4500U" || cbxPreset.Text == "4700U")
            {
                lbPresetValues.Items.Clear();
                lbPresetValues.Items.Add("--tctl-temp=105 | Temp limit = 105c");
                lbPresetValues.Items.Add("--stapm-limit=22000 | STAPM TDP = 22w");
                lbPresetValues.Items.Add("--fast-limit=25000 | Long Boost TDP = 25w");
                lbPresetValues.Items.Add("--stapm-time=900 | Long Boost Duration = 900s");
                lbPresetValues.Items.Add("--slow-limit=32000 | Short Boost TDP = 32w");
                lbPresetValues.Items.Add("--slow-time=60 | Short Boost Duration = 60s");
                lbPresetValues.Items.Add("--vrmmax-current=52000 | VRM Current (A) = 52");
            }
            else if (cbxPreset.Text == "4800U" || cbxPreset.Text == "4600U")
            {
                lbPresetValues.Items.Clear();
                lbPresetValues.Items.Add("--tctl-temp=105 | Temp limit = 105c");
                lbPresetValues.Items.Add("--stapm-limit=25000 | STAPM TDP = 25w");
                lbPresetValues.Items.Add("--fast-limit=28000 | Long Boost TDP = 28w");
                lbPresetValues.Items.Add("--stapm-time=900 | Long Boost Duration = 900s");
                lbPresetValues.Items.Add("--slow-limit=35000 | Short Boost TDP = 35w");
                lbPresetValues.Items.Add("--slow-time=60 | Short Boost Duration = 60s");
                lbPresetValues.Items.Add("--vrmmax-current=55000 | VRM Current (A) = 55");
            }
            else if (cbxPreset.Text == "4600HS")
            {
                lbPresetValues.Items.Clear();
                lbPresetValues.Items.Add("--tctl-temp=105 | Temp limit = 105c");
                lbPresetValues.Items.Add("--stapm-limit=40000 | STAPM TDP = 40w");
                lbPresetValues.Items.Add("--fast-limit=45000 | Long Boost TDP = 45w");
                lbPresetValues.Items.Add("--stapm-time=900 | Long Boost Duration = 900s");
                lbPresetValues.Items.Add("--slow-limit=55000 | Short Boost TDP = 55w");
                lbPresetValues.Items.Add("--slow-time=60 | Short Boost Duration = 60s");
                lbPresetValues.Items.Add("--vrmmax-current=75000 | VRM Current (A) = 75");
            }
            else if (cbxPreset.Text == "4800HS" || cbxPreset.Text == "4900HS")
            {
                lbPresetValues.Items.Clear();
                lbPresetValues.Items.Add("--tctl-temp=105 | Temp limit = 105c");
                lbPresetValues.Items.Add("--stapm-limit=45000 | STAPM TDP = 45w");
                lbPresetValues.Items.Add("--fast-limit=55000 | Long Boost TDP = 55w");
                lbPresetValues.Items.Add("--stapm-time=900 | Long Boost Duration = 900s");
                lbPresetValues.Items.Add("--slow-limit=65000 | Short Boost TDP = 65w");
                lbPresetValues.Items.Add("--slow-time=60 | Short Boost Duration = 60s");
                lbPresetValues.Items.Add("--vrmmax-current=85000 | VRM Current (A) = 85");
            }
            else if (cbxPreset.Text == "4600H")
            {
                lbPresetValues.Items.Clear();
                lbPresetValues.Items.Add("--tctl-temp=105 | Temp limit = 105c");
                lbPresetValues.Items.Add("--stapm-limit=50000 | STAPM TDP = 50w");
                lbPresetValues.Items.Add("--fast-limit=60000 | Long Boost TDP = 60w");
                lbPresetValues.Items.Add("--stapm-time=900 | Long Boost Duration = 900s");
                lbPresetValues.Items.Add("--slow-limit=70000 | Short Boost TDP = 70w");
                lbPresetValues.Items.Add("--slow-time=60 | Short Boost Duration = 60s");
                lbPresetValues.Items.Add("--vrmmax-current=85000 | VRM Current (A) = 85");
            }
            else if (cbxPreset.Text == "4800H" || cbxPreset.Text == "4900H")
            {
                lbPresetValues.Items.Clear();
                lbPresetValues.Items.Add("--tctl-temp=105 | Temp limit = 105c");
                lbPresetValues.Items.Add("--stapm-limit=50000 | STAPM TDP = 50w");
                lbPresetValues.Items.Add("--fast-limit=70000 | Long Boost TDP = 70w");
                lbPresetValues.Items.Add("--stapm-time=900 | Long Boost Duration = 900s");
                lbPresetValues.Items.Add("--slow-limit=80000 | Short Boost TDP = 80w");
                lbPresetValues.Items.Add("--slow-time=60 | Short Boost Duration = 60s");
                lbPresetValues.Items.Add("--vrmmax-current=95000 | VRM Current (A) = 95");
            }

            else
            {
                MessageBox.Show("Please use a valid preset from the preset list", "Important Note",
   MessageBoxButtons.OK,
   MessageBoxIcon.Exclamation,
   MessageBoxDefaultButton.Button1);
            }
        }

        private void cbPreset_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPreset.Checked == true)
            {
                gbPreset.Enabled = true;
                cbCustom.Checked = false;
            }

        }


        private void cbCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCustom.Checked == true)
            {
                gbCustom.Enabled = true;
                cbPreset.Checked = false;
            }
        }

        [DllImport("psapi.dll")]
        static extern int EmptyWorkingSet(IntPtr hwProc);

        static void MinimizeFootprint()
        {
            EmptyWorkingSet(Process.GetCurrentProcess().Handle);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MinimizeFootprint();
            Thread.Sleep(1);

            long usedMemory = GC.GetTotalMemory(true);

            if (cbAutoApply.Checked == true)
            {
                if (RyzenADJ == null || RyzenADJ == "")
                {
                    return;
                }
                else
                {
                    direc = Directory.GetCurrentDirectory();
                    direc = direc + "\\bin\\ryzenadj.exe";
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = direc;
                    startInfo.Arguments = RyzenADJ;
                    process.StartInfo = startInfo;
                    process.Start();
                    //MessageBox.Show(RyzenADJ);
                    //MessageBox.Show("Your settings have been applied!", "Settings Applied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/7tY9VYA");
        }



        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            this.WindowState = FormWindowState.Normal;
            TrayIcon.Visible = false;
            this.ShowInTaskbar = true;
        }

        private void Form1_Resize_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                TrayIcon.Visible = true;
                this.ShowInTaskbar = false;
                this.WindowState = FormWindowState.Minimized;

            }
        }

        private void cbApplyLaunch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbApplyLaunch.Checked == true)
            {
                Settings.Default["ApplyLaunch"] = true;

            }
            else
            {
                Settings.Default["ApplyLaunch"] = false;
            }
            Settings.Default.Save();
        }

        private void cbStartWin_CheckedChanged(object sender, EventArgs e)
        {

            
        }
        public string GetShortcutTargetFile(string shortcutFilename)
        {
            string pathOnly = Path.GetDirectoryName(shortcutFilename);
            string filenameOnly = Path.GetFileName(shortcutFilename);

            Shell32.Shell shell = new Shell32.ShellClass();
            Shell32.Folder folder = shell.NameSpace(pathOnly);
            Shell32.FolderItem folderItem = folder.ParseName(filenameOnly);
            if (folderItem != null)
            {
                Shell32.ShellLinkObject link =
                  (Shell32.ShellLinkObject)folderItem.GetLink;
                return link.Path;
            }

            return String.Empty; // Not found
        }

        private void cbxCustomPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            PresetName = cbxCustomPreset.SelectedItem.ToString();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [table] where PresetName='" + PresetName + "'";
            cmd.ExecuteNonQuery();


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                tbxPresetName.Text = dr["PresetName"].ToString();
                tbTemp.Text = dr["TempLimit"].ToString();
                tbSTAPM.Text = dr["TDP"].ToString();
                tbLongDuration.Text = dr["Boost"].ToString();
                tbLongTDP.Text = dr["BoostTDP"].ToString();
                tbShortDuration.Text = dr["Short"].ToString();
                tbShortTDP.Text = dr["ShortTDP"].ToString();
                tbMinMem.Text = dr["MinMem"].ToString();
                tbMaxMem.Text = dr["MaxMem"].ToString();
                tbVRM.Text = dr["VRM"].ToString();
            }
            con.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            temp = Convert.ToInt32(tbTemp.Text);
            STAPM = Convert.ToInt32(tbSTAPM.Text);
            boostDuration = Convert.ToInt32(tbLongDuration.Text);
            boostTDP = Convert.ToInt32(tbLongTDP.Text);
            shortDuration = Convert.ToInt32(tbShortDuration.Text);
            shortTDP = Convert.ToInt32(tbShortTDP.Text);
            fabricMin = Convert.ToInt32(tbMinMem.Text);
            fabricMax = Convert.ToInt32(tbMaxMem.Text);
            VRMMax = Convert.ToInt32(tbVRM.Text);


            cmd.CommandText = "insert into [table] values('" + tbxPresetName.Text + "','" + temp + "','" + STAPM + "','" + boostDuration + "', '" + boostTDP + "', '" + shortDuration + "', '" + shortTDP + "', '" + fabricMin + "', '" + fabricMax + "', '" + VRMMax + "' )";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Preset has been sucessfully created");
            con.Close();
            cc();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (cbxCustomPreset.SelectedItem != null)
            {
                PresetName = cbxCustomPreset.SelectedItem.ToString();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from [table] where PresetName='" + PresetName + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Preset has been sucessfully deleted");
                con.Close();
                cc();


            }
            else
            {

                MessageBox.Show("Please make sure that you select the preset you wish to delete in the custom preset dropdown", "Important Note",
  MessageBoxButtons.OK,
  MessageBoxIcon.Exclamation,
  MessageBoxDefaultButton.Button1);
            }


        }

        private void btnRyzenTest_Click(object sender, EventArgs e)
        {
            bool firstTime = Convert.ToBoolean(Settings.Default["firstTime"]);
            string ryzentest = Directory.GetCurrentDirectory();
            MessageBox.Show("Please be aware you are about to use thrid party software bundled with AATU, any issues with this software has nothing to do with the AATU team", "Important Note",
  MessageBoxButtons.OK,
  MessageBoxIcon.Exclamation,
  MessageBoxDefaultButton.Button1);
            if (firstTime == true)
            {
                MessageBox.Show("You will first go through an installation process in order for Ryzen Test to work, once u have done that press P-State Control onec again to open RyzenTest", "Important Note",
  MessageBoxButtons.OK,
  MessageBoxIcon.Exclamation,
  MessageBoxDefaultButton.Button1);
                ryzentest = ryzentest + "/bin/ryzentest/InstWinRing0.exe";
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = ryzentest;
                process.StartInfo = startInfo;

                process.Start();

                firstTime = false;
                Settings.Default["firstTime"] = firstTime;
                Settings.Default.Save();
            }
            else
            {
                ryzentest = ryzentest + "/bin/ryzentest/RyzenTest0.exe";
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.FileName = ryzentest;
                process.StartInfo = startInfo;

                process.Start();
            }
        }

        private void btnFanControl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please be aware you are about to use thrid party software bundled with AATU, any issues with this software has nothing to do with the AATU team", "Important Note",
  MessageBoxButtons.OK,
  MessageBoxIcon.Exclamation,
  MessageBoxDefaultButton.Button1);
            string nbfc = Directory.GetCurrentDirectory();

            nbfc = nbfc + "/bin/nbfc/NoteBookFanControl.exe";
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = nbfc;
            process.StartInfo = startInfo;

            process.Start();
        }

        private void cbxSeries_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxSeries.Text == "Ryzen 2000 Series U")
            {
                cbxPreset.Enabled = true;
                cbxPreset.Items.Clear();
                cbxPreset.Items.Add("2200U");
                cbxPreset.Items.Add("2300U");
                cbxPreset.Items.Add("2500U");
                cbxPreset.Items.Add("2700U");
            }
            else if (cbxSeries.Text == "Ryzen 3000 Series U")
            {
                cbxPreset.Enabled = true;
                cbxPreset.Items.Clear();
                cbxPreset.Items.Add("3200U");
                cbxPreset.Items.Add("3300U");
                cbxPreset.Items.Add("3500U");
                cbxPreset.Items.Add("3700U");
            }
            else if (cbxSeries.Text == "Ryzen 3000 Series H")
            {
                cbxPreset.Enabled = true;
                cbxPreset.Items.Clear();
                cbxPreset.Items.Add("3550H");
                cbxPreset.Items.Add("3750H");
            }
            else if (cbxSeries.Text == "Ryzen 4000 Series U")
            {
                cbxPreset.Enabled = true;
                cbxPreset.Items.Clear();
                cbxPreset.Items.Add("4500U");
                cbxPreset.Items.Add("4600U");
                cbxPreset.Items.Add("4700U");
                cbxPreset.Items.Add("4800U");
            }
            else if (cbxSeries.Text == "Ryzen 4000 Series HS")
            {
                cbxPreset.Enabled = true;
                cbxPreset.Items.Clear();
                cbxPreset.Items.Add("4600HS");
                cbxPreset.Items.Add("4800HS");
                cbxPreset.Items.Add("4900HS");
            }
            else if (cbxSeries.Text == "Ryzen 4000 Series H")
            {
                cbxPreset.Enabled = true;
                cbxPreset.Items.Clear();
                cbxPreset.Items.Add("4600H");
                cbxPreset.Items.Add("4800H");
                cbxPreset.Items.Add("4900H");
            }
            else
            {
                MessageBox.Show("Please use a valid APU series from the APU series list", "Important Note",
MessageBoxButtons.OK,
MessageBoxIcon.Exclamation,
MessageBoxDefaultButton.Button1);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gitlab.com/JamesCJ/amd-apu-tuning-utility/-/releases");
        }

        private void cbAutoApply_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAutoApply.Checked == true)
            {
                Settings.Default["AutoApply"] = true;
            } else
            {
                Settings.Default["AutoApply"] = false;
            }
            Settings.Default.Save();
        }

        
    }
}