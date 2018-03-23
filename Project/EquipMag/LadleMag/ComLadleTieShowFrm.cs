using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.LadleMag
{
    public partial class ComLadleTieShowFrm : Form
    {
        public ComLadleTieShowFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session, string strSort, int nPosition, ref AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;
            cmbLadleID.TextChanged += new EventHandler(pxControls_TextChanged);
            cmbLadleID.SelectedIndex = 1;

            bsMain.DataSource = null;
            bsMain.DataSource = dsData;
            bsMain.DataMember = dsData.Tables[0].TableName;

            ((System.Data.DataRowView)(bsMain.Current)).DataView.Sort = strSort;
            bsMain.Position = nPosition;

            return ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsMain.EndEdit();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComLadleTieShowFrm_Load(object sender, EventArgs e)
        {
            txtLadleInnerUseCount.TextChanged += new EventHandler(pxControls_TextChanged);
            txtWaterGapBriWast.TextChanged += new EventHandler(pxControls_TextChanged);
            txtBreatheBriWast .TextChanged+= new EventHandler(pxControls_TextChanged);
            txtCastWast.TextChanged += new EventHandler(pxControls_TextChanged);
            txtSquLeadWast.TextChanged += new EventHandler(pxControls_TextChanged);
            txtHalfBoaWast .TextChanged+= new EventHandler(pxControls_TextChanged);
            rtxtNote.TextChanged += new EventHandler(pxControls_TextChanged);

        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

    }
}