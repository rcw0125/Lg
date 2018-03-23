using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace QualityMag.QualityStandard
{
    public partial class StdInCtrEleShowFrm : Form
    {
        public StdInCtrEleShowFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx( int nPosition, string strSort, ref AppSvrHMI.L3DataSet dsData)
        {
            bsStdInCtrEle.DataSource = null;
            bsStdInCtrEle.DataSource = dsData;
            bsStdInCtrEle.DataMember = dsData.Tables[0].TableName;

            ((System.Data.DataRowView)(bsStdInCtrEle.Current)).DataView.Sort = strSort;
            bsStdInCtrEle.Position = nPosition;

            return ShowDialog();
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsStdInCtrEle.EndEdit();
            this.Close();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsStdInCtrEle.CancelEdit();
            this.Close();
        }
        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void StdInCtrEleShowFrm_Load(object sender, EventArgs e)
        {
            
            foreach (Control c in tpElement.Controls)
            {
                if (c is PxDataValid.PxTextBox)
                {
                    c.TextChanged += new EventHandler(pxControls_TextChanged);
                }
            }
        }

       
    }
}