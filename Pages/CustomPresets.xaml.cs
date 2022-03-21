﻿using AATUV3.Properties;
using AATUV3.Scripts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit;

namespace AATUV3.Pages
{
    /// <summary>
    /// Interaction logic for HomeMenu.xaml
    /// </summary>
    public partial class CustomPresetsMenu : UserControl
    {
        public CustomPresetsMenu()
        {
            InitializeComponent();
            UpdatePresetList();
        }


        private void btnSavePreset_Click(object sender, RoutedEventArgs e)
        {
            string path = Settings.Default["Path"].ToString() + "\\presets\\" + tbxPreset.Text + ".txt";
            string cpuSettings = "";
            string vrmSettings = "";
            string fabricSettings = "";
            string igpuSettings = "";
            string miscSettings = "";

            string finalOutput = "";


            //Get CPU settings
            cpuSettings = $"[CPU Settings]\n{cbTempLimit.IsChecked}\n{nudTempLimit.Value}\n{cbSkinTempLimit.IsChecked}\n{nudSkinTempLimit.Value}\n{cbSTAPMLimit.IsChecked}\n{nudSTAPMLimit.Value}\n{cbPL1.IsChecked}\n{nudPL1.Value}\n{cbPL2.IsChecked}\n{nudPL2.Value}\n{cbPL1_Dur.IsChecked}\n{nudPL1_Dur.Value}\n{cbPL2_Dur.IsChecked}\n{nudPL2_Dur.Value}\n{cbRampTime.IsChecked}\n{nudRampTime.Value}";
            //Get VRM settings
            vrmSettings = $"[VRM Settings]\n{cbVRMCurrent.IsChecked}\n{nudVRMCurrent.Value}\n{cbVRMMaxCurrent.IsChecked}\n{nudVRMMaxCurrent.Value}\n{cbVRMSOC.IsChecked}\n{nudVRMSOC.Value}\n{cbVRMSOCMax.IsChecked}\n{nudVRMSOCMax.Value}\n{cbVRMGFX.IsChecked}\n{nudVRMGFX.Value}\n{cbVRMGFXMax.IsChecked}\n{nudVRMGFXMax.Value}\n{cbVRMCVIP.IsChecked}\n{nudVRMCVIP.Value}";
            //Get Fabric settings
            fabricSettings = $"[Fabric Settings]\n{cbMaxFabric.IsChecked}\n{nudMaxFabric.Value}\n{cbMinFabric.IsChecked}\n{nudMinFabric.Value}";
            //Get iGPU settings
            igpuSettings = $"[iGPU Settings]\n{cbGFXMax.IsChecked}\n{nudGFXMax.Value}\n{cbGFXMin.IsChecked}\n{nudGFXMin.Value}\n{cbSoCMax.IsChecked}\n{nudSoCMax.Value}\n{cbSoCMin.IsChecked}\n{nudSoCMin.Value}\n{cbVCNMax.IsChecked}\n{nudVCNMax.Value}\n{cbVCNMin.IsChecked}\n{nudVCNMin.Value}";
            //Misc settings
            miscSettings = $"[Miscellaneous Settings]\n{cddGPUSkin.IsChecked}\n{nuddGPUSkin.Value}\n{cdiGPUClock.IsChecked}\n{nudiGPUClock.Value}\n{cdBoostDelay.IsChecked}\n{cmbBoostDelay.SelectedValue.ToString()}";

            finalOutput = cpuSettings + "\n\n" + vrmSettings + "\n\n"+ fabricSettings + "\n\n" + igpuSettings + "\n\n" + miscSettings;
            if (!File.Exists(path))
            {
                Backend.ApplySettings("\\bin\\Notification.exe", "1 Preset-Saved! Preset-has-been-saved-successfully-to-the-preset-folder.", false);
                File.WriteAllText(path, finalOutput);
            }
            else
            {
                Backend.ApplySettings("\\bin\\Notification.exe", "1 Error! Preset-under-entered-name-already-exists.", false);
            }

            UpdatePresetList();
        }

        public void UpdatePresetList()
        {
            string path = Settings.Default["Path"].ToString()+"\\presets";
            DirectoryInfo dinfo = new DirectoryInfo(path);
            FileInfo[] Files = dinfo.GetFiles("*.txt");

            cmbPresets.Items.Clear();
            foreach (FileInfo file in Files)
            {
                cmbPresets.Items.Add(file.Name.Substring(0, file.Name.Length-4));
            }
        }

        private void cmbPresets_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                string path = Settings.Default["Path"].ToString()+"\\presets";
                var lines = File.ReadAllLines(path + "\\" + cmbPresets.SelectedItem.ToString() + ".txt");

                cbTempLimit.IsChecked = Convert.ToBoolean(lines[1]);
                nudTempLimit.Value = Convert.ToInt32(lines[2]);

                cbSkinTempLimit.IsChecked = Convert.ToBoolean(lines[3]);
                nudSkinTempLimit.Value = Convert.ToInt32(lines[4]);

                cbSTAPMLimit.IsChecked = Convert.ToBoolean(lines[5]);
                nudSTAPMLimit.Value = Convert.ToInt32(lines[6]);

                cbPL1.IsChecked = Convert.ToBoolean(lines[7]);
                nudPL1.Value = Convert.ToInt32(lines[8]);

                cbPL2.IsChecked = Convert.ToBoolean(lines[9]);
                nudPL2.Value = Convert.ToInt32(lines[10]);

                cbPL1_Dur.IsChecked = Convert.ToBoolean(lines[11]);
                nudPL1_Dur.Value = Convert.ToInt32(lines[12]);

                cbPL2_Dur.IsChecked= Convert.ToBoolean(lines[13]);
                nudPL2_Dur.Value = Convert.ToInt32(lines[14]);

                cbRampTime.IsChecked = Convert.ToBoolean(lines[15]);
                nudRampTime.Value = Convert.ToInt32(lines[16]);

                cbVRMCurrent.IsChecked = Convert.ToBoolean(lines[19]);
                nudVRMCurrent.Value = Convert.ToInt32(lines[20]);

                cbVRMMaxCurrent.IsChecked = Convert.ToBoolean(lines[21]);
                nudVRMMaxCurrent.Value = Convert.ToInt32(lines[22]);

                cbVRMSOC.IsChecked = Convert.ToBoolean(lines[23]);
                nudVRMSOC.Value = Convert.ToInt32(lines[24]);

                cbVRMSOCMax.IsChecked = Convert.ToBoolean(lines[25]);
                nudVRMSOCMax.Value = Convert.ToInt32(lines[26]);

                cbVRMGFX.IsChecked = Convert.ToBoolean(lines[27]);
                nudVRMGFX.Value = Convert.ToInt32(lines[28]);

                cbVRMGFXMax.IsChecked = Convert.ToBoolean(lines[29]);
                nudVRMGFXMax.Value = Convert.ToInt32(lines[30]);

                cbVRMCVIP.IsChecked = Convert.ToBoolean(lines[31]);
                nudVRMCVIP.Value = Convert.ToInt32(lines[32]);

                cbMaxFabric.IsChecked = Convert.ToBoolean(lines[35]);
                nudMaxFabric.Value = Convert.ToInt32(lines[36]);

                cbMinFabric.IsChecked = Convert.ToBoolean(lines[37]);
                nudMinFabric.Value = Convert.ToInt32(lines[38]);

                cbGFXMax.IsChecked = Convert.ToBoolean(lines[41]);
                nudGFXMax.Value = Convert.ToInt32(lines[42]);

                cbGFXMin.IsChecked = Convert.ToBoolean(lines[43]);
                nudGFXMin.Value = Convert.ToInt32(lines[44]);

                cbSoCMax.IsChecked = Convert.ToBoolean(lines[45]);
                nudSoCMax.Value = Convert.ToInt32(lines[46]);

                cbSoCMin.IsChecked = Convert.ToBoolean(lines[47]);
                nudSoCMin.Value = Convert.ToInt32(lines[48]);

                cbVCNMax.IsChecked = Convert.ToBoolean(lines[49]);
                nudVCNMax.Value = Convert.ToInt32(lines[50]);

                cbVCNMin.IsChecked = Convert.ToBoolean(lines[51]);
                nudVCNMin.Value = Convert.ToInt32(lines[52]);

                cddGPUSkin.IsChecked = Convert.ToBoolean(lines[55]);
                nuddGPUSkin.Value = Convert.ToInt32(lines[56]);

                cdiGPUClock.IsChecked = Convert.ToBoolean(lines[57]);
                nudiGPUClock.Value = Convert.ToInt32(lines[58]);

                cdBoostDelay.IsChecked = Convert.ToBoolean(lines[59]);
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.ToString());
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            string path = Settings.Default["Path"].ToString()+"\\presets";
            path = path + "\\" + cmbPresets.SelectedItem.ToString() + ".txt";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            UpdatePresetList();
        }

        private void Apply_Click(object sender, RoutedEventArgs e)
        {
            string ryzenadj = "";
            ryzenadj = null;

            if (cbTempLimit.IsChecked == true)
            {
                ryzenadj = ryzenadj + $"--tctl-temp={nudTempLimit.Value} ";
            }

            if (cbSkinTempLimit.IsChecked == true)
            {
                ryzenadj = ryzenadj + $"--apu-skin-temp={nudSkinTempLimit.Value} ";
            }

            if (cbSTAPMLimit.IsChecked == true)
            {
                ryzenadj = ryzenadj + $"--stapm-limit={nudSTAPMLimit.Value * 1000} ";
            }

            if (cbPL1.IsChecked == true)
            {
                ryzenadj = ryzenadj + $"--slow-limit={nudPL1.Value * 1000} ";
            }

            if (cbPL2.IsChecked == true)
            {
                ryzenadj = ryzenadj + $"--fast-limit={nudPL2.Value * 1000} ";
            }

            if (cbPL1_Dur.IsChecked == true)
            {
                ryzenadj = ryzenadj + $"--slow-time={nudPL1_Dur.Value} ";
            }

            if (cbPL2_Dur.IsChecked == true)
            {
                ryzenadj = ryzenadj + $"--stapm-time={nudPL2_Dur.Value} ";
            }

            if (cbRampTime.IsChecked == true)
            {
                ryzenadj = ryzenadj + $"--prochot-deassertion-ramp={nudRampTime.Value} ";
            }

            if (cbVRMCurrent.IsChecked == true)
            {
                ryzenadj = ryzenadj + $"--vrm-current={nudVRMCurrent.Value * 1000} ";
            }

            if (cbVRMMaxCurrent.IsChecked == true)
            {
                ryzenadj = ryzenadj + $"--vrmmax-current={nudVRMMaxCurrent.Value * 1000} ";
            }

            if (cbVRMSOC.IsChecked == true)
            {
                ryzenadj = ryzenadj + $"--vrmsoc-current={nudVRMSOC.Value * 1000} ";
            }

            if (cbVRMSOCMax.IsChecked == true)
            {
                ryzenadj = ryzenadj + $"--vrmsocmax-current={nudVRMSOCMax.Value * 1000} ";
            }

            if (cbVRMGFX.IsChecked == true)
            {
                ryzenadj = ryzenadj + $"--vrmgfx-current={nudVRMGFX.Value * 1000} ";
            }

            if (cbVRMGFXMax.IsChecked == true)
            {
                ryzenadj = ryzenadj + $"--vrmgfxmax-current={nudVRMGFXMax.Value * 1000} ";
            }

            if (cbVRMCVIP.IsChecked == true)
            {
                ryzenadj = ryzenadj + $"--vrmcvip-current={nudVRMCVIP.Value * 1000} ";
            }

            if (cbMaxFabric.IsChecked == true)
            {
                ryzenadj = ryzenadj + $"--max-fclk-frequency={nudMaxFabric.Value} ";
            }

            if (cbMinFabric.IsChecked == true)
            {
                ryzenadj = ryzenadj + $"--min-fclk-frequency={nudMinFabric.Value} ";
            }

            if (cbGFXMax.IsChecked == true)
            {
                ryzenadj = ryzenadj + $"--max-gfxclk={nudGFXMax.Value} ";
            }

            if (cbGFXMin.IsChecked == true)
            {
                ryzenadj = ryzenadj + $"--min-gfxclk={nudGFXMin.Value} ";
            }


            if (cbSoCMax.IsChecked == true)
            {
                ryzenadj = ryzenadj + $"--max-lclk={nudSoCMax.Value} ";
            }

            if (cbSoCMin.IsChecked == true)
            {
                ryzenadj = ryzenadj + $"--min-lclk={nudSoCMin.Value} ";
            }


            if (cbVCNMax.IsChecked == true)
            {
                ryzenadj = ryzenadj + $"--max-vcn={nudVCNMax.Value} ";
            }

            if (cbVCNMin.IsChecked == true)
            {
                ryzenadj = ryzenadj + $"--min-vcn={nudVCNMin.Value} ";
            }

            if (cddGPUSkin.IsChecked == true)
            {
                ryzenadj = ryzenadj + $"--dgpu-skin-temp={nuddGPUSkin.Value} ";
            }

            if (cdiGPUClock.IsChecked == true)
            {
                ryzenadj = ryzenadj + $"--gfx-clk={nudiGPUClock.Value} ";
            }

            try
            {


                if (ryzenadj == null || ryzenadj == "")
                {
                    Backend.ApplySettings("\\bin\\Notification.exe", "1 Error! There-are-no-settings-to-apply!", false);
                }

                else
                {
                    //Get RyzenAdj path
                    string path = "\\bin\\ryzenadj\\ryzenadj.exe";
                    //Pass settings on to be applied
                    Backend.ApplySettings(path, ryzenadj, true);
                    Backend.ApplySettings("\\bin\\Notification.exe", "1 Settings-Applied! Your-settings-have-been-applied-successfully.", false);
                    Settings.Default["RyzenAdjArguments"] = ryzenadj;
                    Settings.Default.Save();
                    System.Windows.MessageBox.Show(ryzenadj);
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.ToString());
            }
        }
    }
}
