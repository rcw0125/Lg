using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.MoldMag
{
    public partial class MoldBoardInstallMagShowFrm : Form
    {
        public MoldBoardInstallMagShowFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session, string strSort, int iPosition, ref AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;
            bsInstall.DataSource = null;
            bsInstall.DataSource = dsData;
            bsInstall.DataMember = dsData.Tables[0].TableName;

            ((System.Data.DataRowView)(bsInstall.Current)).DataView.Sort = strSort;
            bsInstall.Position = iPosition;

            return ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsInstall.EndEdit();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsInstall.CancelEdit();
            this.Close();
        }

        private void txtCopperID_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void MoldBoardInstallMagShowFrm_Load(object sender, EventArgs e)
        {
            //cmbMoldID.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtCopperLugSteelMea.TextChanged += new EventHandler(pxControls_TextChanged);
            //rtxtNote.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtWideUpTwoFir.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtWideUpTwoSec.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtWideUpTwoThi.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtWideUpThreeFir.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtWideUpThreeSec.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtWideUpThreeThi.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtWideDownEightFir.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtWideDownEightSec.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtWideDownEightThi.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtNarUpTwoFir.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtNarUpTwoSec.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtNarUpTwoThi.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtNarUpThreeFir.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtNarUpThreeSec.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtNarUpThreeThi.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtNarDownEightFir.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtNarDownEightSec.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtNarDownEightThi.TextChanged += new EventHandler(pxControls_TextChanged);
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            //btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

    }
}