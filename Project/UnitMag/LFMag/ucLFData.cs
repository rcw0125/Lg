using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.LFMag
{
    public partial class ucLFData : UserControl
    {
        public ucLFData()
        {
            InitializeComponent();
        }

        public AppSvrIF.Session Session
        {
            get { return Adapter.Session; }
            set { Adapter.Session = value; }
        }

        private string m_UnitID = "";
        private string m_CurHeatID = "";
        private string[,] strArrColor = new string[5, 2] 
              { { "01", CommDataMag.CommonData.Color_Code_Control},
                { "02", CommDataMag.CommonData.Color_Code_Pink },
                { "03", CommDataMag.CommonData.Color_Code_OrangeRed},
                { "04", CommDataMag.CommonData.Color_Code_SteelBlue},
                { "05", CommDataMag.CommonData.Color_Code_SteelBlue}};
        public string HeatID
        {
            get { return m_CurHeatID; }
            set
            {
                m_CurHeatID = value;
                SwitchToHeatID(m_CurHeatID);
            }
        }
        protected void SwitchToHeatID(string HeatID)
        {
            m_CurHeatID = HeatID;
            RefreshContent();
        }

        public string UnitID
        {
            get { return m_UnitID; }
            set
            {
                m_UnitID = value;
                RefreshContent();
            }
        }

        public void RefreshContent()
        {
            if (DesignMode || Adapter == null || Adapter.Session == null)
                return;
            /*2009-02-28Liao*/
            if (m_UnitID.Length != 3)
                return;
            string strID = "S4" + m_UnitID.Substring(2, 1);
            Adapter.set_URIParameters("LFID", m_UnitID);
            Adapter.set_URIParameters("HeatID", m_CurHeatID);

            dbxCurArea.DataObject = "XGMESLogic\\LFMag\\CLF_Unit_Mag\\{LFID}";
            dbxHeatID.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\{LFID}{CurArea}";
            dbxTreatNo.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\{LFID}{CurArea}";
            dbxSteelGradeIndex.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\{LFID}{CurArea}";

            dbxSoftTimeA.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\{LFID}A";
            dbxSoftTimeB.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\{LFID}B";

            dbxSteelGradeIndexA.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\{LFID}A";
            dbxSteelGradeIndexB.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\{LFID}B";

            dbxHeatIDA.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\{LFID}A";
            dbxHeatIDB.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\{LFID}B";

            dbxTreatNoA.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\{LFID}A";
            dbxTreatNoB.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\{LFID}B";

            dsPlan.SourceCondition = "LFID='" + m_UnitID + "' and Status > 10 and (CreateDate >=(select SYSDATE from dual) -0.1667  or( CreateDate  < (select SYSDATE from dual) -0.1667 and Status < 13)) order by LF_Status desc ,Side_Status desc ,BOF_Status desc";
            dsArrivleLFSteel.SourceCondition = "Position ='" + m_UnitID + "' || 'P01' order by Idx";
            dsExcept.SourceCondition = "HeatID = '" + m_CurHeatID + "'  order by UnitTypeID,UnitID asc";
            Adapter.set_URIParameters("BTID", strID);
            string strSQLPlan = "";

            strSQLPlan += "SELECT   a.heatid, a.planid, a.steelgradeindex, a.lfid, a.rhid, a.casterid,";
            strSQLPlan += "         a.status, a.createdate, a.preheatid, a.pre_steelgradeindex,       ";
            strSQLPlan += "         a.pre_steelgrade, a.bofid, a.bof_status, a.lf_status, a.rh_status,";
            strSQLPlan += "         a.caster_status, a.side_status, a.casting_no, a.casting_heat_cnt, ";
            strSQLPlan += "         a.fir_heat_flag, a.div_heatid, a.plan_ord_id, a.destitation,a.AIM_TAPPED_WEIGHT,a.REFINE_TYPE, a.HOT_SEND_FLAG,a.STEEL_RETURN_FLAG,a.STEEL_BACK_FLAG,     ";
            strSQLPlan += "         b.steelgrade, b.protocol                                          ";
            strSQLPlan += "    FROM cplan_tapping a, cqa_steelgradeindex_r b                          ";
            //�������
            dsPlan.SourceMethod = strSQLPlan + " where 1 = 2";

            strSQLPlan += "   WHERE a.steelgradeindex = b.steelgradeindex                             ";
            strSQLPlan += "     AND a.lfid = '" + strID + "'                                       ";
            strSQLPlan += "     AND a.status > 10                                                     ";
            strSQLPlan += "     AND (   a.createdate >= (SELECT SYSDATE                               ";
            strSQLPlan += "                                FROM DUAL) - 0.1667                         ";
            strSQLPlan += "          OR (a.createdate < (SELECT SYSDATE                               ";
            strSQLPlan += "                                FROM DUAL) - 0.1667 AND a.status < 13)      ";
            strSQLPlan += "         )                                                                 ";
            strSQLPlan += "ORDER BY LF_Status desc ,Side_Status desc ,BOF_Status desc         ";

            dsPlan.SourceMethod = strSQLPlan;
            //dsArrivleLFSteel.L3DataAdapter = Adapter;
            Adapter.RefreshDataBindings();
        }


        private void dbxSteelGradeIndex_TextChanged(object sender, EventArgs e)
        {
            Adapter.DeleteURIParameter("SteelGradeIndex");
            Adapter.set_URIParameters("SteelGradeIndex", dbxSteelGradeIndex.Text);
            //Adapter.RefreshDataBindings();

            dsSetL3DataAdapter();
        }
        //��L3DataSet��L3DataAdapter��ȡ���ݸ�ֵ��dv�У�Ȼ��ȡ����
        private void dsSetL3DataAdapter()
        {
            //����
            dsSlagele.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";
            //������׼
            dsBaseData.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";
            //�Ͻ���ϱ�׼
            dsAlloy.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";
            //�����׼
            dsProcess.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";
            //���ϼ���
            dsAddSlag.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";
            //ι˿
            dsFeed.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

        }

        private void dbxCurArea_TextChanged(object sender, EventArgs e)
        {
            if ((dbxCurArea.Text != "A") && (dbxCurArea.Text != "B"))
            {
                return;
            }
            Adapter.DeleteURIParameter("CurArea");
            Adapter.set_URIParameters("CurArea", dbxCurArea.Text);
            dbxSteelGradeIndex.LoadData();
            dbxHeatID.LoadData();
            dbxTreatNo.LoadData();
        }

        //���ݼ���
        private void ucLFData_Load(object sender, EventArgs e)
        {
            dsPlan.L3DataAdapter = Adapter;
            dsArrivleLFSteel.L3DataAdapter = Adapter;

            Set_TabPlan_AutoSubscribe(false);
            Set_tabElementA_AutoSubscribe(false);
            Set_tabElementB_AutoSubscribe(false);
            Set_tabProStd_AutoSubscribe(false);
            Set_tabProcessA_AutoSubscribe(false);
            //Set_tabProcessB_AutoSubscribe(false);

        }

        private void dbxTreatNo_TextChanged(object sender, EventArgs e)
        {
            //2009-04-25 Liao
            if (lbTappingOxygenB.SelectedTab != tabProcessA)
                return;
            dsAddition.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim() + "' order by Discharge_Time desc";

            dsWireData.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim().ToString() + "' order by WireTime desc";

            dsProcessStatus.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim().ToString() + "' order by Change_Time desc";
            // begin [12/24/2008 sun]
            dsLFTempData.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim().ToString() + "' and \"MODE\" <> 4 order by MeasureTime desc";

            dsLFOxyData.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim().ToString() + "' order by Measure_Time desc";
            // end [12/24/2008 sun]
            dsLFProcess.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim().ToString() + "'";

            dsLadleInfo.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim().ToString() + "'";
        }

        private void dbxTreatNoB_TextChanged(object sender, EventArgs e)
        {
            if (lbTappingOxygenB.SelectedTab != tabProcessB)
                return;

            dsAddition.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim() + "' order by Discharge_Time desc";

            dsWireData.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim().ToString() + "' order by WireTime desc";

            dsProcessStatus.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim().ToString() + "' order by Change_Time desc";
            // begin [12/24/2008 sun]
            dsLFTempData.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim().ToString() + "' and \"MODE\" <> 4 order by MeasureTime desc";

            //dsOxyTemp.SourceCondition = "TreatNo = '" + dbxTreatNo.Text.Trim().ToString() + "' and \"MODE\" = 4 order by MeasureTime desc";

            dsLFOxyData.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim().ToString() + "' order by Measure_Time desc";
            // end [12/24/2008 sun]
            dsLFProcess.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim().ToString() + "'";

            dsLadleInfo.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim().ToString() + "'";
        }

        private void dbxHeatID_TextChanged(object sender, EventArgs e)
        {
            //Adapter.DeleteURIParameter("HeatID");
            //Adapter.set_URIParameters("HeatID", dbxHeatID.Text);

            //dsExcept.SourceCondition = "HeatID = '" + dbxHeatID.Text.Trim() + "' order by UnitTypeID,UnitID,Exceptional_Time asc ";

            // begin [12/24/2008 sun]
            //dsBOFProcessData.SourceCondition = "HeatID = '" + dbxHeatID.Text.Trim() + "'";
            //dsTapProcessData.SourceCondition = "HeatID = '" + dbxHeatID.Text.Trim() + "'";
            // end [12/24/2008 sun]
        }

        private void ucLFData_VisibleChanged(object sender, EventArgs e)
        {
            if (!(this.Visible))
            {
                Set_TabPlan_AutoSubscribe(false);
                Set_tabElementA_AutoSubscribe(false);
                Set_tabElementB_AutoSubscribe(false);
                Set_tabProStd_AutoSubscribe(false);
                Set_tabProcessA_AutoSubscribe(false);
                //dsArrivleLFSteel.AutoSubscribe = false;
            }
            else
            {
                TabPage tabpag = lbTappingOxygenB.SelectedTab;
                //dsArrivleLFSteel.AutoSubscribe = true;
                switch (tabpag.Name)
                {
                    case "tabPlan":
                        Set_TabPlan_AutoSubscribe(true);
                        break;
                    case "tabElementA":
                        Set_tabElementA_AutoSubscribe(true);
                        break;
                    case "tabElementB":
                        Set_tabElementB_AutoSubscribe(true);
                        break;
                    case "tabProStd":
                        Set_tabProStd_AutoSubscribe(true);
                        break;
                    case "tabProcessA":
                        Set_tabProcessA_AutoSubscribe(true);
                        break;
                    case "tabProcessB":
                        Set_tabProcessA_AutoSubscribe(true);
                        break;
                    default:
                        break;
                }
            }
        }

        //���ݼƻ���ǰ����״̬���Ƽƻ���������ɫ
        private void dvPlan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            CommDataMag.CommonMethed.SetDataGridViewRowColor(dvPlan, "STATUS", strArrColor);
        }

        private void dvPlan_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                if (e.Action == TabControlAction.Selected)
                {
                    Set_TabPlan_AutoSubscribe(false);
                    Set_tabElementA_AutoSubscribe(false);
                    Set_tabElementB_AutoSubscribe(false);
                    Set_tabProStd_AutoSubscribe(false);
                    Set_tabProcessA_AutoSubscribe(false);
                    //Set_tabProcessB_AutoSubscribe(false);
                    switch (e.TabPage.Name)
                    {
                        case "tabPlan":
                            if (dsPlan.L3DataAdapter == null)
                                dsPlan.L3DataAdapter = Adapter;

                            if (dsArrivleLFSteel.L3DataAdapter == null)
                                dsArrivleLFSteel.L3DataAdapter = Adapter;

                            Set_TabPlan_AutoSubscribe(true);
                            break;
                        case "tabArearA":
                            if (dsElementA.L3DataAdapter == null)
                                dsElementA.L3DataAdapter = Adapter;
                            dsElementA.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexA.Text + "'";

                            if (dsInCtrolEleA.L3DataAdapter == null)
                                dsInCtrolEleA.L3DataAdapter = Adapter;
                            dsInCtrolEleA.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexA.Text + "'";

                            if (dsElementInfoA.L3DataAdapter == null)
                                dsElementInfoA.L3DataAdapter = Adapter;
                            dsElementInfoA.SourceCondition = "HeatID = '" + dbxHeatIDA.Text
                                + "' and UnitTypeID = '" + UnitID.Substring(1, 1).ToString() + "' order by HeatID,AppID,Sample_Count";

                            Set_tabElementA_AutoSubscribe(true);

                            //Modify begin by llj 2011-04-13  ����Ca/Al��ֵ
                            String HeatID_A = dbxHeatIDA.Text.Trim();
                            AppSvrIF.Command command_A= null;
                            String strMethod_A = @"CalEleRateValue";
                            String strObjURI_A = @"XGMESLogic\LFMag\CLF_Unit_Mag\S41";
                            try
                            {
                               int iRet=this.Adapter.Session.CreateCommand((int)AppSvrIF.CommandType.Call, strObjURI_A, strMethod_A, ref command_A);
                                if(iRet==0)
                                {
                                    command_A.set_Parameters(0, HeatID_A);
                                    command_A.set_Parameters(1, "Ca");
                                    command_A.set_Parameters(2, "Al");
                                    this.Adapter.Session.Execute(command_A);
                                    object retValue = command_A.Return;
                                    if (retValue != null)
                                    {
                                        string strA = retValue.ToString();
                                        txtCaAl_A.Text = strA;
                                        if (strA.Length > 7)
                                            txtCaAl_A.Text = strA.Substring(0, 7);
                                    }
                                }
                            }
                            catch
                            {
                                txtCaAl_A.Text = "";
                            }
                            finally
                            {
                                
                                command_A.Dispose();
                            }
                            //Modify end
                            break;

                        case "tabArearB":
                            if (dsElementB.L3DataAdapter == null)
                                dsElementB.L3DataAdapter = Adapter;
                            dsElementB.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexB.Text + "'";

                            if (dsInCtrolEleB.L3DataAdapter == null)
                                dsInCtrolEleB.L3DataAdapter = Adapter;
                            dsInCtrolEleB.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexB.Text + "'";

                            if (dsElementInfoB.L3DataAdapter == null)
                                dsElementInfoB.L3DataAdapter = Adapter;
                            dsElementInfoB.SourceCondition = "HeatID = '" + dbxHeatIDB.Text
                                + "' and UnitTypeID = '" + UnitID.Substring(1, 1).ToString() + "' order by HeatID,AppID,Sample_Count";

                            Set_tabElementB_AutoSubscribe(true);

                            //Modify begin by llj 2011-04-13  ����Ca/Al��ֵ
                            String HeatID_B = dbxHeatIDB.Text.Trim();
                            AppSvrIF.Command command_B = null;
                            String strMethod_B = @"CalEleRateValue";
                            String strObjURI_B = @"XGMESLogic\LFMag\CLF_Unit_Mag\S41";
                            try
                            {
                                int iRet = this.Adapter.Session.CreateCommand((int)AppSvrIF.CommandType.Call, strObjURI_B, strMethod_B, ref command_B);
                                if (iRet == 0)
                                {
                                    command_B.set_Parameters(0, HeatID_B);
                                    command_B.set_Parameters(1, "Ca");
                                    command_B.set_Parameters(2, "Al");
                                    this.Adapter.Session.Execute(command_B);
                                    object retValue = command_B.Return;
                                    if (retValue != null)
                                    {
                                        string strB = retValue.ToString();
                                        txtCaAl_B.Text = strB;
                                        if (strB.Length > 5)
                                            txtCaAl_B.Text = strB.Substring(0, 5);
                                    }
                                }
                            }
                            catch
                            {
                                txtCaAl_B.Text = "";
                            }
                            finally
                            {

                                command_B.Dispose();
                            }
                            //Modify end
                            break;

                        case "tabProStd":
                            if (dsSlagele.L3DataAdapter == null)
                                dsSlagele.L3DataAdapter = Adapter;

                            if (dsBaseData.L3DataAdapter == null)
                                dsBaseData.L3DataAdapter = Adapter;

                            if (dsProcess.L3DataAdapter == null)
                                dsProcess.L3DataAdapter = Adapter;

                            if (dsAlloy.L3DataAdapter == null)
                                dsAlloy.L3DataAdapter = Adapter;

                            if (dsAddSlag.L3DataAdapter == null)
                                dsAddSlag.L3DataAdapter = Adapter;

                            if (dsFeed.L3DataAdapter == null)
                                dsFeed.L3DataAdapter = Adapter;

                            Set_tabProStd_AutoSubscribe(true);
                            break;

                        case "tabProcessA":
                            dsTapProcessData.SourceCondition = "HeatID = '" + dbxHeatIDA.Text.Trim() + "'";
                            if (dsTapProcessData.L3DataAdapter == null)
                                dsTapProcessData.L3DataAdapter = Adapter;

                            dsBOFProcessData.SourceCondition = "HeatID = '" + dbxHeatIDA.Text.Trim() + "'";
                            if (dsBOFProcessData.L3DataAdapter == null)
                                dsBOFProcessData.L3DataAdapter = Adapter;

                            dsLFTempData.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim().ToString() + "' and \"MODE\" <> 4 order by MeasureTime desc";
                            if (dsLFTempData.L3DataAdapter == null)
                                dsLFTempData.L3DataAdapter = Adapter;

                            dsLFOxyData.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim().ToString() + "' order by Measure_Time desc";
                            if (dsLFOxyData.L3DataAdapter == null)
                                dsLFOxyData.L3DataAdapter = Adapter;

                            dsExcept.SourceCondition = "HeatID = '" + dbxHeatIDA.Text.Trim() + "' order by UnitTypeID,UnitID,Exceptional_Time asc ";
                            if (dsExcept.L3DataAdapter == null)
                                dsExcept.L3DataAdapter = Adapter;

                            dsProcessStatus.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim().ToString() + "' order by Change_Time desc";
                            if (dsProcessStatus.L3DataAdapter == null)
                                dsProcessStatus.L3DataAdapter = Adapter;

                            dsAddition.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim() + "' order by Discharge_Time desc";
                            if (dsAddition.L3DataAdapter == null)
                                dsAddition.L3DataAdapter = Adapter;

                            dsWireData.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim().ToString() + "' order by WireTime desc";
                            if (dsWireData.L3DataAdapter == null)
                                dsWireData.L3DataAdapter = Adapter;

                            dsLFProcess.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim().ToString() + "'";
                            if (dsLFProcess.L3DataAdapter == null)
                                dsLFProcess.L3DataAdapter = Adapter;

                            dsLadleInfo.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim().ToString() + "'";
                            if (dsLadleInfo.L3DataAdapter == null)
                                dsLadleInfo.L3DataAdapter = Adapter;

                            Set_tabProcessA_AutoSubscribe(true);
                            break;

                        case "tabProcessB":
                            dsTapProcessData.SourceCondition = "HeatID = '" + dbxHeatIDB.Text.Trim() + "'";
                            if (dsTapProcessData.L3DataAdapter == null)
                                dsTapProcessData.L3DataAdapter = Adapter;

                            dsBOFProcessData.SourceCondition = "HeatID = '" + dbxHeatIDB.Text.Trim() + "'";
                            if (dsBOFProcessData.L3DataAdapter == null)
                                dsBOFProcessData.L3DataAdapter = Adapter;

                            dsLFTempData.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim().ToString() + "' and \"MODE\" <> 4 order by MeasureTime desc";
                            if (dsLFTempData.L3DataAdapter == null)
                                dsLFTempData.L3DataAdapter = Adapter;

                            dsLFOxyData.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim().ToString() + "' order by Measure_Time desc";
                            if (dsLFOxyData.L3DataAdapter == null)
                                dsLFOxyData.L3DataAdapter = Adapter;

                            dsExcept.SourceCondition = "HeatID = '" + dbxHeatIDB.Text.Trim() + "' order by UnitTypeID,UnitID,Exceptional_Time asc ";
                            if (dsExcept.L3DataAdapter == null)
                                dsExcept.L3DataAdapter = Adapter;

                            dsProcessStatus.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim().ToString() + "' order by Change_Time desc";
                            if (dsProcessStatus.L3DataAdapter == null)
                                dsProcessStatus.L3DataAdapter = Adapter;

                            dsAddition.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim() + "' order by Discharge_Time desc";
                            if (dsAddition.L3DataAdapter == null)
                                dsAddition.L3DataAdapter = Adapter;

                            dsWireData.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim().ToString() + "' order by WireTime desc";
                            if (dsWireData.L3DataAdapter == null)
                                dsWireData.L3DataAdapter = Adapter;

                            dsLFProcess.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim().ToString() + "'";
                            if (dsLFProcess.L3DataAdapter == null)
                                dsLFProcess.L3DataAdapter = Adapter;

                            dsLadleInfo.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim().ToString() + "'";
                            if (dsLadleInfo.L3DataAdapter == null)
                                dsLadleInfo.L3DataAdapter = Adapter;

                            Set_tabProcessA_AutoSubscribe(true);
                            break;

                        default:
                            break;
                    }
                }
            }
            catch { }
        }

        //���üƻ�tabҳ���Զ�ԤԼ����
        private void Set_TabPlan_AutoSubscribe(bool bAutoSubscribe)
        {
            dsPlan.AutoSubscribe = bAutoSubscribe;
            dsArrivleLFSteel.AutoSubscribe = true;
            if (bAutoSubscribe)
            {
                dsPlan.LoadData();
                dsArrivleLFSteel.LoadData();
            }
        }

        //���üƻ�tabElementҳ���Զ�ԤԼ����
        private void Set_tabElementA_AutoSubscribe(bool bAutoSubscribe)
        {
            dsElementA.AutoSubscribe = bAutoSubscribe;
            dsInCtrolEleA.AutoSubscribe = bAutoSubscribe;
            dsElementInfoA.AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                dsElementA.LoadData();
                dsInCtrolEleA.LoadData();
                //CommDataMag.CommonMethed.dv_ElementStd_Draw(dvProEleA, dsElementA, dsInCtrolEleA);
                dsElementInfoA.LoadData();
            }
        }

        //���üƻ�tabElementҳ���Զ�ԤԼ����
        private void Set_tabElementB_AutoSubscribe(bool bAutoSubscribe)
        {
            dsElementB.AutoSubscribe = bAutoSubscribe;
            dsInCtrolEleB.AutoSubscribe = bAutoSubscribe;
            dsElementInfoB.AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                dsElementB.LoadData();
                dsInCtrolEleB.LoadData();
                dsElementInfoB.LoadData();
            }
        }
        private void l3dbxTappingStatus_TextChanged(object sender, EventArgs e)
        {
            dsPlan.LoadData();
        }
        //���üƻ�tabProStdҳ���Զ�ԤԼ����
        private void Set_tabProStd_AutoSubscribe(bool bAutoSubscribe)
        {
            dsBaseData.AutoSubscribe = bAutoSubscribe;
            dsProcess.AutoSubscribe = bAutoSubscribe;
            dsSlagele.AutoSubscribe = bAutoSubscribe;
            dsAlloy.AutoSubscribe = bAutoSubscribe;
            dsAddSlag.AutoSubscribe = bAutoSubscribe;
            dsFeed.AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                dsSlagele.LoadData();
                dsBaseData.LoadData();
                dsProcess.LoadData();
                dsAlloy.LoadData();
                dsAddSlag.LoadData();
                dsFeed.LoadData();
            }
        }

        //���üƻ�tabProcessAҳ���Զ�ԤԼ����
        private void Set_tabProcessA_AutoSubscribe(bool bAutoSubscribe)
        {
            dsBOFProcessData.AutoSubscribe = bAutoSubscribe;
            dsLFTempData.AutoSubscribe = bAutoSubscribe;
            dsLFOxyData.AutoSubscribe = bAutoSubscribe;
            dsExcept.AutoSubscribe = bAutoSubscribe;
            dsProcessStatus.AutoSubscribe = bAutoSubscribe;
            dsWireData.AutoSubscribe = bAutoSubscribe;
            dsLFProcess.AutoSubscribe = bAutoSubscribe;
            dsLadleInfo.AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                dsBOFProcessData.LoadData();
                dsLFTempData.LoadData();
                dsLFOxyData.LoadData();
                dsExcept.LoadData();
                dsProcessStatus.LoadData();
                dsWireData.LoadData();
                dsLFProcess.LoadData();
                dsLadleInfo.LoadData();
            }
        }

        ////���üƻ�tabProcessBҳ���Զ�ԤԼ����
        //private void Set_tabProcessB_AutoSubscribe(bool bAutoSubscribe)
        //{
        //    dsBOFProcessData.AutoSubscribe = bAutoSubscribe;
        //    dsLFTempData.AutoSubscribe = bAutoSubscribe;
        //    dsLFOxyData.AutoSubscribe = bAutoSubscribe;
        //    dsExcept.AutoSubscribe = bAutoSubscribe;
        //    dsProcessStatus.AutoSubscribe = bAutoSubscribe;
        //    dsWireData.AutoSubscribe = bAutoSubscribe;
        //    dsLFProcess.AutoSubscribe = bAutoSubscribe;
        //    dsLadleUse.AutoSubscribe = bAutoSubscribe;
        //    if (bAutoSubscribe)
        //    {
        //        dsBOFProcessData.LoadData();
        //        dsLFTempData.LoadData();
        //        dsLFOxyData.LoadData();
        //        dsExcept.LoadData();
        //        dsProcessStatus.LoadData();
        //        dsWireData.LoadData();
        //        dsLFProcess.LoadData();
        //        dsLadleUse.LoadData();
        //    }
        //}

        private void dbxSoftTimeB_TextChanged(object sender, EventArgs e)
        {
            string str = dbxSoftTimeB.Text;
            if (str != "")
            {
                int viTime = Convert.ToInt32(str);
                int viMin = Convert.ToInt32(viTime / 60);
                int viSec = viTime % 60;
                string vsTime = viMin.ToString() + "'" + viSec.ToString() + "''";
                dbxSoftTimeBDis.Text = vsTime;
            }
        }

        private void dbxSoftTimeA_TextChanged(object sender, EventArgs e)
        {
            string str = dbxSoftTimeA.Text;
            if (str != "")
            {
                int viTime = Convert.ToInt32(str);
                int viMin = Convert.ToInt32(viTime / 60);
                int viSec = viTime % 60;
                string vsTime = viMin.ToString() + "'" + viSec.ToString() + "''";
                dbxSoftTimeADis.Text = vsTime;
            }
        }

        private void dbxSteelGradeIndexA_TextChanged(object sender, EventArgs e)
        {
            //2009-04-25 Liao
            if (lbTappingOxygenB.SelectedTab != tabArearA)
                return;
            //��Ʒ�ɷݱ�׼
            dsElementA.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexA.Text + "'";
            dsInCtrolEleA.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexA.Text + "'";
        }

        private void dbxHeatIDA_TextChanged(object sender, EventArgs e)
        {
            //2009-04-25 Liao
            if (lbTappingOxygenB.SelectedTab != tabArearA && lbTappingOxygenB.SelectedTab != tabProcessA)
                return;

            dsElementInfoA.SourceCondition = "HeatID = '" + dbxHeatIDA.Text + "' and UnitTypeID = '" + UnitID.Substring(1, 1).ToString() + "' order by HeatID,AppID,Sample_Count";

            dsExcept.SourceCondition = "HeatID = '" + dbxHeatIDA.Text.Trim() + "' order by UnitTypeID,UnitID,Exceptional_Time asc ";

            // begin [12/24/2008 sun]
            dsBOFProcessData.SourceCondition = "HeatID = '" + dbxHeatIDA.Text.Trim() + "'";
            dsTapProcessData.SourceCondition = "HeatID = '" + dbxHeatIDA.Text.Trim() + "'";
        }

        private void dbxSteelGradeIndexB_TextChanged(object sender, EventArgs e)
        {
            //2009-04-25 Liao
            if (lbTappingOxygenB.SelectedTab != tabArearB)
                return;
            //��Ʒ�ɷݱ�׼
            dsElementB.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexB.Text + "'";
            dsInCtrolEleB.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexB.Text + "'";
        }

        private void dbxHeatIDB_TextChanged(object sender, EventArgs e)
        {
            //2009-04-25 Liao
            if (lbTappingOxygenB.SelectedTab != tabArearB && lbTappingOxygenB.SelectedTab != tabProcessB)
                return;

            dsElementInfoB.SourceCondition = "HeatID = '" + dbxHeatIDB.Text + "' and UnitTypeID = '" + UnitID.Substring(1, 1).ToString() + "' order by HeatID,AppID,Sample_Count";

            dsExcept.SourceCondition = "HeatID = '" + dbxHeatIDB.Text.Trim() + "' order by UnitTypeID,UnitID,Exceptional_Time asc ";

            // begin [12/24/2008 sun]
            dsBOFProcessData.SourceCondition = "HeatID = '" + dbxHeatIDB.Text.Trim() + "'";
            dsTapProcessData.SourceCondition = "HeatID = '" + dbxHeatIDB.Text.Trim() + "'";
        }

        private void dsElementInfoB_OnDataLoaded(object sender)
        {
            CommDataMag.CommonMethed.dv_ElementStd_Draw(dvProEleB, dsElementB, dsInCtrolEleB);
            CommDataMag.CommonMethed.dv_Element_Draw(dvProEleB, dsElementInfoB);
            CommDataMag.CommonMethed.SetDataGridViewCellBackColorByRow(dvProEleB, dsElementB, dsInCtrolEleB, 7);
        }

        private void dsElementInfoA_OnDataLoaded(object sender)
        {
            CommDataMag.CommonMethed.dv_ElementStd_Draw(dvProEleA, dsElementA, dsInCtrolEleA);
            CommDataMag.CommonMethed.dv_Element_Draw(dvProEleA, dsElementInfoA);
            CommDataMag.CommonMethed.SetDataGridViewCellBackColorByRow(dvProEleA, dsElementA, dsInCtrolEleA, 7);
        }

        private void dvPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private int iCount = 0;
        //private int iFlag = 0;
        //private void dsArrivleLFSteel_OnDataLoaded(object sender)
        //{
        //    int i = dsArrivleLFSteel.Tables[0].Rows.Count;

        //    if (i > iCount && iFlag == 1)
        //        MessageBox.Show(m_UnitID + "�и�ˮ���", "��ʾ");
            
        //    iCount = i;

        //    if (iFlag == 0)
        //        iFlag += 1;
        //}

    }
}







 