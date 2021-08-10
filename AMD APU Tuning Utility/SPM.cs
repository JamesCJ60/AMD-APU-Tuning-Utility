using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMD_APU_Tuning_Utility
{
    public partial class SPM : UserControl
    {
        public static SPM _instance;
        public static SPM Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SPM();
                return _instance;
            }
        }
        public SPM()
        {
            InitializeComponent();
        }
    }
}
