﻿using AATUV3.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AATUV3.Scripts
{
    public class Backend
    {
        /// <summary>
        /// Open third party program within folder/sub-folders
        /// </summary>
        /// <param name="program">Program executable</param>
        /// <param name="input">Program arguments</param>
        /// <param name="isHidden">Is program intended to be hidden when opened</param>
        public static void ApplySettings(string program, string input, bool isHidden)
        {
            try
            {
                //Get current path and join it with program executable
                string path = (string)Settings.Default["Path"] + program;
                //Create new process
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                //Hide program if required
                if (isHidden == true)
                {
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                }
                //Pass on path and arguments
                startInfo.FileName = path;
                startInfo.Arguments = input;
                process.StartInfo = startInfo;
                //Start program
                process.Start();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.ToString());
            }
        }


        [DllImport("psapi.dll")]
        static extern int EmptyWorkingSet(IntPtr hwProc);
        public static void Garbage_Collect()
        {
            long usedMemory = GC.GetTotalMemory(true);
            EmptyWorkingSet(Process.GetCurrentProcess().Handle);
        }
    }
}
