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

namespace AMD_APU_Tuning_Utility
{
    public partial class CustomPresets : UserControl
    {
        public static CustomPresets _instance;
        public static CustomPresets Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CustomPresets();
                return _instance;
            }
        }
        public CustomPresets()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        bool useGPUSettings = (bool)Settings.Default["useGPUSettings"];
        bool useDefaultTheme = (bool)Settings.Default["useDefaultTheme"];
        bool SkinTemp = (bool)Settings.Default["SkinTemp"];
        bool connection = (bool)Settings.Default["Internet"];

        string RyzenADJ;
        string series = (string)Settings.Default["Series"];
        string path;
        string path2;
        string path3;



        int topBar1 = 0;
        int topBar2 = 180;
        int topBar3 = 166;

        int sideBar1 = 0;
        int sideBar2 = 110;
        int sideBar3 = 106;

        int TempLimit;
        int SkinTempC;
        int CPUTDP;
        int LongBoostTDP;
        int LongBoostDuration;
        int ShortBoostTDP;
        int ShortBoostDuration;
        int VRM;
        int VRMMax;
        int MemMax;
        int MemMin;
        int GPUMax;
        int GPUMin;
        int SoCMax;
        int SoCMin;
        int VCNMax;
        int VCNMin;


        private void CustomPresets_Load(object sender, EventArgs e)
        {




            path = (string)Settings.Default["Path"];
            path3 = (string)Settings.Default["Path"];

            path3 = path3 + "\\presets";

            if (path3.Contains("bin"))
            {
                path3 = (string)Settings.Default["Path"];
                path3 = path3 + "\\presets";
            }

            DirectoryInfo dinfo = new DirectoryInfo(path3);
            FileInfo[] Files = dinfo.GetFiles("*.txt");
            foreach(FileInfo file in Files)
            {
                cbPreset.Items.Add(file.Name.Substring(0, file.Name.Length-4));
            }

            this.updateTheme();
            
            nudTemp.Value = (int)Settings.Default["TempLimit"];
            nudSkin.Value = (int)Settings.Default["SkinTempC"];
            nudTDP.Value = (int)Settings.Default["CPUTDP"];
            nudLongTDP.Value = (int)Settings.Default["LongBoostTDP"];
            nudLongBoostDuration.Value = (int)Settings.Default["LongBoostDuration"];
            nudShortBoostTDP.Value = (int)Settings.Default["ShortBoostTDP"];
            nudShortBoostDuration.Value = (int)Settings.Default["ShortBoostDuration"];

            nudVRM.Value = (int)Settings.Default["VRM"];
            nudVRMMax.Value = (int)Settings.Default["VRMMax"];

            nudMemMax.Value = (int)Settings.Default["MemMax"];
            nudMemMin.Value = (int)Settings.Default["MemMin"];

            nudGPUMax.Value = (int)Settings.Default["GPUMax"];
            nudGPUMin.Value = (int)Settings.Default["GPUMin"];
            nudSoCMax.Value = (int)Settings.Default["SoCMax"];
            nudSoCMin.Value = (int)Settings.Default["SoCMin"];
            nudVCNMax.Value = (int)Settings.Default["VCNMax"];
            nudVCNMin.Value = (int)Settings.Default["VCNMin"];

            cb1.Checked = (bool)Settings.Default["cb1"];
            cb1h.Checked = (bool)Settings.Default["cb1h"];
            cb2.Checked = (bool)Settings.Default["cb2"];
            cb3.Checked = (bool)Settings.Default["cb3"];
            cb4.Checked = (bool)Settings.Default["cb4"];
            cb5.Checked = (bool)Settings.Default["cb5"];
            cb6.Checked = (bool)Settings.Default["cb6"];
            cb7.Checked = (bool)Settings.Default["cb7"];
            cb8.Checked = (bool)Settings.Default["cb8"];
            cb9.Checked = (bool)Settings.Default["cb9"];
            cb10.Checked = (bool)Settings.Default["cb10"];
            cb11.Checked = (bool)Settings.Default["cb11"];
            cb12.Checked = (bool)Settings.Default["cb12"];
            cb13.Checked = (bool)Settings.Default["cb13"];
            cb14.Checked = (bool)Settings.Default["cb14"];
            cb15.Checked = (bool)Settings.Default["cb15"];
            cb16.Checked = (bool)Settings.Default["cb16"];
            cbPower.Checked = (bool)Settings.Default["power"];
            cbPerf.Checked = (bool)Settings.Default["perf"];

            this.getSettings();
        }

        private void Theme_Tick(object sender, EventArgs e)
        {
            connection = (bool)Settings.Default["Internet"];
            this.updateTheme();

            bool import = (bool)Settings.Default["Import"];
            SkinTemp = (bool)Settings.Default["SkinTemp"];
            if (import == true)
            {
                nudTemp.Value = (int)Settings.Default["TempLimit"];
                nudSkin.Value = (int)Settings.Default["SkinTempC"];
                nudTDP.Value = (int)Settings.Default["CPUTDP"];
                nudLongTDP.Value = (int)Settings.Default["LongBoostTDP"];
                nudLongBoostDuration.Value = (int)Settings.Default["LongBoostDuration"];
                nudShortBoostTDP.Value = (int)Settings.Default["ShortBoostTDP"];
                nudShortBoostDuration.Value = (int)Settings.Default["ShortBoostDuration"];

                nudVRM.Value = (int)Settings.Default["VRM"];
                nudVRMMax.Value = (int)Settings.Default["VRMMax"];

                nudMemMax.Value = (int)Settings.Default["MemMax"];
                nudMemMin.Value = (int)Settings.Default["MemMin"];

                nudGPUMax.Value = (int)Settings.Default["GPUMax"];
                nudGPUMin.Value = (int)Settings.Default["GPUMin"];
                nudSoCMax.Value = (int)Settings.Default["SoCMax"];
                nudSoCMin.Value = (int)Settings.Default["SoCMin"];
                nudVCNMax.Value = (int)Settings.Default["VCNMax"];
                nudVCNMin.Value = (int)Settings.Default["VCNMin"];

                Settings.Default["Import"] = false;
                Settings.Default.Save();
            }





        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            this.getSettings();
            this.applySettings();
        }

        private void AutoReapply_Tick(object sender, EventArgs e)
        {
            bool auto = (bool)Settings.Default["AutoApply"];

            if (auto == true)
            {
                if (RyzenADJ == "" || RyzenADJ == null)
                {
                    return;
                }
                else
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = path;
                    startInfo.Arguments = RyzenADJ;
                    process.StartInfo = startInfo;
                    process.Start();
                    
                }
            }
        }

        private void btnUpdateADJ_Click(object sender, EventArgs e)
        {
            this.getSettings();
        }

        private void getSettings()
        {
            RyzenADJ = "";

            if (cb1.Checked == true)
            {
                TempLimit = Convert.ToInt32(nudTemp.Value);
                RyzenADJ = RyzenADJ + "--tctl-temp=" + TempLimit + " ";
                Settings.Default["TempLimit"] = TempLimit;
            }
            if(cb1h.Checked == true)
            {
                SkinTempC = Convert.ToInt32(nudSkin.Value);
                RyzenADJ = RyzenADJ + "--apu-skin-temp=" + SkinTempC + " ";
                Settings.Default["SkinTempC"] = SkinTempC;
            }
            if (cb2.Checked == true)
            {
                CPUTDP = Convert.ToInt32(nudTDP.Value);
                RyzenADJ = RyzenADJ + "--stapm-limit=" + CPUTDP * 1000 + " ";
                Settings.Default["CPUTDP"] = CPUTDP;
            }
            if (cb3.Checked == true)
            {
                LongBoostTDP = Convert.ToInt32(nudLongTDP.Value);
                RyzenADJ = RyzenADJ + "--fast-limit=" + LongBoostTDP * 1000 + " ";
                Settings.Default["LongBoostTDP"] = LongBoostTDP;
            }
            if (cb4.Checked == true)
            {
                LongBoostDuration = Convert.ToInt32(nudLongBoostDuration.Value);
                RyzenADJ = RyzenADJ + "--stapm-time=" + LongBoostDuration + " ";
                Settings.Default["LongBoostDuration"] = LongBoostDuration;
            }
            if (cb5.Checked == true)
            {
                ShortBoostTDP = Convert.ToInt32(nudShortBoostTDP.Value);
                RyzenADJ = RyzenADJ + "--slow-limit=" + ShortBoostTDP * 1000 + " ";
                Settings.Default["ShortBoostTDP"] = ShortBoostTDP;
            }
            if (cb6.Checked == true)
            {
                ShortBoostDuration = Convert.ToInt32(nudShortBoostDuration.Value);
                RyzenADJ = RyzenADJ + "--slow-time=" + ShortBoostDuration + " ";
                Settings.Default["ShortBoostDuration"] = ShortBoostDuration;
            }
            if (cb7.Checked == true)
            {
                VRM = Convert.ToInt32(nudVRM.Value);
                RyzenADJ = RyzenADJ + "--vrm-current=" + VRM * 1000 + " ";
                Settings.Default["VRM"] = VRM;
            }
            if (cb8.Checked == true)
            {
                VRMMax = Convert.ToInt32(nudVRMMax.Value);
                RyzenADJ = RyzenADJ + "--vrmmax-current=" + VRMMax * 1000 + " ";
                Settings.Default["VRMMax"] = VRMMax;
            }
            if (cb9.Checked == true)
            {
                MemMax = Convert.ToInt32(nudMemMax.Value);
                RyzenADJ = RyzenADJ + "--max-fclk-frequency=" + MemMax + " ";
                Settings.Default["MemMax"] = MemMax;
            }
            if (cb10.Checked == true)
            {
                MemMin = Convert.ToInt32(nudMemMin.Value);
                RyzenADJ = RyzenADJ + "--min-fclk-frequency=" + MemMin + " ";
                Settings.Default["MemMin"] = MemMin;
            }
            if (cb11.Checked == true)
            {
                GPUMax = Convert.ToInt32(nudGPUMax.Value);
                RyzenADJ = RyzenADJ + "--max-gfxclk=" + GPUMax + " ";
                Settings.Default["GPUMax"] = GPUMax;
            }
            if (cb12.Checked == true)
            {
                GPUMin = Convert.ToInt32(nudGPUMin.Value);
                RyzenADJ = RyzenADJ + "--min-gfxclk=" + GPUMin + " ";
                Settings.Default["GPUMin"] = GPUMin;
            }
            if (cb13.Checked == true)
            {
                SoCMax = Convert.ToInt32(nudSoCMax.Value);
                RyzenADJ = RyzenADJ + "--max-socclk-frequency=" + SoCMax + " ";
                Settings.Default["SoCMax"] = SoCMax;
            }
            if (cb14.Checked == true)
            {
                SoCMin = Convert.ToInt32(nudSoCMin.Value);
                RyzenADJ = RyzenADJ + "--min-socclk-frequency=" + SoCMin + " ";
                Settings.Default["SoCMin"] = SoCMin;
            }
            if (cb15.Checked == true)
            {
                VCNMax = Convert.ToInt32(nudVCNMax.Value);
                RyzenADJ = RyzenADJ + "--max-vcn=" + VCNMax + " ";
                Settings.Default["VCNMax"] = VCNMax;
            }
            if (cb16.Checked == true)
            {
                VCNMin = Convert.ToInt32(nudVCNMin.Value);
                RyzenADJ = RyzenADJ + "--min-vcn=" + VCNMin + " ";
                Settings.Default["VCNMin"] = VCNMin;
            }
            if(cbPerf.Checked == true)
            {
                RyzenADJ = RyzenADJ + "--max-performance" + " ";
            }
            if (cbPower.Checked == true)
            {
                RyzenADJ = RyzenADJ + "--power-saving" + " ";
            }
            Settings.Default["RyzenADJ"] = RyzenADJ;
            Settings.Default.Save();

            txtRyzenADJ.Clear();
            txtRyzenADJ.Text = RyzenADJ;
        }

        private void applySettings()
        {
            path = (string)Settings.Default["Path"];
            path2 = (string)Settings.Default["Path"];
            path = path + "\\bin\\ryzenadj.exe";

            path2 = path2 + "\\bin\\Notification.exe";

            if (RyzenADJ == "" || RyzenADJ == null)
            {
                

                if(connection == true)
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = path2;
                    startInfo.Arguments = "https://media.discordapp.net/attachments/711708420281204768/813512272935780412/AATU-LOGO.png?width=697&height=676 Error! There-are-no-settings-to-apply!-Please-enter-some-settings";
                    process.StartInfo = startInfo;
                    process.Start();
                }
                else
                {
                    MessageBox.Show( "There are no settings to apply! Please enter some settings", "Error!");
                }
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
                }
                catch{
                    if (connection == true)
                    {
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = path2;
                        startInfo.Arguments = "https://media.discordapp.net/attachments/711708420281204768/813512272935780412/AATU-LOGO.png?width=697&height=676 Error! Something-went-wrong-when-applying-your-settings-:(";
                        process.StartInfo = startInfo;
                        process.Start();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong when applying your settings :(", "Error!");
                    }
                }
            }

            Settings.Default["cb1"] = cb1.Checked;
            Settings.Default["cb1h"] = cb1h.Checked;
            Settings.Default["cb2"] = cb2.Checked;
            Settings.Default["cb3"] = cb3.Checked;
            Settings.Default["cb4"] = cb4.Checked;
            Settings.Default["cb5"] = cb5.Checked;
            Settings.Default["cb6"] = cb6.Checked;
            Settings.Default["cb7"] = cb7.Checked;
            Settings.Default["cb8"] = cb8.Checked;
            Settings.Default["cb9"] = cb9.Checked;
            Settings.Default["cb10"] = cb10.Checked;
            Settings.Default["cb11"] = cb11.Checked;
            Settings.Default["cb12"] = cb12.Checked;
            Settings.Default["cb13"] = cb13.Checked;
            Settings.Default["cb14"] = cb14.Checked;
            Settings.Default["cb15"] = cb15.Checked;
            Settings.Default["cb16"] = cb16.Checked;
            Settings.Default["perf"] = cbPerf.Checked;
            Settings.Default["power"] = cbPower.Checked;
            Settings.Default.Save();
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

            if (!useGPUSettings)
            {
                lblGPU.Visible = false;
                lbl1.Visible = false;
                lbl2.Visible = false;
                lbl3.Visible = false;
                lbl4.Visible = false;
                lbl5.Visible = false;
                lbl6.Visible = false;

                cb11.Visible = false;
                cb12.Visible = false;
                cb13.Visible = false;
                cb14.Visible = false;
                cb15.Visible = false;
                cb16.Visible = false;

                nudGPUMax.Visible = false;
                nudGPUMin.Visible = false;
                nudSoCMax.Visible = false;
                nudSoCMin.Visible = false;
                nudVCNMax.Visible = false;
                nudVCNMin.Visible = false;
            }
            else
            {
                lblGPU.Visible = true;
                lbl1.Visible = true;
                lbl2.Visible = true;
                lbl3.Visible = true;
                lbl4.Visible = true;
                lbl5.Visible = true;
                lbl6.Visible = true;

                cb11.Visible = true;
                cb12.Visible = true;
                cb13.Visible = true;
                cb14.Visible = true;
                cb15.Visible = true;
                cb16.Visible = true;

                nudGPUMax.Visible = true;
                nudGPUMin.Visible = true;
                nudSoCMax.Visible = true;
                nudSoCMin.Visible = true;
                nudVCNMax.Visible = true;
                nudVCNMin.Visible = true;
            }


            btnApply.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnSave.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnDelete.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnSensors.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnUpdateADJ.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);


        }

        private void cbPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPreset.Text == "" || cbPreset.Text == null)
            {
                if (connection == true)
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = path2;
                    startInfo.Arguments = "https://media.discordapp.net/attachments/711708420281204768/813512272935780412/AATU-LOGO.png?width=697&height=676 Error! Please-select-a-valid-preset";
                    process.StartInfo = startInfo;
                    process.Start();
                }
                else
                {
                    MessageBox.Show("Please select a valid preset", "Error!");
                }
            }
            else
            {
                txtPresetName.Text = cbPreset.Text;

                var lines = File.ReadAllLines(path3 + "\\" + cbPreset.Text + ".txt");

                nudTemp.Value = Convert.ToInt32(lines[0]);
                nudSkin.Value = Convert.ToInt32(lines[1]);
                nudTDP.Value = Convert.ToInt32(lines[2]);
                nudLongTDP.Value = Convert.ToInt32(lines[3]);
                nudLongBoostDuration.Value = Convert.ToInt32(lines[4]);
                nudShortBoostTDP.Value = Convert.ToInt32(lines[5]);
                nudShortBoostDuration.Value = Convert.ToInt32(lines[6]);
                nudVRM.Value = Convert.ToInt32(lines[7]);
                nudVRMMax.Value = Convert.ToInt32(lines[8]);
                nudMemMax.Value = Convert.ToInt32(lines[9]);
                nudMemMin.Value = Convert.ToInt32(lines[10]);
                nudGPUMax.Value = Convert.ToInt32(lines[11]);
                nudGPUMin.Value = Convert.ToInt32(lines[12]);
                nudSoCMax.Value = Convert.ToInt32(lines[13]);
                nudSoCMin.Value = Convert.ToInt32(lines[14]);
                nudVCNMax.Value = Convert.ToInt32(lines[15]);
                nudVCNMin.Value = Convert.ToInt32(lines[16]);
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            path2 = (string)Settings.Default["Path"];
            path2 = path2 + "\\bin\\Notification.exe";
            if(cbPreset.Text == null || cbPreset.Text == "")
            {
                if (connection == true)
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = path2;
                    startInfo.Arguments = "https://media.discordapp.net/attachments/711708420281204768/813512272935780412/AATU-LOGO.png?width=697&height=676 Error! Please-select-a-valid-preset";
                    process.StartInfo = startInfo;
                    process.Start();
                }
                else
                {
                    MessageBox.Show( "Please select a valid preset", "Error!");
                }
            }
            else if (File.Exists(path3 + "\\" + cbPreset.Text + ".txt")){
                File.Delete(path3 + "\\" + cbPreset.Text + ".txt");

                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = path2;
                startInfo.Arguments = "https://media.discordapp.net/attachments/711708420281204768/813512272935780412/AATU-LOGO.png?width=697&height=676 Deleted-Preset Your-preset-has-been-deleted-successfully";
                process.StartInfo = startInfo;
                process.Start();
            }

            DirectoryInfo dinfo = new DirectoryInfo(path3);
            FileInfo[] Files = dinfo.GetFiles("*.txt");
            cbPreset.Items.Clear();
            foreach (FileInfo file in Files)
            {
                cbPreset.Items.Add(file.Name.Substring(0, file.Name.Length - 4));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            path2 = (string)Settings.Default["Path"];
            path2 = path2 + "\\bin\\Notification.exe";
            int i = 0;

            if (txtPresetName.Text == null || txtPresetName.Text == "")
            {
                if (connection == true)
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = path2;
                    startInfo.Arguments = "https://media.discordapp.net/attachments/711708420281204768/813512272935780412/AATU-LOGO.png?width=697&height=676 Error! Please-give-your-preset-a-name";
                    process.StartInfo = startInfo;
                    process.Start();
                }
                else
                {
                    MessageBox.Show("Please give your preset a name", "Error!");
                }

                return;
            } 
            else
            {
                

                string[] lines = new string[17];
                do
                {
                    lines[i] = "";
                    i++;
                }
                while (i < 17);

                if (File.Exists(path3 + "\\" + txtPresetName.Text + ".txt"))
                {
                    if (connection == true)
                    {
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = path2;
                        startInfo.Arguments = "https://media.discordapp.net/attachments/711708420281204768/813512272935780412/AATU-LOGO.png?width=697&height=676 Error! Preset-already-exists-:(";
                        process.StartInfo = startInfo;
                        process.Start();
                    }
                    else
                    {
                        MessageBox.Show("Preset already exists :(", "Error!");
                    }
                }
                else
                {
                    lines[0] = nudTemp.Value.ToString();
                    lines[1] = nudSkin.Value.ToString();
                    lines[2] = nudTDP.Value.ToString();
                    lines[3] = nudLongTDP.Value.ToString();
                    lines[4] = nudLongBoostDuration.Value.ToString();
                    lines[5] = nudShortBoostTDP.Value.ToString();
                    lines[6] = nudShortBoostDuration.Value.ToString();
                    lines[7] = nudVRM.Value.ToString();
                    lines[8] = nudVRMMax.Value.ToString();
                    lines[9] = nudMemMax.Value.ToString();
                    lines[10] = nudMemMin.Value.ToString();
                    lines[11] = nudGPUMax.Value.ToString();
                    lines[12] = nudGPUMin.Value.ToString();
                    lines[13] = nudSoCMax.Value.ToString();
                    lines[14] = nudSoCMin.Value.ToString();
                    lines[15] = nudVCNMax.Value.ToString();
                    lines[16] = nudVCNMin.Value.ToString();
                    using (StreamWriter sw = new StreamWriter(path3 + "\\" + txtPresetName.Text + ".txt", true))
                    {

                        foreach (string line in lines)
                        {
                            sw.WriteLine(line);
                        }
                    }

                    if (connection == true)
                    {
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = path2;
                        startInfo.Arguments = "https://media.discordapp.net/attachments/711708420281204768/813512272935780412/AATU-LOGO.png?width=697&height=676 Saved-Preset Your-preset-has-been-saved-successfully";
                        process.StartInfo = startInfo;
                        process.Start();
                    }
                    else
                    {
                        MessageBox.Show("Your preset has been saved successfully", "Saved Preset");
                    }
                    DirectoryInfo dinfo2 = new DirectoryInfo(path3);
                    FileInfo[] Files2 = dinfo2.GetFiles("*.txt");
                    cbPreset.Items.Clear();
                    foreach (FileInfo file in Files2)
                    {
                        cbPreset.Items.Add(file.Name.Substring(0, file.Name.Length - 4));
                    }
                }
            
            }
        }

        private void btnSensors_Click(object sender, EventArgs e)
        {
            string path4 = (string)Settings.Default["Path"];
            path4 = path4 + "\\bin\\HWiNFO64.exe";
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = path4;
            
            process.StartInfo = startInfo;
            process.Start();
        }

        private void cbPerf_CheckedChanged(object sender, EventArgs e)
        {
            cbPower.Checked = false;
        }

        private void cbPower_CheckedChanged(object sender, EventArgs e)
        {
            cbPerf.Checked = false;
        }
    }
}

