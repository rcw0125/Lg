using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class wire1 : spc.spclf
    {
        public wire1()
        {
            unit_like = "11%";
            qcitemcode = "Ga";
            qc_des = "1#LF ����ι����";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S41";
            maintype = "wire";
            InitializeComponent();
        }
    }
}
