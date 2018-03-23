﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.MIFMag
{
    public partial class MIFSampleApplyFrm : Form
    {
        public MIFSampleApplyFrm()
        {
            InitializeComponent();
        }
        private string strCurAddress = "";
        private string strSort = "";
        private bool bCheck = false;//标记当前是否(Check)选中数据
        private AppSvrHMI.L3DataSet dsSend = new AppSvrHMI.L3DataSet();
        private MIFApplyInfoFrm Frm = new MIFApplyInfoFrm();

        //private bool bAddFlag = false;//标记新增标记【状态】
        public DialogResult ShowDialogEx(AppSvrIF.Session session, string strAddr)
        {
            //add by hyh 2012-03-30
            this.Text = strAddr[strAddr.Length - 1].ToString() + "号混铁炉" + this.Text;
            //end
            Adapter.Session = session;
            switch (strAddr)
            {
                //混铁炉工序
                case CommDataMag.CommonData.MIF_UNIT_01ID:
                    strCurAddress = CommDataMag.CommonData.QA_Sample_Addr_H1;
                    break;
                case CommDataMag.CommonData.MIF_UNIT_02ID:
                    strCurAddress = CommDataMag.CommonData.QA_Sample_Addr_H2;
                    break;
                //add by  hyh 2012-03-29
                case CommDataMag.CommonData.MIF_UNIT_03ID:
                    strCurAddress = CommDataMag.CommonData.QA_Sample_Addr_H3;
                    break;
                //end
                default:
                    break;
            }
            return ShowDialog();
        }


        //取消
        private void MIFSampleApplyFrm_Load(object sender, EventArgs e)
        {
            dsSend = (AppSvrHMI.L3DataSet)dsSampleApply.Clone();
            cmdSampleApply.Parameters[0].ConstantValue = strCurAddress;
            cmdSampleApply.Execute();
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //添加一行数据，对相应数据进行填充
            DataRow newrow = dsSampleApply.Tables[0].NewRow();
            newrow["SAMPLE_ADDRESS"] = strCurAddress;
            dsSampleApply.Tables[0].Rows.Add(newrow);

            bsSampleApply.MoveFirst();
            while (((System.Data.DataRowView)(bsSampleApply.Current)).Row != newrow || bsSampleApply.Position < dsSampleApply.Tables[0].Rows.Count - 1)
                bsSampleApply.MoveNext();
            
            //锁定新增按钮
            btnAdd.Enabled = false;

            Frm.ShowDialogEx(Adapter.Session, strCurAddress, bsSampleApply.Position, strSort, ref dsSampleApply);
        }

        //确定
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dsSampleApply.UpdateData();
            dsSampleApply.AcceptChanges();
            cmdSampleApply.Execute();
        }

       // 删除
        private void btnDel_Click(object sender, EventArgs e)
        {
            if ((bsSampleApply.Position >= 0) && (!(Convert.ToBoolean(dvSampleApply.CurrentRow.Cells["SENDFLAG"].Value))))
                bsSampleApply.RemoveCurrent();
        }

        //去检化验
        private void btnToLab_Click(object sender, EventArgs e)
        {
            cmdToLab.Parameters[0].SourceFilter = "CheckFlag = 1 and APPID <> '' and SAMPLE_CODE <> ''";
            dvSampleApply.EndEdit();
            bsSampleApply.EndEdit();
            if ((DataSet)(cmdToLab.Parameters[0].Value) != null && ((DataSet)(cmdToLab.Parameters[0].Value)).Tables[0].Rows.Count>0)
            {
                string strType = ((DataSet)cmdToLab.Parameters[0].Value).Tables[0].Rows[0]["AppID"].ToString().Substring(0, 1);
                string strHeatID = ((DataSet)cmdToLab.Parameters[0].Value).Tables[0].Rows[0]["HeatID"].ToString();
                if (strType == "H" || (strType != "H" && strHeatID != ""))
                {
                    if (MessageBox.Show("确认下传委托单到检化验？", "提示", 
                        MessageBoxButtons.YesNo,MessageBoxIcon.Question).ToString() == "Yes")
                    {
                        if (cmdToLab.Execute() >= 0)
                        {
                            if (Convert.ToInt16(cmdToLab.Command.Return) > 0)
                            {
                                MessageBox.Show("下传成功！", "提示", MessageBoxButtons.OK);
                                cmdSampleApply.Execute();
                            }
                            else
                            {
                                MessageBox.Show("下传失败！", "提示", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("下传失败！", "提示", MessageBoxButtons.OK);
                        }
                    }
                }
                else 
                {
                    MessageBox.Show("所选委托单无效！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            else
            {
                MessageBox.Show("所选委托单无效！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        //已经去简化验的委托单不允许弹出
        private void dvSampleApply_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(Convert.ToBoolean(dvSampleApply.CurrentRow.Cells["SENDFLAG"].Value)))
                Frm.ShowDialogEx(Adapter.Session, strCurAddress, bsSampleApply.Position, strSort, ref dsSampleApply);
        }

        //校验选择
        private void dvSampleApply_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(dvSampleApply.CurrentRow.Cells["SENDFLAG"].Value))
            {
                dvSampleApply.CurrentRow.Cells[0].Value = 0;
                dvSampleApply.EndEdit();
                return;
            }
            dvSampleApply.EndEdit();
            if (dvSampleApply.CurrentRow.Cells[0].Value.ToString() == "1")
            {
                if (bCheck)
                {
                    int iRowCount = dvSampleApply.Rows.Count;
                    for (int i = 0; i < dvSampleApply.CurrentRow.Index; i++)
                    {
                        if (dvSampleApply.Rows[i].Cells[0].Value.ToString() == "1")
                        {
                            dvSampleApply.Rows[i].Cells[0].Value = 0;
                        }
                    }
                    for (int j = dvSampleApply.CurrentRow.Index + 1; j < iRowCount; j++)
                    {
                        if (dvSampleApply.Rows[j].Cells[0].Value.ToString() == "1")
                        {
                            dvSampleApply.Rows[j].Cells[0].Value = 0;
                        }
                    }
                }
                bCheck = true;
            }
        }

        private void dvSampleApply_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dvSampleApply_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSort = ((System.Data.DataRowView)(bsSampleApply.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvSampleApply_RowPrePaint(object sender, int iRowIndex)
        {
            if (dvSampleApply.Rows[iRowIndex].Cells["BACK_FLAG"].Value.ToString() == "1")
            {
                dvSampleApply.Rows[iRowIndex].Cells["APPID"].Style.BackColor = Color.Red;
                dvSampleApply.Rows[iRowIndex].Cells["APPID"].Style.SelectionForeColor = Color.Red;
                dvSampleApply.Rows[iRowIndex].Cells["APPID"].Style.SelectionBackColor = Color.LightGreen;
            }
            else if (dvSampleApply.Rows[iRowIndex].Cells["RESAMPLE_FLAG"].Value.ToString() == "1")
            {
                dvSampleApply.Rows[iRowIndex].Cells["APPID"].Style.BackColor = Color.Red;
                dvSampleApply.Rows[iRowIndex].Cells["APPID"].Style.SelectionForeColor = Color.Yellow;
                dvSampleApply.Rows[iRowIndex].Cells["APPID"].Style.SelectionBackColor = Color.LightPink;
            }

        }

        //数据源更改时引发
        private void dvSampleApply_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dvSampleApply.Rows.Count; i++)
            {
                dvSampleApply_RowPrePaint(sender, i);
            }
        }


        //确认已重取样
        private void btnConfirmSampleAgain_Click(object sender, EventArgs e)
        {
            string strAppID = dvSampleApply.Rows[bsSampleApply.Position].Cells["APPID"].Value.ToString();
            Adapter.Session.Set("XGMESLogic\\QualityMag\\CQA_Lab_Sheet_App\\" + strAppID, "ReSample_Flag", "2");
            Adapter.RefreshDataBindings();
            cmdSampleApply.Execute();
        }

        //确认已重制单
        private void btnConfirmMakeAgain_Click(object sender, EventArgs e)
        {
            string strAppID = dvSampleApply.Rows[bsSampleApply.Position].Cells["APPID"].Value.ToString();
            Adapter.Session.Set("XGMESLogic\\QualityMag\\CQA_Lab_Sheet_App\\" + strAppID, "Back_Flag", "2");
            Adapter.RefreshDataBindings();
            cmdSampleApply.Execute();
        }

        //[20090103Liao]
        //鼠标右键
        //确认重取样、确认重制样
        private void dvSampleApply_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex < 00)
                return;
            bsSampleApply.Position = e.RowIndex;

            string strBackFlag = dvSampleApply.Rows[bsSampleApply.Position].Cells["BACK_FLAG"].Value.ToString();
            string strReSampleFlag = dvSampleApply.Rows[bsSampleApply.Position].Cells["RESAMPLE_FLAG"].Value.ToString();
            //string strSendFlag = dvSampleApply.Rows[bsSampleApply.Position].Cells["SENDFLAG"].Value.ToString();
            if (strBackFlag == "1")
            {
                btnConfirmMakeAgain.Enabled = true;
                btnConfirmSampleAgain.Enabled = false;
            }
            else if (strReSampleFlag == "1")
            {
                btnConfirmMakeAgain.Enabled = false;
                btnConfirmSampleAgain.Enabled = true;
            }
            else
            {
                btnConfirmMakeAgain.Enabled = false;
                btnConfirmSampleAgain.Enabled = false;
            }
        }

        private void MIFSampleApplyFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        //在数据加载完后方可 显示“新增”按钮
        private void dsSampleApply_OnDataLoaded(object sender)
        {
            btnAdd.Enabled = true;
        }
    }
}