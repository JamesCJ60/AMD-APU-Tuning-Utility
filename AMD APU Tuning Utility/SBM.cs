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
    public partial class SBM : UserControl
    {
        public static SBM _instance;
        public static SBM Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SBM();
                return _instance;
            }
        }
        public SBM()
        {
            InitializeComponent();
        }
    }
}
