﻿namespace UnitMag.RHMag
{
    partial class RHHeatInfoFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RHHeatInfoFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsTemp = new System.Windows.Forms.BindingSource(this.components);
            this.dsTemp = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet2 = new System.Data.DataTable();
            this.coll3DataSet2L3DataTableGUID = new System.Data.DataColumn();
            this.coll3DataSet2L3DataTableName = new System.Data.DataColumn();
            this.coll3DataSet2L3DataTableTreatNo = new System.Data.DataColumn();
            this.coll3DataSet2L3DataTableHeatID = new System.Data.DataColumn();
            this.coll3DataSet2L3DataTableTemp = new System.Data.DataColumn();
            this.coll3DataSet2L3DataTableMeasureTime = new System.Data.DataColumn();
            this.coll3DataSet2L3DataTableMeasureMode = new System.Data.DataColumn();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnBaseOK = new System.Windows.Forms.Button();
            this.btnPaocessOK = new System.Windows.Forms.Button();
            this.btnConfirmExcept = new System.Windows.Forms.Button();
            this.btnAddExcept = new System.Windows.Forms.ToolStripButton();
            this.bnRemark = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsRemark = new System.Windows.Forms.BindingSource(this.components);
            this.dsRemark = new AppSvrHMI.L3DataSet();
            this.schemadsRemark = new System.Data.DataTable();
            this.coldsRemarkL3DataTableGUID = new System.Data.DataColumn();
            this.coldsRemarkL3DataTableName = new System.Data.DataColumn();
            this.coldsRemarkL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsRemarkL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsRemarkL3DataTableType = new System.Data.DataColumn();
            this.coldsRemarkL3DataTableRemark = new System.Data.DataColumn();
            this.coldsRemarkL3DataTableLogTime = new System.Data.DataColumn();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddRemark = new System.Windows.Forms.ToolStripButton();
            this.btnNoteConfirm = new System.Windows.Forms.Button();
            this.btnAddMat = new System.Windows.Forms.ToolStripButton();
            this.btnMatOK = new System.Windows.Forms.Button();
            this.btnWireConfirm = new System.Windows.Forms.Button();
            this.btnWireAdd = new System.Windows.Forms.ToolStripButton();
            this.btnLadleInfoOK = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.bsStatus = new System.Windows.Forms.BindingSource(this.components);
            this.dsStatus = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet1 = new System.Data.DataTable();
            this.coll3DataSet1L3DataTableGUID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableName = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableTreatNo = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableHeatID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableStatus = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableChange_Time = new System.Data.DataColumn();
            this.bsProcess = new System.Windows.Forms.BindingSource(this.components);
            this.dsProcess = new AppSvrHMI.L3DataSet();
            this.schemadsProcess = new System.Data.DataTable();
            this.coldsProcessL3DataTableGUID = new System.Data.DataColumn();
            this.coldsProcessL3DataTableName = new System.Data.DataColumn();
            this.coldsProcessL3DataTableLogDate = new System.Data.DataColumn();
            this.coldsProcessL3DataTableMaterialType = new System.Data.DataColumn();
            this.coldsProcessL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsProcessL3DataTableAmount = new System.Data.DataColumn();
            this.coldsProcessL3DataTableTargetArea = new System.Data.DataColumn();
            this.coldsProcessL3DataTableOperator = new System.Data.DataColumn();
            this.coldsProcessL3DataTableShift = new System.Data.DataColumn();
            this.coldsProcessL3DataTableTeam = new System.Data.DataColumn();
            this.coldsProcessL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsProcessL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsProcessL3DataTableArrival_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableArrival_Temp = new System.Data.DataColumn();
            this.coldsProcessL3DataTableStart_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableEnd_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableProcess_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableProbe_Vonder = new System.Data.DataColumn();
            this.coldsProcessL3DataTableDeparture_Temp = new System.Data.DataColumn();
            this.coldsProcessL3DataTableSoftBlow_StartTime = new System.Data.DataColumn();
            this.coldsProcessL3DataTableSoftBlow_EndTime = new System.Data.DataColumn();
            this.coldsProcessL3DataTableSoftBlow_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableArrival_Temp_Quality = new System.Data.DataColumn();
            this.coldsProcessL3DataTableSlag_Thick = new System.Data.DataColumn();
            this.coldsProcessL3DataTableProcess_Location = new System.Data.DataColumn();
            this.coldsProcessL3DataTableSlot_No = new System.Data.DataColumn();
            this.coldsProcessL3DataTableProcess_Mode = new System.Data.DataColumn();
            this.coldsProcessL3DataTableLoop_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableVac_Min = new System.Data.DataColumn();
            this.coldsProcessL3DataTableOB_Count = new System.Data.DataColumn();
            this.coldsProcessL3DataTableO2_CONS = new System.Data.DataColumn();
            this.coldsProcessL3DataTableAl_CONS = new System.Data.DataColumn();
            this.coldsProcessL3DataTableOB_Cycle_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableWire_End_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableWire_End_Temp = new System.Data.DataColumn();
            this.coldsProcessL3DataTableCircsOfRhythm = new System.Data.DataColumn();
            this.coldsProcessL3DataTableLadleNo = new System.Data.DataColumn();
            this.coldsProcessL3DataTableLadleGrade = new System.Data.DataColumn();
            this.coldsTempL3DataTableGUID = new System.Data.DataColumn();
            this.coldsTempL3DataTableName = new System.Data.DataColumn();
            this.coldsOxygenL3DataTableGUID = new System.Data.DataColumn();
            this.coldsNoteL3DataTableName = new System.Data.DataColumn();
            this.schemadsNote = new System.Data.DataTable();
            this.coldsOxygenL3DataTableName = new System.Data.DataColumn();
            this.coldsNoteL3DataTableGUID = new System.Data.DataColumn();
            this.bsBase = new System.Windows.Forms.BindingSource(this.components);
            this.dsBase = new AppSvrHMI.L3DataSet();
            this.schemadsBase = new System.Data.DataTable();
            this.coldsBaseL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsBaseL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsBaseL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsBaseL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsBaseL3DataTableLadleNo = new System.Data.DataColumn();
            this.coldsBaseL3DataTableAssistant = new System.Data.DataColumn();
            this.coldsBaseL3DataTableSecondHand = new System.Data.DataColumn();
            this.coldsBaseL3DataTableProductionDate = new System.Data.DataColumn();
            this.coldsBaseL3DataTableLocked = new System.Data.DataColumn();
            this.coldsBaseL3DataTableShift = new System.Data.DataColumn();
            this.coldsBaseL3DataTableTeam = new System.Data.DataColumn();
            this.coldsBaseL3DataTableHeatFurnace = new System.Data.DataColumn();
            this.coldsBaseL3DataTableGUID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableName = new System.Data.DataColumn();
            this.dsChemical = new AppSvrHMI.L3DataSet();
            this.schemadsChemical = new System.Data.DataTable();
            this.coldsChemicalL3DataTableGUID = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableName = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableAppID = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableSample_Code = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableArrive_Date = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableReport_Date = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableUnitTypeID = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableUnitID = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableSample_Address = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableSample_Type = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableSample_Count = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableC = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableSi = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableMn = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableP = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableS = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableCu = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableNi = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableCr = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableMo = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableV = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableNb = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableAl = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableAlS = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableTi = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableB = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableSb = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableAs = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableSn = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableZn = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableCa = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableW = new System.Data.DataColumn();
            this.coldsChemicalL3DataTablePb = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableRe = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableCeq = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableN = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableH = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableO = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableOther1 = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableOther2 = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableLogTime = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableDataLogMode = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableCrNi = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableCrCu = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableCrNiCu = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableOther3 = new System.Data.DataColumn();
            this.bsOxygen = new System.Windows.Forms.BindingSource(this.components);
            this.dsOxygen = new AppSvrHMI.L3DataSet();
            this.schemadsOxygen = new System.Data.DataTable();
            this.coldsOxygenL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsOxygenL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsOxygenL3DataTableOxygen_Content = new System.Data.DataColumn();
            this.coldsOxygenL3DataTableMeasureTime = new System.Data.DataColumn();
            this.bsMat = new System.Windows.Forms.BindingSource(this.components);
            this.dsMat = new AppSvrHMI.L3DataSet();
            this.schemadsMat = new System.Data.DataTable();
            this.coldsMatL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMatL3DataTableName = new System.Data.DataColumn();
            this.coldsMatL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsMatL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsMatL3DataTableElement = new System.Data.DataColumn();
            this.coldsMatL3DataTableWeight = new System.Data.DataColumn();
            this.coldsMatL3DataTableDischarge_Time = new System.Data.DataColumn();
            this.coldsMatL3DataTableType = new System.Data.DataColumn();
            this.coldsMatL3DataTableBatch_ID = new System.Data.DataColumn();
            this.coldsMatL3DataTableArea = new System.Data.DataColumn();
            this.coldsMatL3DataTableEnableFlag = new System.Data.DataColumn();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.tabCtrlMain = new System.Windows.Forms.TabControl();
            this.tabBase = new System.Windows.Forms.TabPage();
            this.cmbShift = new PxDataValid.PxComboBox();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbTeam = new PxDataValid.PxComboBox();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxSecondHand = new PxDataValid.PxTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxAssistant = new PxDataValid.PxTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxHeadFurnace = new PxDataValid.PxTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSteelGradeIndex = new PxDataValid.PxTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPreHeatID = new PxDataValid.PxTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBase = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBaseCancel = new System.Windows.Forms.Button();
            this.tabLFAddMat = new System.Windows.Forms.TabPage();
            this.hmiRootPanel2 = new HMIBase.HMIRootPanel();
            this.cmb_Mat = new System.Windows.Forms.ComboBox();
            this.bsMat_Alloy_Add_Man = new System.Windows.Forms.BindingSource(this.components);
            this.dsMat_Alloy_Add_Man = new AppSvrHMI.L3DataSet();
            this.schemadsMat_Alloy_Add_Man = new System.Data.DataTable();
            this.coldsMat_Alloy_Add_ManL3DataTablebatch_id = new System.Data.DataColumn();
            this.coldsMat_Alloy_Add_ManL3DataTableAlloy_Code = new System.Data.DataColumn();
            this.coldsMat_Alloy_Add_ManL3DataTableCode = new System.Data.DataColumn();
            this.coldsMat_Alloy_Add_ManL3DataTableCode_des = new System.Data.DataColumn();
            this.dvMat = new System.Windows.Forms.DataGridView();
            this.treatNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Element = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCode = new AppSvrHMI.L3DataSet();
            this.schemadsCode = new System.Data.DataTable();
            this.coldsCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dischargeTimeDataGridViewTextBoxColumn = new DataGridValid.CalendarColumn();
            this.Batch_ID_Mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsAdditionType = new AppSvrHMI.L3DataSet();
            this.schemadsAdditionType = new System.Data.DataTable();
            this.coldsAdditionTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsAdditionTypeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.EnableFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnAddMat = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlMat = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMatCancel = new System.Windows.Forms.Button();
            this.tabWire = new System.Windows.Forms.TabPage();
            this.hmiRootPanel3 = new HMIBase.HMIRootPanel();
            this.cmb_Wire = new System.Windows.Forms.ComboBox();
            this.bsWire_Add_man = new System.Windows.Forms.BindingSource(this.components);
            this.dsWire_Add_man = new AppSvrHMI.L3DataSet();
            this.schemadsWire_Add_man = new System.Data.DataTable();
            this.coldsWire_Add_manL3DataTablealloy_code = new System.Data.DataColumn();
            this.coldsWire_Add_manL3DataTablebatch_id = new System.Data.DataColumn();
            this.coldsWire_Add_manL3DataTablecode = new System.Data.DataColumn();
            this.coldsWire_Add_manL3DataTablecode_des = new System.Data.DataColumn();
            this.coldsWire_Add_manL3DataTablecode_function_group = new System.Data.DataColumn();
            this.dvWire = new System.Windows.Forms.DataGridView();
            this.treatNoDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WireCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsWireCode = new AppSvrHMI.L3DataSet();
            this.schemadsWireCode = new System.Data.DataTable();
            this.coldsWireCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsWireCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batch_ID_Wire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wireTimeDataGridViewTextBoxColumn = new DataGridValid.CalendarColumn();
            this.Name_Wire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsWire = new System.Windows.Forms.BindingSource(this.components);
            this.dsWire = new AppSvrHMI.L3DataSet();
            this.schemadsWire = new System.Data.DataTable();
            this.coldsWireL3DataTableGUID = new System.Data.DataColumn();
            this.coldsWireL3DataTableName = new System.Data.DataColumn();
            this.coldsWireL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsWireL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsWireL3DataTableWireCode = new System.Data.DataColumn();
            this.coldsWireL3DataTableWeight = new System.Data.DataColumn();
            this.coldsWireL3DataTableSpeed = new System.Data.DataColumn();
            this.coldsWireL3DataTableWireTime = new System.Data.DataColumn();
            this.coldsWireL3DataTableBatch_ID = new System.Data.DataColumn();
            this.coldsWireL3DataTableEnableFlag = new System.Data.DataColumn();
            this.coldsWireL3DataTableAmount = new System.Data.DataColumn();
            this.pnlWire = new System.Windows.Forms.FlowLayoutPanel();
            this.btnWireCancel = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox7 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.tabProcess = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbArrivalTempQuality = new System.Windows.Forms.ComboBox();
            this.dsYesNo = new AppSvrHMI.L3DataSet();
            this.schemadsYesNo = new System.Data.DataTable();
            this.coldsYesNoL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsYesNoL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.txtSoftBlowTimeDis = new PxDataValid.PxTextBox();
            this.txtSoftBlowTime = new PxDataValid.PxTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtWireEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtSoftBlowStopTime = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtWireEndTemp = new PxDataValid.PxTextBox();
            this.txtAlCONS = new PxDataValid.PxTextBox();
            this.txtOBCount = new PxDataValid.PxTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.txtLadleGrade = new PxDataValid.PxTextBox();
            this.txtTotalTime = new PxDataValid.PxTextBox();
            this.txtLadleNo = new PxDataValid.PxTextBox();
            this.txtOBCycleTime = new PxDataValid.PxTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txt02CONS = new PxDataValid.PxTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtVacMin = new PxDataValid.PxTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.txtLoopTime = new PxDataValid.PxTextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txtProbeVonder = new PxDataValid.PxTextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.dtSoftBlowStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.txtProcessTimeDis = new PxDataValid.PxTextBox();
            this.txtProcessTime = new PxDataValid.PxTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtSlotNo = new PxDataValid.PxTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtSlagThick = new PxDataValid.PxTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtDepartureTemp = new PxDataValid.PxTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtProcessMode = new PxDataValid.PxTextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtProcessLocation = new PxDataValid.PxTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtArrivalTemp = new PxDataValid.PxTextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.pnlProcess = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProcessCancel = new System.Windows.Forms.Button();
            this.tabLadleInfo = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bsLadleInfo = new System.Windows.Forms.BindingSource(this.components);
            this.dsLadleInfo = new AppSvrHMI.L3DataSet();
            this.schemadsLadleInfo = new System.Data.DataTable();
            this.coldsLadleInfoL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableLadleID = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableLast_Ladle_Grade = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableTemp = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableLast_SteelGrade = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableAct_Ladle_Grade = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableCur_SteelGrade = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableIn_Ladle_Grade = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableStop_Time_Len = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableLadle_Age = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableSmall_Fire = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableMiddle_Fire = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableBig_Fire = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableNote = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableOther1 = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableOther2 = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableOther3 = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableMaxTemp = new System.Data.DataColumn();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.pnlLadleInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLadleInfoCancel = new System.Windows.Forms.Button();
            this.tabExcept = new System.Windows.Forms.TabPage();
            this.dvExcept = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exceptionalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsExceptCode = new AppSvrHMI.L3DataSet();
            this.schemadsExceptCode = new System.Data.DataTable();
            this.coldsExceptCodeL3DataTableGUID = new System.Data.DataColumn();
            this.coldsExceptCodeL3DataTableName = new System.Data.DataColumn();
            this.coldsExceptCodeL3DataTableExceptional_Code = new System.Data.DataColumn();
            this.coldsExceptCodeL3DataTableExceptional_Des = new System.Data.DataColumn();
            this.coldsExceptCodeL3DataTableUnit = new System.Data.DataColumn();
            this.coldsExceptCodeL3DataTableAuto_Judge_Flag = new System.Data.DataColumn();
            this.exceptionalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDObjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitTypeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preHeatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preSteelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decideCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classifyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsExcept = new System.Windows.Forms.BindingSource(this.components);
            this.dsExcept = new AppSvrHMI.L3DataSet();
            this.schemadsExcept = new System.Data.DataTable();
            this.coldsExceptL3DataTableGUID = new System.Data.DataColumn();
            this.coldsExceptL3DataTableName = new System.Data.DataColumn();
            this.coldsExceptL3DataTableID_Object = new System.Data.DataColumn();
            this.coldsExceptL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsExceptL3DataTableProcess_Count = new System.Data.DataColumn();
            this.coldsExceptL3DataTableUnitTypeID = new System.Data.DataColumn();
            this.coldsExceptL3DataTableUnitID = new System.Data.DataColumn();
            this.coldsExceptL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsExceptL3DataTablePre_SteelGradeIndex = new System.Data.DataColumn();
            this.coldsExceptL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsExceptL3DataTableExceptional_Code = new System.Data.DataColumn();
            this.coldsExceptL3DataTableDecide_Code = new System.Data.DataColumn();
            this.coldsExceptL3DataTableClassify = new System.Data.DataColumn();
            this.coldsExceptL3DataTableExceptional_Time = new System.Data.DataColumn();
            this.fLPExcept = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancelExcept = new System.Windows.Forms.Button();
            this.bdExcept = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem7 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem7 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem7 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem7 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem7 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem7 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator23 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelExcept = new System.Windows.Forms.ToolStripButton();
            this.tabChemical = new System.Windows.Forms.TabPage();
            this.dvChemical = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arriveDateDataGridViewTextBoxColumn = new DataGridValid.CalendarColumn();
            this.reportDateDataGridViewTextBoxColumn = new DataGridValid.CalendarColumn();
            this.unitTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsUnitType = new AppSvrHMI.L3DataSet();
            this.schemadsUnitType = new System.Data.DataTable();
            this.coldsUnitTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsUnitTypeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsSampleAddr = new AppSvrHMI.L3DataSet();
            this.schemadsSampleAddr = new System.Data.DataTable();
            this.coldsSampleAddrL3DataTableCode = new System.Data.DataColumn();
            this.coldsSampleAddrL3DataTableCode_Des = new System.Data.DataColumn();
            this.sampleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsSampleType = new AppSvrHMI.L3DataSet();
            this.schemadsSampleType = new System.Data.DataTable();
            this.coldsSampleTypeL3DataTableCode = new System.Data.DataColumn();
            this.coldsSampleTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.sampleCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.znDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrNi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrNiCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Other3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logTimeDataGridViewTextBoxColumn1 = new DataGridValid.CalendarColumn();
            this.dataLogModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsDataLogMode = new AppSvrHMI.L3DataSet();
            this.schemadsDataLogMode = new System.Data.DataTable();
            this.coldsDataLogModeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsDataLogModeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.bsChemical = new System.Windows.Forms.BindingSource(this.components);
            this.bnChemical = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton27 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton28 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox6 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton29 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton30 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddChemical = new System.Windows.Forms.ToolStripButton();
            this.pnlChemical = new System.Windows.Forms.FlowLayoutPanel();
            this.btnChemicalCancel = new System.Windows.Forms.Button();
            this.btnChemicalOK = new System.Windows.Forms.Button();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.dvStatus = new System.Windows.Forms.DataGridView();
            this.treatNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsRHStatus = new AppSvrHMI.L3DataSet();
            this.schemadsRHStatus = new System.Data.DataTable();
            this.coldsRHStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsRHStatusL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.changeTimeDataGridViewTextBoxColumn = new DataGridValid.CalendarColumn();
            this.gUIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnStatus = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton22 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton23 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox5 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton24 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton25 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddStatus = new System.Windows.Forms.ToolStripButton();
            this.pnlStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStatusCancel = new System.Windows.Forms.Button();
            this.btnStatusOK = new System.Windows.Forms.Button();
            this.tabTemp = new System.Windows.Forms.TabPage();
            this.hmiRootPanel6 = new HMIBase.HMIRootPanel();
            this.dvTemp = new System.Windows.Forms.DataGridView();
            this.treatNoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureTimeDataGridViewTextBoxColumn = new DataGridValid.CalendarColumn();
            this.measureModeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsBOFTempMode = new AppSvrHMI.L3DataSet();
            this.schemadsBOFTempMode = new System.Data.DataTable();
            this.coldsBOFTempModeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsBOFTempModeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.gUIDDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnTemp = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton17 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton19 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton20 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddTemp = new System.Windows.Forms.ToolStripButton();
            this.pnlTemp = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTempCancel = new System.Windows.Forms.Button();
            this.btnTempOK = new System.Windows.Forms.Button();
            this.tabOxygen = new System.Windows.Forms.TabPage();
            this.dvOxygen = new System.Windows.Forms.DataGridView();
            this.treatNoDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oxygenContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasureTime = new DataGridValid.CalendarColumn();
            this.bnOxygen = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddOxygen = new System.Windows.Forms.ToolStripButton();
            this.pnlOxygen = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOxygenCancel = new System.Windows.Forms.Button();
            this.btnOxygenOK = new System.Windows.Forms.Button();
            this.tabRemark = new System.Windows.Forms.TabPage();
            this.dvRemark = new System.Windows.Forms.DataGridView();
            this.treatNoDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsRemarkType = new AppSvrHMI.L3DataSet();
            this.schemadsRemarkType = new System.Data.DataTable();
            this.coldsRemarkTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsRemarkTypeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.logTimeDataGridViewTextBoxColumn = new DataGridValid.CalendarColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlNote = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNoteCancel = new System.Windows.Forms.Button();
            this.tabTundishTemp = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCCMTempMode = new AppSvrHMI.L3DataSet();
            this.schemadsCCMTempMode = new System.Data.DataTable();
            this.coldsCCMTempModeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsCCMTempModeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.tempDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureTimeDataGridViewTextBoxColumn1 = new DataGridValid.CalendarColumn();
            this.inValidFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTundishTemp = new System.Windows.Forms.BindingSource(this.components);
            this.dsTundishTemp = new AppSvrHMI.L3DataSet();
            this.schemadsTundishTemp = new System.Data.DataTable();
            this.coldsTundishTempL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsTundishTempL3DataTableCCMID = new System.Data.DataColumn();
            this.coldsTundishTempL3DataTableTempID = new System.Data.DataColumn();
            this.coldsTundishTempL3DataTableTemp = new System.Data.DataColumn();
            this.coldsTundishTempL3DataTableMeasure_Time = new System.Data.DataColumn();
            this.coldsTundishTempL3DataTableInValidFlag = new System.Data.DataColumn();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panl = new System.Windows.Forms.Panel();
            this.tbxTreatNo = new PxDataValid.PxTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxHeatID = new PxDataValid.PxTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableGUID = new System.Data.DataColumn();
            this.coldsErrorL3DataTableName = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Code = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Des = new System.Data.DataColumn();
            this.coldsErrorL3DataTableOwner = new System.Data.DataColumn();
            this.coldsErrorL3DataTableOwner_Des = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Val_Long = new System.Data.DataColumn();
            this.cmdHeatExcept = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpHeatID = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.cmdTotalTime = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.dsWholePumpTime = new AppSvrHMI.L3DataSet();
            this.schemadsWholePumpTime = new System.Data.DataTable();
            this.coldsWholePumpTimeL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsWholePumpTimeL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsWholePumpTimeL3DataTableWholePump_Time = new System.Data.DataColumn();
            this.bsWholePumpTime = new System.Windows.Forms.BindingSource(this.components);
            this.label36 = new System.Windows.Forms.Label();
            this.txtWholePumpTimeDis = new PxDataValid.PxTextBox();
            this.txtWholePumpTime = new PxDataValid.PxTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnRemark)).BeginInit();
            this.bnRemark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChemical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsChemical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOxygen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOxygen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOxygen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMat)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            this.tabCtrlMain.SuspendLayout();
            this.tabBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            this.pnlBase.SuspendLayout();
            this.tabLFAddMat.SuspendLayout();
            this.hmiRootPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMat_Alloy_Add_Man)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMat_Alloy_Add_Man)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMat_Alloy_Add_Man)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdditionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAdditionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnAddMat)).BeginInit();
            this.bnAddMat.SuspendLayout();
            this.pnlMat.SuspendLayout();
            this.tabWire.SuspendLayout();
            this.hmiRootPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsWire_Add_man)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWire_Add_man)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWire_Add_man)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvWire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWireCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWireCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWire)).BeginInit();
            this.pnlWire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tabProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsYesNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsYesNo)).BeginInit();
            this.pnlProcess.SuspendLayout();
            this.tabLadleInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLadleInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleInfo)).BeginInit();
            this.pnlLadleInfo.SuspendLayout();
            this.tabExcept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvExcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExceptCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsExceptCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsExcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsExcept)).BeginInit();
            this.fLPExcept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdExcept)).BeginInit();
            this.bdExcept.SuspendLayout();
            this.tabChemical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvChemical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataLogMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDataLogMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsChemical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnChemical)).BeginInit();
            this.bnChemical.SuspendLayout();
            this.pnlChemical.SuspendLayout();
            this.tabStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRHStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRHStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnStatus)).BeginInit();
            this.bnStatus.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.tabTemp.SuspendLayout();
            this.hmiRootPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFTempMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFTempMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnTemp)).BeginInit();
            this.bnTemp.SuspendLayout();
            this.pnlTemp.SuspendLayout();
            this.tabOxygen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvOxygen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnOxygen)).BeginInit();
            this.bnOxygen.SuspendLayout();
            this.pnlOxygen.SuspendLayout();
            this.tabRemark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRemarkType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRemarkType)).BeginInit();
            this.pnlNote.SuspendLayout();
            this.tabTundishTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCCMTempMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCCMTempMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTundishTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundishTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.panl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWholePumpTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWholePumpTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWholePumpTime)).BeginInit();
            this.SuspendLayout();
            // 
            // bsTemp
            // 
            this.bsTemp.DataMember = "L3DataTable";
            this.bsTemp.DataSource = this.dsTemp;
            // 
            // dsTemp
            // 
            this.dsTemp.AutoLoad = true;
            this.dsTemp.AutoSubscribe = false;
            this.dsTemp.DataSetName = "L3DataSet";
            this.dsTemp.DeleteMethod = null;
            this.dsTemp.InsertMethod = null;
            this.dsTemp.L3DataAdapter = null;
            this.dsTemp.LoadEvent = "Click";
            this.dsTemp.LoadTrigger = null;
            this.dsTemp.RefreshValve = 1000;
            this.dsTemp.SourceCommand = null;
            this.dsTemp.SourceCondition = null;
            this.dsTemp.SourceMethod = "";
            this.dsTemp.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTemp.SourceURI = "XGMESLogic\\RHMag\\CRH_Temp_Data";
            this.dsTemp.SubscribeTarget = null;
            this.dsTemp.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet2});
            this.dsTemp.UpdateEvent = "Click";
            this.dsTemp.UpdateMethod = null;
            this.dsTemp.UpdateTrigger = null;
            // 
            // schemal3DataSet2
            // 
            this.schemal3DataSet2.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet2L3DataTableGUID,
            this.coll3DataSet2L3DataTableName,
            this.coll3DataSet2L3DataTableTreatNo,
            this.coll3DataSet2L3DataTableHeatID,
            this.coll3DataSet2L3DataTableTemp,
            this.coll3DataSet2L3DataTableMeasureTime,
            this.coll3DataSet2L3DataTableMeasureMode});
            this.schemal3DataSet2.TableName = "L3DataTable";
            // 
            // coll3DataSet2L3DataTableGUID
            // 
            this.coll3DataSet2L3DataTableGUID.Caption = "GUID";
            this.coll3DataSet2L3DataTableGUID.ColumnName = "GUID";
            this.coll3DataSet2L3DataTableGUID.Namespace = "";
            // 
            // coll3DataSet2L3DataTableName
            // 
            this.coll3DataSet2L3DataTableName.Caption = "Name";
            this.coll3DataSet2L3DataTableName.ColumnName = "Name";
            this.coll3DataSet2L3DataTableName.Namespace = "";
            // 
            // coll3DataSet2L3DataTableTreatNo
            // 
            this.coll3DataSet2L3DataTableTreatNo.Caption = "TreatNo";
            this.coll3DataSet2L3DataTableTreatNo.ColumnName = "TreatNo";
            this.coll3DataSet2L3DataTableTreatNo.Namespace = "";
            // 
            // coll3DataSet2L3DataTableHeatID
            // 
            this.coll3DataSet2L3DataTableHeatID.Caption = "HeatID";
            this.coll3DataSet2L3DataTableHeatID.ColumnName = "HeatID";
            this.coll3DataSet2L3DataTableHeatID.Namespace = "";
            // 
            // coll3DataSet2L3DataTableTemp
            // 
            this.coll3DataSet2L3DataTableTemp.Caption = "Temp";
            this.coll3DataSet2L3DataTableTemp.ColumnName = "Temp";
            this.coll3DataSet2L3DataTableTemp.DataType = typeof(int);
            this.coll3DataSet2L3DataTableTemp.Namespace = "";
            // 
            // coll3DataSet2L3DataTableMeasureTime
            // 
            this.coll3DataSet2L3DataTableMeasureTime.Caption = "MeasureTime";
            this.coll3DataSet2L3DataTableMeasureTime.ColumnName = "MeasureTime";
            this.coll3DataSet2L3DataTableMeasureTime.DataType = typeof(System.DateTime);
            this.coll3DataSet2L3DataTableMeasureTime.Namespace = "";
            // 
            // coll3DataSet2L3DataTableMeasureMode
            // 
            this.coll3DataSet2L3DataTableMeasureMode.Caption = "MeasureMode";
            this.coll3DataSet2L3DataTableMeasureMode.ColumnName = "MeasureMode";
            this.coll3DataSet2L3DataTableMeasureMode.DataType = typeof(short);
            this.coll3DataSet2L3DataTableMeasureMode.Namespace = "";
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnBaseOK
            // 
            this.Adapter.SetAccessRight(this.btnBaseOK, "RHCheck");
            this.btnBaseOK.Location = new System.Drawing.Point(825, 3);
            this.btnBaseOK.Name = "btnBaseOK";
            this.btnBaseOK.Size = new System.Drawing.Size(75, 23);
            this.btnBaseOK.TabIndex = 86;
            this.btnBaseOK.Text = "确认";
            this.btnBaseOK.UseVisualStyleBackColor = true;
            this.btnBaseOK.Click += new System.EventHandler(this.btnBaseOK_Click);
            // 
            // btnPaocessOK
            // 
            this.Adapter.SetAccessRight(this.btnPaocessOK, "RHCheck");
            this.btnPaocessOK.Location = new System.Drawing.Point(825, 3);
            this.btnPaocessOK.Name = "btnPaocessOK";
            this.btnPaocessOK.Size = new System.Drawing.Size(75, 23);
            this.btnPaocessOK.TabIndex = 86;
            this.btnPaocessOK.Text = "确认";
            this.btnPaocessOK.UseVisualStyleBackColor = true;
            this.btnPaocessOK.Click += new System.EventHandler(this.btnPaocessOK_Click);
            // 
            // btnConfirmExcept
            // 
            this.Adapter.SetAccessRight(this.btnConfirmExcept, "RHCheck");
            this.btnConfirmExcept.Location = new System.Drawing.Point(827, 3);
            this.btnConfirmExcept.Name = "btnConfirmExcept";
            this.btnConfirmExcept.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmExcept.TabIndex = 86;
            this.btnConfirmExcept.Text = "确认";
            this.btnConfirmExcept.UseVisualStyleBackColor = true;
            this.btnConfirmExcept.Click += new System.EventHandler(this.btnConfirmExcept_Click);
            // 
            // btnAddExcept
            // 
            this.Adapter.SetAccessRight(this.btnAddExcept, "RHCheck");
            this.btnAddExcept.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddExcept.Image = ((System.Drawing.Image)(resources.GetObject("btnAddExcept.Image")));
            this.btnAddExcept.Name = "btnAddExcept";
            this.btnAddExcept.RightToLeftAutoMirrorImage = true;
            this.btnAddExcept.Size = new System.Drawing.Size(23, 22);
            this.btnAddExcept.Text = "新添";
            this.btnAddExcept.Click += new System.EventHandler(this.btnAddExcept_Click);
            // 
            // bnRemark
            // 
            this.Adapter.SetAccessRight(this.bnRemark, "RHCheck");
            this.bnRemark.AddNewItem = null;
            this.bnRemark.BindingSource = this.bsRemark;
            this.bnRemark.CountItem = this.toolStripLabel2;
            this.bnRemark.DeleteItem = null;
            this.bnRemark.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripSeparator6,
            this.btnAddRemark});
            this.bnRemark.Location = new System.Drawing.Point(3, 3);
            this.bnRemark.MoveFirstItem = this.toolStripButton7;
            this.bnRemark.MoveLastItem = this.toolStripButton10;
            this.bnRemark.MoveNextItem = this.toolStripButton9;
            this.bnRemark.MovePreviousItem = this.toolStripButton8;
            this.bnRemark.Name = "bnRemark";
            this.bnRemark.PositionItem = this.toolStripTextBox2;
            this.bnRemark.Size = new System.Drawing.Size(988, 25);
            this.bnRemark.TabIndex = 96;
            this.bnRemark.Text = "bindingNavigator1";
            // 
            // bsRemark
            // 
            this.bsRemark.DataMember = "L3DataTable";
            this.bsRemark.DataSource = this.dsRemark;
            // 
            // dsRemark
            // 
            this.dsRemark.AutoLoad = true;
            this.dsRemark.AutoSubscribe = false;
            this.dsRemark.DataSetName = "L3DataSet";
            this.dsRemark.DeleteMethod = null;
            this.dsRemark.InsertMethod = null;
            this.dsRemark.L3DataAdapter = null;
            this.dsRemark.LoadEvent = "Click";
            this.dsRemark.LoadTrigger = null;
            this.dsRemark.RefreshValve = 1000;
            this.dsRemark.SourceCommand = null;
            this.dsRemark.SourceCondition = null;
            this.dsRemark.SourceMethod = "";
            this.dsRemark.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsRemark.SourceURI = "XGMESLogic\\RHMag\\CRH_HeatRemark";
            this.dsRemark.SubscribeTarget = null;
            this.dsRemark.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsRemark});
            this.dsRemark.UpdateEvent = "Click";
            this.dsRemark.UpdateMethod = null;
            this.dsRemark.UpdateTrigger = null;
            // 
            // schemadsRemark
            // 
            this.schemadsRemark.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsRemarkL3DataTableGUID,
            this.coldsRemarkL3DataTableName,
            this.coldsRemarkL3DataTableTreatNo,
            this.coldsRemarkL3DataTableHeatID,
            this.coldsRemarkL3DataTableType,
            this.coldsRemarkL3DataTableRemark,
            this.coldsRemarkL3DataTableLogTime});
            this.schemadsRemark.TableName = "L3DataTable";
            // 
            // coldsRemarkL3DataTableGUID
            // 
            this.coldsRemarkL3DataTableGUID.Caption = "GUID";
            this.coldsRemarkL3DataTableGUID.ColumnName = "GUID";
            this.coldsRemarkL3DataTableGUID.Namespace = "";
            // 
            // coldsRemarkL3DataTableName
            // 
            this.coldsRemarkL3DataTableName.Caption = "Name";
            this.coldsRemarkL3DataTableName.ColumnName = "Name";
            this.coldsRemarkL3DataTableName.Namespace = "";
            // 
            // coldsRemarkL3DataTableTreatNo
            // 
            this.coldsRemarkL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsRemarkL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsRemarkL3DataTableTreatNo.Namespace = "";
            // 
            // coldsRemarkL3DataTableHeatID
            // 
            this.coldsRemarkL3DataTableHeatID.Caption = "HeatID";
            this.coldsRemarkL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsRemarkL3DataTableHeatID.Namespace = "";
            // 
            // coldsRemarkL3DataTableType
            // 
            this.coldsRemarkL3DataTableType.Caption = "Type";
            this.coldsRemarkL3DataTableType.ColumnName = "Type";
            this.coldsRemarkL3DataTableType.DataType = typeof(short);
            this.coldsRemarkL3DataTableType.Namespace = "";
            // 
            // coldsRemarkL3DataTableRemark
            // 
            this.coldsRemarkL3DataTableRemark.Caption = "Remark";
            this.coldsRemarkL3DataTableRemark.ColumnName = "Remark";
            this.coldsRemarkL3DataTableRemark.Namespace = "";
            // 
            // coldsRemarkL3DataTableLogTime
            // 
            this.coldsRemarkL3DataTableLogTime.Caption = "LogTime";
            this.coldsRemarkL3DataTableLogTime.ColumnName = "LogTime";
            this.coldsRemarkL3DataTableLogTime.DataType = typeof(System.DateTime);
            this.coldsRemarkL3DataTableLogTime.Namespace = "";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel2.Text = "/ {0}";
            this.toolStripLabel2.ToolTipText = "总项数";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "移到第一条记录";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "移到上一条记录";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "位置";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "当前位置";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "移到下一条记录";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "移到最后一条记录";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddRemark
            // 
            this.btnAddRemark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddRemark.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRemark.Image")));
            this.btnAddRemark.Name = "btnAddRemark";
            this.btnAddRemark.RightToLeftAutoMirrorImage = true;
            this.btnAddRemark.Size = new System.Drawing.Size(23, 22);
            this.btnAddRemark.Text = "新添";
            this.btnAddRemark.Click += new System.EventHandler(this.btnAddRemark_Click);
            // 
            // btnNoteConfirm
            // 
            this.Adapter.SetAccessRight(this.btnNoteConfirm, "RHCheck");
            this.btnNoteConfirm.Location = new System.Drawing.Point(825, 3);
            this.btnNoteConfirm.Name = "btnNoteConfirm";
            this.btnNoteConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnNoteConfirm.TabIndex = 86;
            this.btnNoteConfirm.Text = "确认";
            this.btnNoteConfirm.UseVisualStyleBackColor = true;
            this.btnNoteConfirm.Click += new System.EventHandler(this.btnNoteConfirm_Click);
            // 
            // btnAddMat
            // 
            this.Adapter.SetAccessRight(this.btnAddMat, "RHCheck");
            this.btnAddMat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddMat.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMat.Image")));
            this.btnAddMat.Name = "btnAddMat";
            this.btnAddMat.RightToLeftAutoMirrorImage = true;
            this.btnAddMat.Size = new System.Drawing.Size(23, 22);
            this.btnAddMat.Text = "新添";
            this.btnAddMat.Click += new System.EventHandler(this.btnAddMat_Click);
            // 
            // btnMatOK
            // 
            this.Adapter.SetAccessRight(this.btnMatOK, "RHCheck");
            this.btnMatOK.Location = new System.Drawing.Point(827, 3);
            this.btnMatOK.Name = "btnMatOK";
            this.btnMatOK.Size = new System.Drawing.Size(75, 23);
            this.btnMatOK.TabIndex = 86;
            this.btnMatOK.Text = "确认";
            this.btnMatOK.UseVisualStyleBackColor = true;
            this.btnMatOK.Click += new System.EventHandler(this.btnMatOK_Click);
            // 
            // btnWireConfirm
            // 
            this.Adapter.SetAccessRight(this.btnWireConfirm, "RHCheck");
            this.btnWireConfirm.Location = new System.Drawing.Point(827, 3);
            this.btnWireConfirm.Name = "btnWireConfirm";
            this.btnWireConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnWireConfirm.TabIndex = 86;
            this.btnWireConfirm.Text = "确认";
            this.btnWireConfirm.UseVisualStyleBackColor = true;
            this.btnWireConfirm.Click += new System.EventHandler(this.btnWireConfirm_Click);
            // 
            // btnWireAdd
            // 
            this.Adapter.SetAccessRight(this.btnWireAdd, "RHCheck");
            this.btnWireAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnWireAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnWireAdd.Image")));
            this.btnWireAdd.Name = "btnWireAdd";
            this.btnWireAdd.RightToLeftAutoMirrorImage = true;
            this.btnWireAdd.Size = new System.Drawing.Size(23, 22);
            this.btnWireAdd.Text = "新添";
            this.btnWireAdd.Click += new System.EventHandler(this.btnWireAdd_Click);
            // 
            // btnLadleInfoOK
            // 
            this.Adapter.SetAccessRight(this.btnLadleInfoOK, "RHCheck");
            this.btnLadleInfoOK.Location = new System.Drawing.Point(831, 3);
            this.btnLadleInfoOK.Name = "btnLadleInfoOK";
            this.btnLadleInfoOK.Size = new System.Drawing.Size(75, 23);
            this.btnLadleInfoOK.TabIndex = 86;
            this.btnLadleInfoOK.Text = "确认";
            this.btnLadleInfoOK.UseVisualStyleBackColor = true;
            this.btnLadleInfoOK.Click += new System.EventHandler(this.btnLadleInfoOK_Click);
            // 
            // btnDelete
            // 
            this.Adapter.SetAccessRight(this.btnDelete, "RHbtnDelete");
            this.btnDelete.Location = new System.Drawing.Point(746, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 86;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bsStatus
            // 
            this.bsStatus.DataMember = "L3DataTable";
            this.bsStatus.DataSource = this.dsStatus;
            // 
            // dsStatus
            // 
            this.dsStatus.AutoLoad = true;
            this.dsStatus.AutoSubscribe = false;
            this.dsStatus.DataSetName = "L3DataSet";
            this.dsStatus.DeleteMethod = null;
            this.dsStatus.InsertMethod = null;
            this.dsStatus.L3DataAdapter = null;
            this.dsStatus.LoadEvent = "Click";
            this.dsStatus.LoadTrigger = null;
            this.dsStatus.RefreshValve = 1000;
            this.dsStatus.SourceCommand = null;
            this.dsStatus.SourceCondition = null;
            this.dsStatus.SourceMethod = "";
            this.dsStatus.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStatus.SourceURI = "XGMESLogic\\RHMag\\CRH_Process_Satus";
            this.dsStatus.SubscribeTarget = null;
            this.dsStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet1});
            this.dsStatus.UpdateEvent = "Click";
            this.dsStatus.UpdateMethod = null;
            this.dsStatus.UpdateTrigger = null;
            // 
            // schemal3DataSet1
            // 
            this.schemal3DataSet1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet1L3DataTableGUID,
            this.coll3DataSet1L3DataTableName,
            this.coll3DataSet1L3DataTableTreatNo,
            this.coll3DataSet1L3DataTableHeatID,
            this.coll3DataSet1L3DataTableStatus,
            this.coll3DataSet1L3DataTableChange_Time});
            this.schemal3DataSet1.TableName = "L3DataTable";
            // 
            // coll3DataSet1L3DataTableGUID
            // 
            this.coll3DataSet1L3DataTableGUID.Caption = "GUID";
            this.coll3DataSet1L3DataTableGUID.ColumnName = "GUID";
            this.coll3DataSet1L3DataTableGUID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableName
            // 
            this.coll3DataSet1L3DataTableName.Caption = "Name";
            this.coll3DataSet1L3DataTableName.ColumnName = "Name";
            this.coll3DataSet1L3DataTableName.Namespace = "";
            // 
            // coll3DataSet1L3DataTableTreatNo
            // 
            this.coll3DataSet1L3DataTableTreatNo.Caption = "TreatNo";
            this.coll3DataSet1L3DataTableTreatNo.ColumnName = "TreatNo";
            this.coll3DataSet1L3DataTableTreatNo.Namespace = "";
            // 
            // coll3DataSet1L3DataTableHeatID
            // 
            this.coll3DataSet1L3DataTableHeatID.Caption = "HeatID";
            this.coll3DataSet1L3DataTableHeatID.ColumnName = "HeatID";
            this.coll3DataSet1L3DataTableHeatID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableStatus
            // 
            this.coll3DataSet1L3DataTableStatus.Caption = "Status";
            this.coll3DataSet1L3DataTableStatus.ColumnName = "Status";
            this.coll3DataSet1L3DataTableStatus.DataType = typeof(int);
            this.coll3DataSet1L3DataTableStatus.Namespace = "";
            // 
            // coll3DataSet1L3DataTableChange_Time
            // 
            this.coll3DataSet1L3DataTableChange_Time.Caption = "Change_Time";
            this.coll3DataSet1L3DataTableChange_Time.ColumnName = "Change_Time";
            this.coll3DataSet1L3DataTableChange_Time.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableChange_Time.Namespace = "";
            // 
            // bsProcess
            // 
            this.bsProcess.DataMember = "L3DataTable";
            this.bsProcess.DataSource = this.dsProcess;
            // 
            // dsProcess
            // 
            this.dsProcess.AutoLoad = true;
            this.dsProcess.AutoSubscribe = false;
            this.dsProcess.DataSetName = "L3DataSet";
            this.dsProcess.DeleteMethod = null;
            this.dsProcess.InsertMethod = null;
            this.dsProcess.L3DataAdapter = null;
            this.dsProcess.LoadEvent = "Click";
            this.dsProcess.LoadTrigger = null;
            this.dsProcess.RefreshValve = 1000;
            this.dsProcess.SourceCommand = null;
            this.dsProcess.SourceCondition = null;
            this.dsProcess.SourceMethod = "";
            this.dsProcess.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsProcess.SourceURI = "XGMESLogic\\RHMag\\CRH_Process_Data";
            this.dsProcess.SubscribeTarget = null;
            this.dsProcess.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsProcess});
            this.dsProcess.UpdateEvent = "Click";
            this.dsProcess.UpdateMethod = null;
            this.dsProcess.UpdateTrigger = null;
            // 
            // schemadsProcess
            // 
            this.schemadsProcess.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsProcessL3DataTableGUID,
            this.coldsProcessL3DataTableName,
            this.coldsProcessL3DataTableLogDate,
            this.coldsProcessL3DataTableMaterialType,
            this.coldsProcessL3DataTableMaterialID,
            this.coldsProcessL3DataTableAmount,
            this.coldsProcessL3DataTableTargetArea,
            this.coldsProcessL3DataTableOperator,
            this.coldsProcessL3DataTableShift,
            this.coldsProcessL3DataTableTeam,
            this.coldsProcessL3DataTableTreatNo,
            this.coldsProcessL3DataTableHeatID,
            this.coldsProcessL3DataTableArrival_Time,
            this.coldsProcessL3DataTableArrival_Temp,
            this.coldsProcessL3DataTableStart_Time,
            this.coldsProcessL3DataTableEnd_Time,
            this.coldsProcessL3DataTableProcess_Time,
            this.coldsProcessL3DataTableProbe_Vonder,
            this.coldsProcessL3DataTableDeparture_Temp,
            this.coldsProcessL3DataTableSoftBlow_StartTime,
            this.coldsProcessL3DataTableSoftBlow_EndTime,
            this.coldsProcessL3DataTableSoftBlow_Time,
            this.coldsProcessL3DataTableArrival_Temp_Quality,
            this.coldsProcessL3DataTableSlag_Thick,
            this.coldsProcessL3DataTableProcess_Location,
            this.coldsProcessL3DataTableSlot_No,
            this.coldsProcessL3DataTableProcess_Mode,
            this.coldsProcessL3DataTableLoop_Time,
            this.coldsProcessL3DataTableVac_Min,
            this.coldsProcessL3DataTableOB_Count,
            this.coldsProcessL3DataTableO2_CONS,
            this.coldsProcessL3DataTableAl_CONS,
            this.coldsProcessL3DataTableOB_Cycle_Time,
            this.coldsProcessL3DataTableWire_End_Time,
            this.coldsProcessL3DataTableWire_End_Temp,
            this.coldsProcessL3DataTableCircsOfRhythm,
            this.coldsProcessL3DataTableLadleNo,
            this.coldsProcessL3DataTableLadleGrade});
            this.schemadsProcess.TableName = "L3DataTable";
            // 
            // coldsProcessL3DataTableGUID
            // 
            this.coldsProcessL3DataTableGUID.Caption = "GUID";
            this.coldsProcessL3DataTableGUID.ColumnName = "GUID";
            this.coldsProcessL3DataTableGUID.Namespace = "";
            // 
            // coldsProcessL3DataTableName
            // 
            this.coldsProcessL3DataTableName.Caption = "Name";
            this.coldsProcessL3DataTableName.ColumnName = "Name";
            this.coldsProcessL3DataTableName.Namespace = "";
            // 
            // coldsProcessL3DataTableLogDate
            // 
            this.coldsProcessL3DataTableLogDate.Caption = "LogDate";
            this.coldsProcessL3DataTableLogDate.ColumnName = "LogDate";
            this.coldsProcessL3DataTableLogDate.DataType = typeof(System.DateTime);
            this.coldsProcessL3DataTableLogDate.Namespace = "";
            // 
            // coldsProcessL3DataTableMaterialType
            // 
            this.coldsProcessL3DataTableMaterialType.Caption = "MaterialType";
            this.coldsProcessL3DataTableMaterialType.ColumnName = "MaterialType";
            this.coldsProcessL3DataTableMaterialType.Namespace = "";
            // 
            // coldsProcessL3DataTableMaterialID
            // 
            this.coldsProcessL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsProcessL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsProcessL3DataTableMaterialID.Namespace = "";
            // 
            // coldsProcessL3DataTableAmount
            // 
            this.coldsProcessL3DataTableAmount.Caption = "Amount";
            this.coldsProcessL3DataTableAmount.ColumnName = "Amount";
            this.coldsProcessL3DataTableAmount.DataType = typeof(double);
            this.coldsProcessL3DataTableAmount.Namespace = "";
            // 
            // coldsProcessL3DataTableTargetArea
            // 
            this.coldsProcessL3DataTableTargetArea.Caption = "TargetArea";
            this.coldsProcessL3DataTableTargetArea.ColumnName = "TargetArea";
            this.coldsProcessL3DataTableTargetArea.Namespace = "";
            // 
            // coldsProcessL3DataTableOperator
            // 
            this.coldsProcessL3DataTableOperator.Caption = "Operator";
            this.coldsProcessL3DataTableOperator.ColumnName = "Operator";
            this.coldsProcessL3DataTableOperator.Namespace = "";
            // 
            // coldsProcessL3DataTableShift
            // 
            this.coldsProcessL3DataTableShift.Caption = "Shift";
            this.coldsProcessL3DataTableShift.ColumnName = "Shift";
            this.coldsProcessL3DataTableShift.Namespace = "";
            // 
            // coldsProcessL3DataTableTeam
            // 
            this.coldsProcessL3DataTableTeam.Caption = "Team";
            this.coldsProcessL3DataTableTeam.ColumnName = "Team";
            this.coldsProcessL3DataTableTeam.Namespace = "";
            // 
            // coldsProcessL3DataTableTreatNo
            // 
            this.coldsProcessL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsProcessL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsProcessL3DataTableTreatNo.Namespace = "";
            // 
            // coldsProcessL3DataTableHeatID
            // 
            this.coldsProcessL3DataTableHeatID.Caption = "HeatID";
            this.coldsProcessL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsProcessL3DataTableHeatID.Namespace = "";
            // 
            // coldsProcessL3DataTableArrival_Time
            // 
            this.coldsProcessL3DataTableArrival_Time.Caption = "Arrival_Time";
            this.coldsProcessL3DataTableArrival_Time.ColumnName = "Arrival_Time";
            this.coldsProcessL3DataTableArrival_Time.DataType = typeof(System.DateTime);
            this.coldsProcessL3DataTableArrival_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableArrival_Temp
            // 
            this.coldsProcessL3DataTableArrival_Temp.Caption = "Arrival_Temp";
            this.coldsProcessL3DataTableArrival_Temp.ColumnName = "Arrival_Temp";
            this.coldsProcessL3DataTableArrival_Temp.DataType = typeof(int);
            this.coldsProcessL3DataTableArrival_Temp.Namespace = "";
            // 
            // coldsProcessL3DataTableStart_Time
            // 
            this.coldsProcessL3DataTableStart_Time.Caption = "Start_Time";
            this.coldsProcessL3DataTableStart_Time.ColumnName = "Start_Time";
            this.coldsProcessL3DataTableStart_Time.DataType = typeof(System.DateTime);
            this.coldsProcessL3DataTableStart_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableEnd_Time
            // 
            this.coldsProcessL3DataTableEnd_Time.Caption = "End_Time";
            this.coldsProcessL3DataTableEnd_Time.ColumnName = "End_Time";
            this.coldsProcessL3DataTableEnd_Time.DataType = typeof(System.DateTime);
            this.coldsProcessL3DataTableEnd_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableProcess_Time
            // 
            this.coldsProcessL3DataTableProcess_Time.Caption = "Process_Time";
            this.coldsProcessL3DataTableProcess_Time.ColumnName = "Process_Time";
            this.coldsProcessL3DataTableProcess_Time.DataType = typeof(int);
            this.coldsProcessL3DataTableProcess_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableProbe_Vonder
            // 
            this.coldsProcessL3DataTableProbe_Vonder.Caption = "Probe_Vonder";
            this.coldsProcessL3DataTableProbe_Vonder.ColumnName = "Probe_Vonder";
            this.coldsProcessL3DataTableProbe_Vonder.Namespace = "";
            // 
            // coldsProcessL3DataTableDeparture_Temp
            // 
            this.coldsProcessL3DataTableDeparture_Temp.Caption = "Departure_Temp";
            this.coldsProcessL3DataTableDeparture_Temp.ColumnName = "Departure_Temp";
            this.coldsProcessL3DataTableDeparture_Temp.DataType = typeof(int);
            this.coldsProcessL3DataTableDeparture_Temp.Namespace = "";
            // 
            // coldsProcessL3DataTableSoftBlow_StartTime
            // 
            this.coldsProcessL3DataTableSoftBlow_StartTime.Caption = "SoftBlow_StartTime";
            this.coldsProcessL3DataTableSoftBlow_StartTime.ColumnName = "SoftBlow_StartTime";
            this.coldsProcessL3DataTableSoftBlow_StartTime.DataType = typeof(System.DateTime);
            this.coldsProcessL3DataTableSoftBlow_StartTime.Namespace = "";
            // 
            // coldsProcessL3DataTableSoftBlow_EndTime
            // 
            this.coldsProcessL3DataTableSoftBlow_EndTime.Caption = "SoftBlow_EndTime";
            this.coldsProcessL3DataTableSoftBlow_EndTime.ColumnName = "SoftBlow_EndTime";
            this.coldsProcessL3DataTableSoftBlow_EndTime.DataType = typeof(System.DateTime);
            this.coldsProcessL3DataTableSoftBlow_EndTime.Namespace = "";
            // 
            // coldsProcessL3DataTableSoftBlow_Time
            // 
            this.coldsProcessL3DataTableSoftBlow_Time.Caption = "SoftBlow_Time";
            this.coldsProcessL3DataTableSoftBlow_Time.ColumnName = "SoftBlow_Time";
            this.coldsProcessL3DataTableSoftBlow_Time.DataType = typeof(int);
            this.coldsProcessL3DataTableSoftBlow_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableArrival_Temp_Quality
            // 
            this.coldsProcessL3DataTableArrival_Temp_Quality.Caption = "Arrival_Temp_Quality";
            this.coldsProcessL3DataTableArrival_Temp_Quality.ColumnName = "Arrival_Temp_Quality";
            this.coldsProcessL3DataTableArrival_Temp_Quality.DataType = typeof(int);
            this.coldsProcessL3DataTableArrival_Temp_Quality.Namespace = "";
            // 
            // coldsProcessL3DataTableSlag_Thick
            // 
            this.coldsProcessL3DataTableSlag_Thick.Caption = "Slag_Thick";
            this.coldsProcessL3DataTableSlag_Thick.ColumnName = "Slag_Thick";
            this.coldsProcessL3DataTableSlag_Thick.DataType = typeof(float);
            this.coldsProcessL3DataTableSlag_Thick.Namespace = "";
            // 
            // coldsProcessL3DataTableProcess_Location
            // 
            this.coldsProcessL3DataTableProcess_Location.Caption = "Process_Location";
            this.coldsProcessL3DataTableProcess_Location.ColumnName = "Process_Location";
            this.coldsProcessL3DataTableProcess_Location.Namespace = "";
            // 
            // coldsProcessL3DataTableSlot_No
            // 
            this.coldsProcessL3DataTableSlot_No.Caption = "Slot_No";
            this.coldsProcessL3DataTableSlot_No.ColumnName = "Slot_No";
            this.coldsProcessL3DataTableSlot_No.Namespace = "";
            // 
            // coldsProcessL3DataTableProcess_Mode
            // 
            this.coldsProcessL3DataTableProcess_Mode.Caption = "Process_Mode";
            this.coldsProcessL3DataTableProcess_Mode.ColumnName = "Process_Mode";
            this.coldsProcessL3DataTableProcess_Mode.DataType = typeof(int);
            this.coldsProcessL3DataTableProcess_Mode.Namespace = "";
            // 
            // coldsProcessL3DataTableLoop_Time
            // 
            this.coldsProcessL3DataTableLoop_Time.Caption = "Loop_Time";
            this.coldsProcessL3DataTableLoop_Time.ColumnName = "Loop_Time";
            this.coldsProcessL3DataTableLoop_Time.DataType = typeof(int);
            this.coldsProcessL3DataTableLoop_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableVac_Min
            // 
            this.coldsProcessL3DataTableVac_Min.Caption = "Vac_Min";
            this.coldsProcessL3DataTableVac_Min.ColumnName = "Vac_Min";
            this.coldsProcessL3DataTableVac_Min.DataType = typeof(float);
            this.coldsProcessL3DataTableVac_Min.Namespace = "";
            // 
            // coldsProcessL3DataTableOB_Count
            // 
            this.coldsProcessL3DataTableOB_Count.Caption = "OB_Count";
            this.coldsProcessL3DataTableOB_Count.ColumnName = "OB_Count";
            this.coldsProcessL3DataTableOB_Count.DataType = typeof(int);
            this.coldsProcessL3DataTableOB_Count.Namespace = "";
            // 
            // coldsProcessL3DataTableO2_CONS
            // 
            this.coldsProcessL3DataTableO2_CONS.Caption = "O2_CONS";
            this.coldsProcessL3DataTableO2_CONS.ColumnName = "O2_CONS";
            this.coldsProcessL3DataTableO2_CONS.DataType = typeof(float);
            this.coldsProcessL3DataTableO2_CONS.Namespace = "";
            // 
            // coldsProcessL3DataTableAl_CONS
            // 
            this.coldsProcessL3DataTableAl_CONS.Caption = "Al_CONS";
            this.coldsProcessL3DataTableAl_CONS.ColumnName = "Al_CONS";
            this.coldsProcessL3DataTableAl_CONS.DataType = typeof(float);
            this.coldsProcessL3DataTableAl_CONS.Namespace = "";
            // 
            // coldsProcessL3DataTableOB_Cycle_Time
            // 
            this.coldsProcessL3DataTableOB_Cycle_Time.Caption = "OB_Cycle_Time";
            this.coldsProcessL3DataTableOB_Cycle_Time.ColumnName = "OB_Cycle_Time";
            this.coldsProcessL3DataTableOB_Cycle_Time.DataType = typeof(int);
            this.coldsProcessL3DataTableOB_Cycle_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableWire_End_Time
            // 
            this.coldsProcessL3DataTableWire_End_Time.Caption = "Wire_End_Time";
            this.coldsProcessL3DataTableWire_End_Time.ColumnName = "Wire_End_Time";
            this.coldsProcessL3DataTableWire_End_Time.DataType = typeof(System.DateTime);
            this.coldsProcessL3DataTableWire_End_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableWire_End_Temp
            // 
            this.coldsProcessL3DataTableWire_End_Temp.Caption = "Wire_End_Temp";
            this.coldsProcessL3DataTableWire_End_Temp.ColumnName = "Wire_End_Temp";
            this.coldsProcessL3DataTableWire_End_Temp.DataType = typeof(int);
            this.coldsProcessL3DataTableWire_End_Temp.Namespace = "";
            // 
            // coldsProcessL3DataTableCircsOfRhythm
            // 
            this.coldsProcessL3DataTableCircsOfRhythm.Caption = "CircsOfRhythm";
            this.coldsProcessL3DataTableCircsOfRhythm.ColumnName = "CircsOfRhythm";
            this.coldsProcessL3DataTableCircsOfRhythm.DataType = typeof(int);
            this.coldsProcessL3DataTableCircsOfRhythm.Namespace = "";
            // 
            // coldsProcessL3DataTableLadleNo
            // 
            this.coldsProcessL3DataTableLadleNo.Caption = "LadleNo";
            this.coldsProcessL3DataTableLadleNo.ColumnName = "LadleNo";
            this.coldsProcessL3DataTableLadleNo.Namespace = "";
            // 
            // coldsProcessL3DataTableLadleGrade
            // 
            this.coldsProcessL3DataTableLadleGrade.Caption = "LadleGrade";
            this.coldsProcessL3DataTableLadleGrade.ColumnName = "LadleGrade";
            this.coldsProcessL3DataTableLadleGrade.Namespace = "";
            // 
            // coldsTempL3DataTableGUID
            // 
            this.coldsTempL3DataTableGUID.Caption = "GUID";
            this.coldsTempL3DataTableGUID.ColumnName = "GUID";
            this.coldsTempL3DataTableGUID.Namespace = "";
            // 
            // coldsTempL3DataTableName
            // 
            this.coldsTempL3DataTableName.Caption = "Name";
            this.coldsTempL3DataTableName.ColumnName = "Name";
            this.coldsTempL3DataTableName.Namespace = "";
            // 
            // coldsOxygenL3DataTableGUID
            // 
            this.coldsOxygenL3DataTableGUID.Caption = "GUID";
            this.coldsOxygenL3DataTableGUID.ColumnName = "GUID";
            this.coldsOxygenL3DataTableGUID.Namespace = "";
            // 
            // coldsNoteL3DataTableName
            // 
            this.coldsNoteL3DataTableName.Caption = "Name";
            this.coldsNoteL3DataTableName.ColumnName = "Name";
            this.coldsNoteL3DataTableName.Namespace = "";
            // 
            // schemadsNote
            // 
            this.schemadsNote.TableName = "L3DataTable";
            // 
            // coldsOxygenL3DataTableName
            // 
            this.coldsOxygenL3DataTableName.Caption = "Name";
            this.coldsOxygenL3DataTableName.ColumnName = "Name";
            this.coldsOxygenL3DataTableName.Namespace = "";
            // 
            // coldsNoteL3DataTableGUID
            // 
            this.coldsNoteL3DataTableGUID.Caption = "GUID";
            this.coldsNoteL3DataTableGUID.ColumnName = "GUID";
            this.coldsNoteL3DataTableGUID.Namespace = "";
            // 
            // bsBase
            // 
            this.bsBase.DataMember = "L3DataTable";
            this.bsBase.DataSource = this.dsBase;
            // 
            // dsBase
            // 
            this.dsBase.AutoLoad = true;
            this.dsBase.AutoSubscribe = false;
            this.dsBase.DataSetName = "L3DataSet";
            this.dsBase.DeleteMethod = null;
            this.dsBase.InsertMethod = null;
            this.dsBase.L3DataAdapter = this.Adapter;
            this.dsBase.LoadEvent = "Click";
            this.dsBase.LoadTrigger = null;
            this.dsBase.RefreshValve = 1000;
            this.dsBase.SourceCommand = null;
            this.dsBase.SourceCondition = null;
            this.dsBase.SourceMethod = "";
            this.dsBase.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBase.SourceURI = "XGMESLogic\\RHMag\\CRH_Base_Data";
            this.dsBase.SubscribeTarget = null;
            this.dsBase.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBase});
            this.dsBase.UpdateEvent = "Click";
            this.dsBase.UpdateMethod = null;
            this.dsBase.UpdateTrigger = null;
            this.dsBase.OnDataLoaded += new AppSvrHMI.Delegate_OnDataLoaded(this.dsBase_OnDataLoaded);
            // 
            // schemadsBase
            // 
            this.schemadsBase.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBaseL3DataTableTreatNo,
            this.coldsBaseL3DataTableHeatID,
            this.coldsBaseL3DataTablePreHeatID,
            this.coldsBaseL3DataTableSteelGradeIndex,
            this.coldsBaseL3DataTableSteelGrade,
            this.coldsBaseL3DataTableLadleNo,
            this.coldsBaseL3DataTableAssistant,
            this.coldsBaseL3DataTableSecondHand,
            this.coldsBaseL3DataTableProductionDate,
            this.coldsBaseL3DataTableLocked,
            this.coldsBaseL3DataTableShift,
            this.coldsBaseL3DataTableTeam,
            this.coldsBaseL3DataTableHeatFurnace});
            this.schemadsBase.TableName = "L3DataTable";
            // 
            // coldsBaseL3DataTableTreatNo
            // 
            this.coldsBaseL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsBaseL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsBaseL3DataTableTreatNo.Namespace = "";
            // 
            // coldsBaseL3DataTableHeatID
            // 
            this.coldsBaseL3DataTableHeatID.Caption = "HeatID";
            this.coldsBaseL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsBaseL3DataTableHeatID.Namespace = "";
            // 
            // coldsBaseL3DataTablePreHeatID
            // 
            this.coldsBaseL3DataTablePreHeatID.Caption = "PreHeatID";
            this.coldsBaseL3DataTablePreHeatID.ColumnName = "PreHeatID";
            this.coldsBaseL3DataTablePreHeatID.Namespace = "";
            // 
            // coldsBaseL3DataTableSteelGradeIndex
            // 
            this.coldsBaseL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsBaseL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsBaseL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsBaseL3DataTableSteelGrade
            // 
            this.coldsBaseL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsBaseL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsBaseL3DataTableSteelGrade.Namespace = "";
            // 
            // coldsBaseL3DataTableLadleNo
            // 
            this.coldsBaseL3DataTableLadleNo.Caption = "LadleNo";
            this.coldsBaseL3DataTableLadleNo.ColumnName = "LadleNo";
            this.coldsBaseL3DataTableLadleNo.Namespace = "";
            // 
            // coldsBaseL3DataTableAssistant
            // 
            this.coldsBaseL3DataTableAssistant.Caption = "Assistant";
            this.coldsBaseL3DataTableAssistant.ColumnName = "Assistant";
            this.coldsBaseL3DataTableAssistant.Namespace = "";
            // 
            // coldsBaseL3DataTableSecondHand
            // 
            this.coldsBaseL3DataTableSecondHand.Caption = "SecondHand";
            this.coldsBaseL3DataTableSecondHand.ColumnName = "SecondHand";
            this.coldsBaseL3DataTableSecondHand.Namespace = "";
            // 
            // coldsBaseL3DataTableProductionDate
            // 
            this.coldsBaseL3DataTableProductionDate.Caption = "ProductionDate";
            this.coldsBaseL3DataTableProductionDate.ColumnName = "ProductionDate";
            this.coldsBaseL3DataTableProductionDate.DataType = typeof(System.DateTime);
            this.coldsBaseL3DataTableProductionDate.Namespace = "";
            // 
            // coldsBaseL3DataTableLocked
            // 
            this.coldsBaseL3DataTableLocked.Caption = "Locked";
            this.coldsBaseL3DataTableLocked.ColumnName = "Locked";
            this.coldsBaseL3DataTableLocked.DataType = typeof(int);
            this.coldsBaseL3DataTableLocked.Namespace = "";
            // 
            // coldsBaseL3DataTableShift
            // 
            this.coldsBaseL3DataTableShift.Caption = "Shift";
            this.coldsBaseL3DataTableShift.ColumnName = "Shift";
            this.coldsBaseL3DataTableShift.Namespace = "";
            // 
            // coldsBaseL3DataTableTeam
            // 
            this.coldsBaseL3DataTableTeam.Caption = "Team";
            this.coldsBaseL3DataTableTeam.ColumnName = "Team";
            this.coldsBaseL3DataTableTeam.Namespace = "";
            // 
            // coldsBaseL3DataTableHeatFurnace
            // 
            this.coldsBaseL3DataTableHeatFurnace.Caption = "HeatFurnace";
            this.coldsBaseL3DataTableHeatFurnace.ColumnName = "HeatFurnace";
            this.coldsBaseL3DataTableHeatFurnace.Namespace = "";
            // 
            // coldsBaseL3DataTableGUID
            // 
            this.coldsBaseL3DataTableGUID.Caption = "GUID";
            this.coldsBaseL3DataTableGUID.ColumnName = "GUID";
            this.coldsBaseL3DataTableGUID.Namespace = "";
            // 
            // coldsBaseL3DataTableName
            // 
            this.coldsBaseL3DataTableName.Caption = "Name";
            this.coldsBaseL3DataTableName.ColumnName = "Name";
            this.coldsBaseL3DataTableName.Namespace = "";
            // 
            // dsChemical
            // 
            this.dsChemical.AutoLoad = true;
            this.dsChemical.AutoSubscribe = false;
            this.dsChemical.DataSetName = "L3DataSet";
            this.dsChemical.DeleteMethod = null;
            this.dsChemical.InsertMethod = null;
            this.dsChemical.L3DataAdapter = null;
            this.dsChemical.LoadEvent = "Click";
            this.dsChemical.LoadTrigger = null;
            this.dsChemical.RefreshValve = 1000;
            this.dsChemical.SourceCommand = null;
            this.dsChemical.SourceCondition = null;
            this.dsChemical.SourceMethod = "";
            this.dsChemical.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsChemical.SourceURI = "XGMESLogic\\QualityMag\\CQA_Lab_Element";
            this.dsChemical.SubscribeTarget = null;
            this.dsChemical.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsChemical});
            this.dsChemical.UpdateEvent = "Click";
            this.dsChemical.UpdateMethod = null;
            this.dsChemical.UpdateTrigger = null;
            // 
            // schemadsChemical
            // 
            this.schemadsChemical.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsChemicalL3DataTableGUID,
            this.coldsChemicalL3DataTableName,
            this.coldsChemicalL3DataTableHeatID,
            this.coldsChemicalL3DataTableAppID,
            this.coldsChemicalL3DataTableSample_Code,
            this.coldsChemicalL3DataTableArrive_Date,
            this.coldsChemicalL3DataTableReport_Date,
            this.coldsChemicalL3DataTableUnitTypeID,
            this.coldsChemicalL3DataTableUnitID,
            this.coldsChemicalL3DataTableSample_Address,
            this.coldsChemicalL3DataTableSample_Type,
            this.coldsChemicalL3DataTableSample_Count,
            this.coldsChemicalL3DataTableC,
            this.coldsChemicalL3DataTableSi,
            this.coldsChemicalL3DataTableMn,
            this.coldsChemicalL3DataTableP,
            this.coldsChemicalL3DataTableS,
            this.coldsChemicalL3DataTableCu,
            this.coldsChemicalL3DataTableNi,
            this.coldsChemicalL3DataTableCr,
            this.coldsChemicalL3DataTableMo,
            this.coldsChemicalL3DataTableV,
            this.coldsChemicalL3DataTableNb,
            this.coldsChemicalL3DataTableAl,
            this.coldsChemicalL3DataTableAlS,
            this.coldsChemicalL3DataTableTi,
            this.coldsChemicalL3DataTableB,
            this.coldsChemicalL3DataTableSb,
            this.coldsChemicalL3DataTableAs,
            this.coldsChemicalL3DataTableSn,
            this.coldsChemicalL3DataTableZn,
            this.coldsChemicalL3DataTableCa,
            this.coldsChemicalL3DataTableW,
            this.coldsChemicalL3DataTablePb,
            this.coldsChemicalL3DataTableRe,
            this.coldsChemicalL3DataTableCeq,
            this.coldsChemicalL3DataTableN,
            this.coldsChemicalL3DataTableH,
            this.coldsChemicalL3DataTableO,
            this.coldsChemicalL3DataTableOther1,
            this.coldsChemicalL3DataTableOther2,
            this.coldsChemicalL3DataTableLogTime,
            this.coldsChemicalL3DataTableDataLogMode,
            this.coldsChemicalL3DataTableCrNi,
            this.coldsChemicalL3DataTableCrCu,
            this.coldsChemicalL3DataTableCrNiCu,
            this.coldsChemicalL3DataTableOther3});
            this.schemadsChemical.TableName = "L3DataTable";
            // 
            // coldsChemicalL3DataTableGUID
            // 
            this.coldsChemicalL3DataTableGUID.Caption = "GUID";
            this.coldsChemicalL3DataTableGUID.ColumnName = "GUID";
            this.coldsChemicalL3DataTableGUID.Namespace = "";
            // 
            // coldsChemicalL3DataTableName
            // 
            this.coldsChemicalL3DataTableName.Caption = "Name";
            this.coldsChemicalL3DataTableName.ColumnName = "Name";
            this.coldsChemicalL3DataTableName.Namespace = "";
            // 
            // coldsChemicalL3DataTableHeatID
            // 
            this.coldsChemicalL3DataTableHeatID.Caption = "HeatID";
            this.coldsChemicalL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsChemicalL3DataTableHeatID.Namespace = "";
            // 
            // coldsChemicalL3DataTableAppID
            // 
            this.coldsChemicalL3DataTableAppID.Caption = "AppID";
            this.coldsChemicalL3DataTableAppID.ColumnName = "AppID";
            this.coldsChemicalL3DataTableAppID.Namespace = "";
            // 
            // coldsChemicalL3DataTableSample_Code
            // 
            this.coldsChemicalL3DataTableSample_Code.Caption = "Sample_Code";
            this.coldsChemicalL3DataTableSample_Code.ColumnName = "Sample_Code";
            this.coldsChemicalL3DataTableSample_Code.Namespace = "";
            // 
            // coldsChemicalL3DataTableArrive_Date
            // 
            this.coldsChemicalL3DataTableArrive_Date.Caption = "Arrive_Date";
            this.coldsChemicalL3DataTableArrive_Date.ColumnName = "Arrive_Date";
            this.coldsChemicalL3DataTableArrive_Date.DataType = typeof(System.DateTime);
            this.coldsChemicalL3DataTableArrive_Date.Namespace = "";
            // 
            // coldsChemicalL3DataTableReport_Date
            // 
            this.coldsChemicalL3DataTableReport_Date.Caption = "Report_Date";
            this.coldsChemicalL3DataTableReport_Date.ColumnName = "Report_Date";
            this.coldsChemicalL3DataTableReport_Date.DataType = typeof(System.DateTime);
            this.coldsChemicalL3DataTableReport_Date.Namespace = "";
            // 
            // coldsChemicalL3DataTableUnitTypeID
            // 
            this.coldsChemicalL3DataTableUnitTypeID.Caption = "UnitTypeID";
            this.coldsChemicalL3DataTableUnitTypeID.ColumnName = "UnitTypeID";
            this.coldsChemicalL3DataTableUnitTypeID.DataType = typeof(int);
            this.coldsChemicalL3DataTableUnitTypeID.Namespace = "";
            // 
            // coldsChemicalL3DataTableUnitID
            // 
            this.coldsChemicalL3DataTableUnitID.Caption = "UnitID";
            this.coldsChemicalL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsChemicalL3DataTableUnitID.DataType = typeof(int);
            this.coldsChemicalL3DataTableUnitID.Namespace = "";
            // 
            // coldsChemicalL3DataTableSample_Address
            // 
            this.coldsChemicalL3DataTableSample_Address.Caption = "Sample_Address";
            this.coldsChemicalL3DataTableSample_Address.ColumnName = "Sample_Address";
            this.coldsChemicalL3DataTableSample_Address.Namespace = "";
            // 
            // coldsChemicalL3DataTableSample_Type
            // 
            this.coldsChemicalL3DataTableSample_Type.Caption = "Sample_Type";
            this.coldsChemicalL3DataTableSample_Type.ColumnName = "Sample_Type";
            this.coldsChemicalL3DataTableSample_Type.Namespace = "";
            // 
            // coldsChemicalL3DataTableSample_Count
            // 
            this.coldsChemicalL3DataTableSample_Count.Caption = "Sample_Count";
            this.coldsChemicalL3DataTableSample_Count.ColumnName = "Sample_Count";
            this.coldsChemicalL3DataTableSample_Count.Namespace = "";
            // 
            // coldsChemicalL3DataTableC
            // 
            this.coldsChemicalL3DataTableC.Caption = "C";
            this.coldsChemicalL3DataTableC.ColumnName = "C";
            this.coldsChemicalL3DataTableC.Namespace = "";
            // 
            // coldsChemicalL3DataTableSi
            // 
            this.coldsChemicalL3DataTableSi.Caption = "Si";
            this.coldsChemicalL3DataTableSi.ColumnName = "Si";
            this.coldsChemicalL3DataTableSi.Namespace = "";
            // 
            // coldsChemicalL3DataTableMn
            // 
            this.coldsChemicalL3DataTableMn.Caption = "Mn";
            this.coldsChemicalL3DataTableMn.ColumnName = "Mn";
            this.coldsChemicalL3DataTableMn.Namespace = "";
            // 
            // coldsChemicalL3DataTableP
            // 
            this.coldsChemicalL3DataTableP.Caption = "P";
            this.coldsChemicalL3DataTableP.ColumnName = "P";
            this.coldsChemicalL3DataTableP.Namespace = "";
            // 
            // coldsChemicalL3DataTableS
            // 
            this.coldsChemicalL3DataTableS.Caption = "S";
            this.coldsChemicalL3DataTableS.ColumnName = "S";
            this.coldsChemicalL3DataTableS.Namespace = "";
            // 
            // coldsChemicalL3DataTableCu
            // 
            this.coldsChemicalL3DataTableCu.Caption = "Cu";
            this.coldsChemicalL3DataTableCu.ColumnName = "Cu";
            this.coldsChemicalL3DataTableCu.Namespace = "";
            // 
            // coldsChemicalL3DataTableNi
            // 
            this.coldsChemicalL3DataTableNi.Caption = "Ni";
            this.coldsChemicalL3DataTableNi.ColumnName = "Ni";
            this.coldsChemicalL3DataTableNi.Namespace = "";
            // 
            // coldsChemicalL3DataTableCr
            // 
            this.coldsChemicalL3DataTableCr.Caption = "Cr";
            this.coldsChemicalL3DataTableCr.ColumnName = "Cr";
            this.coldsChemicalL3DataTableCr.Namespace = "";
            // 
            // coldsChemicalL3DataTableMo
            // 
            this.coldsChemicalL3DataTableMo.Caption = "Mo";
            this.coldsChemicalL3DataTableMo.ColumnName = "Mo";
            this.coldsChemicalL3DataTableMo.Namespace = "";
            // 
            // coldsChemicalL3DataTableV
            // 
            this.coldsChemicalL3DataTableV.Caption = "V";
            this.coldsChemicalL3DataTableV.ColumnName = "V";
            this.coldsChemicalL3DataTableV.Namespace = "";
            // 
            // coldsChemicalL3DataTableNb
            // 
            this.coldsChemicalL3DataTableNb.Caption = "Nb";
            this.coldsChemicalL3DataTableNb.ColumnName = "Nb";
            this.coldsChemicalL3DataTableNb.Namespace = "";
            // 
            // coldsChemicalL3DataTableAl
            // 
            this.coldsChemicalL3DataTableAl.Caption = "Al";
            this.coldsChemicalL3DataTableAl.ColumnName = "Al";
            this.coldsChemicalL3DataTableAl.Namespace = "";
            // 
            // coldsChemicalL3DataTableAlS
            // 
            this.coldsChemicalL3DataTableAlS.Caption = "AlS";
            this.coldsChemicalL3DataTableAlS.ColumnName = "AlS";
            this.coldsChemicalL3DataTableAlS.Namespace = "";
            // 
            // coldsChemicalL3DataTableTi
            // 
            this.coldsChemicalL3DataTableTi.Caption = "Ti";
            this.coldsChemicalL3DataTableTi.ColumnName = "Ti";
            this.coldsChemicalL3DataTableTi.Namespace = "";
            // 
            // coldsChemicalL3DataTableB
            // 
            this.coldsChemicalL3DataTableB.Caption = "B";
            this.coldsChemicalL3DataTableB.ColumnName = "B";
            this.coldsChemicalL3DataTableB.Namespace = "";
            // 
            // coldsChemicalL3DataTableSb
            // 
            this.coldsChemicalL3DataTableSb.Caption = "Sb";
            this.coldsChemicalL3DataTableSb.ColumnName = "Sb";
            this.coldsChemicalL3DataTableSb.Namespace = "";
            // 
            // coldsChemicalL3DataTableAs
            // 
            this.coldsChemicalL3DataTableAs.Caption = "As";
            this.coldsChemicalL3DataTableAs.ColumnName = "As";
            this.coldsChemicalL3DataTableAs.Namespace = "";
            // 
            // coldsChemicalL3DataTableSn
            // 
            this.coldsChemicalL3DataTableSn.Caption = "Sn";
            this.coldsChemicalL3DataTableSn.ColumnName = "Sn";
            this.coldsChemicalL3DataTableSn.Namespace = "";
            // 
            // coldsChemicalL3DataTableZn
            // 
            this.coldsChemicalL3DataTableZn.Caption = "Zn";
            this.coldsChemicalL3DataTableZn.ColumnName = "Zn";
            this.coldsChemicalL3DataTableZn.Namespace = "";
            // 
            // coldsChemicalL3DataTableCa
            // 
            this.coldsChemicalL3DataTableCa.Caption = "Ca";
            this.coldsChemicalL3DataTableCa.ColumnName = "Ca";
            this.coldsChemicalL3DataTableCa.Namespace = "";
            // 
            // coldsChemicalL3DataTableW
            // 
            this.coldsChemicalL3DataTableW.Caption = "W";
            this.coldsChemicalL3DataTableW.ColumnName = "W";
            this.coldsChemicalL3DataTableW.Namespace = "";
            // 
            // coldsChemicalL3DataTablePb
            // 
            this.coldsChemicalL3DataTablePb.Caption = "Pb";
            this.coldsChemicalL3DataTablePb.ColumnName = "Pb";
            this.coldsChemicalL3DataTablePb.Namespace = "";
            // 
            // coldsChemicalL3DataTableRe
            // 
            this.coldsChemicalL3DataTableRe.Caption = "Re";
            this.coldsChemicalL3DataTableRe.ColumnName = "Re";
            this.coldsChemicalL3DataTableRe.Namespace = "";
            // 
            // coldsChemicalL3DataTableCeq
            // 
            this.coldsChemicalL3DataTableCeq.Caption = "Ceq";
            this.coldsChemicalL3DataTableCeq.ColumnName = "Ceq";
            this.coldsChemicalL3DataTableCeq.Namespace = "";
            // 
            // coldsChemicalL3DataTableN
            // 
            this.coldsChemicalL3DataTableN.Caption = "N";
            this.coldsChemicalL3DataTableN.ColumnName = "N";
            this.coldsChemicalL3DataTableN.Namespace = "";
            // 
            // coldsChemicalL3DataTableH
            // 
            this.coldsChemicalL3DataTableH.Caption = "H";
            this.coldsChemicalL3DataTableH.ColumnName = "H";
            this.coldsChemicalL3DataTableH.Namespace = "";
            // 
            // coldsChemicalL3DataTableO
            // 
            this.coldsChemicalL3DataTableO.Caption = "O";
            this.coldsChemicalL3DataTableO.ColumnName = "O";
            this.coldsChemicalL3DataTableO.Namespace = "";
            // 
            // coldsChemicalL3DataTableOther1
            // 
            this.coldsChemicalL3DataTableOther1.Caption = "Other1";
            this.coldsChemicalL3DataTableOther1.ColumnName = "Other1";
            this.coldsChemicalL3DataTableOther1.Namespace = "";
            // 
            // coldsChemicalL3DataTableOther2
            // 
            this.coldsChemicalL3DataTableOther2.Caption = "Other2";
            this.coldsChemicalL3DataTableOther2.ColumnName = "Other2";
            this.coldsChemicalL3DataTableOther2.Namespace = "";
            // 
            // coldsChemicalL3DataTableLogTime
            // 
            this.coldsChemicalL3DataTableLogTime.Caption = "LogTime";
            this.coldsChemicalL3DataTableLogTime.ColumnName = "LogTime";
            this.coldsChemicalL3DataTableLogTime.DataType = typeof(System.DateTime);
            this.coldsChemicalL3DataTableLogTime.Namespace = "";
            // 
            // coldsChemicalL3DataTableDataLogMode
            // 
            this.coldsChemicalL3DataTableDataLogMode.Caption = "DataLogMode";
            this.coldsChemicalL3DataTableDataLogMode.ColumnName = "DataLogMode";
            this.coldsChemicalL3DataTableDataLogMode.DataType = typeof(int);
            this.coldsChemicalL3DataTableDataLogMode.Namespace = "";
            // 
            // coldsChemicalL3DataTableCrNi
            // 
            this.coldsChemicalL3DataTableCrNi.Caption = "CrNi";
            this.coldsChemicalL3DataTableCrNi.ColumnName = "CrNi";
            this.coldsChemicalL3DataTableCrNi.Namespace = "";
            // 
            // coldsChemicalL3DataTableCrCu
            // 
            this.coldsChemicalL3DataTableCrCu.Caption = "CrCu";
            this.coldsChemicalL3DataTableCrCu.ColumnName = "CrCu";
            this.coldsChemicalL3DataTableCrCu.Namespace = "";
            // 
            // coldsChemicalL3DataTableCrNiCu
            // 
            this.coldsChemicalL3DataTableCrNiCu.Caption = "CrNiCu";
            this.coldsChemicalL3DataTableCrNiCu.ColumnName = "CrNiCu";
            this.coldsChemicalL3DataTableCrNiCu.Namespace = "";
            // 
            // coldsChemicalL3DataTableOther3
            // 
            this.coldsChemicalL3DataTableOther3.Caption = "Other3";
            this.coldsChemicalL3DataTableOther3.ColumnName = "Other3";
            this.coldsChemicalL3DataTableOther3.Namespace = "";
            // 
            // bsOxygen
            // 
            this.bsOxygen.DataMember = "L3DataTable";
            this.bsOxygen.DataSource = this.dsOxygen;
            // 
            // dsOxygen
            // 
            this.dsOxygen.AutoLoad = true;
            this.dsOxygen.AutoSubscribe = false;
            this.dsOxygen.DataSetName = "L3DataSet";
            this.dsOxygen.DeleteMethod = null;
            this.dsOxygen.InsertMethod = null;
            this.dsOxygen.L3DataAdapter = null;
            this.dsOxygen.LoadEvent = "Click";
            this.dsOxygen.LoadTrigger = null;
            this.dsOxygen.RefreshValve = 1000;
            this.dsOxygen.SourceCommand = null;
            this.dsOxygen.SourceCondition = null;
            this.dsOxygen.SourceMethod = "";
            this.dsOxygen.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsOxygen.SourceURI = "XGMESLogic\\RHMag\\CRH_Oxygen_Data";
            this.dsOxygen.SubscribeTarget = null;
            this.dsOxygen.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsOxygen});
            this.dsOxygen.UpdateEvent = "Click";
            this.dsOxygen.UpdateMethod = null;
            this.dsOxygen.UpdateTrigger = null;
            // 
            // schemadsOxygen
            // 
            this.schemadsOxygen.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsOxygenL3DataTableGUID,
            this.coldsOxygenL3DataTableTreatNo,
            this.coldsOxygenL3DataTableHeatID,
            this.coldsOxygenL3DataTableOxygen_Content,
            this.coldsOxygenL3DataTableMeasureTime});
            this.schemadsOxygen.TableName = "L3DataTable";
            // 
            // coldsOxygenL3DataTableTreatNo
            // 
            this.coldsOxygenL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsOxygenL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsOxygenL3DataTableTreatNo.Namespace = "";
            // 
            // coldsOxygenL3DataTableHeatID
            // 
            this.coldsOxygenL3DataTableHeatID.Caption = "HeatID";
            this.coldsOxygenL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsOxygenL3DataTableHeatID.Namespace = "";
            // 
            // coldsOxygenL3DataTableOxygen_Content
            // 
            this.coldsOxygenL3DataTableOxygen_Content.Caption = "Oxygen_Content";
            this.coldsOxygenL3DataTableOxygen_Content.ColumnName = "Oxygen_Content";
            this.coldsOxygenL3DataTableOxygen_Content.DataType = typeof(float);
            this.coldsOxygenL3DataTableOxygen_Content.Namespace = "";
            // 
            // coldsOxygenL3DataTableMeasureTime
            // 
            this.coldsOxygenL3DataTableMeasureTime.Caption = "MeasureTime";
            this.coldsOxygenL3DataTableMeasureTime.ColumnName = "MeasureTime";
            this.coldsOxygenL3DataTableMeasureTime.DataType = typeof(System.DateTime);
            this.coldsOxygenL3DataTableMeasureTime.Namespace = "";
            // 
            // bsMat
            // 
            this.bsMat.DataMember = "L3DataTable";
            this.bsMat.DataSource = this.dsMat;
            this.bsMat.CurrentChanged += new System.EventHandler(this.bsBatchID_CurrentChanged);
            // 
            // dsMat
            // 
            this.dsMat.AutoLoad = true;
            this.dsMat.AutoSubscribe = false;
            this.dsMat.DataSetName = "L3DataSet";
            this.dsMat.DeleteMethod = null;
            this.dsMat.InsertMethod = null;
            this.dsMat.L3DataAdapter = null;
            this.dsMat.LoadEvent = "Click";
            this.dsMat.LoadTrigger = null;
            this.dsMat.RefreshValve = 1000;
            this.dsMat.SourceCommand = null;
            this.dsMat.SourceCondition = "1=2";
            this.dsMat.SourceMethod = "";
            this.dsMat.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMat.SourceURI = "XGMESLogic\\RHMag\\CRH_Addition_Data";
            this.dsMat.SubscribeTarget = null;
            this.dsMat.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMat});
            this.dsMat.UpdateEvent = "Click";
            this.dsMat.UpdateMethod = null;
            this.dsMat.UpdateTrigger = null;
            // 
            // schemadsMat
            // 
            this.schemadsMat.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMatL3DataTableGUID,
            this.coldsMatL3DataTableName,
            this.coldsMatL3DataTableTreatNo,
            this.coldsMatL3DataTableHeatID,
            this.coldsMatL3DataTableElement,
            this.coldsMatL3DataTableWeight,
            this.coldsMatL3DataTableDischarge_Time,
            this.coldsMatL3DataTableType,
            this.coldsMatL3DataTableBatch_ID,
            this.coldsMatL3DataTableArea,
            this.coldsMatL3DataTableEnableFlag});
            this.schemadsMat.TableName = "L3DataTable";
            // 
            // coldsMatL3DataTableGUID
            // 
            this.coldsMatL3DataTableGUID.Caption = "GUID";
            this.coldsMatL3DataTableGUID.ColumnName = "GUID";
            this.coldsMatL3DataTableGUID.Namespace = "";
            // 
            // coldsMatL3DataTableName
            // 
            this.coldsMatL3DataTableName.Caption = "Name";
            this.coldsMatL3DataTableName.ColumnName = "Name";
            this.coldsMatL3DataTableName.Namespace = "";
            // 
            // coldsMatL3DataTableTreatNo
            // 
            this.coldsMatL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsMatL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsMatL3DataTableTreatNo.Namespace = "";
            // 
            // coldsMatL3DataTableHeatID
            // 
            this.coldsMatL3DataTableHeatID.Caption = "HeatID";
            this.coldsMatL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsMatL3DataTableHeatID.Namespace = "";
            // 
            // coldsMatL3DataTableElement
            // 
            this.coldsMatL3DataTableElement.Caption = "Element";
            this.coldsMatL3DataTableElement.ColumnName = "Element";
            this.coldsMatL3DataTableElement.Namespace = "";
            // 
            // coldsMatL3DataTableWeight
            // 
            this.coldsMatL3DataTableWeight.Caption = "Weight";
            this.coldsMatL3DataTableWeight.ColumnName = "Weight";
            this.coldsMatL3DataTableWeight.DataType = typeof(float);
            this.coldsMatL3DataTableWeight.Namespace = "";
            // 
            // coldsMatL3DataTableDischarge_Time
            // 
            this.coldsMatL3DataTableDischarge_Time.Caption = "Discharge_Time";
            this.coldsMatL3DataTableDischarge_Time.ColumnName = "Discharge_Time";
            this.coldsMatL3DataTableDischarge_Time.DataType = typeof(System.DateTime);
            this.coldsMatL3DataTableDischarge_Time.Namespace = "";
            // 
            // coldsMatL3DataTableType
            // 
            this.coldsMatL3DataTableType.Caption = "Type";
            this.coldsMatL3DataTableType.ColumnName = "Type";
            this.coldsMatL3DataTableType.DataType = typeof(short);
            this.coldsMatL3DataTableType.Namespace = "";
            // 
            // coldsMatL3DataTableBatch_ID
            // 
            this.coldsMatL3DataTableBatch_ID.Caption = "Batch_ID";
            this.coldsMatL3DataTableBatch_ID.ColumnName = "Batch_ID";
            this.coldsMatL3DataTableBatch_ID.Namespace = "";
            // 
            // coldsMatL3DataTableArea
            // 
            this.coldsMatL3DataTableArea.Caption = "Area";
            this.coldsMatL3DataTableArea.ColumnName = "Area";
            this.coldsMatL3DataTableArea.Namespace = "";
            // 
            // coldsMatL3DataTableEnableFlag
            // 
            this.coldsMatL3DataTableEnableFlag.Caption = "EnableFlag";
            this.coldsMatL3DataTableEnableFlag.ColumnName = "EnableFlag";
            this.coldsMatL3DataTableEnableFlag.Namespace = "";
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.tabCtrlMain);
            this.hmiRootPanel1.Controls.Add(this.panl);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1004, 423);
            this.hmiRootPanel1.TabIndex = 90;
            // 
            // tabCtrlMain
            // 
            this.tabCtrlMain.Controls.Add(this.tabBase);
            this.tabCtrlMain.Controls.Add(this.tabLFAddMat);
            this.tabCtrlMain.Controls.Add(this.tabWire);
            this.tabCtrlMain.Controls.Add(this.tabProcess);
            this.tabCtrlMain.Controls.Add(this.tabLadleInfo);
            this.tabCtrlMain.Controls.Add(this.tabExcept);
            this.tabCtrlMain.Controls.Add(this.tabChemical);
            this.tabCtrlMain.Controls.Add(this.tabStatus);
            this.tabCtrlMain.Controls.Add(this.tabTemp);
            this.tabCtrlMain.Controls.Add(this.tabOxygen);
            this.tabCtrlMain.Controls.Add(this.tabRemark);
            this.tabCtrlMain.Controls.Add(this.tabTundishTemp);
            this.tabCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlMain.Location = new System.Drawing.Point(0, 29);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.SelectedIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(1004, 394);
            this.tabCtrlMain.TabIndex = 0;
            this.tabCtrlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabCtrlMain_Selected);
            this.tabCtrlMain.SelectedIndexChanged += new System.EventHandler(this.tabCtrlMain_SelectedIndexChanged);
            // 
            // tabBase
            // 
            this.tabBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBase.Controls.Add(this.cmbShift);
            this.tabBase.Controls.Add(this.cmbTeam);
            this.tabBase.Controls.Add(this.dateTimePicker6);
            this.tabBase.Controls.Add(this.label10);
            this.tabBase.Controls.Add(this.tbxSecondHand);
            this.tabBase.Controls.Add(this.label9);
            this.tabBase.Controls.Add(this.tbxAssistant);
            this.tabBase.Controls.Add(this.label7);
            this.tabBase.Controls.Add(this.tbxHeadFurnace);
            this.tabBase.Controls.Add(this.label5);
            this.tabBase.Controls.Add(this.label4);
            this.tabBase.Controls.Add(this.label3);
            this.tabBase.Controls.Add(this.tbxSteelGradeIndex);
            this.tabBase.Controls.Add(this.label2);
            this.tabBase.Controls.Add(this.tbxPreHeatID);
            this.tabBase.Controls.Add(this.label1);
            this.tabBase.Controls.Add(this.pnlBase);
            this.tabBase.Location = new System.Drawing.Point(4, 22);
            this.tabBase.Name = "tabBase";
            this.tabBase.Padding = new System.Windows.Forms.Padding(3);
            this.tabBase.Size = new System.Drawing.Size(996, 368);
            this.tabBase.TabIndex = 0;
            this.tabBase.Text = "基本数据";
            this.tabBase.UseVisualStyleBackColor = true;
            // 
            // cmbShift
            // 
            this.cmbShift.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbShift.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbShift.BackColor = System.Drawing.SystemColors.Window;
            this.cmbShift.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBase, "Shift", true));
            this.cmbShift.DataSource = this.dsShiftID;
            this.cmbShift.DisplayMember = "L3DataTable.Code_Des";
            this.cmbShift.EnableNull = false;
            this.cmbShift.ErropPr = this.errorProvider1;
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Location = new System.Drawing.Point(194, 100);
            this.cmbShift.Name = "cmbShift";
            //
            this.cmbShift.Size = new System.Drawing.Size(141, 20);
            this.cmbShift.TabIndex = 105;
            //
            this.cmbShift.ToolTipValid = this.toolTip1;
            this.cmbShift.ValidEable = true;
            this.cmbShift.ValueMember = "L3DataTable.Code";
            // 
            // dsShiftID
            // 
            this.dsShiftID.AutoLoad = true;
            this.dsShiftID.AutoSubscribe = false;
            this.dsShiftID.DataSetName = "L3DataSet";
            this.dsShiftID.DeleteMethod = null;
            this.dsShiftID.InsertMethod = null;
            this.dsShiftID.L3DataAdapter = this.Adapter;
            this.dsShiftID.LoadEvent = "Click";
            this.dsShiftID.LoadTrigger = null;
            this.dsShiftID.RefreshValve = 1000;
            this.dsShiftID.SourceCommand = null;
            this.dsShiftID.SourceCondition = "CODE_GROUP = \'ShiftID\'";
            this.dsShiftID.SourceMethod = "";
            this.dsShiftID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsShiftID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsShiftID.SubscribeTarget = null;
            this.dsShiftID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsShiftID});
            this.dsShiftID.UpdateEvent = "Click";
            this.dsShiftID.UpdateMethod = null;
            this.dsShiftID.UpdateTrigger = null;
            // 
            // schemadsShiftID
            // 
            this.schemadsShiftID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsShiftIDL3DataTableCode,
            this.coldsShiftIDL3DataTableCode_Des});
            this.schemadsShiftID.TableName = "L3DataTable";
            // 
            // coldsShiftIDL3DataTableCode
            // 
            this.coldsShiftIDL3DataTableCode.Caption = "Code";
            this.coldsShiftIDL3DataTableCode.ColumnName = "Code";
            this.coldsShiftIDL3DataTableCode.Namespace = "";
            // 
            // coldsShiftIDL3DataTableCode_Des
            // 
            this.coldsShiftIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.Namespace = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // cmbTeam
            // 
            this.cmbTeam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTeam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTeam.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTeam.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBase, "Team", true));
            this.cmbTeam.DataSource = this.dsTeamID;
            this.cmbTeam.DisplayMember = "L3DataTable.Code_Des";
            this.cmbTeam.EnableNull = false;
            this.cmbTeam.ErropPr = this.errorProvider1;
            this.cmbTeam.FormattingEnabled = true;
            this.cmbTeam.Location = new System.Drawing.Point(194, 127);
            this.cmbTeam.Name = "cmbTeam";
            //
            this.cmbTeam.Size = new System.Drawing.Size(142, 20);
            this.cmbTeam.TabIndex = 105;
            //
            this.cmbTeam.ToolTipValid = this.toolTip1;
            this.cmbTeam.ValidEable = true;
            this.cmbTeam.ValueMember = "L3DataTable.Code";
            // 
            // dsTeamID
            // 
            this.dsTeamID.AutoLoad = true;
            this.dsTeamID.AutoSubscribe = false;
            this.dsTeamID.DataSetName = "L3DataSet";
            this.dsTeamID.DeleteMethod = null;
            this.dsTeamID.InsertMethod = null;
            this.dsTeamID.L3DataAdapter = this.Adapter;
            this.dsTeamID.LoadEvent = "Click";
            this.dsTeamID.LoadTrigger = null;
            this.dsTeamID.RefreshValve = 1000;
            this.dsTeamID.SourceCommand = null;
            this.dsTeamID.SourceCondition = "CODE_GROUP = \'TeamID\'";
            this.dsTeamID.SourceMethod = "";
            this.dsTeamID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTeamID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTeamID.SubscribeTarget = null;
            this.dsTeamID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTeamID});
            this.dsTeamID.UpdateEvent = "Click";
            this.dsTeamID.UpdateMethod = null;
            this.dsTeamID.UpdateTrigger = null;
            // 
            // schemadsTeamID
            // 
            this.schemadsTeamID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTeamIDL3DataTableCode,
            this.coldsTeamIDL3DataTableCode_Des});
            this.schemadsTeamID.TableName = "L3DataTable";
            // 
            // coldsTeamIDL3DataTableCode
            // 
            this.coldsTeamIDL3DataTableCode.Caption = "Code";
            this.coldsTeamIDL3DataTableCode.ColumnName = "Code";
            this.coldsTeamIDL3DataTableCode.Namespace = "";
            // 
            // coldsTeamIDL3DataTableCode_Des
            // 
            this.coldsTeamIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.Namespace = "";
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "ProductionDate", true));
            this.dateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker6.Location = new System.Drawing.Point(424, 126);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(141, 21);
            this.dateTimePicker6.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(359, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 104;
            this.label10.Text = "生产日期:";
            // 
            // tbxSecondHand
            // 
            this.tbxSecondHand.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "SecondHand", true));
            //
            this.tbxSecondHand.EnableNull = true;
            this.tbxSecondHand.ErropPr = this.errorProvider1;
            //
            this.tbxSecondHand.Length = 0;
            this.tbxSecondHand.Location = new System.Drawing.Point(424, 100);
            this.tbxSecondHand.Max = 0;
            //
            //
            this.tbxSecondHand.MaxStrLength = 0;
            this.tbxSecondHand.Min = 0;
            //
            //
            this.tbxSecondHand.MinStrLength = 0;
            this.tbxSecondHand.Name = "tbxSecondHand";
            this.tbxSecondHand.Precision = 0;
            //
            this.tbxSecondHand.Size = new System.Drawing.Size(141, 21);
            this.tbxSecondHand.TabIndex = 6;
            this.tbxSecondHand.ToolTipValid = this.toolTip1;
          //
            this.tbxSecondHand.ValidEable = true;
            this.tbxSecondHand.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(371, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 102;
            this.label9.Text = "二助手:";
            // 
            // tbxAssistant
            // 
            this.tbxAssistant.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Assistant", true));
            //
            this.tbxAssistant.EnableNull = true;
            this.tbxAssistant.ErropPr = this.errorProvider1;
            //
            this.tbxAssistant.Length = 0;
            this.tbxAssistant.Location = new System.Drawing.Point(424, 73);
            this.tbxAssistant.Max = 0;
            //
            //
            this.tbxAssistant.MaxStrLength = 0;
            this.tbxAssistant.Min = 0;
            //
            //
            this.tbxAssistant.MinStrLength = 0;
            this.tbxAssistant.Name = "tbxAssistant";
            this.tbxAssistant.Precision = 0;
            //
            this.tbxAssistant.Size = new System.Drawing.Size(141, 21);
            this.tbxAssistant.TabIndex = 5;
            this.tbxAssistant.ToolTipValid = this.toolTip1;
          //
            this.tbxAssistant.ValidEable = true;
            this.tbxAssistant.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 100;
            this.label7.Text = "一助手:";
            // 
            // tbxHeadFurnace
            // 
            this.tbxHeadFurnace.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "HeatFurnace", true));
            //
            this.tbxHeadFurnace.EnableNull = false;
            this.tbxHeadFurnace.ErropPr = this.errorProvider1;
            //
            this.tbxHeadFurnace.Length = 0;
            this.tbxHeadFurnace.Location = new System.Drawing.Point(424, 46);
            this.tbxHeadFurnace.Max = 0;
            //
            //
            this.tbxHeadFurnace.MaxStrLength = 0;
            this.tbxHeadFurnace.Min = 0;
            //
            //
            this.tbxHeadFurnace.MinStrLength = 0;
            this.tbxHeadFurnace.Name = "tbxHeadFurnace";
            this.tbxHeadFurnace.Precision = 0;
            //
            this.tbxHeadFurnace.Size = new System.Drawing.Size(141, 21);
            this.tbxHeadFurnace.TabIndex = 4;
            this.tbxHeadFurnace.ToolTipValid = this.toolTip1;
          //
            this.tbxHeadFurnace.ValidEable = true;
            this.tbxHeadFurnace.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 98;
            this.label5.Text = "炉长:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 96;
            this.label4.Text = "班别:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 94;
            this.label3.Text = "班次:";
            // 
            // tbxSteelGradeIndex
            // 
            this.tbxSteelGradeIndex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "SteelGradeIndex", true));
            //
            this.tbxSteelGradeIndex.EnableNull = false;
            this.tbxSteelGradeIndex.ErropPr = this.errorProvider1;
            //
            this.tbxSteelGradeIndex.Length = 8;
            this.tbxSteelGradeIndex.Location = new System.Drawing.Point(194, 73);
            this.tbxSteelGradeIndex.Max = 0;
            this.tbxSteelGradeIndex.MaxLength = 8;
            //
            //
            this.tbxSteelGradeIndex.MaxStrLength = 0;
            this.tbxSteelGradeIndex.Min = 0;
            //
            //
            this.tbxSteelGradeIndex.MinStrLength = 0;
            this.tbxSteelGradeIndex.Name = "tbxSteelGradeIndex";
            this.tbxSteelGradeIndex.Precision = 0;
            this.tbxSteelGradeIndex.ReadOnly = true;
            //
            this.tbxSteelGradeIndex.Size = new System.Drawing.Size(141, 21);
            this.tbxSteelGradeIndex.TabIndex = 1;
            this.tbxSteelGradeIndex.ToolTipValid = this.toolTip1;
          //
            this.tbxSteelGradeIndex.ValidEable = true;
            this.tbxSteelGradeIndex.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 92;
            this.label2.Text = "炼钢记号:";
            // 
            // tbxPreHeatID
            // 
            this.tbxPreHeatID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "PreHeatID", true));
            //
            this.tbxPreHeatID.EnableNull = false;
            this.tbxPreHeatID.ErropPr = this.errorProvider1;
            //
            this.tbxPreHeatID.Length = 0;
            this.tbxPreHeatID.Location = new System.Drawing.Point(194, 46);
            this.tbxPreHeatID.Max = 0;
            //
            //
            this.tbxPreHeatID.MaxStrLength = 0;
            this.tbxPreHeatID.Min = 0;
            //
            //
            this.tbxPreHeatID.MinStrLength = 0;
            this.tbxPreHeatID.Name = "tbxPreHeatID";
            this.tbxPreHeatID.Precision = 0;
            this.tbxPreHeatID.ReadOnly = true;
            //
            this.tbxPreHeatID.Size = new System.Drawing.Size(141, 21);
            this.tbxPreHeatID.TabIndex = 0;
            this.tbxPreHeatID.ToolTipValid = this.toolTip1;
          //
            this.tbxPreHeatID.ValidEable = true;
            this.tbxPreHeatID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 90;
            this.label1.Text = "预定炉号:";
            // 
            // pnlBase
            // 
            this.pnlBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBase.Controls.Add(this.btnBaseCancel);
            this.pnlBase.Controls.Add(this.btnBaseOK);
            this.pnlBase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBase.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlBase.Location = new System.Drawing.Point(3, 330);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(988, 33);
            this.pnlBase.TabIndex = 89;
            // 
            // btnBaseCancel
            // 
            this.btnBaseCancel.Location = new System.Drawing.Point(906, 3);
            this.btnBaseCancel.Name = "btnBaseCancel";
            this.btnBaseCancel.Size = new System.Drawing.Size(75, 23);
            this.btnBaseCancel.TabIndex = 87;
            this.btnBaseCancel.Text = "取消";
            this.btnBaseCancel.UseVisualStyleBackColor = true;
            this.btnBaseCancel.Click += new System.EventHandler(this.btnBaseCancel_Click);
            // 
            // tabLFAddMat
            // 
            this.tabLFAddMat.Controls.Add(this.hmiRootPanel2);
            this.tabLFAddMat.Controls.Add(this.pnlMat);
            this.tabLFAddMat.Location = new System.Drawing.Point(4, 22);
            this.tabLFAddMat.Name = "tabLFAddMat";
            this.tabLFAddMat.Padding = new System.Windows.Forms.Padding(3);
            this.tabLFAddMat.Size = new System.Drawing.Size(996, 368);
            this.tabLFAddMat.TabIndex = 1;
            this.tabLFAddMat.Text = "加料数据";
            this.tabLFAddMat.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel2
            // 
            this.hmiRootPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hmiRootPanel2.Controls.Add(this.cmb_Mat);
            this.hmiRootPanel2.Controls.Add(this.dvMat);
            this.hmiRootPanel2.Controls.Add(this.bnAddMat);
            this.hmiRootPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel2.Location = new System.Drawing.Point(3, 3);
            this.hmiRootPanel2.Name = "hmiRootPanel2";
            this.hmiRootPanel2.Size = new System.Drawing.Size(990, 329);
            this.hmiRootPanel2.TabIndex = 90;
            // 
            // cmb_Mat
            // 
            this.cmb_Mat.DataSource = this.bsMat_Alloy_Add_Man;
            this.cmb_Mat.DisplayMember = "Code_des";
            this.cmb_Mat.DropDownHeight = 200;
            this.cmb_Mat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Mat.DropDownWidth = 200;
            this.cmb_Mat.FormattingEnabled = true;
            this.cmb_Mat.IntegralHeight = false;
            this.cmb_Mat.Location = new System.Drawing.Point(322, 50);
            this.cmb_Mat.Name = "cmb_Mat";
            this.cmb_Mat.Size = new System.Drawing.Size(103, 20);
            this.cmb_Mat.TabIndex = 97;
            this.cmb_Mat.ValueMember = "Code";
            this.cmb_Mat.Visible = false;
            this.cmb_Mat.SelectedIndexChanged += new System.EventHandler(this.cmb_Mat_SelectedIndexChanged);
            // 
            // bsMat_Alloy_Add_Man
            // 
            this.bsMat_Alloy_Add_Man.DataMember = "L3DataTable";
            this.bsMat_Alloy_Add_Man.DataSource = this.dsMat_Alloy_Add_Man;
            // 
            // dsMat_Alloy_Add_Man
            // 
            this.dsMat_Alloy_Add_Man.AutoLoad = true;
            this.dsMat_Alloy_Add_Man.AutoSubscribe = false;
            this.dsMat_Alloy_Add_Man.DataSetName = "L3DataSet";
            this.dsMat_Alloy_Add_Man.DeleteMethod = "";
            this.dsMat_Alloy_Add_Man.InsertMethod = "";
            this.dsMat_Alloy_Add_Man.L3DataAdapter = this.Adapter;
            this.dsMat_Alloy_Add_Man.LoadEvent = "";
            this.dsMat_Alloy_Add_Man.LoadTrigger = null;
            this.dsMat_Alloy_Add_Man.RefreshValve = 1000;
            this.dsMat_Alloy_Add_Man.SourceCommand = null;
            this.dsMat_Alloy_Add_Man.SourceCondition = "";
            this.dsMat_Alloy_Add_Man.SourceMethod = "";
            this.dsMat_Alloy_Add_Man.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsMat_Alloy_Add_Man.SourceURI = "";
            this.dsMat_Alloy_Add_Man.SubscribeTarget = "";
            this.dsMat_Alloy_Add_Man.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMat_Alloy_Add_Man});
            this.dsMat_Alloy_Add_Man.UpdateEvent = "";
            this.dsMat_Alloy_Add_Man.UpdateMethod = "";
            this.dsMat_Alloy_Add_Man.UpdateTrigger = null;
            // 
            // schemadsMat_Alloy_Add_Man
            // 
            this.schemadsMat_Alloy_Add_Man.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMat_Alloy_Add_ManL3DataTablebatch_id,
            this.coldsMat_Alloy_Add_ManL3DataTableAlloy_Code,
            this.coldsMat_Alloy_Add_ManL3DataTableCode,
            this.coldsMat_Alloy_Add_ManL3DataTableCode_des});
            this.schemadsMat_Alloy_Add_Man.TableName = "L3DataTable";
            // 
            // coldsMat_Alloy_Add_ManL3DataTablebatch_id
            // 
            this.coldsMat_Alloy_Add_ManL3DataTablebatch_id.Caption = "batch_id";
            this.coldsMat_Alloy_Add_ManL3DataTablebatch_id.ColumnName = "batch_id";
            this.coldsMat_Alloy_Add_ManL3DataTablebatch_id.Namespace = "";
            // 
            // coldsMat_Alloy_Add_ManL3DataTableAlloy_Code
            // 
            this.coldsMat_Alloy_Add_ManL3DataTableAlloy_Code.Caption = "Alloy_Code";
            this.coldsMat_Alloy_Add_ManL3DataTableAlloy_Code.ColumnName = "Alloy_Code";
            this.coldsMat_Alloy_Add_ManL3DataTableAlloy_Code.Namespace = "";
            // 
            // coldsMat_Alloy_Add_ManL3DataTableCode
            // 
            this.coldsMat_Alloy_Add_ManL3DataTableCode.Caption = "Code";
            this.coldsMat_Alloy_Add_ManL3DataTableCode.ColumnName = "Code";
            this.coldsMat_Alloy_Add_ManL3DataTableCode.Namespace = "";
            // 
            // coldsMat_Alloy_Add_ManL3DataTableCode_des
            // 
            this.coldsMat_Alloy_Add_ManL3DataTableCode_des.Caption = "Code_des";
            this.coldsMat_Alloy_Add_ManL3DataTableCode_des.ColumnName = "Code_des";
            this.coldsMat_Alloy_Add_ManL3DataTableCode_des.Namespace = "";
            // 
            // dvMat
            // 
            this.dvMat.AllowUserToAddRows = false;
            this.dvMat.AutoGenerateColumns = false;
            this.dvMat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.treatNoDataGridViewTextBoxColumn,
            this.heatIDDataGridViewTextBoxColumn,
            this.Element,
            this.weightDataGridViewTextBoxColumn,
            this.dischargeTimeDataGridViewTextBoxColumn,
            this.Batch_ID_Mat,
            this.typeDataGridViewCheckBoxColumn,
            this.EnableFlag,
            this.gUIDDataGridViewTextBoxColumn,
            this.Name_Mat});
            this.dvMat.DataSource = this.bsMat;
            this.dvMat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvMat.Location = new System.Drawing.Point(0, 25);
            this.dvMat.Name = "dvMat";
            this.dvMat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvMat.RowTemplate.Height = 23;
            this.dvMat.Size = new System.Drawing.Size(988, 302);
            this.dvMat.TabIndex = 95;
            this.dvMat.CurrentCellDirtyStateChanged += new System.EventHandler(this.dvBatchID_CurrentCellDirtyStateChanged);
            this.dvMat.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMat_DataError);
            // 
            // treatNoDataGridViewTextBoxColumn
            // 
            this.treatNoDataGridViewTextBoxColumn.DataPropertyName = "TreatNo";
            this.treatNoDataGridViewTextBoxColumn.Frozen = true;
            this.treatNoDataGridViewTextBoxColumn.HeaderText = "处理号";
            this.treatNoDataGridViewTextBoxColumn.Name = "treatNoDataGridViewTextBoxColumn";
            // 
            // heatIDDataGridViewTextBoxColumn
            // 
            this.heatIDDataGridViewTextBoxColumn.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn.Frozen = true;
            this.heatIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn.Name = "heatIDDataGridViewTextBoxColumn";
            // 
            // Element
            // 
            this.Element.DataPropertyName = "Element";
            this.Element.DataSource = this.dsCode;
            this.Element.DisplayMember = "L3DataTable.Code_Des";
            this.Element.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Element.Frozen = true;
            this.Element.HeaderText = "辅料代码";
            this.Element.Name = "Element";
            this.Element.ReadOnly = true;
            this.Element.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Element.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Element.ValueMember = "L3DataTable.Code";
            // 
            // dsCode
            // 
            this.dsCode.AutoLoad = true;
            this.dsCode.AutoSubscribe = false;
            this.dsCode.DataSetName = "L3DataSet";
            this.dsCode.DeleteMethod = null;
            this.dsCode.InsertMethod = null;
            this.dsCode.L3DataAdapter = this.Adapter;
            this.dsCode.LoadEvent = "Click";
            this.dsCode.LoadTrigger = null;
            this.dsCode.RefreshValve = 1000;
            this.dsCode.SourceCommand = null;
            this.dsCode.SourceCondition = "CODE_GROUP = \'ALLOY_CODE\' OR CODE_GROUP = \'BULK_CODE\' order by code_des";
            this.dsCode.SourceMethod = "";
            this.dsCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCode.SubscribeTarget = null;
            this.dsCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCode});
            this.dsCode.UpdateEvent = "Click";
            this.dsCode.UpdateMethod = null;
            this.dsCode.UpdateTrigger = null;
            // 
            // schemadsCode
            // 
            this.schemadsCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCodeL3DataTableCode,
            this.coldsCodeL3DataTableCode_Des});
            this.schemadsCode.TableName = "L3DataTable";
            // 
            // coldsCodeL3DataTableCode
            // 
            this.coldsCodeL3DataTableCode.Caption = "Code";
            this.coldsCodeL3DataTableCode.ColumnName = "Code";
            this.coldsCodeL3DataTableCode.Namespace = "";
            // 
            // coldsCodeL3DataTableCode_Des
            // 
            this.coldsCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCodeL3DataTableCode_Des.Namespace = "";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.Frozen = true;
            this.weightDataGridViewTextBoxColumn.HeaderText = "加料量";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // dischargeTimeDataGridViewTextBoxColumn
            // 
            this.dischargeTimeDataGridViewTextBoxColumn.DataPropertyName = "Discharge_Time";
            this.dischargeTimeDataGridViewTextBoxColumn.Frozen = true;
            this.dischargeTimeDataGridViewTextBoxColumn.HeaderText = "加料时刻";
            this.dischargeTimeDataGridViewTextBoxColumn.Name = "dischargeTimeDataGridViewTextBoxColumn";
            this.dischargeTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dischargeTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dischargeTimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // Batch_ID_Mat
            // 
            this.Batch_ID_Mat.DataPropertyName = "Batch_ID";
            this.Batch_ID_Mat.Frozen = true;
            this.Batch_ID_Mat.HeaderText = "批次号";
            this.Batch_ID_Mat.Name = "Batch_ID_Mat";
            this.Batch_ID_Mat.ReadOnly = true;
            // 
            // typeDataGridViewCheckBoxColumn
            // 
            this.typeDataGridViewCheckBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewCheckBoxColumn.DataSource = this.dsAdditionType;
            this.typeDataGridViewCheckBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.typeDataGridViewCheckBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.typeDataGridViewCheckBoxColumn.Frozen = true;
            this.typeDataGridViewCheckBoxColumn.HeaderText = "加料性质";
            this.typeDataGridViewCheckBoxColumn.Name = "typeDataGridViewCheckBoxColumn";
            this.typeDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typeDataGridViewCheckBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.typeDataGridViewCheckBoxColumn.Width = 80;
            // 
            // dsAdditionType
            // 
            this.dsAdditionType.AutoLoad = true;
            this.dsAdditionType.AutoSubscribe = false;
            this.dsAdditionType.DataSetName = "L3DataSet";
            this.dsAdditionType.DeleteMethod = null;
            this.dsAdditionType.InsertMethod = null;
            this.dsAdditionType.L3DataAdapter = this.Adapter;
            this.dsAdditionType.LoadEvent = "Click";
            this.dsAdditionType.LoadTrigger = null;
            this.dsAdditionType.RefreshValve = 1000;
            this.dsAdditionType.SourceCommand = null;
            this.dsAdditionType.SourceCondition = "CODE_GROUP = \'ADDITION_TYPE\' and code is not null order by code";
            this.dsAdditionType.SourceMethod = "";
            this.dsAdditionType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAdditionType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsAdditionType.SubscribeTarget = null;
            this.dsAdditionType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAdditionType});
            this.dsAdditionType.UpdateEvent = "Click";
            this.dsAdditionType.UpdateMethod = null;
            this.dsAdditionType.UpdateTrigger = null;
            // 
            // schemadsAdditionType
            // 
            this.schemadsAdditionType.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAdditionTypeL3DataTableCode_Des,
            this.coldsAdditionTypeL3DataTableCode_Val_Long});
            this.schemadsAdditionType.TableName = "L3DataTable";
            // 
            // coldsAdditionTypeL3DataTableCode_Des
            // 
            this.coldsAdditionTypeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsAdditionTypeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsAdditionTypeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsAdditionTypeL3DataTableCode_Val_Long
            // 
            this.coldsAdditionTypeL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsAdditionTypeL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsAdditionTypeL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsAdditionTypeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // EnableFlag
            // 
            this.EnableFlag.DataPropertyName = "EnableFlag";
            this.EnableFlag.Frozen = true;
            this.EnableFlag.HeaderText = "EnableFlag";
            this.EnableFlag.Name = "EnableFlag";
            this.EnableFlag.Visible = false;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Frozen = true;
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Name_Mat
            // 
            this.Name_Mat.DataPropertyName = "Name";
            this.Name_Mat.Frozen = true;
            this.Name_Mat.HeaderText = "人工录入标志";
            this.Name_Mat.Name = "Name_Mat";
            this.Name_Mat.ReadOnly = true;
            // 
            // bnAddMat
            // 
            this.bnAddMat.AddNewItem = null;
            this.bnAddMat.BindingSource = this.bsMat;
            this.bnAddMat.CountItem = this.toolStripLabel1;
            this.bnAddMat.DeleteItem = null;
            this.bnAddMat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator3,
            this.btnAddMat});
            this.bnAddMat.Location = new System.Drawing.Point(0, 0);
            this.bnAddMat.MoveFirstItem = this.toolStripButton2;
            this.bnAddMat.MoveLastItem = this.toolStripButton5;
            this.bnAddMat.MoveNextItem = this.toolStripButton4;
            this.bnAddMat.MovePreviousItem = this.toolStripButton3;
            this.bnAddMat.Name = "bnAddMat";
            this.bnAddMat.PositionItem = this.toolStripTextBox1;
            this.bnAddMat.Size = new System.Drawing.Size(988, 25);
            this.bnAddMat.TabIndex = 94;
            this.bnAddMat.Text = "bindingNavigator2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "/ {0}";
            this.toolStripLabel1.ToolTipText = "总项数";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "移到第一条记录";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "移到上一条记录";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "位置";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "当前位置";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "移到下一条记录";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "移到最后一条记录";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // pnlMat
            // 
            this.pnlMat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMat.Controls.Add(this.btnMatCancel);
            this.pnlMat.Controls.Add(this.btnMatOK);
            this.pnlMat.Controls.Add(this.btnDelete);
            this.pnlMat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMat.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlMat.Location = new System.Drawing.Point(3, 332);
            this.pnlMat.Name = "pnlMat";
            this.pnlMat.Size = new System.Drawing.Size(990, 33);
            this.pnlMat.TabIndex = 89;
            // 
            // btnMatCancel
            // 
            this.btnMatCancel.Location = new System.Drawing.Point(908, 3);
            this.btnMatCancel.Name = "btnMatCancel";
            this.btnMatCancel.Size = new System.Drawing.Size(75, 23);
            this.btnMatCancel.TabIndex = 87;
            this.btnMatCancel.Text = "取消";
            this.btnMatCancel.UseVisualStyleBackColor = true;
            this.btnMatCancel.Click += new System.EventHandler(this.btnMatCancel_Click);
            // 
            // tabWire
            // 
            this.tabWire.Controls.Add(this.hmiRootPanel3);
            this.tabWire.Location = new System.Drawing.Point(4, 22);
            this.tabWire.Name = "tabWire";
            this.tabWire.Padding = new System.Windows.Forms.Padding(3);
            this.tabWire.Size = new System.Drawing.Size(996, 368);
            this.tabWire.TabIndex = 12;
            this.tabWire.Text = "喂线数据";
            this.tabWire.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel3
            // 
            this.hmiRootPanel3.Controls.Add(this.cmb_Wire);
            this.hmiRootPanel3.Controls.Add(this.dvWire);
            this.hmiRootPanel3.Controls.Add(this.pnlWire);
            this.hmiRootPanel3.Controls.Add(this.bindingNavigator1);
            this.hmiRootPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel3.Location = new System.Drawing.Point(3, 3);
            this.hmiRootPanel3.Name = "hmiRootPanel3";
            this.hmiRootPanel3.Size = new System.Drawing.Size(990, 362);
            this.hmiRootPanel3.TabIndex = 0;
            // 
            // cmb_Wire
            // 
            this.cmb_Wire.DataSource = this.bsWire_Add_man;
            this.cmb_Wire.DisplayMember = "Code_des";
            this.cmb_Wire.DropDownHeight = 200;
            this.cmb_Wire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Wire.DropDownWidth = 200;
            this.cmb_Wire.FormattingEnabled = true;
            this.cmb_Wire.IntegralHeight = false;
            this.cmb_Wire.Location = new System.Drawing.Point(244, 48);
            this.cmb_Wire.Name = "cmb_Wire";
            this.cmb_Wire.Size = new System.Drawing.Size(96, 20);
            this.cmb_Wire.TabIndex = 101;
            this.cmb_Wire.ValueMember = "Code";
            this.cmb_Wire.Visible = false;
            this.cmb_Wire.SelectedIndexChanged += new System.EventHandler(this.cmb_Wire_SelectedIndexChanged);
            // 
            // bsWire_Add_man
            // 
            this.bsWire_Add_man.DataMember = "L3DataTable";
            this.bsWire_Add_man.DataSource = this.dsWire_Add_man;
            // 
            // dsWire_Add_man
            // 
            this.dsWire_Add_man.AutoLoad = true;
            this.dsWire_Add_man.AutoSubscribe = false;
            this.dsWire_Add_man.DataSetName = "L3DataSet";
            this.dsWire_Add_man.DeleteMethod = "";
            this.dsWire_Add_man.InsertMethod = "";
            this.dsWire_Add_man.L3DataAdapter = this.Adapter;
            this.dsWire_Add_man.LoadEvent = "";
            this.dsWire_Add_man.LoadTrigger = null;
            this.dsWire_Add_man.RefreshValve = 1000;
            this.dsWire_Add_man.SourceCommand = null;
            this.dsWire_Add_man.SourceCondition = "";
            this.dsWire_Add_man.SourceMethod = "";
            this.dsWire_Add_man.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsWire_Add_man.SourceURI = "";
            this.dsWire_Add_man.SubscribeTarget = "";
            this.dsWire_Add_man.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWire_Add_man});
            this.dsWire_Add_man.UpdateEvent = "";
            this.dsWire_Add_man.UpdateMethod = "";
            this.dsWire_Add_man.UpdateTrigger = null;
            // 
            // schemadsWire_Add_man
            // 
            this.schemadsWire_Add_man.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWire_Add_manL3DataTablealloy_code,
            this.coldsWire_Add_manL3DataTablebatch_id,
            this.coldsWire_Add_manL3DataTablecode,
            this.coldsWire_Add_manL3DataTablecode_des,
            this.coldsWire_Add_manL3DataTablecode_function_group});
            this.schemadsWire_Add_man.TableName = "L3DataTable";
            // 
            // coldsWire_Add_manL3DataTablealloy_code
            // 
            this.coldsWire_Add_manL3DataTablealloy_code.Caption = "alloy_code";
            this.coldsWire_Add_manL3DataTablealloy_code.ColumnName = "alloy_code";
            this.coldsWire_Add_manL3DataTablealloy_code.Namespace = "";
            // 
            // coldsWire_Add_manL3DataTablebatch_id
            // 
            this.coldsWire_Add_manL3DataTablebatch_id.Caption = "batch_id";
            this.coldsWire_Add_manL3DataTablebatch_id.ColumnName = "batch_id";
            this.coldsWire_Add_manL3DataTablebatch_id.Namespace = "";
            // 
            // coldsWire_Add_manL3DataTablecode
            // 
            this.coldsWire_Add_manL3DataTablecode.Caption = "code";
            this.coldsWire_Add_manL3DataTablecode.ColumnName = "code";
            this.coldsWire_Add_manL3DataTablecode.Namespace = "";
            // 
            // coldsWire_Add_manL3DataTablecode_des
            // 
            this.coldsWire_Add_manL3DataTablecode_des.Caption = "code_des";
            this.coldsWire_Add_manL3DataTablecode_des.ColumnName = "code_des";
            this.coldsWire_Add_manL3DataTablecode_des.Namespace = "";
            // 
            // coldsWire_Add_manL3DataTablecode_function_group
            // 
            this.coldsWire_Add_manL3DataTablecode_function_group.Caption = "code_function_group";
            this.coldsWire_Add_manL3DataTablecode_function_group.ColumnName = "code_function_group";
            this.coldsWire_Add_manL3DataTablecode_function_group.Namespace = "";
            // 
            // dvWire
            // 
            this.dvWire.AllowUserToAddRows = false;
            this.dvWire.AllowUserToDeleteRows = false;
            this.dvWire.AutoGenerateColumns = false;
            this.dvWire.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvWire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvWire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.treatNoDataGridViewTextBoxColumn5,
            this.heatIDDataGridViewTextBoxColumn6,
            this.WireCode,
            this.Weight,
            this.Amount,
            this.Batch_ID_Wire,
            this.speedDataGridViewTextBoxColumn,
            this.wireTimeDataGridViewTextBoxColumn,
            this.Name_Wire});
            this.dvWire.DataSource = this.bsWire;
            this.dvWire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvWire.Location = new System.Drawing.Point(0, 25);
            this.dvWire.Name = "dvWire";
            this.dvWire.RowTemplate.Height = 23;
            this.dvWire.Size = new System.Drawing.Size(990, 304);
            this.dvWire.TabIndex = 100;
            this.dvWire.CurrentCellDirtyStateChanged += new System.EventHandler(this.dvWire_CurrentCellDirtyStateChanged);
            this.dvWire.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMat_DataError);
            // 
            // treatNoDataGridViewTextBoxColumn5
            // 
            this.treatNoDataGridViewTextBoxColumn5.DataPropertyName = "TreatNo";
            this.treatNoDataGridViewTextBoxColumn5.Frozen = true;
            this.treatNoDataGridViewTextBoxColumn5.HeaderText = "处理号";
            this.treatNoDataGridViewTextBoxColumn5.Name = "treatNoDataGridViewTextBoxColumn5";
            // 
            // heatIDDataGridViewTextBoxColumn6
            // 
            this.heatIDDataGridViewTextBoxColumn6.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn6.Frozen = true;
            this.heatIDDataGridViewTextBoxColumn6.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn6.Name = "heatIDDataGridViewTextBoxColumn6";
            // 
            // WireCode
            // 
            this.WireCode.DataPropertyName = "WireCode";
            this.WireCode.DataSource = this.dsWireCode;
            this.WireCode.DisplayMember = "L3DataTable.Code_Des";
            this.WireCode.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.WireCode.Frozen = true;
            this.WireCode.HeaderText = "喂线代码";
            this.WireCode.Name = "WireCode";
            this.WireCode.ReadOnly = true;
            this.WireCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WireCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.WireCode.ValueMember = "L3DataTable.Code";
            // 
            // dsWireCode
            // 
            this.dsWireCode.AutoLoad = true;
            this.dsWireCode.AutoSubscribe = false;
            this.dsWireCode.DataSetName = "L3DataSet";
            this.dsWireCode.DeleteMethod = "";
            this.dsWireCode.InsertMethod = "";
            this.dsWireCode.L3DataAdapter = this.Adapter;
            this.dsWireCode.LoadEvent = "";
            this.dsWireCode.LoadTrigger = null;
            this.dsWireCode.RefreshValve = 1000;
            this.dsWireCode.SourceCommand = null;
            this.dsWireCode.SourceCondition = "CODE_FUNCTION_GROUP = \'FeedWire\'";
            this.dsWireCode.SourceMethod = "";
            this.dsWireCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWireCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsWireCode.SubscribeTarget = null;
            this.dsWireCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWireCode});
            this.dsWireCode.UpdateEvent = "";
            this.dsWireCode.UpdateMethod = "";
            this.dsWireCode.UpdateTrigger = null;
            // 
            // schemadsWireCode
            // 
            this.schemadsWireCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWireCodeL3DataTableCode,
            this.coldsWireCodeL3DataTableCode_Des});
            this.schemadsWireCode.TableName = "L3DataTable";
            // 
            // coldsWireCodeL3DataTableCode
            // 
            this.coldsWireCodeL3DataTableCode.Caption = "Code";
            this.coldsWireCodeL3DataTableCode.ColumnName = "Code";
            this.coldsWireCodeL3DataTableCode.Namespace = "";
            // 
            // coldsWireCodeL3DataTableCode_Des
            // 
            this.coldsWireCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsWireCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsWireCodeL3DataTableCode_Des.Namespace = "";
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            this.Weight.Frozen = true;
            this.Weight.HeaderText = "喂线长度[M]";
            this.Weight.Name = "Weight";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.Frozen = true;
            this.Amount.HeaderText = "喂线重量[Kg]";
            this.Amount.Name = "Amount";
            // 
            // Batch_ID_Wire
            // 
            this.Batch_ID_Wire.DataPropertyName = "Batch_ID";
            this.Batch_ID_Wire.Frozen = true;
            this.Batch_ID_Wire.HeaderText = "批次号";
            this.Batch_ID_Wire.Name = "Batch_ID_Wire";
            // 
            // speedDataGridViewTextBoxColumn
            // 
            this.speedDataGridViewTextBoxColumn.DataPropertyName = "Speed";
            this.speedDataGridViewTextBoxColumn.Frozen = true;
            this.speedDataGridViewTextBoxColumn.HeaderText = "喂线速度";
            this.speedDataGridViewTextBoxColumn.Name = "speedDataGridViewTextBoxColumn";
            // 
            // wireTimeDataGridViewTextBoxColumn
            // 
            this.wireTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.wireTimeDataGridViewTextBoxColumn.DataPropertyName = "WireTime";
            this.wireTimeDataGridViewTextBoxColumn.Frozen = true;
            this.wireTimeDataGridViewTextBoxColumn.HeaderText = "喂线时刻";
            this.wireTimeDataGridViewTextBoxColumn.Name = "wireTimeDataGridViewTextBoxColumn";
            this.wireTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wireTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wireTimeDataGridViewTextBoxColumn.Width = 144;
            // 
            // Name_Wire
            // 
            this.Name_Wire.DataPropertyName = "Name";
            this.Name_Wire.Frozen = true;
            this.Name_Wire.HeaderText = "人工录入标志";
            this.Name_Wire.Name = "Name_Wire";
            this.Name_Wire.ReadOnly = true;
            // 
            // bsWire
            // 
            this.bsWire.DataMember = "L3DataTable";
            this.bsWire.DataSource = this.dsWire;
            this.bsWire.CurrentChanged += new System.EventHandler(this.bsBatchID_CurrentChanged);
            // 
            // dsWire
            // 
            this.dsWire.AutoLoad = true;
            this.dsWire.AutoSubscribe = false;
            this.dsWire.DataSetName = "L3DataSet";
            this.dsWire.DeleteMethod = null;
            this.dsWire.InsertMethod = null;
            this.dsWire.L3DataAdapter = null;
            this.dsWire.LoadEvent = "Click";
            this.dsWire.LoadTrigger = null;
            this.dsWire.RefreshValve = 1000;
            this.dsWire.SourceCommand = null;
            this.dsWire.SourceCondition = "1=2";
            this.dsWire.SourceMethod = "";
            this.dsWire.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWire.SourceURI = "XGMESLogic\\RHMag\\CRH_Wire_Data";
            this.dsWire.SubscribeTarget = null;
            this.dsWire.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWire});
            this.dsWire.UpdateEvent = "Click";
            this.dsWire.UpdateMethod = null;
            this.dsWire.UpdateTrigger = null;
            // 
            // schemadsWire
            // 
            this.schemadsWire.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWireL3DataTableGUID,
            this.coldsWireL3DataTableName,
            this.coldsWireL3DataTableTreatNo,
            this.coldsWireL3DataTableHeatID,
            this.coldsWireL3DataTableWireCode,
            this.coldsWireL3DataTableWeight,
            this.coldsWireL3DataTableSpeed,
            this.coldsWireL3DataTableWireTime,
            this.coldsWireL3DataTableBatch_ID,
            this.coldsWireL3DataTableEnableFlag,
            this.coldsWireL3DataTableAmount});
            this.schemadsWire.TableName = "L3DataTable";
            // 
            // coldsWireL3DataTableGUID
            // 
            this.coldsWireL3DataTableGUID.Caption = "GUID";
            this.coldsWireL3DataTableGUID.ColumnName = "GUID";
            this.coldsWireL3DataTableGUID.Namespace = "";
            // 
            // coldsWireL3DataTableName
            // 
            this.coldsWireL3DataTableName.Caption = "Name";
            this.coldsWireL3DataTableName.ColumnName = "Name";
            this.coldsWireL3DataTableName.Namespace = "";
            // 
            // coldsWireL3DataTableTreatNo
            // 
            this.coldsWireL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsWireL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsWireL3DataTableTreatNo.Namespace = "";
            // 
            // coldsWireL3DataTableHeatID
            // 
            this.coldsWireL3DataTableHeatID.Caption = "HeatID";
            this.coldsWireL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsWireL3DataTableHeatID.Namespace = "";
            // 
            // coldsWireL3DataTableWireCode
            // 
            this.coldsWireL3DataTableWireCode.Caption = "WireCode";
            this.coldsWireL3DataTableWireCode.ColumnName = "WireCode";
            this.coldsWireL3DataTableWireCode.Namespace = "";
            // 
            // coldsWireL3DataTableWeight
            // 
            this.coldsWireL3DataTableWeight.Caption = "Weight";
            this.coldsWireL3DataTableWeight.ColumnName = "Weight";
            this.coldsWireL3DataTableWeight.DataType = typeof(float);
            this.coldsWireL3DataTableWeight.Namespace = "";
            // 
            // coldsWireL3DataTableSpeed
            // 
            this.coldsWireL3DataTableSpeed.Caption = "Speed";
            this.coldsWireL3DataTableSpeed.ColumnName = "Speed";
            this.coldsWireL3DataTableSpeed.DataType = typeof(float);
            this.coldsWireL3DataTableSpeed.Namespace = "";
            // 
            // coldsWireL3DataTableWireTime
            // 
            this.coldsWireL3DataTableWireTime.Caption = "WireTime";
            this.coldsWireL3DataTableWireTime.ColumnName = "WireTime";
            this.coldsWireL3DataTableWireTime.DataType = typeof(System.DateTime);
            this.coldsWireL3DataTableWireTime.Namespace = "";
            // 
            // coldsWireL3DataTableBatch_ID
            // 
            this.coldsWireL3DataTableBatch_ID.Caption = "Batch_ID";
            this.coldsWireL3DataTableBatch_ID.ColumnName = "Batch_ID";
            this.coldsWireL3DataTableBatch_ID.Namespace = "";
            // 
            // coldsWireL3DataTableEnableFlag
            // 
            this.coldsWireL3DataTableEnableFlag.Caption = "EnableFlag";
            this.coldsWireL3DataTableEnableFlag.ColumnName = "EnableFlag";
            this.coldsWireL3DataTableEnableFlag.Namespace = "";
            // 
            // coldsWireL3DataTableAmount
            // 
            this.coldsWireL3DataTableAmount.Caption = "Amount";
            this.coldsWireL3DataTableAmount.ColumnName = "Amount";
            this.coldsWireL3DataTableAmount.DataType = typeof(double);
            this.coldsWireL3DataTableAmount.Namespace = "";
            // 
            // pnlWire
            // 
            this.pnlWire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlWire.Controls.Add(this.btnWireCancel);
            this.pnlWire.Controls.Add(this.btnWireConfirm);
            this.pnlWire.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlWire.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlWire.Location = new System.Drawing.Point(0, 329);
            this.pnlWire.Name = "pnlWire";
            this.pnlWire.Size = new System.Drawing.Size(990, 33);
            this.pnlWire.TabIndex = 99;
            // 
            // btnWireCancel
            // 
            this.btnWireCancel.Location = new System.Drawing.Point(908, 3);
            this.btnWireCancel.Name = "btnWireCancel";
            this.btnWireCancel.Size = new System.Drawing.Size(75, 23);
            this.btnWireCancel.TabIndex = 87;
            this.btnWireCancel.Text = "取消";
            this.btnWireCancel.UseVisualStyleBackColor = true;
            this.btnWireCancel.Click += new System.EventHandler(this.btnWireCancel_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsWire;
            this.bindingNavigator1.CountItem = this.toolStripLabel7;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton6,
            this.toolStripSeparator19,
            this.toolStripTextBox7,
            this.toolStripLabel7,
            this.toolStripSeparator20,
            this.toolStripButton11,
            this.toolStripButton16,
            this.toolStripSeparator21,
            this.btnWireAdd});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton1;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton16;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton11;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton6;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox7;
            this.bindingNavigator1.Size = new System.Drawing.Size(990, 25);
            this.bindingNavigator1.TabIndex = 97;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel7.Text = "/ {0}";
            this.toolStripLabel7.ToolTipText = "总项数";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "移到第一条记录";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "移到上一条记录";
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox7
            // 
            this.toolStripTextBox7.AccessibleName = "位置";
            this.toolStripTextBox7.AutoSize = false;
            this.toolStripTextBox7.Name = "toolStripTextBox7";
            this.toolStripTextBox7.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox7.Text = "0";
            this.toolStripTextBox7.ToolTipText = "当前位置";
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "移到下一条记录";
            // 
            // toolStripButton16
            // 
            this.toolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton16.Image")));
            this.toolStripButton16.Name = "toolStripButton16";
            this.toolStripButton16.RightToLeftAutoMirrorImage = true;
            this.toolStripButton16.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton16.Text = "移到最后一条记录";
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            this.toolStripSeparator21.Size = new System.Drawing.Size(6, 25);
            // 
            // tabProcess
            // 
            this.tabProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabProcess.Controls.Add(this.txtDepartureTemp);
            this.tabProcess.Controls.Add(this.txtWholePumpTimeDis);
            this.tabProcess.Controls.Add(this.txtWholePumpTime);
            this.tabProcess.Controls.Add(this.label36);
            this.tabProcess.Controls.Add(this.label21);
            this.tabProcess.Controls.Add(this.label17);
            this.tabProcess.Controls.Add(this.cmbArrivalTempQuality);
            this.tabProcess.Controls.Add(this.txtSoftBlowTimeDis);
            this.tabProcess.Controls.Add(this.txtSoftBlowTime);
            this.tabProcess.Controls.Add(this.label16);
            this.tabProcess.Controls.Add(this.dtWireEndTime);
            this.tabProcess.Controls.Add(this.dtSoftBlowStopTime);
            this.tabProcess.Controls.Add(this.label11);
            this.tabProcess.Controls.Add(this.txtWireEndTemp);
            this.tabProcess.Controls.Add(this.txtAlCONS);
            this.tabProcess.Controls.Add(this.txtOBCount);
            this.tabProcess.Controls.Add(this.label18);
            this.tabProcess.Controls.Add(this.label15);
            this.tabProcess.Controls.Add(this.label13);
            this.tabProcess.Controls.Add(this.label43);
            this.tabProcess.Controls.Add(this.txtLadleGrade);
            this.tabProcess.Controls.Add(this.txtTotalTime);
            this.tabProcess.Controls.Add(this.txtLadleNo);
            this.tabProcess.Controls.Add(this.txtOBCycleTime);
            this.tabProcess.Controls.Add(this.label20);
            this.tabProcess.Controls.Add(this.label35);
            this.tabProcess.Controls.Add(this.txt02CONS);
            this.tabProcess.Controls.Add(this.label19);
            this.tabProcess.Controls.Add(this.txtVacMin);
            this.tabProcess.Controls.Add(this.label14);
            this.tabProcess.Controls.Add(this.label12);
            this.tabProcess.Controls.Add(this.label44);
            this.tabProcess.Controls.Add(this.txtLoopTime);
            this.tabProcess.Controls.Add(this.label40);
            this.tabProcess.Controls.Add(this.txtProbeVonder);
            this.tabProcess.Controls.Add(this.label41);
            this.tabProcess.Controls.Add(this.dtSoftBlowStartTime);
            this.tabProcess.Controls.Add(this.dtEndTime);
            this.tabProcess.Controls.Add(this.dtStartTime);
            this.tabProcess.Controls.Add(this.dtArrivalTime);
            this.tabProcess.Controls.Add(this.txtProcessTimeDis);
            this.tabProcess.Controls.Add(this.txtProcessTime);
            this.tabProcess.Controls.Add(this.label23);
            this.tabProcess.Controls.Add(this.txtSlotNo);
            this.tabProcess.Controls.Add(this.label24);
            this.tabProcess.Controls.Add(this.txtSlagThick);
            this.tabProcess.Controls.Add(this.label25);
            this.tabProcess.Controls.Add(this.label26);
            this.tabProcess.Controls.Add(this.txtProcessMode);
            this.tabProcess.Controls.Add(this.label27);
            this.tabProcess.Controls.Add(this.txtProcessLocation);
            this.tabProcess.Controls.Add(this.label28);
            this.tabProcess.Controls.Add(this.txtArrivalTemp);
            this.tabProcess.Controls.Add(this.label30);
            this.tabProcess.Controls.Add(this.label31);
            this.tabProcess.Controls.Add(this.label32);
            this.tabProcess.Controls.Add(this.label33);
            this.tabProcess.Controls.Add(this.label34);
            this.tabProcess.Controls.Add(this.pnlProcess);
            this.tabProcess.Location = new System.Drawing.Point(4, 22);
            this.tabProcess.Name = "tabProcess";
            this.tabProcess.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcess.Size = new System.Drawing.Size(996, 368);
            this.tabProcess.TabIndex = 2;
            this.tabProcess.Text = "精炼数据";
            this.tabProcess.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(805, 39);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 23);
            this.label21.TabIndex = 184;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(570, 255);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 12);
            this.label17.TabIndex = 183;
            this.label17.Text = "进站温度是否合格:";
            // 
            // cmbArrivalTempQuality
            // 
            this.cmbArrivalTempQuality.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProcess, "Arrival_Temp_Quality", true));
            this.cmbArrivalTempQuality.DataSource = this.dsYesNo;
            this.cmbArrivalTempQuality.DisplayMember = "L3DataTable.Code_Des";
            this.cmbArrivalTempQuality.FormattingEnabled = true;
            this.cmbArrivalTempQuality.Location = new System.Drawing.Point(683, 251);
            this.cmbArrivalTempQuality.Name = "cmbArrivalTempQuality";
            this.cmbArrivalTempQuality.Size = new System.Drawing.Size(91, 20);
            this.cmbArrivalTempQuality.TabIndex = 182;
            this.cmbArrivalTempQuality.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsYesNo
            // 
            this.dsYesNo.AutoLoad = true;
            this.dsYesNo.AutoSubscribe = false;
            this.dsYesNo.DataSetName = "L3DataSet";
            this.dsYesNo.DeleteMethod = "";
            this.dsYesNo.InsertMethod = "";
            this.dsYesNo.L3DataAdapter = this.Adapter;
            this.dsYesNo.LoadEvent = "";
            this.dsYesNo.LoadTrigger = null;
            this.dsYesNo.RefreshValve = 1000;
            this.dsYesNo.SourceCommand = null;
            this.dsYesNo.SourceCondition = "code_group = \'COMMON_YESNO\'";
            this.dsYesNo.SourceMethod = "";
            this.dsYesNo.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsYesNo.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsYesNo.SubscribeTarget = null;
            this.dsYesNo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsYesNo});
            this.dsYesNo.UpdateEvent = "";
            this.dsYesNo.UpdateMethod = "";
            this.dsYesNo.UpdateTrigger = null;
            // 
            // schemadsYesNo
            // 
            this.schemadsYesNo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsYesNoL3DataTableCode_Des,
            this.coldsYesNoL3DataTableCode_Val_Long});
            this.schemadsYesNo.TableName = "L3DataTable";
            // 
            // coldsYesNoL3DataTableCode_Des
            // 
            this.coldsYesNoL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsYesNoL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsYesNoL3DataTableCode_Des.Namespace = "";
            // 
            // coldsYesNoL3DataTableCode_Val_Long
            // 
            this.coldsYesNoL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsYesNoL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsYesNoL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsYesNoL3DataTableCode_Val_Long.Namespace = "";
            // 
            // txtSoftBlowTimeDis
            // 
            //
            this.txtSoftBlowTimeDis.EnableNull = true;
            this.txtSoftBlowTimeDis.ErropPr = null;
            //
            this.txtSoftBlowTimeDis.Length = 0;
            this.txtSoftBlowTimeDis.Location = new System.Drawing.Point(154, 196);
            this.txtSoftBlowTimeDis.Max = 9999;
            //
            //
            this.txtSoftBlowTimeDis.MaxStrLength = 0;
            this.txtSoftBlowTimeDis.Min = 0;
            //
            //
            this.txtSoftBlowTimeDis.MinStrLength = 0;
            this.txtSoftBlowTimeDis.Name = "txtSoftBlowTimeDis";
            this.txtSoftBlowTimeDis.Precision = 0;
            this.txtSoftBlowTimeDis.ReadOnly = true;
            //
            this.txtSoftBlowTimeDis.Size = new System.Drawing.Size(144, 21);
            this.txtSoftBlowTimeDis.TabIndex = 6;
            this.txtSoftBlowTimeDis.ToolTipValid = null;
          //
            this.txtSoftBlowTimeDis.ValidEable = true;
            this.txtSoftBlowTimeDis.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtSoftBlowTime
            // 
            this.txtSoftBlowTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "SoftBlow_Time", true));
            //
            this.txtSoftBlowTime.EnableNull = true;
            this.txtSoftBlowTime.ErropPr = this.errorProvider1;
            //
            this.txtSoftBlowTime.Length = 0;
            this.txtSoftBlowTime.Location = new System.Drawing.Point(694, 41);
            this.txtSoftBlowTime.Max = 0;
            //
            //
            this.txtSoftBlowTime.MaxStrLength = 0;
            this.txtSoftBlowTime.Min = -0.99;
            //
            //
            this.txtSoftBlowTime.MinStrLength = 0;
            this.txtSoftBlowTime.Name = "txtSoftBlowTime";
            this.txtSoftBlowTime.Precision = 0;
            //
            this.txtSoftBlowTime.Size = new System.Drawing.Size(21, 21);
            this.txtSoftBlowTime.TabIndex = 6;
            this.txtSoftBlowTime.ToolTipValid = this.toolTip1;
          //
            this.txtSoftBlowTime.ValidEable = false;
            this.txtSoftBlowTime.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            this.txtSoftBlowTime.TextChanged += new System.EventHandler(this.txtSoftBlowTime_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(89, 199);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 12);
            this.label16.TabIndex = 181;
            this.label16.Text = "软吹时间:";
            // 
            // dtWireEndTime
            // 
            this.dtWireEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtWireEndTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "Wire_End_Time", true));
            this.dtWireEndTime.Enabled = false;
            this.dtWireEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtWireEndTime.Location = new System.Drawing.Point(154, 170);
            this.dtWireEndTime.Name = "dtWireEndTime";
            this.dtWireEndTime.Size = new System.Drawing.Size(144, 21);
            this.dtWireEndTime.TabIndex = 5;
            // 
            // dtSoftBlowStopTime
            // 
            this.dtSoftBlowStopTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtSoftBlowStopTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "SoftBlow_EndTime", true));
            this.dtSoftBlowStopTime.Enabled = false;
            this.dtSoftBlowStopTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSoftBlowStopTime.Location = new System.Drawing.Point(154, 145);
            this.dtSoftBlowStopTime.Name = "dtSoftBlowStopTime";
            this.dtSoftBlowStopTime.Size = new System.Drawing.Size(144, 21);
            this.dtSoftBlowStopTime.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(65, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 12);
            this.label11.TabIndex = 178;
            this.label11.Text = "软吹结束时刻:";
            // 
            // txtWireEndTemp
            // 
            this.txtWireEndTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Wire_End_Temp", true));
            //
            this.txtWireEndTemp.EnableNull = true;
            this.txtWireEndTemp.ErropPr = this.errorProvider1;
            //
            this.txtWireEndTemp.Length = 0;
            this.txtWireEndTemp.Location = new System.Drawing.Point(683, 224);
            this.txtWireEndTemp.Max = 2000;
            //
            //
            this.txtWireEndTemp.MaxStrLength = 0;
            this.txtWireEndTemp.Min = 0;
            //
            //
            this.txtWireEndTemp.MinStrLength = 0;
            this.txtWireEndTemp.Name = "txtWireEndTemp";
            this.txtWireEndTemp.Precision = 0;
            this.txtWireEndTemp.ReadOnly = true;
            //
            this.txtWireEndTemp.Size = new System.Drawing.Size(91, 21);
            this.txtWireEndTemp.TabIndex = 23;
            this.txtWireEndTemp.ToolTipValid = this.toolTip1;
          //
            this.txtWireEndTemp.ValidEable = true;
            this.txtWireEndTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtAlCONS
            // 
            this.txtAlCONS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Al_CONS", true));
            //
            this.txtAlCONS.EnableNull = true;
            this.txtAlCONS.ErropPr = this.errorProvider1;
            //
            this.txtAlCONS.Length = 0;
            this.txtAlCONS.Location = new System.Drawing.Point(683, 197);
            this.txtAlCONS.Max = 9999;
            //
            //
            this.txtAlCONS.MaxStrLength = 0;
            this.txtAlCONS.Min = 0;
            //
            //
            this.txtAlCONS.MinStrLength = 0;
            this.txtAlCONS.Name = "txtAlCONS";
            this.txtAlCONS.Precision = 0;
            this.txtAlCONS.ReadOnly = true;
            //
            this.txtAlCONS.Size = new System.Drawing.Size(91, 21);
            this.txtAlCONS.TabIndex = 22;
            this.txtAlCONS.ToolTipValid = this.toolTip1;
          //
            this.txtAlCONS.ValidEable = true;
            this.txtAlCONS.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtOBCount
            // 
            this.txtOBCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "OB_Count", true));
            //
            this.txtOBCount.EnableNull = true;
            this.txtOBCount.ErropPr = this.errorProvider1;
            //
            this.txtOBCount.Length = 0;
            this.txtOBCount.Location = new System.Drawing.Point(683, 171);
            this.txtOBCount.Max = 999;
            //
            //
            this.txtOBCount.MaxStrLength = 0;
            this.txtOBCount.Min = 0;
            //
            //
            this.txtOBCount.MinStrLength = 0;
            this.txtOBCount.Name = "txtOBCount";
            this.txtOBCount.Precision = 0;
            this.txtOBCount.ReadOnly = true;
            //
            this.txtOBCount.Size = new System.Drawing.Size(91, 21);
            this.txtOBCount.TabIndex = 21;
            this.txtOBCount.ToolTipValid = this.toolTip1;
          //
            this.txtOBCount.ValidEable = true;
            this.txtOBCount.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(53, 175);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 12);
            this.label18.TabIndex = 174;
            this.label18.Text = "钙处理完毕时刻:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(558, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 12);
            this.label15.TabIndex = 174;
            this.label15.Text = "钙处理完毕温度[℃]:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(594, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 12);
            this.label13.TabIndex = 174;
            this.label13.Text = "消耗铝量[Kg]:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(630, 175);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(47, 12);
            this.label43.TabIndex = 174;
            this.label43.Text = "OB次数:";
            // 
            // txtLadleGrade
            // 
            this.txtLadleGrade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "LadleGrade", true));
            //
            this.txtLadleGrade.EnableNull = true;
            this.txtLadleGrade.ErropPr = null;
            //
            this.txtLadleGrade.Length = 0;
            this.txtLadleGrade.Location = new System.Drawing.Point(441, 224);
            this.txtLadleGrade.Max = 99;
            //
            //
            this.txtLadleGrade.MaxStrLength = 0;
            this.txtLadleGrade.Min = 0;
            //
            //
            this.txtLadleGrade.MinStrLength = 0;
            this.txtLadleGrade.Name = "txtLadleGrade";
            this.txtLadleGrade.Precision = 0;
            this.txtLadleGrade.ReadOnly = true;
            //
            this.txtLadleGrade.Size = new System.Drawing.Size(87, 21);
            this.txtLadleGrade.TabIndex = 15;
            this.txtLadleGrade.ToolTipValid = null;
          //
            this.txtLadleGrade.ValidEable = true;
            this.txtLadleGrade.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtTotalTime
            // 
            //
            this.txtTotalTime.EnableNull = true;
            this.txtTotalTime.ErropPr = null;
            //
            this.txtTotalTime.Length = 0;
            this.txtTotalTime.Location = new System.Drawing.Point(154, 251);
            this.txtTotalTime.Max = 9999;
            //
            //
            this.txtTotalTime.MaxStrLength = 0;
            this.txtTotalTime.Min = 0;
            //
            //
            this.txtTotalTime.MinStrLength = 0;
            this.txtTotalTime.Name = "txtTotalTime";
            this.txtTotalTime.Precision = 0;
            this.txtTotalTime.ReadOnly = true;
            //
            this.txtTotalTime.Size = new System.Drawing.Size(144, 21);
            this.txtTotalTime.TabIndex = 15;
            this.txtTotalTime.ToolTipValid = null;
          //
            this.txtTotalTime.ValidEable = true;
            this.txtTotalTime.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtLadleNo
            // 
            this.txtLadleNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "LadleNo", true));
            //
            this.txtLadleNo.EnableNull = true;
            this.txtLadleNo.ErropPr = null;
            //
            this.txtLadleNo.Length = 0;
            this.txtLadleNo.Location = new System.Drawing.Point(441, 251);
            this.txtLadleNo.Max = 9999;
            //
            //
            this.txtLadleNo.MaxStrLength = 0;
            this.txtLadleNo.Min = 0;
            //
            //
            this.txtLadleNo.MinStrLength = 0;
            this.txtLadleNo.Name = "txtLadleNo";
            this.txtLadleNo.Precision = 0;
            this.txtLadleNo.ReadOnly = true;
            //
            this.txtLadleNo.Size = new System.Drawing.Size(87, 21);
            this.txtLadleNo.TabIndex = 15;
            this.txtLadleNo.ToolTipValid = null;
          //
            this.txtLadleNo.ValidEable = true;
            this.txtLadleNo.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtOBCycleTime
            // 
            this.txtOBCycleTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "OB_Cycle_Time", true));
            //
            this.txtOBCycleTime.EnableNull = true;
            this.txtOBCycleTime.ErropPr = this.errorProvider1;
            //
            this.txtOBCycleTime.Length = 0;
            this.txtOBCycleTime.Location = new System.Drawing.Point(441, 199);
            this.txtOBCycleTime.Max = 9999;
            //
            //
            this.txtOBCycleTime.MaxStrLength = 0;
            this.txtOBCycleTime.Min = 0;
            //
            //
            this.txtOBCycleTime.MinStrLength = 0;
            this.txtOBCycleTime.Name = "txtOBCycleTime";
            this.txtOBCycleTime.Precision = 0;
            this.txtOBCycleTime.ReadOnly = true;
            //
            this.txtOBCycleTime.Size = new System.Drawing.Size(87, 21);
            this.txtOBCycleTime.TabIndex = 15;
            this.txtOBCycleTime.ToolTipValid = this.toolTip1;
          //
            this.txtOBCycleTime.ValidEable = true;
            this.txtOBCycleTime.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(376, 227);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 12);
            this.label20.TabIndex = 172;
            this.label20.Text = "钢包状况:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(52, 255);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(95, 12);
            this.label35.TabIndex = 172;
            this.label35.Text = "浸渍管累计时间:";
            // 
            // txt02CONS
            // 
            this.txt02CONS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "O2_CONS", true));
            //
            this.txt02CONS.EnableNull = true;
            this.txt02CONS.ErropPr = this.errorProvider1;
            //
            this.txt02CONS.Length = 0;
            this.txt02CONS.Location = new System.Drawing.Point(441, 172);
            this.txt02CONS.Max = 999;
            //
            //
            this.txt02CONS.MaxStrLength = 0;
            this.txt02CONS.Min = 0;
            //
            //
            this.txt02CONS.MinStrLength = 0;
            this.txt02CONS.Name = "txt02CONS";
            this.txt02CONS.Precision = 0;
            this.txt02CONS.ReadOnly = true;
            //
            this.txt02CONS.Size = new System.Drawing.Size(87, 21);
            this.txt02CONS.TabIndex = 14;
            this.txt02CONS.ToolTipValid = this.toolTip1;
          //
            this.txt02CONS.ValidEable = true;
            this.txt02CONS.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(388, 255);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 12);
            this.label19.TabIndex = 172;
            this.label19.Text = "钢包号:";
            // 
            // txtVacMin
            // 
            this.txtVacMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Vac_Min", true));
            //
            this.txtVacMin.EnableNull = true;
            this.txtVacMin.ErropPr = this.errorProvider1;
            //
            this.txtVacMin.Length = 0;
            this.txtVacMin.Location = new System.Drawing.Point(441, 146);
            this.txtVacMin.Max = 9999;
            //
            //
            this.txtVacMin.MaxStrLength = 0;
            this.txtVacMin.Min = 0;
            //
            //
            this.txtVacMin.MinStrLength = 0;
            this.txtVacMin.Name = "txtVacMin";
            this.txtVacMin.Precision = 0;
            this.txtVacMin.ReadOnly = true;
            //
            this.txtVacMin.Size = new System.Drawing.Size(87, 21);
            this.txtVacMin.TabIndex = 13;
            this.txtVacMin.ToolTipValid = this.toolTip1;
          //
            this.txtVacMin.ValidEable = true;
            this.txtVacMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(352, 203);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 12);
            this.label14.TabIndex = 172;
            this.label14.Text = "OB后环流时间:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(376, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 172;
            this.label12.Text = "消耗氧量:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(334, 150);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(101, 12);
            this.label44.TabIndex = 172;
            this.label44.Text = "最低真空度[Kpa]:";
            // 
            // txtLoopTime
            // 
            this.txtLoopTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Loop_Time", true));
            //
            this.txtLoopTime.EnableNull = true;
            this.txtLoopTime.ErropPr = this.errorProvider1;
            //
            this.txtLoopTime.Length = 0;
            this.txtLoopTime.Location = new System.Drawing.Point(683, 145);
            this.txtLoopTime.Max = 9999;
            //
            //
            this.txtLoopTime.MaxStrLength = 0;
            this.txtLoopTime.Min = 0;
            //
            //
            this.txtLoopTime.MinStrLength = 0;
            this.txtLoopTime.Name = "txtLoopTime";
            this.txtLoopTime.Precision = 0;
            this.txtLoopTime.ReadOnly = true;
            //
            this.txtLoopTime.Size = new System.Drawing.Size(91, 21);
            this.txtLoopTime.TabIndex = 20;
            this.txtLoopTime.ToolTipValid = this.toolTip1;
          //
            this.txtLoopTime.ValidEable = true;
            this.txtLoopTime.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(606, 149);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(71, 12);
            this.label40.TabIndex = 168;
            this.label40.Text = "纯循环时间:";
            // 
            // txtProbeVonder
            // 
            this.txtProbeVonder.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Probe_Vonder", true));
            //
            this.txtProbeVonder.EnableNull = true;
            this.txtProbeVonder.ErropPr = this.errorProvider1;
            //
            this.txtProbeVonder.Length = 0;
            this.txtProbeVonder.Location = new System.Drawing.Point(441, 120);
            this.txtProbeVonder.Max = 0;
            //
            //
            this.txtProbeVonder.MaxStrLength = 0;
            this.txtProbeVonder.Min = 0;
            //
            //
            this.txtProbeVonder.MinStrLength = 0;
            this.txtProbeVonder.Name = "txtProbeVonder";
            this.txtProbeVonder.Precision = 0;
            this.txtProbeVonder.ReadOnly = true;
            //
            this.txtProbeVonder.Size = new System.Drawing.Size(87, 21);
            this.txtProbeVonder.TabIndex = 12;
            this.txtProbeVonder.ToolTipValid = this.toolTip1;
          //
            this.txtProbeVonder.ValidEable = true;
            this.txtProbeVonder.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(376, 124);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(59, 12);
            this.label41.TabIndex = 166;
            this.label41.Text = "探头厂家:";
            // 
            // dtSoftBlowStartTime
            // 
            this.dtSoftBlowStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtSoftBlowStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "SoftBlow_StartTime", true));
            this.dtSoftBlowStartTime.Enabled = false;
            this.dtSoftBlowStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSoftBlowStartTime.Location = new System.Drawing.Point(154, 119);
            this.dtSoftBlowStartTime.Name = "dtSoftBlowStartTime";
            this.dtSoftBlowStartTime.Size = new System.Drawing.Size(144, 21);
            this.dtSoftBlowStartTime.TabIndex = 3;
            // 
            // dtEndTime
            // 
            this.dtEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtEndTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "End_Time", true));
            this.dtEndTime.Enabled = false;
            this.dtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndTime.Location = new System.Drawing.Point(154, 93);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.Size = new System.Drawing.Size(144, 21);
            this.dtEndTime.TabIndex = 2;
            // 
            // dtStartTime
            // 
            this.dtStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "Start_Time", true));
            this.dtStartTime.Enabled = false;
            this.dtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartTime.Location = new System.Drawing.Point(154, 67);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.Size = new System.Drawing.Size(144, 21);
            this.dtStartTime.TabIndex = 1;
            // 
            // dtArrivalTime
            // 
            this.dtArrivalTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtArrivalTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "Arrival_Time", true));
            this.dtArrivalTime.Enabled = false;
            this.dtArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtArrivalTime.Location = new System.Drawing.Point(154, 41);
            this.dtArrivalTime.Name = "dtArrivalTime";
            this.dtArrivalTime.Size = new System.Drawing.Size(144, 21);
            this.dtArrivalTime.TabIndex = 0;
            // 
            // txtProcessTimeDis
            // 
            //
            this.txtProcessTimeDis.EnableNull = true;
            this.txtProcessTimeDis.ErropPr = null;
            //
            this.txtProcessTimeDis.Length = 0;
            this.txtProcessTimeDis.Location = new System.Drawing.Point(683, 119);
            this.txtProcessTimeDis.Max = 9999;
            //
            //
            this.txtProcessTimeDis.MaxStrLength = 0;
            this.txtProcessTimeDis.Min = 0;
            //
            //
            this.txtProcessTimeDis.MinStrLength = 0;
            this.txtProcessTimeDis.Name = "txtProcessTimeDis";
            this.txtProcessTimeDis.Precision = 0;
            this.txtProcessTimeDis.ReadOnly = true;
            //
            this.txtProcessTimeDis.Size = new System.Drawing.Size(91, 21);
            this.txtProcessTimeDis.TabIndex = 19;
            this.txtProcessTimeDis.ToolTipValid = null;
          //
            this.txtProcessTimeDis.ValidEable = true;
            this.txtProcessTimeDis.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtProcessTime
            // 
            this.txtProcessTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Process_Time", true));
            //
            this.txtProcessTime.EnableNull = true;
            this.txtProcessTime.ErropPr = this.errorProvider1;
            //
            this.txtProcessTime.Length = 0;
            this.txtProcessTime.Location = new System.Drawing.Point(721, 41);
            this.txtProcessTime.Max = 0;
            //
            //
            this.txtProcessTime.MaxStrLength = 0;
            this.txtProcessTime.Min = 0;
            //
            //
            this.txtProcessTime.MinStrLength = 0;
            this.txtProcessTime.Name = "txtProcessTime";
            this.txtProcessTime.Precision = 0;
            //
            this.txtProcessTime.Size = new System.Drawing.Size(16, 21);
            this.txtProcessTime.TabIndex = 19;
            this.txtProcessTime.ToolTipValid = this.toolTip1;
          //
            this.txtProcessTime.ValidEable = false;
            this.txtProcessTime.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            this.txtProcessTime.TextChanged += new System.EventHandler(this.txtProcessTime_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(594, 123);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 12);
            this.label23.TabIndex = 152;
            this.label23.Text = "真空处理时间:";
            // 
            // txtSlotNo
            // 
            this.txtSlotNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Slot_No", true));
            //
            this.txtSlotNo.EnableNull = true;
            this.txtSlotNo.ErropPr = this.errorProvider1;
            //
            this.txtSlotNo.Length = 0;
            this.txtSlotNo.Location = new System.Drawing.Point(683, 93);
            this.txtSlotNo.Max = 0;
            //
            //
            this.txtSlotNo.MaxStrLength = 0;
            this.txtSlotNo.Min = 0;
            //
            //
            this.txtSlotNo.MinStrLength = 0;
            this.txtSlotNo.Name = "txtSlotNo";
            this.txtSlotNo.Precision = 0;
            //
            this.txtSlotNo.Size = new System.Drawing.Size(91, 21);
            this.txtSlotNo.TabIndex = 18;
            this.txtSlotNo.ToolTipValid = this.toolTip1;
          //
            this.txtSlotNo.ValidEable = false;
            this.txtSlotNo.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(642, 97);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 12);
            this.label24.TabIndex = 150;
            this.label24.Text = "槽号:";
            // 
            // txtSlagThick
            // 
            this.txtSlagThick.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Slag_Thick", true));
            //
            this.txtSlagThick.EnableNull = true;
            this.txtSlagThick.ErropPr = this.errorProvider1;
            //
            this.txtSlagThick.Length = 0;
            this.txtSlagThick.Location = new System.Drawing.Point(683, 67);
            this.txtSlagThick.Max = 999;
            //
            //
            this.txtSlagThick.MaxStrLength = 0;
            this.txtSlagThick.Min = 0;
            //
            //
            this.txtSlagThick.MinStrLength = 0;
            this.txtSlagThick.Name = "txtSlagThick";
            this.txtSlagThick.Precision = 0;
            //
            this.txtSlagThick.Size = new System.Drawing.Size(91, 21);
            this.txtSlagThick.TabIndex = 17;
            this.txtSlagThick.Text = "0";
            this.txtSlagThick.ToolTipValid = this.toolTip1;
          //
            this.txtSlagThick.ValidEable = true;
            this.txtSlagThick.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(618, 71);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 12);
            this.label25.TabIndex = 148;
            this.label25.Text = "渣厚[mm]:";
            // 
            // txtDepartureTemp
            // 
            this.txtDepartureTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Departure_Temp", true));
            //
            this.txtDepartureTemp.EnableNull = true;
            this.txtDepartureTemp.ErropPr = this.errorProvider1;
            //
            this.txtDepartureTemp.Length = 0;
            this.txtDepartureTemp.Location = new System.Drawing.Point(683, 41);
            this.txtDepartureTemp.Max = 2000;
            //
            //
            this.txtDepartureTemp.MaxStrLength = 0;
            this.txtDepartureTemp.Min = 0;
            //
            //
            this.txtDepartureTemp.MinStrLength = 0;
            this.txtDepartureTemp.Name = "txtDepartureTemp";
            this.txtDepartureTemp.Precision = 0;
            this.txtDepartureTemp.ReadOnly = true;
            //
            this.txtDepartureTemp.Size = new System.Drawing.Size(91, 21);
            this.txtDepartureTemp.TabIndex = 16;
            this.txtDepartureTemp.ToolTipValid = this.toolTip1;
          //
            this.txtDepartureTemp.ValidEable = true;
            this.txtDepartureTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(594, 45);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(83, 12);
            this.label26.TabIndex = 146;
            this.label26.Text = "离站温度[℃]:";
            // 
            // txtProcessMode
            // 
            this.txtProcessMode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Process_Mode", true));
            //
            this.txtProcessMode.EnableNull = true;
            this.txtProcessMode.ErropPr = this.errorProvider1;
            //
            this.txtProcessMode.Length = 0;
            this.txtProcessMode.Location = new System.Drawing.Point(441, 94);
            this.txtProcessMode.Max = 99;
            //
            //
            this.txtProcessMode.MaxStrLength = 0;
            this.txtProcessMode.Min = 0;
            //
            //
            this.txtProcessMode.MinStrLength = 0;
            this.txtProcessMode.Name = "txtProcessMode";
            this.txtProcessMode.Precision = 0;
            this.txtProcessMode.ReadOnly = true;
            //
            this.txtProcessMode.Size = new System.Drawing.Size(87, 21);
            this.txtProcessMode.TabIndex = 11;
            this.txtProcessMode.ToolTipValid = this.toolTip1;
          //
            this.txtProcessMode.ValidEable = true;
            this.txtProcessMode.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(376, 98);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 12);
            this.label27.TabIndex = 144;
            this.label27.Text = "处理模式:";
            // 
            // txtProcessLocation
            // 
            this.txtProcessLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Process_Location", true));
            //
            this.txtProcessLocation.EnableNull = true;
            this.txtProcessLocation.ErropPr = this.errorProvider1;
            //
            this.txtProcessLocation.Length = 0;
            this.txtProcessLocation.Location = new System.Drawing.Point(441, 68);
            this.txtProcessLocation.Max = 0;
            //
            //
            this.txtProcessLocation.MaxStrLength = 0;
            this.txtProcessLocation.Min = 0;
            //
            //
            this.txtProcessLocation.MinStrLength = 0;
            this.txtProcessLocation.Name = "txtProcessLocation";
            this.txtProcessLocation.Precision = 0;
            this.txtProcessLocation.ReadOnly = true;
            //
            this.txtProcessLocation.Size = new System.Drawing.Size(87, 21);
            this.txtProcessLocation.TabIndex = 10;
            this.txtProcessLocation.ToolTipValid = this.toolTip1;
          //
            this.txtProcessLocation.ValidEable = true;
            this.txtProcessLocation.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(388, 72);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(47, 12);
            this.label28.TabIndex = 142;
            this.label28.Text = "处理位:";
            // 
            // txtArrivalTemp
            // 
            this.txtArrivalTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Arrival_Temp", true));
            //
            this.txtArrivalTemp.EnableNull = true;
            this.txtArrivalTemp.ErropPr = this.errorProvider1;
            //
            this.txtArrivalTemp.Length = 0;
            this.txtArrivalTemp.Location = new System.Drawing.Point(441, 41);
            this.txtArrivalTemp.Max = 2000;
            //
            //
            this.txtArrivalTemp.MaxStrLength = 0;
            this.txtArrivalTemp.Min = 0;
            //
            //
            this.txtArrivalTemp.MinStrLength = 0;
            this.txtArrivalTemp.Name = "txtArrivalTemp";
            this.txtArrivalTemp.Precision = 0;
            this.txtArrivalTemp.ReadOnly = true;
            //
            this.txtArrivalTemp.Size = new System.Drawing.Size(87, 21);
            this.txtArrivalTemp.TabIndex = 8;
            this.txtArrivalTemp.ToolTipValid = this.toolTip1;
          //
            this.txtArrivalTemp.ValidEable = true;
            this.txtArrivalTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(352, 45);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(83, 12);
            this.label30.TabIndex = 138;
            this.label30.Text = "进站温度[℃]:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(65, 123);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(83, 12);
            this.label31.TabIndex = 136;
            this.label31.Text = "软吹开始时刻:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(41, 97);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(107, 12);
            this.label32.TabIndex = 134;
            this.label32.Text = "真空处理结束时刻:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(41, 71);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(107, 12);
            this.label33.TabIndex = 132;
            this.label33.Text = "真空处理开始时刻:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(89, 45);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(59, 12);
            this.label34.TabIndex = 130;
            this.label34.Text = "到达时刻:";
            // 
            // pnlProcess
            // 
            this.pnlProcess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProcess.Controls.Add(this.btnProcessCancel);
            this.pnlProcess.Controls.Add(this.btnPaocessOK);
            this.pnlProcess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProcess.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlProcess.Location = new System.Drawing.Point(3, 330);
            this.pnlProcess.Name = "pnlProcess";
            this.pnlProcess.Size = new System.Drawing.Size(988, 33);
            this.pnlProcess.TabIndex = 89;
            // 
            // btnProcessCancel
            // 
            this.btnProcessCancel.Location = new System.Drawing.Point(906, 3);
            this.btnProcessCancel.Name = "btnProcessCancel";
            this.btnProcessCancel.Size = new System.Drawing.Size(75, 23);
            this.btnProcessCancel.TabIndex = 87;
            this.btnProcessCancel.Text = "取消";
            this.btnProcessCancel.UseVisualStyleBackColor = true;
            this.btnProcessCancel.Click += new System.EventHandler(this.btnProcessCancel_Click);
            // 
            // tabLadleInfo
            // 
            this.tabLadleInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabLadleInfo.Controls.Add(this.richTextBox1);
            this.tabLadleInfo.Controls.Add(this.comboBox3);
            this.tabLadleInfo.Controls.Add(this.comboBox2);
            this.tabLadleInfo.Controls.Add(this.comboBox1);
            this.tabLadleInfo.Controls.Add(this.textBox7);
            this.tabLadleInfo.Controls.Add(this.textBox6);
            this.tabLadleInfo.Controls.Add(this.textBox5);
            this.tabLadleInfo.Controls.Add(this.textBox4);
            this.tabLadleInfo.Controls.Add(this.textBox3);
            this.tabLadleInfo.Controls.Add(this.textBox9);
            this.tabLadleInfo.Controls.Add(this.textBox2);
            this.tabLadleInfo.Controls.Add(this.textBox8);
            this.tabLadleInfo.Controls.Add(this.label29);
            this.tabLadleInfo.Controls.Add(this.textBox1);
            this.tabLadleInfo.Controls.Add(this.label22);
            this.tabLadleInfo.Controls.Add(this.label68);
            this.tabLadleInfo.Controls.Add(this.label70);
            this.tabLadleInfo.Controls.Add(this.label72);
            this.tabLadleInfo.Controls.Add(this.label53);
            this.tabLadleInfo.Controls.Add(this.label54);
            this.tabLadleInfo.Controls.Add(this.label55);
            this.tabLadleInfo.Controls.Add(this.label56);
            this.tabLadleInfo.Controls.Add(this.label57);
            this.tabLadleInfo.Controls.Add(this.label58);
            this.tabLadleInfo.Controls.Add(this.label59);
            this.tabLadleInfo.Controls.Add(this.label60);
            this.tabLadleInfo.Controls.Add(this.pnlLadleInfo);
            this.tabLadleInfo.Location = new System.Drawing.Point(4, 22);
            this.tabLadleInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tabLadleInfo.Name = "tabLadleInfo";
            this.tabLadleInfo.Size = new System.Drawing.Size(996, 368);
            this.tabLadleInfo.TabIndex = 14;
            this.tabLadleInfo.Text = "钢包信息";
            this.tabLadleInfo.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "Note", true));
            this.richTextBox1.Location = new System.Drawing.Point(196, 150);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(554, 96);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // bsLadleInfo
            // 
            this.bsLadleInfo.DataMember = "L3DataTable";
            this.bsLadleInfo.DataSource = this.dsLadleInfo;
            // 
            // dsLadleInfo
            // 
            this.dsLadleInfo.AutoLoad = true;
            this.dsLadleInfo.AutoSubscribe = true;
            this.dsLadleInfo.DataSetName = "L3DataSet";
            this.dsLadleInfo.DeleteMethod = "";
            this.dsLadleInfo.InsertMethod = "";
            this.dsLadleInfo.L3DataAdapter = null;
            this.dsLadleInfo.LoadEvent = "";
            this.dsLadleInfo.LoadTrigger = null;
            this.dsLadleInfo.RefreshValve = 1000;
            this.dsLadleInfo.SourceCommand = null;
            this.dsLadleInfo.SourceCondition = "1=2";
            this.dsLadleInfo.SourceMethod = "";
            this.dsLadleInfo.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLadleInfo.SourceURI = "XGMESLogic\\RHMag\\CRH_Ladle_Info";
            this.dsLadleInfo.SubscribeTarget = "";
            this.dsLadleInfo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLadleInfo});
            this.dsLadleInfo.UpdateEvent = "";
            this.dsLadleInfo.UpdateMethod = "";
            this.dsLadleInfo.UpdateTrigger = null;
            // 
            // schemadsLadleInfo
            // 
            this.schemadsLadleInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLadleInfoL3DataTableTreatNo,
            this.coldsLadleInfoL3DataTableHeatID,
            this.coldsLadleInfoL3DataTableLadleID,
            this.coldsLadleInfoL3DataTableLast_Ladle_Grade,
            this.coldsLadleInfoL3DataTableTemp,
            this.coldsLadleInfoL3DataTableLast_SteelGrade,
            this.coldsLadleInfoL3DataTableAct_Ladle_Grade,
            this.coldsLadleInfoL3DataTableCur_SteelGrade,
            this.coldsLadleInfoL3DataTableIn_Ladle_Grade,
            this.coldsLadleInfoL3DataTableStop_Time_Len,
            this.coldsLadleInfoL3DataTableLadle_Age,
            this.coldsLadleInfoL3DataTableSmall_Fire,
            this.coldsLadleInfoL3DataTableMiddle_Fire,
            this.coldsLadleInfoL3DataTableBig_Fire,
            this.coldsLadleInfoL3DataTableNote,
            this.coldsLadleInfoL3DataTableOther1,
            this.coldsLadleInfoL3DataTableOther2,
            this.coldsLadleInfoL3DataTableOther3,
            this.coldsLadleInfoL3DataTableMaxTemp});
            this.schemadsLadleInfo.TableName = "L3DataTable";
            // 
            // coldsLadleInfoL3DataTableTreatNo
            // 
            this.coldsLadleInfoL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsLadleInfoL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsLadleInfoL3DataTableTreatNo.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableHeatID
            // 
            this.coldsLadleInfoL3DataTableHeatID.Caption = "HeatID";
            this.coldsLadleInfoL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsLadleInfoL3DataTableHeatID.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableLadleID
            // 
            this.coldsLadleInfoL3DataTableLadleID.Caption = "LadleID";
            this.coldsLadleInfoL3DataTableLadleID.ColumnName = "LadleID";
            this.coldsLadleInfoL3DataTableLadleID.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableLast_Ladle_Grade
            // 
            this.coldsLadleInfoL3DataTableLast_Ladle_Grade.Caption = "Last_Ladle_Grade";
            this.coldsLadleInfoL3DataTableLast_Ladle_Grade.ColumnName = "Last_Ladle_Grade";
            this.coldsLadleInfoL3DataTableLast_Ladle_Grade.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableTemp
            // 
            this.coldsLadleInfoL3DataTableTemp.Caption = "Temp";
            this.coldsLadleInfoL3DataTableTemp.ColumnName = "Temp";
            this.coldsLadleInfoL3DataTableTemp.DataType = typeof(int);
            this.coldsLadleInfoL3DataTableTemp.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableLast_SteelGrade
            // 
            this.coldsLadleInfoL3DataTableLast_SteelGrade.Caption = "Last_SteelGrade";
            this.coldsLadleInfoL3DataTableLast_SteelGrade.ColumnName = "Last_SteelGrade";
            this.coldsLadleInfoL3DataTableLast_SteelGrade.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableAct_Ladle_Grade
            // 
            this.coldsLadleInfoL3DataTableAct_Ladle_Grade.Caption = "Act_Ladle_Grade";
            this.coldsLadleInfoL3DataTableAct_Ladle_Grade.ColumnName = "Act_Ladle_Grade";
            this.coldsLadleInfoL3DataTableAct_Ladle_Grade.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableCur_SteelGrade
            // 
            this.coldsLadleInfoL3DataTableCur_SteelGrade.Caption = "Cur_SteelGrade";
            this.coldsLadleInfoL3DataTableCur_SteelGrade.ColumnName = "Cur_SteelGrade";
            this.coldsLadleInfoL3DataTableCur_SteelGrade.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableIn_Ladle_Grade
            // 
            this.coldsLadleInfoL3DataTableIn_Ladle_Grade.Caption = "In_Ladle_Grade";
            this.coldsLadleInfoL3DataTableIn_Ladle_Grade.ColumnName = "In_Ladle_Grade";
            this.coldsLadleInfoL3DataTableIn_Ladle_Grade.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableStop_Time_Len
            // 
            this.coldsLadleInfoL3DataTableStop_Time_Len.Caption = "Stop_Time_Len";
            this.coldsLadleInfoL3DataTableStop_Time_Len.ColumnName = "Stop_Time_Len";
            this.coldsLadleInfoL3DataTableStop_Time_Len.DataType = typeof(int);
            this.coldsLadleInfoL3DataTableStop_Time_Len.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableLadle_Age
            // 
            this.coldsLadleInfoL3DataTableLadle_Age.Caption = "Ladle_Age";
            this.coldsLadleInfoL3DataTableLadle_Age.ColumnName = "Ladle_Age";
            this.coldsLadleInfoL3DataTableLadle_Age.DataType = typeof(int);
            this.coldsLadleInfoL3DataTableLadle_Age.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableSmall_Fire
            // 
            this.coldsLadleInfoL3DataTableSmall_Fire.Caption = "Small_Fire";
            this.coldsLadleInfoL3DataTableSmall_Fire.ColumnName = "Small_Fire";
            this.coldsLadleInfoL3DataTableSmall_Fire.DataType = typeof(int);
            this.coldsLadleInfoL3DataTableSmall_Fire.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableMiddle_Fire
            // 
            this.coldsLadleInfoL3DataTableMiddle_Fire.Caption = "Middle_Fire";
            this.coldsLadleInfoL3DataTableMiddle_Fire.ColumnName = "Middle_Fire";
            this.coldsLadleInfoL3DataTableMiddle_Fire.DataType = typeof(int);
            this.coldsLadleInfoL3DataTableMiddle_Fire.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableBig_Fire
            // 
            this.coldsLadleInfoL3DataTableBig_Fire.Caption = "Big_Fire";
            this.coldsLadleInfoL3DataTableBig_Fire.ColumnName = "Big_Fire";
            this.coldsLadleInfoL3DataTableBig_Fire.DataType = typeof(int);
            this.coldsLadleInfoL3DataTableBig_Fire.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableNote
            // 
            this.coldsLadleInfoL3DataTableNote.Caption = "Note";
            this.coldsLadleInfoL3DataTableNote.ColumnName = "Note";
            this.coldsLadleInfoL3DataTableNote.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableOther1
            // 
            this.coldsLadleInfoL3DataTableOther1.Caption = "Other1";
            this.coldsLadleInfoL3DataTableOther1.ColumnName = "Other1";
            this.coldsLadleInfoL3DataTableOther1.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableOther2
            // 
            this.coldsLadleInfoL3DataTableOther2.Caption = "Other2";
            this.coldsLadleInfoL3DataTableOther2.ColumnName = "Other2";
            this.coldsLadleInfoL3DataTableOther2.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableOther3
            // 
            this.coldsLadleInfoL3DataTableOther3.Caption = "Other3";
            this.coldsLadleInfoL3DataTableOther3.ColumnName = "Other3";
            this.coldsLadleInfoL3DataTableOther3.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableMaxTemp
            // 
            this.coldsLadleInfoL3DataTableMaxTemp.Caption = "MaxTemp";
            this.coldsLadleInfoL3DataTableMaxTemp.ColumnName = "MaxTemp";
            this.coldsLadleInfoL3DataTableMaxTemp.DataType = typeof(int);
            this.coldsLadleInfoL3DataTableMaxTemp.DefaultValue = 0;
            this.coldsLadleInfoL3DataTableMaxTemp.Namespace = "";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "Act_Ladle_Grade", true));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D"});
            this.comboBox3.Location = new System.Drawing.Point(426, 70);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 20);
            this.comboBox3.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "In_Ladle_Grade", true));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D"});
            this.comboBox2.Location = new System.Drawing.Point(426, 44);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 20);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "Last_Ladle_Grade", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D"});
            this.comboBox1.Location = new System.Drawing.Point(196, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "Big_Fire", true));
            this.textBox7.Location = new System.Drawing.Point(650, 122);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 21);
            this.textBox7.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "Middle_Fire", true));
            this.textBox6.Location = new System.Drawing.Point(650, 96);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 21);
            this.textBox6.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "Small_Fire", true));
            this.textBox5.Location = new System.Drawing.Point(650, 70);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "Stop_Time_Len", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.textBox4.Location = new System.Drawing.Point(650, 44);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "Ladle_Age", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.textBox3.Location = new System.Drawing.Point(426, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 6;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "MaxTemp", true));
            this.textBox9.Location = new System.Drawing.Point(426, 122);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 21);
            this.textBox9.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "Temp", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.textBox2.Location = new System.Drawing.Point(196, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 3;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "Last_SteelGrade", true));
            this.textBox8.Location = new System.Drawing.Point(196, 70);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 21);
            this.textBox8.TabIndex = 1;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(343, 126);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(83, 12);
            this.label29.TabIndex = 101;
            this.label29.Text = "上次转包温降:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "LadleID", true));
            this.textBox1.Location = new System.Drawing.Point(196, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(113, 126);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 12);
            this.label22.TabIndex = 101;
            this.label22.Text = "上次20\'温降:";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(131, 100);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(59, 12);
            this.label68.TabIndex = 102;
            this.label68.Text = "上次包况:";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(107, 74);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(83, 12);
            this.label70.TabIndex = 99;
            this.label70.Text = "上次使用钢种:";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(143, 48);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(47, 12);
            this.label72.TabIndex = 100;
            this.label72.Text = "钢包号:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(361, 48);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(59, 12);
            this.label53.TabIndex = 94;
            this.label53.Text = "进站包况:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(131, 150);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(59, 12);
            this.label54.TabIndex = 93;
            this.label54.Text = "钢包备注:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(337, 74);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(83, 12);
            this.label55.TabIndex = 95;
            this.label55.Text = "当前钢包状况:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(361, 100);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(59, 12);
            this.label56.TabIndex = 98;
            this.label56.Text = "钢包包龄:";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(555, 126);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(89, 12);
            this.label57.TabIndex = 97;
            this.label57.Text = "大火时间[min]:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(555, 100);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(89, 12);
            this.label58.TabIndex = 96;
            this.label58.Text = "中火时间[min]:";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(555, 74);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(89, 12);
            this.label59.TabIndex = 91;
            this.label59.Text = "小火时间[min]:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(555, 48);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(89, 12);
            this.label60.TabIndex = 92;
            this.label60.Text = "停用时长[min]:";
            // 
            // pnlLadleInfo
            // 
            this.pnlLadleInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLadleInfo.Controls.Add(this.btnLadleInfoCancel);
            this.pnlLadleInfo.Controls.Add(this.btnLadleInfoOK);
            this.pnlLadleInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLadleInfo.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlLadleInfo.Location = new System.Drawing.Point(0, 333);
            this.pnlLadleInfo.Name = "pnlLadleInfo";
            this.pnlLadleInfo.Size = new System.Drawing.Size(994, 33);
            this.pnlLadleInfo.TabIndex = 90;
            // 
            // btnLadleInfoCancel
            // 
            this.btnLadleInfoCancel.Location = new System.Drawing.Point(912, 3);
            this.btnLadleInfoCancel.Name = "btnLadleInfoCancel";
            this.btnLadleInfoCancel.Size = new System.Drawing.Size(75, 23);
            this.btnLadleInfoCancel.TabIndex = 87;
            this.btnLadleInfoCancel.Text = "取消";
            this.btnLadleInfoCancel.UseVisualStyleBackColor = true;
            this.btnLadleInfoCancel.Click += new System.EventHandler(this.btnLadleInfoCancel_Click);
            // 
            // tabExcept
            // 
            this.tabExcept.Controls.Add(this.dvExcept);
            this.tabExcept.Controls.Add(this.fLPExcept);
            this.tabExcept.Controls.Add(this.bdExcept);
            this.tabExcept.Location = new System.Drawing.Point(4, 22);
            this.tabExcept.Name = "tabExcept";
            this.tabExcept.Padding = new System.Windows.Forms.Padding(3);
            this.tabExcept.Size = new System.Drawing.Size(996, 368);
            this.tabExcept.TabIndex = 13;
            this.tabExcept.Text = "炉次异常";
            this.tabExcept.UseVisualStyleBackColor = true;
            // 
            // dvExcept
            // 
            this.dvExcept.AllowUserToAddRows = false;
            this.dvExcept.AllowUserToDeleteRows = false;
            this.dvExcept.AutoGenerateColumns = false;
            this.dvExcept.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvExcept.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvExcept.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn7,
            this.exceptionalCodeDataGridViewTextBoxColumn,
            this.exceptionalTimeDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.iDObjectDataGridViewTextBoxColumn,
            this.processCountDataGridViewTextBoxColumn,
            this.unitTypeIDDataGridViewTextBoxColumn1,
            this.unitIDDataGridViewTextBoxColumn1,
            this.preHeatIDDataGridViewTextBoxColumn,
            this.preSteelGradeIndexDataGridViewTextBoxColumn,
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.decideCodeDataGridViewTextBoxColumn,
            this.classifyDataGridViewTextBoxColumn});
            this.dvExcept.DataSource = this.bsExcept;
            this.dvExcept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvExcept.Location = new System.Drawing.Point(3, 28);
            this.dvExcept.Name = "dvExcept";
            this.dvExcept.RowTemplate.Height = 23;
            this.dvExcept.Size = new System.Drawing.Size(990, 304);
            this.dvExcept.TabIndex = 95;
            this.dvExcept.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMat_DataError);
            // 
            // heatIDDataGridViewTextBoxColumn7
            // 
            this.heatIDDataGridViewTextBoxColumn7.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn7.FillWeight = 168.0672F;
            this.heatIDDataGridViewTextBoxColumn7.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn7.Name = "heatIDDataGridViewTextBoxColumn7";
            // 
            // exceptionalCodeDataGridViewTextBoxColumn
            // 
            this.exceptionalCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.exceptionalCodeDataGridViewTextBoxColumn.DataPropertyName = "Exceptional_Code";
            this.exceptionalCodeDataGridViewTextBoxColumn.DataSource = this.dsExceptCode;
            this.exceptionalCodeDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Exceptional_Des";
            this.exceptionalCodeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.exceptionalCodeDataGridViewTextBoxColumn.HeaderText = "异常代码";
            this.exceptionalCodeDataGridViewTextBoxColumn.Name = "exceptionalCodeDataGridViewTextBoxColumn";
            this.exceptionalCodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.exceptionalCodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.exceptionalCodeDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Exceptional_Code";
            this.exceptionalCodeDataGridViewTextBoxColumn.Width = 78;
            // 
            // dsExceptCode
            // 
            this.dsExceptCode.AutoLoad = true;
            this.dsExceptCode.AutoSubscribe = false;
            this.dsExceptCode.DataSetName = "L3DataSet";
            this.dsExceptCode.DeleteMethod = "";
            this.dsExceptCode.InsertMethod = "";
            this.dsExceptCode.L3DataAdapter = this.Adapter;
            this.dsExceptCode.LoadEvent = "";
            this.dsExceptCode.LoadTrigger = null;
            this.dsExceptCode.RefreshValve = 1000;
            this.dsExceptCode.SourceCommand = null;
            this.dsExceptCode.SourceCondition = "Unit=\'5\'";
            this.dsExceptCode.SourceMethod = "";
            this.dsExceptCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsExceptCode.SourceURI = "XGMESLogic\\QualityMag\\CQA_Heat_Except_Code";
            this.dsExceptCode.SubscribeTarget = null;
            this.dsExceptCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsExceptCode});
            this.dsExceptCode.UpdateEvent = "";
            this.dsExceptCode.UpdateMethod = "";
            this.dsExceptCode.UpdateTrigger = null;
            // 
            // schemadsExceptCode
            // 
            this.schemadsExceptCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsExceptCodeL3DataTableGUID,
            this.coldsExceptCodeL3DataTableName,
            this.coldsExceptCodeL3DataTableExceptional_Code,
            this.coldsExceptCodeL3DataTableExceptional_Des,
            this.coldsExceptCodeL3DataTableUnit,
            this.coldsExceptCodeL3DataTableAuto_Judge_Flag});
            this.schemadsExceptCode.TableName = "L3DataTable";
            // 
            // coldsExceptCodeL3DataTableGUID
            // 
            this.coldsExceptCodeL3DataTableGUID.Caption = "GUID";
            this.coldsExceptCodeL3DataTableGUID.ColumnName = "GUID";
            this.coldsExceptCodeL3DataTableGUID.Namespace = "";
            // 
            // coldsExceptCodeL3DataTableName
            // 
            this.coldsExceptCodeL3DataTableName.Caption = "Name";
            this.coldsExceptCodeL3DataTableName.ColumnName = "Name";
            this.coldsExceptCodeL3DataTableName.Namespace = "";
            // 
            // coldsExceptCodeL3DataTableExceptional_Code
            // 
            this.coldsExceptCodeL3DataTableExceptional_Code.Caption = "Exceptional_Code";
            this.coldsExceptCodeL3DataTableExceptional_Code.ColumnName = "Exceptional_Code";
            this.coldsExceptCodeL3DataTableExceptional_Code.Namespace = "";
            // 
            // coldsExceptCodeL3DataTableExceptional_Des
            // 
            this.coldsExceptCodeL3DataTableExceptional_Des.Caption = "Exceptional_Des";
            this.coldsExceptCodeL3DataTableExceptional_Des.ColumnName = "Exceptional_Des";
            this.coldsExceptCodeL3DataTableExceptional_Des.Namespace = "";
            // 
            // coldsExceptCodeL3DataTableUnit
            // 
            this.coldsExceptCodeL3DataTableUnit.Caption = "Unit";
            this.coldsExceptCodeL3DataTableUnit.ColumnName = "Unit";
            this.coldsExceptCodeL3DataTableUnit.Namespace = "";
            // 
            // coldsExceptCodeL3DataTableAuto_Judge_Flag
            // 
            this.coldsExceptCodeL3DataTableAuto_Judge_Flag.Caption = "Auto_Judge_Flag";
            this.coldsExceptCodeL3DataTableAuto_Judge_Flag.ColumnName = "Auto_Judge_Flag";
            this.coldsExceptCodeL3DataTableAuto_Judge_Flag.DataType = typeof(int);
            this.coldsExceptCodeL3DataTableAuto_Judge_Flag.Namespace = "";
            // 
            // exceptionalTimeDataGridViewTextBoxColumn
            // 
            this.exceptionalTimeDataGridViewTextBoxColumn.DataPropertyName = "Exceptional_Time";
            this.exceptionalTimeDataGridViewTextBoxColumn.FillWeight = 31.93277F;
            this.exceptionalTimeDataGridViewTextBoxColumn.HeaderText = "异常产生时间";
            this.exceptionalTimeDataGridViewTextBoxColumn.Name = "exceptionalTimeDataGridViewTextBoxColumn";
            this.exceptionalTimeDataGridViewTextBoxColumn.Width = 200;
            // 
            // gUIDDataGridViewTextBoxColumn1
            // 
            this.gUIDDataGridViewTextBoxColumn1.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn1.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn1.Name = "gUIDDataGridViewTextBoxColumn1";
            this.gUIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Visible = false;
            // 
            // iDObjectDataGridViewTextBoxColumn
            // 
            this.iDObjectDataGridViewTextBoxColumn.DataPropertyName = "ID_Object";
            this.iDObjectDataGridViewTextBoxColumn.HeaderText = "ID_Object";
            this.iDObjectDataGridViewTextBoxColumn.Name = "iDObjectDataGridViewTextBoxColumn";
            this.iDObjectDataGridViewTextBoxColumn.Visible = false;
            // 
            // processCountDataGridViewTextBoxColumn
            // 
            this.processCountDataGridViewTextBoxColumn.DataPropertyName = "Process_Count";
            this.processCountDataGridViewTextBoxColumn.HeaderText = "Process_Count";
            this.processCountDataGridViewTextBoxColumn.Name = "processCountDataGridViewTextBoxColumn";
            this.processCountDataGridViewTextBoxColumn.Visible = false;
            // 
            // unitTypeIDDataGridViewTextBoxColumn1
            // 
            this.unitTypeIDDataGridViewTextBoxColumn1.DataPropertyName = "UnitTypeID";
            this.unitTypeIDDataGridViewTextBoxColumn1.HeaderText = "UnitTypeID";
            this.unitTypeIDDataGridViewTextBoxColumn1.Name = "unitTypeIDDataGridViewTextBoxColumn1";
            this.unitTypeIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // unitIDDataGridViewTextBoxColumn1
            // 
            this.unitIDDataGridViewTextBoxColumn1.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn1.HeaderText = "UnitID";
            this.unitIDDataGridViewTextBoxColumn1.Name = "unitIDDataGridViewTextBoxColumn1";
            this.unitIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // preHeatIDDataGridViewTextBoxColumn
            // 
            this.preHeatIDDataGridViewTextBoxColumn.DataPropertyName = "PreHeatID";
            this.preHeatIDDataGridViewTextBoxColumn.HeaderText = "PreHeatID";
            this.preHeatIDDataGridViewTextBoxColumn.Name = "preHeatIDDataGridViewTextBoxColumn";
            this.preHeatIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // preSteelGradeIndexDataGridViewTextBoxColumn
            // 
            this.preSteelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "Pre_SteelGradeIndex";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.HeaderText = "Pre_SteelGradeIndex";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.Name = "preSteelGradeIndexDataGridViewTextBoxColumn";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.Visible = false;
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            this.steelGradeIndexDataGridViewTextBoxColumn.Visible = false;
            // 
            // decideCodeDataGridViewTextBoxColumn
            // 
            this.decideCodeDataGridViewTextBoxColumn.DataPropertyName = "Decide_Code";
            this.decideCodeDataGridViewTextBoxColumn.HeaderText = "Decide_Code";
            this.decideCodeDataGridViewTextBoxColumn.Name = "decideCodeDataGridViewTextBoxColumn";
            this.decideCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // classifyDataGridViewTextBoxColumn
            // 
            this.classifyDataGridViewTextBoxColumn.DataPropertyName = "Classify";
            this.classifyDataGridViewTextBoxColumn.HeaderText = "Classify";
            this.classifyDataGridViewTextBoxColumn.Name = "classifyDataGridViewTextBoxColumn";
            this.classifyDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsExcept
            // 
            this.bsExcept.DataMember = "L3DataTable";
            this.bsExcept.DataSource = this.dsExcept;
            // 
            // dsExcept
            // 
            this.dsExcept.AutoLoad = true;
            this.dsExcept.AutoSubscribe = false;
            this.dsExcept.DataSetName = "L3DataSet";
            this.dsExcept.DeleteMethod = "";
            this.dsExcept.InsertMethod = "";
            this.dsExcept.L3DataAdapter = null;
            this.dsExcept.LoadEvent = "";
            this.dsExcept.LoadTrigger = null;
            this.dsExcept.RefreshValve = 1000;
            this.dsExcept.SourceCommand = null;
            this.dsExcept.SourceCondition = "1=2";
            this.dsExcept.SourceMethod = "";
            this.dsExcept.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsExcept.SourceURI = "XGMESLogic\\QualityMag\\CQA_Heat_Prod_Except";
            this.dsExcept.SubscribeTarget = null;
            this.dsExcept.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsExcept});
            this.dsExcept.UpdateEvent = "";
            this.dsExcept.UpdateMethod = "";
            this.dsExcept.UpdateTrigger = null;
            // 
            // schemadsExcept
            // 
            this.schemadsExcept.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsExceptL3DataTableGUID,
            this.coldsExceptL3DataTableName,
            this.coldsExceptL3DataTableID_Object,
            this.coldsExceptL3DataTableHeatID,
            this.coldsExceptL3DataTableProcess_Count,
            this.coldsExceptL3DataTableUnitTypeID,
            this.coldsExceptL3DataTableUnitID,
            this.coldsExceptL3DataTablePreHeatID,
            this.coldsExceptL3DataTablePre_SteelGradeIndex,
            this.coldsExceptL3DataTableSteelGradeIndex,
            this.coldsExceptL3DataTableExceptional_Code,
            this.coldsExceptL3DataTableDecide_Code,
            this.coldsExceptL3DataTableClassify,
            this.coldsExceptL3DataTableExceptional_Time});
            this.schemadsExcept.TableName = "L3DataTable";
            // 
            // coldsExceptL3DataTableGUID
            // 
            this.coldsExceptL3DataTableGUID.Caption = "GUID";
            this.coldsExceptL3DataTableGUID.ColumnName = "GUID";
            this.coldsExceptL3DataTableGUID.Namespace = "";
            // 
            // coldsExceptL3DataTableName
            // 
            this.coldsExceptL3DataTableName.Caption = "Name";
            this.coldsExceptL3DataTableName.ColumnName = "Name";
            this.coldsExceptL3DataTableName.Namespace = "";
            // 
            // coldsExceptL3DataTableID_Object
            // 
            this.coldsExceptL3DataTableID_Object.Caption = "ID_Object";
            this.coldsExceptL3DataTableID_Object.ColumnName = "ID_Object";
            this.coldsExceptL3DataTableID_Object.Namespace = "";
            // 
            // coldsExceptL3DataTableHeatID
            // 
            this.coldsExceptL3DataTableHeatID.Caption = "HeatID";
            this.coldsExceptL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsExceptL3DataTableHeatID.Namespace = "";
            // 
            // coldsExceptL3DataTableProcess_Count
            // 
            this.coldsExceptL3DataTableProcess_Count.Caption = "Process_Count";
            this.coldsExceptL3DataTableProcess_Count.ColumnName = "Process_Count";
            this.coldsExceptL3DataTableProcess_Count.DataType = typeof(int);
            this.coldsExceptL3DataTableProcess_Count.Namespace = "";
            // 
            // coldsExceptL3DataTableUnitTypeID
            // 
            this.coldsExceptL3DataTableUnitTypeID.Caption = "UnitTypeID";
            this.coldsExceptL3DataTableUnitTypeID.ColumnName = "UnitTypeID";
            this.coldsExceptL3DataTableUnitTypeID.Namespace = "";
            // 
            // coldsExceptL3DataTableUnitID
            // 
            this.coldsExceptL3DataTableUnitID.Caption = "UnitID";
            this.coldsExceptL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsExceptL3DataTableUnitID.Namespace = "";
            // 
            // coldsExceptL3DataTablePreHeatID
            // 
            this.coldsExceptL3DataTablePreHeatID.Caption = "PreHeatID";
            this.coldsExceptL3DataTablePreHeatID.ColumnName = "PreHeatID";
            this.coldsExceptL3DataTablePreHeatID.Namespace = "";
            // 
            // coldsExceptL3DataTablePre_SteelGradeIndex
            // 
            this.coldsExceptL3DataTablePre_SteelGradeIndex.Caption = "Pre_SteelGradeIndex";
            this.coldsExceptL3DataTablePre_SteelGradeIndex.ColumnName = "Pre_SteelGradeIndex";
            this.coldsExceptL3DataTablePre_SteelGradeIndex.Namespace = "";
            // 
            // coldsExceptL3DataTableSteelGradeIndex
            // 
            this.coldsExceptL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsExceptL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsExceptL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsExceptL3DataTableExceptional_Code
            // 
            this.coldsExceptL3DataTableExceptional_Code.Caption = "Exceptional_Code";
            this.coldsExceptL3DataTableExceptional_Code.ColumnName = "Exceptional_Code";
            this.coldsExceptL3DataTableExceptional_Code.Namespace = "";
            // 
            // coldsExceptL3DataTableDecide_Code
            // 
            this.coldsExceptL3DataTableDecide_Code.Caption = "Decide_Code";
            this.coldsExceptL3DataTableDecide_Code.ColumnName = "Decide_Code";
            this.coldsExceptL3DataTableDecide_Code.Namespace = "";
            // 
            // coldsExceptL3DataTableClassify
            // 
            this.coldsExceptL3DataTableClassify.Caption = "Classify";
            this.coldsExceptL3DataTableClassify.ColumnName = "Classify";
            this.coldsExceptL3DataTableClassify.DataType = typeof(int);
            this.coldsExceptL3DataTableClassify.Namespace = "";
            // 
            // coldsExceptL3DataTableExceptional_Time
            // 
            this.coldsExceptL3DataTableExceptional_Time.Caption = "Exceptional_Time";
            this.coldsExceptL3DataTableExceptional_Time.ColumnName = "Exceptional_Time";
            this.coldsExceptL3DataTableExceptional_Time.DataType = typeof(System.DateTime);
            this.coldsExceptL3DataTableExceptional_Time.Namespace = "";
            // 
            // fLPExcept
            // 
            this.fLPExcept.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fLPExcept.Controls.Add(this.btnCancelExcept);
            this.fLPExcept.Controls.Add(this.btnConfirmExcept);
            this.fLPExcept.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fLPExcept.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fLPExcept.Location = new System.Drawing.Point(3, 332);
            this.fLPExcept.Name = "fLPExcept";
            this.fLPExcept.Size = new System.Drawing.Size(990, 33);
            this.fLPExcept.TabIndex = 94;
            // 
            // btnCancelExcept
            // 
            this.btnCancelExcept.Location = new System.Drawing.Point(908, 3);
            this.btnCancelExcept.Name = "btnCancelExcept";
            this.btnCancelExcept.Size = new System.Drawing.Size(75, 23);
            this.btnCancelExcept.TabIndex = 87;
            this.btnCancelExcept.Text = "取消";
            this.btnCancelExcept.UseVisualStyleBackColor = true;
            this.btnCancelExcept.Click += new System.EventHandler(this.btnCancelExcept_Click);
            // 
            // bdExcept
            // 
            this.bdExcept.AddNewItem = null;
            this.bdExcept.CountItem = this.bindingNavigatorCountItem7;
            this.bdExcept.DeleteItem = null;
            this.bdExcept.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem7,
            this.bindingNavigatorMovePreviousItem7,
            this.bindingNavigatorSeparator21,
            this.bindingNavigatorPositionItem7,
            this.bindingNavigatorCountItem7,
            this.bindingNavigatorSeparator22,
            this.bindingNavigatorMoveNextItem7,
            this.bindingNavigatorMoveLastItem7,
            this.bindingNavigatorSeparator23,
            this.btnAddExcept,
            this.btnDelExcept});
            this.bdExcept.Location = new System.Drawing.Point(3, 3);
            this.bdExcept.MoveFirstItem = this.bindingNavigatorMoveFirstItem7;
            this.bdExcept.MoveLastItem = this.bindingNavigatorMoveLastItem7;
            this.bdExcept.MoveNextItem = this.bindingNavigatorMoveNextItem7;
            this.bdExcept.MovePreviousItem = this.bindingNavigatorMovePreviousItem7;
            this.bdExcept.Name = "bdExcept";
            this.bdExcept.PositionItem = this.bindingNavigatorPositionItem7;
            this.bdExcept.Size = new System.Drawing.Size(990, 25);
            this.bdExcept.TabIndex = 2;
            this.bdExcept.Text = "bindingNavigator2";
            // 
            // bindingNavigatorCountItem7
            // 
            this.bindingNavigatorCountItem7.Name = "bindingNavigatorCountItem7";
            this.bindingNavigatorCountItem7.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem7.Text = "/ {0}";
            this.bindingNavigatorCountItem7.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem7
            // 
            this.bindingNavigatorMoveFirstItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem7.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem7.Image")));
            this.bindingNavigatorMoveFirstItem7.Name = "bindingNavigatorMoveFirstItem7";
            this.bindingNavigatorMoveFirstItem7.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem7.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem7.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem7
            // 
            this.bindingNavigatorMovePreviousItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem7.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem7.Image")));
            this.bindingNavigatorMovePreviousItem7.Name = "bindingNavigatorMovePreviousItem7";
            this.bindingNavigatorMovePreviousItem7.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem7.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem7.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator21
            // 
            this.bindingNavigatorSeparator21.Name = "bindingNavigatorSeparator21";
            this.bindingNavigatorSeparator21.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem7
            // 
            this.bindingNavigatorPositionItem7.AccessibleName = "位置";
            this.bindingNavigatorPositionItem7.AutoSize = false;
            this.bindingNavigatorPositionItem7.Name = "bindingNavigatorPositionItem7";
            this.bindingNavigatorPositionItem7.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem7.Text = "0";
            this.bindingNavigatorPositionItem7.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator22
            // 
            this.bindingNavigatorSeparator22.Name = "bindingNavigatorSeparator22";
            this.bindingNavigatorSeparator22.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem7
            // 
            this.bindingNavigatorMoveNextItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem7.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem7.Image")));
            this.bindingNavigatorMoveNextItem7.Name = "bindingNavigatorMoveNextItem7";
            this.bindingNavigatorMoveNextItem7.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem7.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem7.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem7
            // 
            this.bindingNavigatorMoveLastItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem7.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem7.Image")));
            this.bindingNavigatorMoveLastItem7.Name = "bindingNavigatorMoveLastItem7";
            this.bindingNavigatorMoveLastItem7.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem7.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem7.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator23
            // 
            this.bindingNavigatorSeparator23.Name = "bindingNavigatorSeparator23";
            this.bindingNavigatorSeparator23.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDelExcept
            // 
            this.btnDelExcept.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelExcept.Image = ((System.Drawing.Image)(resources.GetObject("btnDelExcept.Image")));
            this.btnDelExcept.Name = "btnDelExcept";
            this.btnDelExcept.RightToLeftAutoMirrorImage = true;
            this.btnDelExcept.Size = new System.Drawing.Size(23, 22);
            this.btnDelExcept.Text = "删除";
            this.btnDelExcept.Click += new System.EventHandler(this.btnDelExcept_Click);
            // 
            // tabChemical
            // 
            this.tabChemical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabChemical.Controls.Add(this.dvChemical);
            this.tabChemical.Controls.Add(this.bnChemical);
            this.tabChemical.Controls.Add(this.pnlChemical);
            this.tabChemical.Location = new System.Drawing.Point(4, 22);
            this.tabChemical.Name = "tabChemical";
            this.tabChemical.Padding = new System.Windows.Forms.Padding(3);
            this.tabChemical.Size = new System.Drawing.Size(996, 368);
            this.tabChemical.TabIndex = 3;
            this.tabChemical.Text = "成份数据";
            this.tabChemical.UseVisualStyleBackColor = true;
            // 
            // dvChemical
            // 
            this.dvChemical.AllowUserToAddRows = false;
            this.dvChemical.AllowUserToDeleteRows = false;
            this.dvChemical.AutoGenerateColumns = false;
            this.dvChemical.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvChemical.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn5,
            this.appIDDataGridViewTextBoxColumn,
            this.sampleCodeDataGridViewTextBoxColumn,
            this.arriveDateDataGridViewTextBoxColumn,
            this.reportDateDataGridViewTextBoxColumn,
            this.unitTypeIDDataGridViewTextBoxColumn,
            this.unitIDDataGridViewTextBoxColumn,
            this.sampleAddressDataGridViewTextBoxColumn,
            this.sampleTypeDataGridViewTextBoxColumn,
            this.sampleCountDataGridViewTextBoxColumn,
            this.cDataGridViewTextBoxColumn,
            this.siDataGridViewTextBoxColumn,
            this.mnDataGridViewTextBoxColumn,
            this.pDataGridViewTextBoxColumn,
            this.sDataGridViewTextBoxColumn,
            this.alDataGridViewTextBoxColumn,
            this.crDataGridViewTextBoxColumn,
            this.tiDataGridViewTextBoxColumn,
            this.vDataGridViewTextBoxColumn,
            this.bDataGridViewTextBoxColumn,
            this.moDataGridViewTextBoxColumn,
            this.niDataGridViewTextBoxColumn,
            this.caDataGridViewTextBoxColumn,
            this.cuDataGridViewTextBoxColumn,
            this.nbDataGridViewTextBoxColumn,
            this.snDataGridViewTextBoxColumn,
            this.wDataGridViewTextBoxColumn,
            this.pbDataGridViewTextBoxColumn,
            this.znDataGridViewTextBoxColumn,
            this.nDataGridViewTextBoxColumn,
            this.hDataGridViewTextBoxColumn,
            this.oDataGridViewTextBoxColumn,
            this.asDataGridViewTextBoxColumn,
            this.alSDataGridViewTextBoxColumn,
            this.sbDataGridViewTextBoxColumn,
            this.reDataGridViewTextBoxColumn,
            this.ceqDataGridViewTextBoxColumn,
            this.CrNi,
            this.CrCu,
            this.CrNiCu,
            this.other1DataGridViewTextBoxColumn,
            this.other2DataGridViewTextBoxColumn,
            this.Other3,
            this.logTimeDataGridViewTextBoxColumn1,
            this.dataLogModeDataGridViewTextBoxColumn});
            this.dvChemical.DataSource = this.bsChemical;
            this.dvChemical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvChemical.Location = new System.Drawing.Point(3, 28);
            this.dvChemical.Name = "dvChemical";
            this.dvChemical.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvChemical.RowTemplate.Height = 23;
            this.dvChemical.Size = new System.Drawing.Size(988, 302);
            this.dvChemical.TabIndex = 102;
            this.dvChemical.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMat_DataError);
            this.dvChemical.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvChemical_DataBindingComplete);
            // 
            // heatIDDataGridViewTextBoxColumn5
            // 
            this.heatIDDataGridViewTextBoxColumn5.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn5.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn5.Name = "heatIDDataGridViewTextBoxColumn5";
            // 
            // appIDDataGridViewTextBoxColumn
            // 
            this.appIDDataGridViewTextBoxColumn.DataPropertyName = "AppID";
            this.appIDDataGridViewTextBoxColumn.HeaderText = "委托单编号";
            this.appIDDataGridViewTextBoxColumn.Name = "appIDDataGridViewTextBoxColumn";
            // 
            // sampleCodeDataGridViewTextBoxColumn
            // 
            this.sampleCodeDataGridViewTextBoxColumn.DataPropertyName = "Sample_Code";
            this.sampleCodeDataGridViewTextBoxColumn.HeaderText = "试样编码";
            this.sampleCodeDataGridViewTextBoxColumn.Name = "sampleCodeDataGridViewTextBoxColumn";
            // 
            // arriveDateDataGridViewTextBoxColumn
            // 
            this.arriveDateDataGridViewTextBoxColumn.DataPropertyName = "Arrive_Date";
            this.arriveDateDataGridViewTextBoxColumn.HeaderText = "到样时间";
            this.arriveDateDataGridViewTextBoxColumn.Name = "arriveDateDataGridViewTextBoxColumn";
            this.arriveDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.arriveDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.arriveDateDataGridViewTextBoxColumn.Width = 130;
            // 
            // reportDateDataGridViewTextBoxColumn
            // 
            this.reportDateDataGridViewTextBoxColumn.DataPropertyName = "Report_Date";
            this.reportDateDataGridViewTextBoxColumn.HeaderText = "报告时间";
            this.reportDateDataGridViewTextBoxColumn.Name = "reportDateDataGridViewTextBoxColumn";
            this.reportDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.reportDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.reportDateDataGridViewTextBoxColumn.Width = 130;
            // 
            // unitTypeIDDataGridViewTextBoxColumn
            // 
            this.unitTypeIDDataGridViewTextBoxColumn.DataPropertyName = "UnitTypeID";
            this.unitTypeIDDataGridViewTextBoxColumn.DataSource = this.dsUnitType;
            this.unitTypeIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.unitTypeIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.unitTypeIDDataGridViewTextBoxColumn.HeaderText = "工序";
            this.unitTypeIDDataGridViewTextBoxColumn.Name = "unitTypeIDDataGridViewTextBoxColumn";
            this.unitTypeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unitTypeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.unitTypeIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsUnitType
            // 
            this.dsUnitType.AutoLoad = true;
            this.dsUnitType.AutoSubscribe = false;
            this.dsUnitType.DataSetName = "L3DataSet";
            this.dsUnitType.DeleteMethod = null;
            this.dsUnitType.InsertMethod = null;
            this.dsUnitType.L3DataAdapter = this.Adapter;
            this.dsUnitType.LoadEvent = "Click";
            this.dsUnitType.LoadTrigger = null;
            this.dsUnitType.RefreshValve = 1000;
            this.dsUnitType.SourceCommand = null;
            this.dsUnitType.SourceCondition = "CODE_GROUP = \'UnitType\' and code is not null order by code";
            this.dsUnitType.SourceMethod = "";
            this.dsUnitType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsUnitType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsUnitType.SubscribeTarget = null;
            this.dsUnitType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsUnitType});
            this.dsUnitType.UpdateEvent = "Click";
            this.dsUnitType.UpdateMethod = null;
            this.dsUnitType.UpdateTrigger = null;
            // 
            // schemadsUnitType
            // 
            this.schemadsUnitType.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsUnitTypeL3DataTableCode_Des,
            this.coldsUnitTypeL3DataTableCode_Val_Long});
            this.schemadsUnitType.TableName = "L3DataTable";
            // 
            // coldsUnitTypeL3DataTableCode_Des
            // 
            this.coldsUnitTypeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsUnitTypeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsUnitTypeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsUnitTypeL3DataTableCode_Val_Long
            // 
            this.coldsUnitTypeL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsUnitTypeL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsUnitTypeL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsUnitTypeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // unitIDDataGridViewTextBoxColumn
            // 
            this.unitIDDataGridViewTextBoxColumn.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn.HeaderText = "工位";
            this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
            // 
            // sampleAddressDataGridViewTextBoxColumn
            // 
            this.sampleAddressDataGridViewTextBoxColumn.DataPropertyName = "Sample_Address";
            this.sampleAddressDataGridViewTextBoxColumn.DataSource = this.dsSampleAddr;
            this.sampleAddressDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.sampleAddressDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sampleAddressDataGridViewTextBoxColumn.HeaderText = "取样地点";
            this.sampleAddressDataGridViewTextBoxColumn.Name = "sampleAddressDataGridViewTextBoxColumn";
            this.sampleAddressDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sampleAddressDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sampleAddressDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsSampleAddr
            // 
            this.dsSampleAddr.AutoLoad = true;
            this.dsSampleAddr.AutoSubscribe = false;
            this.dsSampleAddr.DataSetName = "L3DataSet";
            this.dsSampleAddr.DeleteMethod = null;
            this.dsSampleAddr.InsertMethod = null;
            this.dsSampleAddr.L3DataAdapter = this.Adapter;
            this.dsSampleAddr.LoadEvent = "Click";
            this.dsSampleAddr.LoadTrigger = null;
            this.dsSampleAddr.RefreshValve = 1000;
            this.dsSampleAddr.SourceCommand = null;
            this.dsSampleAddr.SourceCondition = "CODE_GROUP = \'QA_Sample_Addr\'";
            this.dsSampleAddr.SourceMethod = "";
            this.dsSampleAddr.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSampleAddr.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSampleAddr.SubscribeTarget = null;
            this.dsSampleAddr.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSampleAddr});
            this.dsSampleAddr.UpdateEvent = "Click";
            this.dsSampleAddr.UpdateMethod = null;
            this.dsSampleAddr.UpdateTrigger = null;
            // 
            // schemadsSampleAddr
            // 
            this.schemadsSampleAddr.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSampleAddrL3DataTableCode,
            this.coldsSampleAddrL3DataTableCode_Des});
            this.schemadsSampleAddr.TableName = "L3DataTable";
            // 
            // coldsSampleAddrL3DataTableCode
            // 
            this.coldsSampleAddrL3DataTableCode.Caption = "Code";
            this.coldsSampleAddrL3DataTableCode.ColumnName = "Code";
            this.coldsSampleAddrL3DataTableCode.Namespace = "";
            // 
            // coldsSampleAddrL3DataTableCode_Des
            // 
            this.coldsSampleAddrL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSampleAddrL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSampleAddrL3DataTableCode_Des.Namespace = "";
            // 
            // sampleTypeDataGridViewTextBoxColumn
            // 
            this.sampleTypeDataGridViewTextBoxColumn.DataPropertyName = "Sample_Type";
            this.sampleTypeDataGridViewTextBoxColumn.DataSource = this.dsSampleType;
            this.sampleTypeDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.sampleTypeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sampleTypeDataGridViewTextBoxColumn.HeaderText = "试样类别";
            this.sampleTypeDataGridViewTextBoxColumn.Name = "sampleTypeDataGridViewTextBoxColumn";
            this.sampleTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sampleTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sampleTypeDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsSampleType
            // 
            this.dsSampleType.AutoLoad = true;
            this.dsSampleType.AutoSubscribe = false;
            this.dsSampleType.DataSetName = "L3DataSet";
            this.dsSampleType.DeleteMethod = null;
            this.dsSampleType.InsertMethod = null;
            this.dsSampleType.L3DataAdapter = this.Adapter;
            this.dsSampleType.LoadEvent = "Click";
            this.dsSampleType.LoadTrigger = null;
            this.dsSampleType.RefreshValve = 1000;
            this.dsSampleType.SourceCommand = null;
            this.dsSampleType.SourceCondition = "CODE_GROUP = \'QA_Sample_Type\'";
            this.dsSampleType.SourceMethod = "";
            this.dsSampleType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSampleType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSampleType.SubscribeTarget = null;
            this.dsSampleType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSampleType});
            this.dsSampleType.UpdateEvent = "Click";
            this.dsSampleType.UpdateMethod = null;
            this.dsSampleType.UpdateTrigger = null;
            // 
            // schemadsSampleType
            // 
            this.schemadsSampleType.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSampleTypeL3DataTableCode,
            this.coldsSampleTypeL3DataTableCode_Des});
            this.schemadsSampleType.TableName = "L3DataTable";
            // 
            // coldsSampleTypeL3DataTableCode
            // 
            this.coldsSampleTypeL3DataTableCode.Caption = "Code";
            this.coldsSampleTypeL3DataTableCode.ColumnName = "Code";
            this.coldsSampleTypeL3DataTableCode.Namespace = "";
            // 
            // coldsSampleTypeL3DataTableCode_Des
            // 
            this.coldsSampleTypeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSampleTypeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSampleTypeL3DataTableCode_Des.Namespace = "";
            // 
            // sampleCountDataGridViewTextBoxColumn
            // 
            this.sampleCountDataGridViewTextBoxColumn.DataPropertyName = "Sample_Count";
            this.sampleCountDataGridViewTextBoxColumn.HeaderText = "取样次数";
            this.sampleCountDataGridViewTextBoxColumn.Name = "sampleCountDataGridViewTextBoxColumn";
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "C";
            this.cDataGridViewTextBoxColumn.HeaderText = "C";
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            // 
            // siDataGridViewTextBoxColumn
            // 
            this.siDataGridViewTextBoxColumn.DataPropertyName = "Si";
            this.siDataGridViewTextBoxColumn.HeaderText = "Si";
            this.siDataGridViewTextBoxColumn.Name = "siDataGridViewTextBoxColumn";
            // 
            // mnDataGridViewTextBoxColumn
            // 
            this.mnDataGridViewTextBoxColumn.DataPropertyName = "Mn";
            this.mnDataGridViewTextBoxColumn.HeaderText = "Mn";
            this.mnDataGridViewTextBoxColumn.Name = "mnDataGridViewTextBoxColumn";
            // 
            // pDataGridViewTextBoxColumn
            // 
            this.pDataGridViewTextBoxColumn.DataPropertyName = "P";
            this.pDataGridViewTextBoxColumn.HeaderText = "P";
            this.pDataGridViewTextBoxColumn.Name = "pDataGridViewTextBoxColumn";
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn.HeaderText = "S";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            // 
            // alDataGridViewTextBoxColumn
            // 
            this.alDataGridViewTextBoxColumn.DataPropertyName = "Al";
            this.alDataGridViewTextBoxColumn.HeaderText = "Al";
            this.alDataGridViewTextBoxColumn.Name = "alDataGridViewTextBoxColumn";
            // 
            // crDataGridViewTextBoxColumn
            // 
            this.crDataGridViewTextBoxColumn.DataPropertyName = "Cr";
            this.crDataGridViewTextBoxColumn.HeaderText = "Cr";
            this.crDataGridViewTextBoxColumn.Name = "crDataGridViewTextBoxColumn";
            // 
            // tiDataGridViewTextBoxColumn
            // 
            this.tiDataGridViewTextBoxColumn.DataPropertyName = "Ti";
            this.tiDataGridViewTextBoxColumn.HeaderText = "Ti";
            this.tiDataGridViewTextBoxColumn.Name = "tiDataGridViewTextBoxColumn";
            // 
            // vDataGridViewTextBoxColumn
            // 
            this.vDataGridViewTextBoxColumn.DataPropertyName = "V";
            this.vDataGridViewTextBoxColumn.HeaderText = "V";
            this.vDataGridViewTextBoxColumn.Name = "vDataGridViewTextBoxColumn";
            // 
            // bDataGridViewTextBoxColumn
            // 
            this.bDataGridViewTextBoxColumn.DataPropertyName = "B";
            this.bDataGridViewTextBoxColumn.HeaderText = "B";
            this.bDataGridViewTextBoxColumn.Name = "bDataGridViewTextBoxColumn";
            // 
            // moDataGridViewTextBoxColumn
            // 
            this.moDataGridViewTextBoxColumn.DataPropertyName = "Mo";
            this.moDataGridViewTextBoxColumn.HeaderText = "Mo";
            this.moDataGridViewTextBoxColumn.Name = "moDataGridViewTextBoxColumn";
            // 
            // niDataGridViewTextBoxColumn
            // 
            this.niDataGridViewTextBoxColumn.DataPropertyName = "Ni";
            this.niDataGridViewTextBoxColumn.HeaderText = "Ni";
            this.niDataGridViewTextBoxColumn.Name = "niDataGridViewTextBoxColumn";
            // 
            // caDataGridViewTextBoxColumn
            // 
            this.caDataGridViewTextBoxColumn.DataPropertyName = "Ca";
            this.caDataGridViewTextBoxColumn.HeaderText = "Ca";
            this.caDataGridViewTextBoxColumn.Name = "caDataGridViewTextBoxColumn";
            // 
            // cuDataGridViewTextBoxColumn
            // 
            this.cuDataGridViewTextBoxColumn.DataPropertyName = "Cu";
            this.cuDataGridViewTextBoxColumn.HeaderText = "Cu";
            this.cuDataGridViewTextBoxColumn.Name = "cuDataGridViewTextBoxColumn";
            // 
            // nbDataGridViewTextBoxColumn
            // 
            this.nbDataGridViewTextBoxColumn.DataPropertyName = "Nb";
            this.nbDataGridViewTextBoxColumn.HeaderText = "Nb";
            this.nbDataGridViewTextBoxColumn.Name = "nbDataGridViewTextBoxColumn";
            // 
            // snDataGridViewTextBoxColumn
            // 
            this.snDataGridViewTextBoxColumn.DataPropertyName = "Sn";
            this.snDataGridViewTextBoxColumn.HeaderText = "Sn";
            this.snDataGridViewTextBoxColumn.Name = "snDataGridViewTextBoxColumn";
            // 
            // wDataGridViewTextBoxColumn
            // 
            this.wDataGridViewTextBoxColumn.DataPropertyName = "W";
            this.wDataGridViewTextBoxColumn.HeaderText = "W";
            this.wDataGridViewTextBoxColumn.Name = "wDataGridViewTextBoxColumn";
            // 
            // pbDataGridViewTextBoxColumn
            // 
            this.pbDataGridViewTextBoxColumn.DataPropertyName = "Pb";
            this.pbDataGridViewTextBoxColumn.HeaderText = "Pb";
            this.pbDataGridViewTextBoxColumn.Name = "pbDataGridViewTextBoxColumn";
            // 
            // znDataGridViewTextBoxColumn
            // 
            this.znDataGridViewTextBoxColumn.DataPropertyName = "Zn";
            this.znDataGridViewTextBoxColumn.HeaderText = "Zn";
            this.znDataGridViewTextBoxColumn.Name = "znDataGridViewTextBoxColumn";
            // 
            // nDataGridViewTextBoxColumn
            // 
            this.nDataGridViewTextBoxColumn.DataPropertyName = "N";
            this.nDataGridViewTextBoxColumn.HeaderText = "N";
            this.nDataGridViewTextBoxColumn.Name = "nDataGridViewTextBoxColumn";
            // 
            // hDataGridViewTextBoxColumn
            // 
            this.hDataGridViewTextBoxColumn.DataPropertyName = "H";
            this.hDataGridViewTextBoxColumn.HeaderText = "H";
            this.hDataGridViewTextBoxColumn.Name = "hDataGridViewTextBoxColumn";
            // 
            // oDataGridViewTextBoxColumn
            // 
            this.oDataGridViewTextBoxColumn.DataPropertyName = "O";
            this.oDataGridViewTextBoxColumn.HeaderText = "O";
            this.oDataGridViewTextBoxColumn.Name = "oDataGridViewTextBoxColumn";
            // 
            // asDataGridViewTextBoxColumn
            // 
            this.asDataGridViewTextBoxColumn.DataPropertyName = "As";
            this.asDataGridViewTextBoxColumn.HeaderText = "As";
            this.asDataGridViewTextBoxColumn.Name = "asDataGridViewTextBoxColumn";
            // 
            // alSDataGridViewTextBoxColumn
            // 
            this.alSDataGridViewTextBoxColumn.DataPropertyName = "AlS";
            this.alSDataGridViewTextBoxColumn.HeaderText = "AlS";
            this.alSDataGridViewTextBoxColumn.Name = "alSDataGridViewTextBoxColumn";
            // 
            // sbDataGridViewTextBoxColumn
            // 
            this.sbDataGridViewTextBoxColumn.DataPropertyName = "Sb";
            this.sbDataGridViewTextBoxColumn.HeaderText = "Sb";
            this.sbDataGridViewTextBoxColumn.Name = "sbDataGridViewTextBoxColumn";
            // 
            // reDataGridViewTextBoxColumn
            // 
            this.reDataGridViewTextBoxColumn.DataPropertyName = "Re";
            this.reDataGridViewTextBoxColumn.HeaderText = "Re";
            this.reDataGridViewTextBoxColumn.Name = "reDataGridViewTextBoxColumn";
            // 
            // ceqDataGridViewTextBoxColumn
            // 
            this.ceqDataGridViewTextBoxColumn.DataPropertyName = "Ceq";
            this.ceqDataGridViewTextBoxColumn.HeaderText = "Ceq";
            this.ceqDataGridViewTextBoxColumn.Name = "ceqDataGridViewTextBoxColumn";
            // 
            // CrNi
            // 
            this.CrNi.DataPropertyName = "CrNi";
            this.CrNi.HeaderText = "CrNi";
            this.CrNi.Name = "CrNi";
            // 
            // CrCu
            // 
            this.CrCu.DataPropertyName = "CrCu";
            this.CrCu.HeaderText = "CrCu";
            this.CrCu.Name = "CrCu";
            // 
            // CrNiCu
            // 
            this.CrNiCu.DataPropertyName = "CrNiCu";
            this.CrNiCu.HeaderText = "CrNiCu";
            this.CrNiCu.Name = "CrNiCu";
            // 
            // other1DataGridViewTextBoxColumn
            // 
            this.other1DataGridViewTextBoxColumn.DataPropertyName = "Other1";
            this.other1DataGridViewTextBoxColumn.HeaderText = "其他1";
            this.other1DataGridViewTextBoxColumn.Name = "other1DataGridViewTextBoxColumn";
            // 
            // other2DataGridViewTextBoxColumn
            // 
            this.other2DataGridViewTextBoxColumn.DataPropertyName = "Other2";
            this.other2DataGridViewTextBoxColumn.HeaderText = "其他2";
            this.other2DataGridViewTextBoxColumn.Name = "other2DataGridViewTextBoxColumn";
            // 
            // Other3
            // 
            this.Other3.DataPropertyName = "Other3";
            this.Other3.HeaderText = "其他3";
            this.Other3.Name = "Other3";
            // 
            // logTimeDataGridViewTextBoxColumn1
            // 
            this.logTimeDataGridViewTextBoxColumn1.DataPropertyName = "LogTime";
            this.logTimeDataGridViewTextBoxColumn1.HeaderText = "数据记录时间";
            this.logTimeDataGridViewTextBoxColumn1.Name = "logTimeDataGridViewTextBoxColumn1";
            this.logTimeDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.logTimeDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.logTimeDataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataLogModeDataGridViewTextBoxColumn
            // 
            this.dataLogModeDataGridViewTextBoxColumn.DataPropertyName = "DataLogMode";
            this.dataLogModeDataGridViewTextBoxColumn.DataSource = this.dsDataLogMode;
            this.dataLogModeDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.dataLogModeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataLogModeDataGridViewTextBoxColumn.HeaderText = "数据产生方式";
            this.dataLogModeDataGridViewTextBoxColumn.Name = "dataLogModeDataGridViewTextBoxColumn";
            this.dataLogModeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLogModeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataLogModeDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsDataLogMode
            // 
            this.dsDataLogMode.AutoLoad = true;
            this.dsDataLogMode.AutoSubscribe = false;
            this.dsDataLogMode.DataSetName = "L3DataSet";
            this.dsDataLogMode.DeleteMethod = null;
            this.dsDataLogMode.InsertMethod = null;
            this.dsDataLogMode.L3DataAdapter = this.Adapter;
            this.dsDataLogMode.LoadEvent = "Click";
            this.dsDataLogMode.LoadTrigger = null;
            this.dsDataLogMode.RefreshValve = 1000;
            this.dsDataLogMode.SourceCommand = null;
            this.dsDataLogMode.SourceCondition = "CODE_GROUP = \'DataLogMode\' and code is not null order by code";
            this.dsDataLogMode.SourceMethod = "";
            this.dsDataLogMode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsDataLogMode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsDataLogMode.SubscribeTarget = null;
            this.dsDataLogMode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDataLogMode});
            this.dsDataLogMode.UpdateEvent = "Click";
            this.dsDataLogMode.UpdateMethod = null;
            this.dsDataLogMode.UpdateTrigger = null;
            // 
            // schemadsDataLogMode
            // 
            this.schemadsDataLogMode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDataLogModeL3DataTableCode_Des,
            this.coldsDataLogModeL3DataTableCode_Val_Long});
            this.schemadsDataLogMode.TableName = "L3DataTable";
            // 
            // coldsDataLogModeL3DataTableCode_Des
            // 
            this.coldsDataLogModeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsDataLogModeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsDataLogModeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsDataLogModeL3DataTableCode_Val_Long
            // 
            this.coldsDataLogModeL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsDataLogModeL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsDataLogModeL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsDataLogModeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // bsChemical
            // 
            this.bsChemical.DataMember = "L3DataTable";
            this.bsChemical.DataSource = this.dsChemical;
            // 
            // bnChemical
            // 
            this.bnChemical.AddNewItem = null;
            this.bnChemical.BindingSource = this.bsChemical;
            this.bnChemical.CountItem = this.toolStripLabel6;
            this.bnChemical.DeleteItem = null;
            this.bnChemical.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton27,
            this.toolStripButton28,
            this.toolStripSeparator16,
            this.toolStripTextBox6,
            this.toolStripLabel6,
            this.toolStripSeparator17,
            this.toolStripButton29,
            this.toolStripButton30,
            this.toolStripSeparator18,
            this.btnAddChemical});
            this.bnChemical.Location = new System.Drawing.Point(3, 3);
            this.bnChemical.MoveFirstItem = this.toolStripButton27;
            this.bnChemical.MoveLastItem = this.toolStripButton30;
            this.bnChemical.MoveNextItem = this.toolStripButton29;
            this.bnChemical.MovePreviousItem = this.toolStripButton28;
            this.bnChemical.Name = "bnChemical";
            this.bnChemical.PositionItem = this.toolStripTextBox6;
            this.bnChemical.Size = new System.Drawing.Size(988, 25);
            this.bnChemical.TabIndex = 100;
            this.bnChemical.Text = "bindingNavigator6";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel6.Text = "/ {0}";
            this.toolStripLabel6.ToolTipText = "总项数";
            // 
            // toolStripButton27
            // 
            this.toolStripButton27.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton27.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton27.Image")));
            this.toolStripButton27.Name = "toolStripButton27";
            this.toolStripButton27.RightToLeftAutoMirrorImage = true;
            this.toolStripButton27.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton27.Text = "移到第一条记录";
            // 
            // toolStripButton28
            // 
            this.toolStripButton28.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton28.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton28.Image")));
            this.toolStripButton28.Name = "toolStripButton28";
            this.toolStripButton28.RightToLeftAutoMirrorImage = true;
            this.toolStripButton28.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton28.Text = "移到上一条记录";
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox6
            // 
            this.toolStripTextBox6.AccessibleName = "位置";
            this.toolStripTextBox6.AutoSize = false;
            this.toolStripTextBox6.Name = "toolStripTextBox6";
            this.toolStripTextBox6.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox6.Text = "0";
            this.toolStripTextBox6.ToolTipText = "当前位置";
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton29
            // 
            this.toolStripButton29.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton29.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton29.Image")));
            this.toolStripButton29.Name = "toolStripButton29";
            this.toolStripButton29.RightToLeftAutoMirrorImage = true;
            this.toolStripButton29.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton29.Text = "移到下一条记录";
            // 
            // toolStripButton30
            // 
            this.toolStripButton30.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton30.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton30.Image")));
            this.toolStripButton30.Name = "toolStripButton30";
            this.toolStripButton30.RightToLeftAutoMirrorImage = true;
            this.toolStripButton30.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton30.Text = "移到最后一条记录";
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddChemical
            // 
            this.btnAddChemical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddChemical.Image = ((System.Drawing.Image)(resources.GetObject("btnAddChemical.Image")));
            this.btnAddChemical.Name = "btnAddChemical";
            this.btnAddChemical.RightToLeftAutoMirrorImage = true;
            this.btnAddChemical.Size = new System.Drawing.Size(23, 22);
            this.btnAddChemical.Text = "新添";
            this.btnAddChemical.Click += new System.EventHandler(this.btnAddChemical_Click);
            // 
            // pnlChemical
            // 
            this.pnlChemical.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlChemical.Controls.Add(this.btnChemicalCancel);
            this.pnlChemical.Controls.Add(this.btnChemicalOK);
            this.pnlChemical.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChemical.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlChemical.Location = new System.Drawing.Point(3, 330);
            this.pnlChemical.Name = "pnlChemical";
            this.pnlChemical.Size = new System.Drawing.Size(988, 33);
            this.pnlChemical.TabIndex = 90;
            // 
            // btnChemicalCancel
            // 
            this.btnChemicalCancel.Location = new System.Drawing.Point(906, 3);
            this.btnChemicalCancel.Name = "btnChemicalCancel";
            this.btnChemicalCancel.Size = new System.Drawing.Size(75, 23);
            this.btnChemicalCancel.TabIndex = 87;
            this.btnChemicalCancel.Text = "取消";
            this.btnChemicalCancel.UseVisualStyleBackColor = true;
            this.btnChemicalCancel.Click += new System.EventHandler(this.btnChemicalCancel_Click);
            // 
            // btnChemicalOK
            // 
            this.btnChemicalOK.Location = new System.Drawing.Point(825, 3);
            this.btnChemicalOK.Name = "btnChemicalOK";
            this.btnChemicalOK.Size = new System.Drawing.Size(75, 23);
            this.btnChemicalOK.TabIndex = 86;
            this.btnChemicalOK.Text = "确认";
            this.btnChemicalOK.UseVisualStyleBackColor = true;
            this.btnChemicalOK.Click += new System.EventHandler(this.btnChemicalOK_Click);
            // 
            // tabStatus
            // 
            this.tabStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabStatus.Controls.Add(this.dvStatus);
            this.tabStatus.Controls.Add(this.bnStatus);
            this.tabStatus.Controls.Add(this.pnlStatus);
            this.tabStatus.Location = new System.Drawing.Point(4, 22);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatus.Size = new System.Drawing.Size(996, 368);
            this.tabStatus.TabIndex = 6;
            this.tabStatus.Text = "状态数据";
            this.tabStatus.UseVisualStyleBackColor = true;
            // 
            // dvStatus
            // 
            this.dvStatus.AllowUserToAddRows = false;
            this.dvStatus.AllowUserToDeleteRows = false;
            this.dvStatus.AutoGenerateColumns = false;
            this.dvStatus.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.treatNoDataGridViewTextBoxColumn1,
            this.heatIDDataGridViewTextBoxColumn1,
            this.statusDataGridViewCheckBoxColumn,
            this.changeTimeDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn3,
            this.nameDataGridViewTextBoxColumn3});
            this.dvStatus.DataSource = this.bsStatus;
            this.dvStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvStatus.Location = new System.Drawing.Point(3, 28);
            this.dvStatus.Name = "dvStatus";
            this.dvStatus.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvStatus.RowTemplate.Height = 23;
            this.dvStatus.Size = new System.Drawing.Size(988, 302);
            this.dvStatus.TabIndex = 100;
            this.dvStatus.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMat_DataError);
            // 
            // treatNoDataGridViewTextBoxColumn1
            // 
            this.treatNoDataGridViewTextBoxColumn1.DataPropertyName = "TreatNo";
            this.treatNoDataGridViewTextBoxColumn1.HeaderText = "处理号";
            this.treatNoDataGridViewTextBoxColumn1.Name = "treatNoDataGridViewTextBoxColumn1";
            // 
            // heatIDDataGridViewTextBoxColumn1
            // 
            this.heatIDDataGridViewTextBoxColumn1.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn1.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn1.Name = "heatIDDataGridViewTextBoxColumn1";
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.DataSource = this.dsRHStatus;
            this.statusDataGridViewCheckBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.statusDataGridViewCheckBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.statusDataGridViewCheckBoxColumn.HeaderText = "状态";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusDataGridViewCheckBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsRHStatus
            // 
            this.dsRHStatus.AutoLoad = true;
            this.dsRHStatus.AutoSubscribe = false;
            this.dsRHStatus.DataSetName = "L3DataSet";
            this.dsRHStatus.DeleteMethod = null;
            this.dsRHStatus.InsertMethod = null;
            this.dsRHStatus.L3DataAdapter = this.Adapter;
            this.dsRHStatus.LoadEvent = "Click";
            this.dsRHStatus.LoadTrigger = null;
            this.dsRHStatus.RefreshValve = 1000;
            this.dsRHStatus.SourceCommand = null;
            this.dsRHStatus.SourceCondition = "CODE_GROUP = \'RHUnitStatus\' and code is not null order by code";
            this.dsRHStatus.SourceMethod = "";
            this.dsRHStatus.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsRHStatus.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsRHStatus.SubscribeTarget = null;
            this.dsRHStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsRHStatus});
            this.dsRHStatus.UpdateEvent = "Click";
            this.dsRHStatus.UpdateMethod = null;
            this.dsRHStatus.UpdateTrigger = null;
            // 
            // schemadsRHStatus
            // 
            this.schemadsRHStatus.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsRHStatusL3DataTableCode_Des,
            this.coldsRHStatusL3DataTableCode_Val_Long});
            this.schemadsRHStatus.TableName = "L3DataTable";
            // 
            // coldsRHStatusL3DataTableCode_Des
            // 
            this.coldsRHStatusL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsRHStatusL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsRHStatusL3DataTableCode_Des.Namespace = "";
            // 
            // coldsRHStatusL3DataTableCode_Val_Long
            // 
            this.coldsRHStatusL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsRHStatusL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsRHStatusL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsRHStatusL3DataTableCode_Val_Long.Namespace = "";
            // 
            // changeTimeDataGridViewTextBoxColumn
            // 
            this.changeTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.changeTimeDataGridViewTextBoxColumn.DataPropertyName = "Change_Time";
            this.changeTimeDataGridViewTextBoxColumn.HeaderText = "状态变化时刻";
            this.changeTimeDataGridViewTextBoxColumn.Name = "changeTimeDataGridViewTextBoxColumn";
            this.changeTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.changeTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // gUIDDataGridViewTextBoxColumn3
            // 
            this.gUIDDataGridViewTextBoxColumn3.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn3.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn3.Name = "gUIDDataGridViewTextBoxColumn3";
            this.gUIDDataGridViewTextBoxColumn3.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            this.nameDataGridViewTextBoxColumn3.Visible = false;
            // 
            // bnStatus
            // 
            this.bnStatus.AddNewItem = null;
            this.bnStatus.BindingSource = this.bsStatus;
            this.bnStatus.CountItem = this.toolStripLabel5;
            this.bnStatus.DeleteItem = null;
            this.bnStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton22,
            this.toolStripButton23,
            this.toolStripSeparator13,
            this.toolStripTextBox5,
            this.toolStripLabel5,
            this.toolStripSeparator14,
            this.toolStripButton24,
            this.toolStripButton25,
            this.toolStripSeparator15,
            this.btnAddStatus});
            this.bnStatus.Location = new System.Drawing.Point(3, 3);
            this.bnStatus.MoveFirstItem = this.toolStripButton22;
            this.bnStatus.MoveLastItem = this.toolStripButton25;
            this.bnStatus.MoveNextItem = this.toolStripButton24;
            this.bnStatus.MovePreviousItem = this.toolStripButton23;
            this.bnStatus.Name = "bnStatus";
            this.bnStatus.PositionItem = this.toolStripTextBox5;
            this.bnStatus.Size = new System.Drawing.Size(988, 25);
            this.bnStatus.TabIndex = 99;
            this.bnStatus.Text = "bindingNavigator5";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel5.Text = "/ {0}";
            this.toolStripLabel5.ToolTipText = "总项数";
            // 
            // toolStripButton22
            // 
            this.toolStripButton22.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton22.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton22.Image")));
            this.toolStripButton22.Name = "toolStripButton22";
            this.toolStripButton22.RightToLeftAutoMirrorImage = true;
            this.toolStripButton22.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton22.Text = "移到第一条记录";
            // 
            // toolStripButton23
            // 
            this.toolStripButton23.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton23.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton23.Image")));
            this.toolStripButton23.Name = "toolStripButton23";
            this.toolStripButton23.RightToLeftAutoMirrorImage = true;
            this.toolStripButton23.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton23.Text = "移到上一条记录";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox5
            // 
            this.toolStripTextBox5.AccessibleName = "位置";
            this.toolStripTextBox5.AutoSize = false;
            this.toolStripTextBox5.Name = "toolStripTextBox5";
            this.toolStripTextBox5.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox5.Text = "0";
            this.toolStripTextBox5.ToolTipText = "当前位置";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton24
            // 
            this.toolStripButton24.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton24.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton24.Image")));
            this.toolStripButton24.Name = "toolStripButton24";
            this.toolStripButton24.RightToLeftAutoMirrorImage = true;
            this.toolStripButton24.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton24.Text = "移到下一条记录";
            // 
            // toolStripButton25
            // 
            this.toolStripButton25.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton25.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton25.Image")));
            this.toolStripButton25.Name = "toolStripButton25";
            this.toolStripButton25.RightToLeftAutoMirrorImage = true;
            this.toolStripButton25.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton25.Text = "移到最后一条记录";
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddStatus
            // 
            this.btnAddStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStatus.Image")));
            this.btnAddStatus.Name = "btnAddStatus";
            this.btnAddStatus.RightToLeftAutoMirrorImage = true;
            this.btnAddStatus.Size = new System.Drawing.Size(23, 22);
            this.btnAddStatus.Text = "新添";
            this.btnAddStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // pnlStatus
            // 
            this.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlStatus.Controls.Add(this.btnStatusCancel);
            this.pnlStatus.Controls.Add(this.btnStatusOK);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlStatus.Location = new System.Drawing.Point(3, 330);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(988, 33);
            this.pnlStatus.TabIndex = 91;
            // 
            // btnStatusCancel
            // 
            this.btnStatusCancel.Location = new System.Drawing.Point(906, 3);
            this.btnStatusCancel.Name = "btnStatusCancel";
            this.btnStatusCancel.Size = new System.Drawing.Size(75, 23);
            this.btnStatusCancel.TabIndex = 87;
            this.btnStatusCancel.Text = "取消";
            this.btnStatusCancel.UseVisualStyleBackColor = true;
            this.btnStatusCancel.Click += new System.EventHandler(this.btnStatusCancel_Click);
            // 
            // btnStatusOK
            // 
            this.btnStatusOK.Location = new System.Drawing.Point(825, 3);
            this.btnStatusOK.Name = "btnStatusOK";
            this.btnStatusOK.Size = new System.Drawing.Size(75, 23);
            this.btnStatusOK.TabIndex = 86;
            this.btnStatusOK.Text = "确认";
            this.btnStatusOK.UseVisualStyleBackColor = true;
            this.btnStatusOK.Click += new System.EventHandler(this.btnStatusOK_Click);
            // 
            // tabTemp
            // 
            this.tabTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTemp.Controls.Add(this.hmiRootPanel6);
            this.tabTemp.Location = new System.Drawing.Point(4, 22);
            this.tabTemp.Name = "tabTemp";
            this.tabTemp.Padding = new System.Windows.Forms.Padding(3);
            this.tabTemp.Size = new System.Drawing.Size(996, 368);
            this.tabTemp.TabIndex = 9;
            this.tabTemp.Text = "测温数据";
            this.tabTemp.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel6
            // 
            this.hmiRootPanel6.Controls.Add(this.dvTemp);
            this.hmiRootPanel6.Controls.Add(this.bnTemp);
            this.hmiRootPanel6.Controls.Add(this.pnlTemp);
            this.hmiRootPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel6.Location = new System.Drawing.Point(3, 3);
            this.hmiRootPanel6.Name = "hmiRootPanel6";
            this.hmiRootPanel6.Size = new System.Drawing.Size(988, 360);
            this.hmiRootPanel6.TabIndex = 0;
            // 
            // dvTemp
            // 
            this.dvTemp.AllowUserToAddRows = false;
            this.dvTemp.AllowUserToDeleteRows = false;
            this.dvTemp.AutoGenerateColumns = false;
            this.dvTemp.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvTemp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.treatNoDataGridViewTextBoxColumn2,
            this.heatIDDataGridViewTextBoxColumn2,
            this.tempDataGridViewTextBoxColumn,
            this.measureTimeDataGridViewTextBoxColumn,
            this.measureModeDataGridViewCheckBoxColumn,
            this.gUIDDataGridViewTextBoxColumn4,
            this.nameDataGridViewTextBoxColumn4});
            this.dvTemp.DataSource = this.bsTemp;
            this.dvTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvTemp.Location = new System.Drawing.Point(0, 25);
            this.dvTemp.Name = "dvTemp";
            this.dvTemp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvTemp.RowTemplate.Height = 23;
            this.dvTemp.Size = new System.Drawing.Size(988, 302);
            this.dvTemp.TabIndex = 99;
            this.dvTemp.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMat_DataError);
            // 
            // treatNoDataGridViewTextBoxColumn2
            // 
            this.treatNoDataGridViewTextBoxColumn2.DataPropertyName = "TreatNo";
            this.treatNoDataGridViewTextBoxColumn2.HeaderText = "处理号";
            this.treatNoDataGridViewTextBoxColumn2.Name = "treatNoDataGridViewTextBoxColumn2";
            // 
            // heatIDDataGridViewTextBoxColumn2
            // 
            this.heatIDDataGridViewTextBoxColumn2.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn2.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn2.Name = "heatIDDataGridViewTextBoxColumn2";
            // 
            // tempDataGridViewTextBoxColumn
            // 
            this.tempDataGridViewTextBoxColumn.DataPropertyName = "Temp";
            this.tempDataGridViewTextBoxColumn.HeaderText = "测温值";
            this.tempDataGridViewTextBoxColumn.Name = "tempDataGridViewTextBoxColumn";
            // 
            // measureTimeDataGridViewTextBoxColumn
            // 
            this.measureTimeDataGridViewTextBoxColumn.DataPropertyName = "MeasureTime";
            dataGridViewCellStyle3.Format = "G";
            this.measureTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.measureTimeDataGridViewTextBoxColumn.HeaderText = "测温时刻";
            this.measureTimeDataGridViewTextBoxColumn.Name = "measureTimeDataGridViewTextBoxColumn";
            this.measureTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.measureTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.measureTimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // measureModeDataGridViewCheckBoxColumn
            // 
            this.measureModeDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.measureModeDataGridViewCheckBoxColumn.DataPropertyName = "MeasureMode";
            this.measureModeDataGridViewCheckBoxColumn.DataSource = this.dsBOFTempMode;
            this.measureModeDataGridViewCheckBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.measureModeDataGridViewCheckBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.measureModeDataGridViewCheckBoxColumn.HeaderText = "测温模式";
            this.measureModeDataGridViewCheckBoxColumn.Name = "measureModeDataGridViewCheckBoxColumn";
            this.measureModeDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.measureModeDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.measureModeDataGridViewCheckBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsBOFTempMode
            // 
            this.dsBOFTempMode.AutoLoad = true;
            this.dsBOFTempMode.AutoSubscribe = false;
            this.dsBOFTempMode.DataSetName = "L3DataSet";
            this.dsBOFTempMode.DeleteMethod = null;
            this.dsBOFTempMode.InsertMethod = null;
            this.dsBOFTempMode.L3DataAdapter = this.Adapter;
            this.dsBOFTempMode.LoadEvent = "Click";
            this.dsBOFTempMode.LoadTrigger = null;
            this.dsBOFTempMode.RefreshValve = 1000;
            this.dsBOFTempMode.SourceCommand = null;
            this.dsBOFTempMode.SourceCondition = "CODE_GROUP = \'LF_TEMP_MODE\' and code is not null order by code";
            this.dsBOFTempMode.SourceMethod = "";
            this.dsBOFTempMode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBOFTempMode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBOFTempMode.SubscribeTarget = null;
            this.dsBOFTempMode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBOFTempMode});
            this.dsBOFTempMode.UpdateEvent = "Click";
            this.dsBOFTempMode.UpdateMethod = null;
            this.dsBOFTempMode.UpdateTrigger = null;
            // 
            // schemadsBOFTempMode
            // 
            this.schemadsBOFTempMode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBOFTempModeL3DataTableCode_Des,
            this.coldsBOFTempModeL3DataTableCode_Val_Long});
            this.schemadsBOFTempMode.TableName = "L3DataTable";
            // 
            // coldsBOFTempModeL3DataTableCode_Des
            // 
            this.coldsBOFTempModeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBOFTempModeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBOFTempModeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsBOFTempModeL3DataTableCode_Val_Long
            // 
            this.coldsBOFTempModeL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsBOFTempModeL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsBOFTempModeL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsBOFTempModeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // gUIDDataGridViewTextBoxColumn4
            // 
            this.gUIDDataGridViewTextBoxColumn4.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn4.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn4.Name = "gUIDDataGridViewTextBoxColumn4";
            this.gUIDDataGridViewTextBoxColumn4.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn4
            // 
            this.nameDataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn4.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn4.Name = "nameDataGridViewTextBoxColumn4";
            this.nameDataGridViewTextBoxColumn4.Visible = false;
            // 
            // bnTemp
            // 
            this.bnTemp.AddNewItem = null;
            this.bnTemp.BindingSource = this.bsTemp;
            this.bnTemp.CountItem = this.toolStripLabel4;
            this.bnTemp.DeleteItem = null;
            this.bnTemp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton17,
            this.toolStripButton18,
            this.toolStripSeparator10,
            this.toolStripTextBox4,
            this.toolStripLabel4,
            this.toolStripSeparator11,
            this.toolStripButton19,
            this.toolStripButton20,
            this.toolStripSeparator12,
            this.btnAddTemp});
            this.bnTemp.Location = new System.Drawing.Point(0, 0);
            this.bnTemp.MoveFirstItem = this.toolStripButton17;
            this.bnTemp.MoveLastItem = this.toolStripButton20;
            this.bnTemp.MoveNextItem = this.toolStripButton19;
            this.bnTemp.MovePreviousItem = this.toolStripButton18;
            this.bnTemp.Name = "bnTemp";
            this.bnTemp.PositionItem = this.toolStripTextBox4;
            this.bnTemp.Size = new System.Drawing.Size(988, 25);
            this.bnTemp.TabIndex = 98;
            this.bnTemp.Text = "bindingNavigator4";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel4.Text = "/ {0}";
            this.toolStripLabel4.ToolTipText = "总项数";
            // 
            // toolStripButton17
            // 
            this.toolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton17.Image")));
            this.toolStripButton17.Name = "toolStripButton17";
            this.toolStripButton17.RightToLeftAutoMirrorImage = true;
            this.toolStripButton17.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton17.Text = "移到第一条记录";
            // 
            // toolStripButton18
            // 
            this.toolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton18.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton18.Image")));
            this.toolStripButton18.Name = "toolStripButton18";
            this.toolStripButton18.RightToLeftAutoMirrorImage = true;
            this.toolStripButton18.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton18.Text = "移到上一条记录";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.AccessibleName = "位置";
            this.toolStripTextBox4.AutoSize = false;
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox4.Text = "0";
            this.toolStripTextBox4.ToolTipText = "当前位置";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton19
            // 
            this.toolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton19.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton19.Image")));
            this.toolStripButton19.Name = "toolStripButton19";
            this.toolStripButton19.RightToLeftAutoMirrorImage = true;
            this.toolStripButton19.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton19.Text = "移到下一条记录";
            // 
            // toolStripButton20
            // 
            this.toolStripButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton20.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton20.Image")));
            this.toolStripButton20.Name = "toolStripButton20";
            this.toolStripButton20.RightToLeftAutoMirrorImage = true;
            this.toolStripButton20.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton20.Text = "移到最后一条记录";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddTemp
            // 
            this.btnAddTemp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddTemp.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTemp.Image")));
            this.btnAddTemp.Name = "btnAddTemp";
            this.btnAddTemp.RightToLeftAutoMirrorImage = true;
            this.btnAddTemp.Size = new System.Drawing.Size(23, 22);
            this.btnAddTemp.Text = "新添";
            this.btnAddTemp.Click += new System.EventHandler(this.btnAddTemp_Click);
            // 
            // pnlTemp
            // 
            this.pnlTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTemp.Controls.Add(this.btnTempCancel);
            this.pnlTemp.Controls.Add(this.btnTempOK);
            this.pnlTemp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTemp.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlTemp.Location = new System.Drawing.Point(0, 327);
            this.pnlTemp.Name = "pnlTemp";
            this.pnlTemp.Size = new System.Drawing.Size(988, 33);
            this.pnlTemp.TabIndex = 92;
            // 
            // btnTempCancel
            // 
            this.btnTempCancel.Location = new System.Drawing.Point(906, 3);
            this.btnTempCancel.Name = "btnTempCancel";
            this.btnTempCancel.Size = new System.Drawing.Size(75, 23);
            this.btnTempCancel.TabIndex = 87;
            this.btnTempCancel.Text = "取消";
            this.btnTempCancel.UseVisualStyleBackColor = true;
            this.btnTempCancel.Click += new System.EventHandler(this.btnTempCancel_Click);
            // 
            // btnTempOK
            // 
            this.btnTempOK.Location = new System.Drawing.Point(825, 3);
            this.btnTempOK.Name = "btnTempOK";
            this.btnTempOK.Size = new System.Drawing.Size(75, 23);
            this.btnTempOK.TabIndex = 86;
            this.btnTempOK.Text = "确认";
            this.btnTempOK.UseVisualStyleBackColor = true;
            this.btnTempOK.Click += new System.EventHandler(this.btnTempOK_Click);
            // 
            // tabOxygen
            // 
            this.tabOxygen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabOxygen.Controls.Add(this.dvOxygen);
            this.tabOxygen.Controls.Add(this.bnOxygen);
            this.tabOxygen.Controls.Add(this.pnlOxygen);
            this.tabOxygen.Location = new System.Drawing.Point(4, 22);
            this.tabOxygen.Name = "tabOxygen";
            this.tabOxygen.Padding = new System.Windows.Forms.Padding(3);
            this.tabOxygen.Size = new System.Drawing.Size(996, 368);
            this.tabOxygen.TabIndex = 10;
            this.tabOxygen.Text = "定氧数据";
            this.tabOxygen.UseVisualStyleBackColor = true;
            // 
            // dvOxygen
            // 
            this.dvOxygen.AllowUserToAddRows = false;
            this.dvOxygen.AllowUserToDeleteRows = false;
            this.dvOxygen.AutoGenerateColumns = false;
            this.dvOxygen.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvOxygen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvOxygen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.treatNoDataGridViewTextBoxColumn3,
            this.heatIDDataGridViewTextBoxColumn3,
            this.oxygenContentDataGridViewTextBoxColumn,
            this.MeasureTime});
            this.dvOxygen.DataSource = this.bsOxygen;
            this.dvOxygen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvOxygen.Location = new System.Drawing.Point(3, 28);
            this.dvOxygen.Name = "dvOxygen";
            this.dvOxygen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvOxygen.RowTemplate.Height = 23;
            this.dvOxygen.Size = new System.Drawing.Size(988, 302);
            this.dvOxygen.TabIndex = 98;
            this.dvOxygen.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMat_DataError);
            // 
            // treatNoDataGridViewTextBoxColumn3
            // 
            this.treatNoDataGridViewTextBoxColumn3.DataPropertyName = "TreatNo";
            this.treatNoDataGridViewTextBoxColumn3.HeaderText = "处理号";
            this.treatNoDataGridViewTextBoxColumn3.Name = "treatNoDataGridViewTextBoxColumn3";
            // 
            // heatIDDataGridViewTextBoxColumn3
            // 
            this.heatIDDataGridViewTextBoxColumn3.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn3.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn3.Name = "heatIDDataGridViewTextBoxColumn3";
            // 
            // oxygenContentDataGridViewTextBoxColumn
            // 
            this.oxygenContentDataGridViewTextBoxColumn.DataPropertyName = "Oxygen_Content";
            this.oxygenContentDataGridViewTextBoxColumn.HeaderText = "氧含量";
            this.oxygenContentDataGridViewTextBoxColumn.Name = "oxygenContentDataGridViewTextBoxColumn";
            // 
            // MeasureTime
            // 
            this.MeasureTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MeasureTime.DataPropertyName = "MeasureTime";
            this.MeasureTime.HeaderText = "定氧时间";
            this.MeasureTime.Name = "MeasureTime";
            this.MeasureTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MeasureTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bnOxygen
            // 
            this.bnOxygen.AddNewItem = null;
            this.bnOxygen.BindingSource = this.bsOxygen;
            this.bnOxygen.CountItem = this.toolStripLabel3;
            this.bnOxygen.DeleteItem = null;
            this.bnOxygen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripSeparator7,
            this.toolStripTextBox3,
            this.toolStripLabel3,
            this.toolStripSeparator8,
            this.toolStripButton14,
            this.toolStripButton15,
            this.toolStripSeparator9,
            this.btnAddOxygen});
            this.bnOxygen.Location = new System.Drawing.Point(3, 3);
            this.bnOxygen.MoveFirstItem = this.toolStripButton12;
            this.bnOxygen.MoveLastItem = this.toolStripButton15;
            this.bnOxygen.MoveNextItem = this.toolStripButton14;
            this.bnOxygen.MovePreviousItem = this.toolStripButton13;
            this.bnOxygen.Name = "bnOxygen";
            this.bnOxygen.PositionItem = this.toolStripTextBox3;
            this.bnOxygen.Size = new System.Drawing.Size(988, 25);
            this.bnOxygen.TabIndex = 97;
            this.bnOxygen.Text = "bindingNavigator3";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel3.Text = "/ {0}";
            this.toolStripLabel3.ToolTipText = "总项数";
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "移到第一条记录";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "移到上一条记录";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.AccessibleName = "位置";
            this.toolStripTextBox3.AutoSize = false;
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox3.Text = "0";
            this.toolStripTextBox3.ToolTipText = "当前位置";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.RightToLeftAutoMirrorImage = true;
            this.toolStripButton14.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton14.Text = "移到下一条记录";
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.RightToLeftAutoMirrorImage = true;
            this.toolStripButton15.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton15.Text = "移到最后一条记录";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddOxygen
            // 
            this.btnAddOxygen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddOxygen.Image = ((System.Drawing.Image)(resources.GetObject("btnAddOxygen.Image")));
            this.btnAddOxygen.Name = "btnAddOxygen";
            this.btnAddOxygen.RightToLeftAutoMirrorImage = true;
            this.btnAddOxygen.Size = new System.Drawing.Size(23, 22);
            this.btnAddOxygen.Text = "新添";
            this.btnAddOxygen.Click += new System.EventHandler(this.btnAddOxygen_Click);
            // 
            // pnlOxygen
            // 
            this.pnlOxygen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOxygen.Controls.Add(this.btnOxygenCancel);
            this.pnlOxygen.Controls.Add(this.btnOxygenOK);
            this.pnlOxygen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOxygen.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlOxygen.Location = new System.Drawing.Point(3, 330);
            this.pnlOxygen.Name = "pnlOxygen";
            this.pnlOxygen.Size = new System.Drawing.Size(988, 33);
            this.pnlOxygen.TabIndex = 92;
            // 
            // btnOxygenCancel
            // 
            this.btnOxygenCancel.Location = new System.Drawing.Point(906, 3);
            this.btnOxygenCancel.Name = "btnOxygenCancel";
            this.btnOxygenCancel.Size = new System.Drawing.Size(75, 23);
            this.btnOxygenCancel.TabIndex = 87;
            this.btnOxygenCancel.Text = "取消";
            this.btnOxygenCancel.UseVisualStyleBackColor = true;
            this.btnOxygenCancel.Click += new System.EventHandler(this.btnOxygenCancel_Click);
            // 
            // btnOxygenOK
            // 
            this.btnOxygenOK.Location = new System.Drawing.Point(825, 3);
            this.btnOxygenOK.Name = "btnOxygenOK";
            this.btnOxygenOK.Size = new System.Drawing.Size(75, 23);
            this.btnOxygenOK.TabIndex = 86;
            this.btnOxygenOK.Text = "确认";
            this.btnOxygenOK.UseVisualStyleBackColor = true;
            this.btnOxygenOK.Click += new System.EventHandler(this.btnOxygenOK_Click);
            // 
            // tabRemark
            // 
            this.tabRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabRemark.Controls.Add(this.dvRemark);
            this.tabRemark.Controls.Add(this.bnRemark);
            this.tabRemark.Controls.Add(this.pnlNote);
            this.tabRemark.Location = new System.Drawing.Point(4, 22);
            this.tabRemark.Name = "tabRemark";
            this.tabRemark.Padding = new System.Windows.Forms.Padding(3);
            this.tabRemark.Size = new System.Drawing.Size(996, 368);
            this.tabRemark.TabIndex = 11;
            this.tabRemark.Text = "记事数据";
            this.tabRemark.UseVisualStyleBackColor = true;
            // 
            // dvRemark
            // 
            this.dvRemark.AllowUserToAddRows = false;
            this.dvRemark.AllowUserToDeleteRows = false;
            this.dvRemark.AutoGenerateColumns = false;
            this.dvRemark.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvRemark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvRemark.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.treatNoDataGridViewTextBoxColumn4,
            this.heatIDDataGridViewTextBoxColumn4,
            this.typeDataGridViewCheckBoxColumn1,
            this.logTimeDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn2});
            this.dvRemark.DataSource = this.bsRemark;
            this.dvRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvRemark.Location = new System.Drawing.Point(3, 28);
            this.dvRemark.Name = "dvRemark";
            this.dvRemark.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvRemark.RowTemplate.Height = 23;
            this.dvRemark.Size = new System.Drawing.Size(988, 302);
            this.dvRemark.TabIndex = 97;
            this.dvRemark.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMat_DataError);
            // 
            // treatNoDataGridViewTextBoxColumn4
            // 
            this.treatNoDataGridViewTextBoxColumn4.DataPropertyName = "TreatNo";
            this.treatNoDataGridViewTextBoxColumn4.HeaderText = "处理号";
            this.treatNoDataGridViewTextBoxColumn4.Name = "treatNoDataGridViewTextBoxColumn4";
            // 
            // heatIDDataGridViewTextBoxColumn4
            // 
            this.heatIDDataGridViewTextBoxColumn4.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn4.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn4.Name = "heatIDDataGridViewTextBoxColumn4";
            // 
            // typeDataGridViewCheckBoxColumn1
            // 
            this.typeDataGridViewCheckBoxColumn1.DataPropertyName = "Type";
            this.typeDataGridViewCheckBoxColumn1.DataSource = this.dsRemarkType;
            this.typeDataGridViewCheckBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.typeDataGridViewCheckBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.typeDataGridViewCheckBoxColumn1.HeaderText = "分类";
            this.typeDataGridViewCheckBoxColumn1.Name = "typeDataGridViewCheckBoxColumn1";
            this.typeDataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typeDataGridViewCheckBoxColumn1.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsRemarkType
            // 
            this.dsRemarkType.AutoLoad = true;
            this.dsRemarkType.AutoSubscribe = false;
            this.dsRemarkType.DataSetName = "L3DataSet";
            this.dsRemarkType.DeleteMethod = null;
            this.dsRemarkType.InsertMethod = null;
            this.dsRemarkType.L3DataAdapter = this.Adapter;
            this.dsRemarkType.LoadEvent = "Click";
            this.dsRemarkType.LoadTrigger = null;
            this.dsRemarkType.RefreshValve = 1000;
            this.dsRemarkType.SourceCommand = null;
            this.dsRemarkType.SourceCondition = "CODE_GROUP = \'REMARK_TYPE\' and code is not null order by code";
            this.dsRemarkType.SourceMethod = "";
            this.dsRemarkType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsRemarkType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsRemarkType.SubscribeTarget = null;
            this.dsRemarkType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsRemarkType});
            this.dsRemarkType.UpdateEvent = "Click";
            this.dsRemarkType.UpdateMethod = null;
            this.dsRemarkType.UpdateTrigger = null;
            // 
            // schemadsRemarkType
            // 
            this.schemadsRemarkType.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsRemarkTypeL3DataTableCode_Des,
            this.coldsRemarkTypeL3DataTableCode_Val_Long});
            this.schemadsRemarkType.TableName = "L3DataTable";
            // 
            // coldsRemarkTypeL3DataTableCode_Des
            // 
            this.coldsRemarkTypeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsRemarkTypeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsRemarkTypeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsRemarkTypeL3DataTableCode_Val_Long
            // 
            this.coldsRemarkTypeL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsRemarkTypeL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsRemarkTypeL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsRemarkTypeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // logTimeDataGridViewTextBoxColumn
            // 
            this.logTimeDataGridViewTextBoxColumn.DataPropertyName = "LogTime";
            this.logTimeDataGridViewTextBoxColumn.HeaderText = "记录时刻";
            this.logTimeDataGridViewTextBoxColumn.Name = "logTimeDataGridViewTextBoxColumn";
            this.logTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.logTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.logTimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "备注";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            // 
            // gUIDDataGridViewTextBoxColumn2
            // 
            this.gUIDDataGridViewTextBoxColumn2.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn2.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn2.Name = "gUIDDataGridViewTextBoxColumn2";
            this.gUIDDataGridViewTextBoxColumn2.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.Visible = false;
            // 
            // pnlNote
            // 
            this.pnlNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlNote.Controls.Add(this.btnNoteCancel);
            this.pnlNote.Controls.Add(this.btnNoteConfirm);
            this.pnlNote.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNote.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlNote.Location = new System.Drawing.Point(3, 330);
            this.pnlNote.Name = "pnlNote";
            this.pnlNote.Size = new System.Drawing.Size(988, 33);
            this.pnlNote.TabIndex = 95;
            // 
            // btnNoteCancel
            // 
            this.btnNoteCancel.Location = new System.Drawing.Point(906, 3);
            this.btnNoteCancel.Name = "btnNoteCancel";
            this.btnNoteCancel.Size = new System.Drawing.Size(75, 23);
            this.btnNoteCancel.TabIndex = 87;
            this.btnNoteCancel.Text = "取消";
            this.btnNoteCancel.UseVisualStyleBackColor = true;
            this.btnNoteCancel.Click += new System.EventHandler(this.btnNoteCancel_Click);
            // 
            // tabTundishTemp
            // 
            this.tabTundishTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTundishTemp.Controls.Add(this.dataGridView1);
            this.tabTundishTemp.Controls.Add(this.bindingNavigator2);
            this.tabTundishTemp.Location = new System.Drawing.Point(4, 22);
            this.tabTundishTemp.Name = "tabTundishTemp";
            this.tabTundishTemp.Size = new System.Drawing.Size(996, 368);
            this.tabTundishTemp.TabIndex = 15;
            this.tabTundishTemp.Text = "中包温度";
            this.tabTundishTemp.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn8,
            this.cCMIDDataGridViewTextBoxColumn,
            this.tempIDDataGridViewTextBoxColumn,
            this.tempDataGridViewTextBoxColumn1,
            this.measureTimeDataGridViewTextBoxColumn1,
            this.inValidFlagDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsTundishTemp;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(994, 341);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // heatIDDataGridViewTextBoxColumn8
            // 
            this.heatIDDataGridViewTextBoxColumn8.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn8.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn8.Name = "heatIDDataGridViewTextBoxColumn8";
            // 
            // cCMIDDataGridViewTextBoxColumn
            // 
            this.cCMIDDataGridViewTextBoxColumn.DataPropertyName = "CCMID";
            this.cCMIDDataGridViewTextBoxColumn.HeaderText = "铸机号";
            this.cCMIDDataGridViewTextBoxColumn.Name = "cCMIDDataGridViewTextBoxColumn";
            // 
            // tempIDDataGridViewTextBoxColumn
            // 
            this.tempIDDataGridViewTextBoxColumn.DataPropertyName = "TempID";
            this.tempIDDataGridViewTextBoxColumn.DataSource = this.dsCCMTempMode;
            this.tempIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.tempIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tempIDDataGridViewTextBoxColumn.HeaderText = "测温模式";
            this.tempIDDataGridViewTextBoxColumn.Name = "tempIDDataGridViewTextBoxColumn";
            this.tempIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tempIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tempIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsCCMTempMode
            // 
            this.dsCCMTempMode.AutoLoad = true;
            this.dsCCMTempMode.AutoSubscribe = false;
            this.dsCCMTempMode.DataSetName = "L3DataSet";
            this.dsCCMTempMode.DeleteMethod = null;
            this.dsCCMTempMode.InsertMethod = null;
            this.dsCCMTempMode.L3DataAdapter = this.Adapter;
            this.dsCCMTempMode.LoadEvent = "Click";
            this.dsCCMTempMode.LoadTrigger = null;
            this.dsCCMTempMode.RefreshValve = 1000;
            this.dsCCMTempMode.SourceCommand = null;
            this.dsCCMTempMode.SourceCondition = "CODE_GROUP = \'CCM_TEMP_MODE\' and code is not null order by code";
            this.dsCCMTempMode.SourceMethod = "";
            this.dsCCMTempMode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCCMTempMode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCCMTempMode.SubscribeTarget = null;
            this.dsCCMTempMode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCCMTempMode});
            this.dsCCMTempMode.UpdateEvent = "Click";
            this.dsCCMTempMode.UpdateMethod = null;
            this.dsCCMTempMode.UpdateTrigger = null;
            // 
            // schemadsCCMTempMode
            // 
            this.schemadsCCMTempMode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCCMTempModeL3DataTableCode_Des,
            this.coldsCCMTempModeL3DataTableCode_Val_Long});
            this.schemadsCCMTempMode.TableName = "L3DataTable";
            // 
            // coldsCCMTempModeL3DataTableCode_Des
            // 
            this.coldsCCMTempModeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCCMTempModeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCCMTempModeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsCCMTempModeL3DataTableCode_Val_Long
            // 
            this.coldsCCMTempModeL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsCCMTempModeL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsCCMTempModeL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsCCMTempModeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // tempDataGridViewTextBoxColumn1
            // 
            this.tempDataGridViewTextBoxColumn1.DataPropertyName = "Temp";
            this.tempDataGridViewTextBoxColumn1.HeaderText = "温度值";
            this.tempDataGridViewTextBoxColumn1.Name = "tempDataGridViewTextBoxColumn1";
            // 
            // measureTimeDataGridViewTextBoxColumn1
            // 
            this.measureTimeDataGridViewTextBoxColumn1.DataPropertyName = "Measure_Time";
            this.measureTimeDataGridViewTextBoxColumn1.HeaderText = "测温时刻";
            this.measureTimeDataGridViewTextBoxColumn1.Name = "measureTimeDataGridViewTextBoxColumn1";
            this.measureTimeDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.measureTimeDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // inValidFlagDataGridViewTextBoxColumn
            // 
            this.inValidFlagDataGridViewTextBoxColumn.DataPropertyName = "InValidFlag";
            this.inValidFlagDataGridViewTextBoxColumn.HeaderText = "是否有效";
            this.inValidFlagDataGridViewTextBoxColumn.Name = "inValidFlagDataGridViewTextBoxColumn";
            // 
            // bsTundishTemp
            // 
            this.bsTundishTemp.DataMember = "L3DataTable";
            this.bsTundishTemp.DataSource = this.dsTundishTemp;
            // 
            // dsTundishTemp
            // 
            this.dsTundishTemp.AutoLoad = true;
            this.dsTundishTemp.AutoSubscribe = false;
            this.dsTundishTemp.DataSetName = "L3DataSet";
            this.dsTundishTemp.DeleteMethod = null;
            this.dsTundishTemp.InsertMethod = null;
            this.dsTundishTemp.L3DataAdapter = null;
            this.dsTundishTemp.LoadEvent = "Click";
            this.dsTundishTemp.LoadTrigger = null;
            this.dsTundishTemp.RefreshValve = 1000;
            this.dsTundishTemp.SourceCommand = null;
            this.dsTundishTemp.SourceCondition = "1=2";
            this.dsTundishTemp.SourceMethod = "";
            this.dsTundishTemp.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTundishTemp.SourceURI = "XGMESLogic\\CCMMag\\CCCM_Heat_TundishTemp";
            this.dsTundishTemp.SubscribeTarget = null;
            this.dsTundishTemp.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTundishTemp});
            this.dsTundishTemp.UpdateEvent = "Click";
            this.dsTundishTemp.UpdateMethod = null;
            this.dsTundishTemp.UpdateTrigger = null;
            // 
            // schemadsTundishTemp
            // 
            this.schemadsTundishTemp.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTundishTempL3DataTableHeatID,
            this.coldsTundishTempL3DataTableCCMID,
            this.coldsTundishTempL3DataTableTempID,
            this.coldsTundishTempL3DataTableTemp,
            this.coldsTundishTempL3DataTableMeasure_Time,
            this.coldsTundishTempL3DataTableInValidFlag});
            this.schemadsTundishTemp.TableName = "L3DataTable";
            // 
            // coldsTundishTempL3DataTableHeatID
            // 
            this.coldsTundishTempL3DataTableHeatID.Caption = "HeatID";
            this.coldsTundishTempL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsTundishTempL3DataTableHeatID.Namespace = "";
            // 
            // coldsTundishTempL3DataTableCCMID
            // 
            this.coldsTundishTempL3DataTableCCMID.Caption = "CCMID";
            this.coldsTundishTempL3DataTableCCMID.ColumnName = "CCMID";
            this.coldsTundishTempL3DataTableCCMID.Namespace = "";
            // 
            // coldsTundishTempL3DataTableTempID
            // 
            this.coldsTundishTempL3DataTableTempID.Caption = "TempID";
            this.coldsTundishTempL3DataTableTempID.ColumnName = "TempID";
            this.coldsTundishTempL3DataTableTempID.DataType = typeof(short);
            this.coldsTundishTempL3DataTableTempID.Namespace = "";
            // 
            // coldsTundishTempL3DataTableTemp
            // 
            this.coldsTundishTempL3DataTableTemp.Caption = "Temp";
            this.coldsTundishTempL3DataTableTemp.ColumnName = "Temp";
            this.coldsTundishTempL3DataTableTemp.DataType = typeof(short);
            this.coldsTundishTempL3DataTableTemp.Namespace = "";
            // 
            // coldsTundishTempL3DataTableMeasure_Time
            // 
            this.coldsTundishTempL3DataTableMeasure_Time.Caption = "Measure_Time";
            this.coldsTundishTempL3DataTableMeasure_Time.ColumnName = "Measure_Time";
            this.coldsTundishTempL3DataTableMeasure_Time.DataType = typeof(System.DateTime);
            this.coldsTundishTempL3DataTableMeasure_Time.Namespace = "";
            // 
            // coldsTundishTempL3DataTableInValidFlag
            // 
            this.coldsTundishTempL3DataTableInValidFlag.Caption = "InValidFlag";
            this.coldsTundishTempL3DataTableInValidFlag.ColumnName = "InValidFlag";
            this.coldsTundishTempL3DataTableInValidFlag.DataType = typeof(int);
            this.coldsTundishTempL3DataTableInValidFlag.Namespace = "";
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator2.BindingSource = this.bsTundishTemp;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator2.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator2.Size = new System.Drawing.Size(994, 25);
            this.bindingNavigator2.TabIndex = 0;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // panl
            // 
            this.panl.BackColor = System.Drawing.Color.SteelBlue;
            this.panl.Controls.Add(this.tbxTreatNo);
            this.panl.Controls.Add(this.label8);
            this.panl.Controls.Add(this.tbxHeatID);
            this.panl.Controls.Add(this.label6);
            this.panl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panl.Location = new System.Drawing.Point(0, 0);
            this.panl.Margin = new System.Windows.Forms.Padding(0);
            this.panl.Name = "panl";
            this.panl.Size = new System.Drawing.Size(1004, 29);
            this.panl.TabIndex = 92;
            // 
            // tbxTreatNo
            // 
            //
            this.tbxTreatNo.EnableNull = true;
            this.tbxTreatNo.ErropPr = null;
            //
            this.tbxTreatNo.Length = 0;
            this.tbxTreatNo.Location = new System.Drawing.Point(68, 5);
            this.tbxTreatNo.Max = 0;
            //
            //
            this.tbxTreatNo.MaxStrLength = 0;
            this.tbxTreatNo.Min = 0;
            //
            //
            this.tbxTreatNo.MinStrLength = 0;
            this.tbxTreatNo.Name = "tbxTreatNo";
            this.tbxTreatNo.Precision = 0;
            this.tbxTreatNo.ReadOnly = true;
            //
            this.tbxTreatNo.Size = new System.Drawing.Size(106, 21);
            this.tbxTreatNo.TabIndex = 76;
            this.tbxTreatNo.ToolTipValid = null;
          //
            this.tbxTreatNo.ValidEable = true;
            this.tbxTreatNo.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(11, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 12);
            this.label8.TabIndex = 75;
            this.label8.Text = "处理号:";
            // 
            // tbxHeatID
            // 
            //
            this.tbxHeatID.EnableNull = true;
            this.tbxHeatID.ErropPr = null;
            //
            this.tbxHeatID.Length = 0;
            this.tbxHeatID.Location = new System.Drawing.Point(241, 5);
            this.tbxHeatID.Max = 0;
            //
            //
            this.tbxHeatID.MaxStrLength = 0;
            this.tbxHeatID.Min = 0;
            //
            //
            this.tbxHeatID.MinStrLength = 0;
            this.tbxHeatID.Name = "tbxHeatID";
            this.tbxHeatID.Precision = 0;
            this.tbxHeatID.ReadOnly = true;
            //
            this.tbxHeatID.Size = new System.Drawing.Size(106, 21);
            this.tbxHeatID.TabIndex = 74;
            this.tbxHeatID.ToolTipValid = null;
          //
            this.tbxHeatID.ValidEable = true;
            this.tbxHeatID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(197, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 12);
            this.label6.TabIndex = 73;
            this.label6.Text = "炉号:";
            // 
            // dsError
            // 
            this.dsError.AutoLoad = true;
            this.dsError.AutoSubscribe = false;
            this.dsError.DataSetName = "L3DataSet";
            this.dsError.DeleteMethod = null;
            this.dsError.InsertMethod = null;
            this.dsError.L3DataAdapter = this.Adapter;
            this.dsError.LoadEvent = "Click";
            this.dsError.LoadTrigger = null;
            this.dsError.RefreshValve = 1000;
            this.dsError.SourceCommand = null;
            this.dsError.SourceCondition = "OWNER = \'UnitMag\'";
            this.dsError.SourceMethod = "";
            this.dsError.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsError.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Error_Code";
            this.dsError.SubscribeTarget = null;
            this.dsError.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsError});
            this.dsError.UpdateEvent = "Click";
            this.dsError.UpdateMethod = null;
            this.dsError.UpdateTrigger = null;
            // 
            // schemadsError
            // 
            this.schemadsError.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsErrorL3DataTableGUID,
            this.coldsErrorL3DataTableName,
            this.coldsErrorL3DataTableError_Code,
            this.coldsErrorL3DataTableError_Des,
            this.coldsErrorL3DataTableOwner,
            this.coldsErrorL3DataTableOwner_Des,
            this.coldsErrorL3DataTableError_Val_Long});
            this.schemadsError.TableName = "L3DataTable";
            // 
            // coldsErrorL3DataTableGUID
            // 
            this.coldsErrorL3DataTableGUID.Caption = "GUID";
            this.coldsErrorL3DataTableGUID.ColumnName = "GUID";
            this.coldsErrorL3DataTableGUID.Namespace = "";
            // 
            // coldsErrorL3DataTableName
            // 
            this.coldsErrorL3DataTableName.Caption = "Name";
            this.coldsErrorL3DataTableName.ColumnName = "Name";
            this.coldsErrorL3DataTableName.Namespace = "";
            // 
            // coldsErrorL3DataTableError_Code
            // 
            this.coldsErrorL3DataTableError_Code.Caption = "Error_Code";
            this.coldsErrorL3DataTableError_Code.ColumnName = "Error_Code";
            this.coldsErrorL3DataTableError_Code.Namespace = "";
            // 
            // coldsErrorL3DataTableError_Des
            // 
            this.coldsErrorL3DataTableError_Des.Caption = "Error_Des";
            this.coldsErrorL3DataTableError_Des.ColumnName = "Error_Des";
            this.coldsErrorL3DataTableError_Des.Namespace = "";
            // 
            // coldsErrorL3DataTableOwner
            // 
            this.coldsErrorL3DataTableOwner.Caption = "Owner";
            this.coldsErrorL3DataTableOwner.ColumnName = "Owner";
            this.coldsErrorL3DataTableOwner.Namespace = "";
            // 
            // coldsErrorL3DataTableOwner_Des
            // 
            this.coldsErrorL3DataTableOwner_Des.Caption = "Owner_Des";
            this.coldsErrorL3DataTableOwner_Des.ColumnName = "Owner_Des";
            this.coldsErrorL3DataTableOwner_Des.Namespace = "";
            // 
            // coldsErrorL3DataTableError_Val_Long
            // 
            this.coldsErrorL3DataTableError_Val_Long.Caption = "Error_Val_Long";
            this.coldsErrorL3DataTableError_Val_Long.ColumnName = "Error_Val_Long";
            this.coldsErrorL3DataTableError_Val_Long.Namespace = "";
            // 
            // cmdHeatExcept
            // 
            this.cmdHeatExcept.Adapter = this.Adapter;
            this.cmdHeatExcept.MergeReturnTarget = false;
            this.cmdHeatExcept.Method = "NewHeatExceptionData";
            this.cmdHeatExcept.Object = "XGMESLogic\\QualityMag\\CQA_HeatChemicalData_Mag\\QA_HeatChemicalData_Mag";
            this.cmdHeatExcept.Parameters.Add(this.l3cmdpHeatID);
            this.cmdHeatExcept.ReturnTarget = null;
            this.cmdHeatExcept.ReturnTargetProperty = null;
            this.cmdHeatExcept.Trigger = null;
            this.cmdHeatExcept.TriggerEvent = "Click";
            // 
            // l3cmdpHeatID
            // 
            this.l3cmdpHeatID.AcceptAfterExecuted = false;
            this.l3cmdpHeatID.ConstantValue = null;
            this.l3cmdpHeatID.MergeTarget = false;
            this.l3cmdpHeatID.SourceFilter = null;
            this.l3cmdpHeatID.SourceObject = null;
            this.l3cmdpHeatID.SourceProperty = null;
            this.l3cmdpHeatID.TargetObject = null;
            this.l3cmdpHeatID.TargetProperty = null;
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = null;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // cmdTotalTime
            // 
            this.cmdTotalTime.Adapter = this.Adapter;
            this.cmdTotalTime.MergeReturnTarget = false;
            this.cmdTotalTime.Method = "LastVacTubeAesSoaTotalLenOfHeatID";
            this.cmdTotalTime.Object = "XGMESLogic\\VacTubeMag\\CVacTube_Mag\\VacTubeMag";
            this.cmdTotalTime.Parameters.Add(this.l3CommandParameter3);
            this.cmdTotalTime.ReturnTarget = null;
            this.cmdTotalTime.ReturnTargetProperty = null;
            this.cmdTotalTime.Trigger = null;
            this.cmdTotalTime.TriggerEvent = "Click";
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = null;
            this.l3CommandParameter3.SourceObject = null;
            this.l3CommandParameter3.SourceProperty = null;
            this.l3CommandParameter3.TargetObject = null;
            this.l3CommandParameter3.TargetProperty = null;
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = null;
            this.l3CommandParameter2.SourceProperty = null;
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // dsWholePumpTime
            // 
            this.dsWholePumpTime.AutoLoad = true;
            this.dsWholePumpTime.AutoSubscribe = false;
            this.dsWholePumpTime.DataSetName = "L3DataSet";
            this.dsWholePumpTime.DeleteMethod = null;
            this.dsWholePumpTime.InsertMethod = null;
            this.dsWholePumpTime.L3DataAdapter = null;
            this.dsWholePumpTime.LoadEvent = "Click";
            this.dsWholePumpTime.LoadTrigger = null;
            this.dsWholePumpTime.RefreshValve = 1000;
            this.dsWholePumpTime.SourceCommand = null;
            this.dsWholePumpTime.SourceCondition = null;
            this.dsWholePumpTime.SourceMethod = "";
            this.dsWholePumpTime.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWholePumpTime.SourceURI = "XGMESLogic\\RHMag\\CRH_Process_Data";
            this.dsWholePumpTime.SubscribeTarget = null;
            this.dsWholePumpTime.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWholePumpTime});
            this.dsWholePumpTime.UpdateEvent = "Click";
            this.dsWholePumpTime.UpdateMethod = null;
            this.dsWholePumpTime.UpdateTrigger = null;
            // 
            // schemadsWholePumpTime
            // 
            this.schemadsWholePumpTime.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWholePumpTimeL3DataTableTreatNo,
            this.coldsWholePumpTimeL3DataTableHeatID,
            this.coldsWholePumpTimeL3DataTableWholePump_Time});
            this.schemadsWholePumpTime.TableName = "L3DataTable";
            // 
            // coldsWholePumpTimeL3DataTableTreatNo
            // 
            this.coldsWholePumpTimeL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsWholePumpTimeL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsWholePumpTimeL3DataTableTreatNo.Namespace = "";
            // 
            // coldsWholePumpTimeL3DataTableHeatID
            // 
            this.coldsWholePumpTimeL3DataTableHeatID.Caption = "HeatID";
            this.coldsWholePumpTimeL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsWholePumpTimeL3DataTableHeatID.Namespace = "";
            // 
            // coldsWholePumpTimeL3DataTableWholePump_Time
            // 
            this.coldsWholePumpTimeL3DataTableWholePump_Time.Caption = "WholePump_Time";
            this.coldsWholePumpTimeL3DataTableWholePump_Time.ColumnName = "WholePump_Time";
            this.coldsWholePumpTimeL3DataTableWholePump_Time.DataType = typeof(int);
            this.coldsWholePumpTimeL3DataTableWholePump_Time.Namespace = "";
            // 
            // bsWholePumpTime
            // 
            this.bsWholePumpTime.DataMember = "L3DataTable";
            this.bsWholePumpTime.DataSource = this.dsWholePumpTime;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(61, 227);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(83, 12);
            this.label36.TabIndex = 185;
            this.label36.Text = "全泵投用时间:";
            // 
            // txtWholePumpTimeDis
            // 
            //
            this.txtWholePumpTimeDis.EnableNull = false;
            this.txtWholePumpTimeDis.ErropPr = null;
            //this.txtWholePumpTimeDis.FixedLength = null;
            this.txtWholePumpTimeDis.Length = 0;
            this.txtWholePumpTimeDis.Location = new System.Drawing.Point(154, 224);
            this.txtWholePumpTimeDis.Max = 0;
            //this.txtWholePumpTimeDis.MaxNull = null;
            //this.txtWholePumpTimeDis.MaxStringLength = null;
            this.txtWholePumpTimeDis.MaxStrLength = 0;
            this.txtWholePumpTimeDis.Min = 0;
            //this.txtWholePumpTimeDis.MinNull = null;
            //this.txtWholePumpTimeDis.MinStringLength = null;
            this.txtWholePumpTimeDis.MinStrLength = 0;
            this.txtWholePumpTimeDis.Name = "txtWholePumpTimeDis";
            this.txtWholePumpTimeDis.Precision = 0;
            this.txtWholePumpTimeDis.ReadOnly = true;
            //
            this.txtWholePumpTimeDis.Size = new System.Drawing.Size(144, 21);
            this.txtWholePumpTimeDis.TabIndex = 186;
            this.txtWholePumpTimeDis.ToolTipValid = null;
          //
            this.txtWholePumpTimeDis.ValidEable = false;
            this.txtWholePumpTimeDis.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtWholePumpTime
            // 
            this.txtWholePumpTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsWholePumpTime, "WholePump_Time", true));
            //
            this.txtWholePumpTime.EnableNull = true;
            this.txtWholePumpTime.ErropPr = null;
            //
            this.txtWholePumpTime.Length = 0;
            this.txtWholePumpTime.Location = new System.Drawing.Point(236, 224);
            this.txtWholePumpTime.Max = 0;
            //this.txtWholePumpTime.MaxNull = null;
            //
            this.txtWholePumpTime.MaxStrLength = 0;
            this.txtWholePumpTime.Min = 0;
            //this.txtWholePumpTime.MinNull = null;
            //
            this.txtWholePumpTime.MinStrLength = 0;
            this.txtWholePumpTime.Name = "txtWholePumpTime";
            this.txtWholePumpTime.Precision = 0;
            //
            this.txtWholePumpTime.Size = new System.Drawing.Size(30, 21);
            this.txtWholePumpTime.TabIndex = 187;
            this.txtWholePumpTime.ToolTipValid = null;
          //
            this.txtWholePumpTime.ValidEable = true;
            this.txtWholePumpTime.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            this.txtWholePumpTime.TextChanged += new System.EventHandler(this.txtWholePumpTime_TextChanged);
            // 
            // RHHeatInfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 423);
            this.Controls.Add(this.hmiRootPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RHHeatInfoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RH炉次数据";
            this.Load += new System.EventHandler(this.RHHeatInfoFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnRemark)).EndInit();
            this.bnRemark.ResumeLayout(false);
            this.bnRemark.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChemical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsChemical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOxygen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOxygen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOxygen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMat)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            this.tabCtrlMain.ResumeLayout(false);
            this.tabBase.ResumeLayout(false);
            this.tabBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            this.pnlBase.ResumeLayout(false);
            this.tabLFAddMat.ResumeLayout(false);
            this.hmiRootPanel2.ResumeLayout(false);
            this.hmiRootPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMat_Alloy_Add_Man)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMat_Alloy_Add_Man)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMat_Alloy_Add_Man)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdditionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAdditionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnAddMat)).EndInit();
            this.bnAddMat.ResumeLayout(false);
            this.bnAddMat.PerformLayout();
            this.pnlMat.ResumeLayout(false);
            this.tabWire.ResumeLayout(false);
            this.hmiRootPanel3.ResumeLayout(false);
            this.hmiRootPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsWire_Add_man)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWire_Add_man)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWire_Add_man)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvWire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWireCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWireCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWire)).EndInit();
            this.pnlWire.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tabProcess.ResumeLayout(false);
            this.tabProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsYesNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsYesNo)).EndInit();
            this.pnlProcess.ResumeLayout(false);
            this.tabLadleInfo.ResumeLayout(false);
            this.tabLadleInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLadleInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleInfo)).EndInit();
            this.pnlLadleInfo.ResumeLayout(false);
            this.tabExcept.ResumeLayout(false);
            this.tabExcept.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvExcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExceptCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsExceptCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsExcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsExcept)).EndInit();
            this.fLPExcept.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdExcept)).EndInit();
            this.bdExcept.ResumeLayout(false);
            this.bdExcept.PerformLayout();
            this.tabChemical.ResumeLayout(false);
            this.tabChemical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvChemical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataLogMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDataLogMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsChemical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnChemical)).EndInit();
            this.bnChemical.ResumeLayout(false);
            this.bnChemical.PerformLayout();
            this.pnlChemical.ResumeLayout(false);
            this.tabStatus.ResumeLayout(false);
            this.tabStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRHStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRHStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnStatus)).EndInit();
            this.bnStatus.ResumeLayout(false);
            this.bnStatus.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.tabTemp.ResumeLayout(false);
            this.hmiRootPanel6.ResumeLayout(false);
            this.hmiRootPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFTempMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFTempMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnTemp)).EndInit();
            this.bnTemp.ResumeLayout(false);
            this.bnTemp.PerformLayout();
            this.pnlTemp.ResumeLayout(false);
            this.tabOxygen.ResumeLayout(false);
            this.tabOxygen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvOxygen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnOxygen)).EndInit();
            this.bnOxygen.ResumeLayout(false);
            this.bnOxygen.PerformLayout();
            this.pnlOxygen.ResumeLayout(false);
            this.tabRemark.ResumeLayout(false);
            this.tabRemark.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRemarkType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRemarkType)).EndInit();
            this.pnlNote.ResumeLayout(false);
            this.tabTundishTemp.ResumeLayout(false);
            this.tabTundishTemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCCMTempMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCCMTempMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTundishTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundishTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.panl.ResumeLayout(false);
            this.panl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWholePumpTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWholePumpTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWholePumpTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsTemp;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsStatus;
        private System.Windows.Forms.BindingSource bsChemical;
        private System.Windows.Forms.BindingSource bsProcess;
        private AppSvrHMI.L3DataSet dsProcess;
        private System.Data.DataTable schemadsProcess;
        private System.Data.DataColumn coldsProcessL3DataTableGUID;
        private System.Data.DataColumn coldsProcessL3DataTableName;
        private System.Data.DataColumn coldsProcessL3DataTableLogDate;
        private System.Data.DataColumn coldsProcessL3DataTableMaterialType;
        private System.Data.DataColumn coldsProcessL3DataTableMaterialID;
        private System.Data.DataColumn coldsProcessL3DataTableAmount;
        private System.Data.DataColumn coldsProcessL3DataTableTargetArea;
        private System.Data.DataColumn coldsProcessL3DataTableOperator;
        private System.Data.DataColumn coldsProcessL3DataTableShift;
        private System.Data.DataColumn coldsProcessL3DataTableTeam;
        private System.Data.DataColumn coldsProcessL3DataTableTreatNo;
        private System.Data.DataColumn coldsProcessL3DataTableHeatID;
        private System.Data.DataColumn coldsProcessL3DataTableArrival_Time;
        private System.Data.DataColumn coldsProcessL3DataTableArrival_Temp;
        private System.Data.DataColumn coldsProcessL3DataTableStart_Time;
        private System.Data.DataColumn coldsProcessL3DataTableEnd_Time;
        private System.Data.DataColumn coldsProcessL3DataTableProcess_Time;
        private System.Data.DataColumn coldsProcessL3DataTableProbe_Vonder;
        private System.Data.DataColumn coldsProcessL3DataTableDeparture_Temp;
        private System.Data.DataColumn coldsProcessL3DataTableSoftBlow_StartTime;
        private System.Data.DataColumn coldsProcessL3DataTableSoftBlow_EndTime;
        private System.Data.DataColumn coldsProcessL3DataTableSoftBlow_Time;
        private System.Data.DataColumn coldsRemarkL3DataTableHeatID;
        private System.Data.DataColumn coldsRemarkL3DataTableType;
        private System.Data.DataColumn coldsRemarkL3DataTableName;
        private System.Data.DataColumn coldsRemarkL3DataTableTreatNo;
        private System.Data.DataColumn coldsRemarkL3DataTableRemark;
        private System.Data.DataColumn coldsRemarkL3DataTableLogTime;
        private System.Windows.Forms.BindingSource bsRemark;
        private AppSvrHMI.L3DataSet dsRemark;
        private System.Data.DataTable schemadsRemark;
        private System.Data.DataColumn coldsRemarkL3DataTableGUID;
        private System.Data.DataColumn coldsTempL3DataTableGUID;
        private System.Data.DataColumn coldsTempL3DataTableName;
        private System.Data.DataColumn coldsOxygenL3DataTableGUID;
        private System.Data.DataColumn coldsNoteL3DataTableName;
        private System.Data.DataTable schemadsNote;
        private System.Data.DataColumn coldsOxygenL3DataTableName;
        private System.Data.DataColumn coldsNoteL3DataTableGUID;
        private System.Windows.Forms.BindingSource bsBase;
        private AppSvrHMI.L3DataSet dsBase;
        private System.Data.DataTable schemadsBase;
        private System.Data.DataColumn coldsBaseL3DataTableTreatNo;
        private System.Data.DataColumn coldsBaseL3DataTableHeatID;
        private System.Data.DataColumn coldsBaseL3DataTablePreHeatID;
        private System.Data.DataColumn coldsBaseL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsBaseL3DataTableSteelGrade;
        private System.Data.DataColumn coldsBaseL3DataTableLadleNo;
        private System.Data.DataColumn coldsBaseL3DataTableAssistant;
        private System.Data.DataColumn coldsBaseL3DataTableSecondHand;
        private System.Data.DataColumn coldsBaseL3DataTableProductionDate;
        private System.Data.DataColumn coldsBaseL3DataTableLocked;
        private System.Data.DataColumn coldsBaseL3DataTableShift;
        private System.Data.DataColumn coldsBaseL3DataTableTeam;
        private System.Data.DataColumn coldsBaseL3DataTableGUID;
        private System.Data.DataColumn coldsBaseL3DataTableName;
        private AppSvrHMI.L3DataSet dsChemical;
        private System.Windows.Forms.BindingSource bsOxygen;
        private AppSvrHMI.L3DataSet dsOxygen;
        private System.Data.DataTable schemadsOxygen;
        private System.Data.DataColumn coldsOxygenL3DataTableTreatNo;
        private System.Data.DataColumn coldsOxygenL3DataTableHeatID;
        private System.Data.DataColumn coldsOxygenL3DataTableOxygen_Content;
        private System.Windows.Forms.BindingSource bsMat;
        private AppSvrHMI.L3DataSet dsMat;
        private System.Data.DataTable schemadsMat;
        private System.Data.DataColumn coldsMatL3DataTableGUID;
        private System.Data.DataColumn coldsMatL3DataTableName;
        private System.Data.DataColumn coldsMatL3DataTableTreatNo;
        private System.Data.DataColumn coldsMatL3DataTableHeatID;
        private System.Data.DataColumn coldsMatL3DataTableElement;
        private System.Data.DataColumn coldsMatL3DataTableWeight;
        private System.Data.DataColumn coldsMatL3DataTableDischarge_Time;
        private System.Data.DataColumn coldsMatL3DataTableType;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.Panel panl;
        private PxDataValid.PxTextBox tbxTreatNo;
        private System.Windows.Forms.Label label8;
        private PxDataValid.PxTextBox tbxHeatID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabCtrlMain;
        private System.Windows.Forms.TabPage tabBase;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.Label label10;
        private PxDataValid.PxTextBox tbxSecondHand;
        private System.Windows.Forms.Label label9;
        private PxDataValid.PxTextBox tbxAssistant;
        private System.Windows.Forms.Label label7;
        private PxDataValid.PxTextBox tbxHeadFurnace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private PxDataValid.PxTextBox tbxSteelGradeIndex;
        private System.Windows.Forms.Label label2;
        private PxDataValid.PxTextBox tbxPreHeatID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnlBase;
        private System.Windows.Forms.Button btnBaseCancel;
        private System.Windows.Forms.Button btnBaseOK;
        private System.Windows.Forms.TabPage tabLFAddMat;
        private HMIBase.HMIRootPanel hmiRootPanel2;
        private System.Windows.Forms.BindingNavigator bnAddMat;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnAddMat;
        private System.Windows.Forms.FlowLayoutPanel pnlMat;
        private System.Windows.Forms.Button btnMatCancel;
        private System.Windows.Forms.Button btnMatOK;
        private System.Windows.Forms.TabPage tabProcess;
        private System.Windows.Forms.DateTimePicker dtSoftBlowStopTime;
        private System.Windows.Forms.Label label11;
        private PxDataValid.PxTextBox txtOBCount;
        private System.Windows.Forms.Label label43;
        private PxDataValid.PxTextBox txtVacMin;
        private System.Windows.Forms.Label label44;
        private PxDataValid.PxTextBox txtLoopTime;
        private System.Windows.Forms.Label label40;
        private PxDataValid.PxTextBox txtProbeVonder;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.DateTimePicker dtSoftBlowStartTime;
        private System.Windows.Forms.DateTimePicker dtEndTime;
        private System.Windows.Forms.DateTimePicker dtStartTime;
        private System.Windows.Forms.DateTimePicker dtArrivalTime;
        private PxDataValid.PxTextBox txtProcessTime;
        private System.Windows.Forms.Label label23;
        private PxDataValid.PxTextBox txtSlotNo;
        private System.Windows.Forms.Label label24;
        private PxDataValid.PxTextBox txtSlagThick;
        private System.Windows.Forms.Label label25;
        private PxDataValid.PxTextBox txtDepartureTemp;
        private System.Windows.Forms.Label label26;
        private PxDataValid.PxTextBox txtProcessMode;
        private System.Windows.Forms.Label label27;
        private PxDataValid.PxTextBox txtProcessLocation;
        private System.Windows.Forms.Label label28;
        private PxDataValid.PxTextBox txtArrivalTemp;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.FlowLayoutPanel pnlProcess;
        private System.Windows.Forms.Button btnProcessCancel;
        private System.Windows.Forms.Button btnPaocessOK;
        private System.Windows.Forms.TabPage tabChemical;
        private System.Windows.Forms.BindingNavigator bnChemical;
        private System.Windows.Forms.ToolStripButton btnAddChemical;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton toolStripButton27;
        private System.Windows.Forms.ToolStripButton toolStripButton28;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripButton toolStripButton29;
        private System.Windows.Forms.ToolStripButton toolStripButton30;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
        private System.Windows.Forms.FlowLayoutPanel pnlChemical;
        private System.Windows.Forms.Button btnChemicalCancel;
        private System.Windows.Forms.Button btnChemicalOK;
        private System.Windows.Forms.TabPage tabStatus;
        private System.Windows.Forms.DataGridView dvStatus;
        private System.Windows.Forms.BindingNavigator bnStatus;
        private System.Windows.Forms.ToolStripButton btnAddStatus;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton toolStripButton22;
        private System.Windows.Forms.ToolStripButton toolStripButton23;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton toolStripButton24;
        private System.Windows.Forms.ToolStripButton toolStripButton25;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.FlowLayoutPanel pnlStatus;
        private System.Windows.Forms.Button btnStatusCancel;
        private System.Windows.Forms.Button btnStatusOK;
        private System.Windows.Forms.TabPage tabTemp;
        private HMIBase.HMIRootPanel hmiRootPanel6;
        private System.Windows.Forms.DataGridView dvTemp;
        private System.Windows.Forms.BindingNavigator bnTemp;
        private System.Windows.Forms.ToolStripButton btnAddTemp;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton17;
        private System.Windows.Forms.ToolStripButton toolStripButton18;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton toolStripButton19;
        private System.Windows.Forms.ToolStripButton toolStripButton20;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.FlowLayoutPanel pnlTemp;
        private System.Windows.Forms.Button btnTempCancel;
        private System.Windows.Forms.Button btnTempOK;
        private System.Windows.Forms.TabPage tabOxygen;
        private System.Windows.Forms.DataGridView dvOxygen;
        private System.Windows.Forms.BindingNavigator bnOxygen;
        private System.Windows.Forms.ToolStripButton btnAddOxygen;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.FlowLayoutPanel pnlOxygen;
        private System.Windows.Forms.Button btnOxygenCancel;
        private System.Windows.Forms.Button btnOxygenOK;
        private System.Windows.Forms.TabPage tabRemark;
        private System.Windows.Forms.DataGridView dvRemark;
        private System.Windows.Forms.BindingNavigator bnRemark;
        private System.Windows.Forms.ToolStripButton btnAddRemark;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.FlowLayoutPanel pnlNote;
        private System.Windows.Forms.Button btnNoteCancel;
        private System.Data.DataColumn coldsProcessL3DataTableArrival_Temp_Quality;
        private System.Data.DataColumn coldsProcessL3DataTableSlag_Thick;
        private System.Data.DataColumn coldsProcessL3DataTableProcess_Location;
        private System.Data.DataColumn coldsProcessL3DataTableSlot_No;
        private System.Data.DataColumn coldsProcessL3DataTableProcess_Mode;
        private System.Data.DataColumn coldsProcessL3DataTableLoop_Time;
        private System.Data.DataColumn coldsProcessL3DataTableVac_Min;
        private System.Data.DataColumn coldsProcessL3DataTableOB_Count;
        private System.Data.DataColumn coldsProcessL3DataTableO2_CONS;
        private System.Data.DataColumn coldsProcessL3DataTableAl_CONS;
        private System.Data.DataColumn coldsProcessL3DataTableOB_Cycle_Time;
        private System.Data.DataColumn coldsProcessL3DataTableWire_End_Time;
        private System.Data.DataColumn coldsProcessL3DataTableWire_End_Temp;
        private System.Data.DataColumn coldsProcessL3DataTableCircsOfRhythm;
        private System.Data.DataTable schemadsChemical;
        private System.Data.DataColumn coldsChemicalL3DataTableGUID;
        private System.Data.DataColumn coldsChemicalL3DataTableName;
        private System.Data.DataColumn coldsChemicalL3DataTableHeatID;
        private System.Data.DataColumn coldsChemicalL3DataTableAppID;
        private System.Data.DataColumn coldsChemicalL3DataTableSample_Code;
        private System.Data.DataColumn coldsChemicalL3DataTableArrive_Date;
        private System.Data.DataColumn coldsChemicalL3DataTableReport_Date;
        private System.Data.DataColumn coldsChemicalL3DataTableUnitTypeID;
        private System.Data.DataColumn coldsChemicalL3DataTableUnitID;
        private System.Data.DataColumn coldsChemicalL3DataTableSample_Address;
        private System.Data.DataColumn coldsChemicalL3DataTableSample_Type;
        private System.Data.DataColumn coldsChemicalL3DataTableSample_Count;
        private System.Data.DataColumn coldsChemicalL3DataTableC;
        private System.Data.DataColumn coldsChemicalL3DataTableSi;
        private System.Data.DataColumn coldsChemicalL3DataTableMn;
        private System.Data.DataColumn coldsChemicalL3DataTableP;
        private System.Data.DataColumn coldsChemicalL3DataTableS;
        private System.Data.DataColumn coldsChemicalL3DataTableCu;
        private System.Data.DataColumn coldsChemicalL3DataTableNi;
        private System.Data.DataColumn coldsChemicalL3DataTableCr;
        private System.Data.DataColumn coldsChemicalL3DataTableMo;
        private System.Data.DataColumn coldsChemicalL3DataTableV;
        private System.Data.DataColumn coldsChemicalL3DataTableNb;
        private System.Data.DataColumn coldsChemicalL3DataTableAl;
        private System.Data.DataColumn coldsChemicalL3DataTableAlS;
        private System.Data.DataColumn coldsChemicalL3DataTableTi;
        private System.Data.DataColumn coldsChemicalL3DataTableB;
        private System.Data.DataColumn coldsChemicalL3DataTableSb;
        private System.Data.DataColumn coldsChemicalL3DataTableAs;
        private System.Data.DataColumn coldsChemicalL3DataTableSn;
        private System.Data.DataColumn coldsChemicalL3DataTableZn;
        private System.Data.DataColumn coldsChemicalL3DataTableCa;
        private System.Data.DataColumn coldsChemicalL3DataTableW;
        private System.Data.DataColumn coldsChemicalL3DataTablePb;
        private System.Data.DataColumn coldsChemicalL3DataTableRe;
        private System.Data.DataColumn coldsChemicalL3DataTableCeq;
        private System.Data.DataColumn coldsChemicalL3DataTableN;
        private System.Data.DataColumn coldsChemicalL3DataTableH;
        private System.Data.DataColumn coldsChemicalL3DataTableO;
        private System.Data.DataColumn coldsChemicalL3DataTableOther1;
        private System.Data.DataColumn coldsChemicalL3DataTableOther2;
        private System.Data.DataColumn coldsChemicalL3DataTableLogTime;
        private System.Data.DataColumn coldsChemicalL3DataTableDataLogMode;
        private PxDataValid.PxTextBox txtWireEndTemp;
        private PxDataValid.PxTextBox txtAlCONS;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private PxDataValid.PxTextBox txtOBCycleTime;
        private PxDataValid.PxTextBox txt02CONS;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtWireEndTime;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private PxDataValid.PxTextBox txtSoftBlowTime;
        private AppSvrHMI.L3DataSet dsTemp;
        private System.Data.DataTable schemal3DataSet2;
        private System.Data.DataColumn coll3DataSet2L3DataTableGUID;
        private System.Data.DataColumn coll3DataSet2L3DataTableName;
        private System.Data.DataColumn coll3DataSet2L3DataTableTreatNo;
        private System.Data.DataColumn coll3DataSet2L3DataTableHeatID;
        private System.Data.DataColumn coll3DataSet2L3DataTableTemp;
        private System.Data.DataColumn coll3DataSet2L3DataTableMeasureTime;
        private System.Data.DataColumn coll3DataSet2L3DataTableMeasureMode;
        private System.Windows.Forms.DataGridView dvChemical;
        private AppSvrHMI.L3DataSet dsStatus;
        private System.Data.DataTable schemal3DataSet1;
        private System.Data.DataColumn coll3DataSet1L3DataTableGUID;
        private System.Data.DataColumn coll3DataSet1L3DataTableName;
        private System.Data.DataColumn coll3DataSet1L3DataTableTreatNo;
        private System.Data.DataColumn coll3DataSet1L3DataTableHeatID;
        private System.Data.DataColumn coll3DataSet1L3DataTableStatus;
        private System.Data.DataColumn coll3DataSet1L3DataTableChange_Time;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private PxDataValid.PxComboBox cmbShift;
        private PxDataValid.PxComboBox cmbTeam;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsAdditionType;
        private System.Data.DataTable schemadsAdditionType;
        private System.Data.DataColumn coldsAdditionTypeL3DataTableCode_Des;
        private System.Data.DataColumn coldsAdditionTypeL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsUnitType;
        private System.Data.DataTable schemadsUnitType;
        private System.Data.DataColumn coldsUnitTypeL3DataTableCode_Des;
        private System.Data.DataColumn coldsUnitTypeL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsSampleAddr;
        private System.Data.DataTable schemadsSampleAddr;
        private System.Data.DataColumn coldsSampleAddrL3DataTableCode;
        private System.Data.DataColumn coldsSampleAddrL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsSampleType;
        private System.Data.DataTable schemadsSampleType;
        private System.Data.DataColumn coldsSampleTypeL3DataTableCode;
        private System.Data.DataColumn coldsSampleTypeL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsDataLogMode;
        private System.Data.DataTable schemadsDataLogMode;
        private System.Data.DataColumn coldsDataLogModeL3DataTableCode_Des;
        private System.Data.DataColumn coldsDataLogModeL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsRHStatus;
        private System.Data.DataTable schemadsRHStatus;
        private System.Data.DataColumn coldsRHStatusL3DataTableCode_Des;
        private System.Data.DataColumn coldsRHStatusL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsRemarkType;
        private System.Data.DataTable schemadsRemarkType;
        private System.Data.DataColumn coldsRemarkTypeL3DataTableCode_Des;
        private System.Data.DataColumn coldsRemarkTypeL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsCode;
        private System.Data.DataTable schemadsCode;
        private System.Data.DataColumn coldsCodeL3DataTableCode;
        private System.Data.DataColumn coldsCodeL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsBOFTempMode;
        private System.Data.DataTable schemadsBOFTempMode;
        private System.Data.DataColumn coldsBOFTempModeL3DataTableCode_Des;
        private System.Data.DataColumn coldsBOFTempModeL3DataTableCode_Val_Long;
        private System.Data.DataColumn coldsChemicalL3DataTableCrNi;
        private System.Data.DataColumn coldsChemicalL3DataTableCrCu;
        private System.Data.DataColumn coldsChemicalL3DataTableCrNiCu;
        private System.Data.DataColumn coldsChemicalL3DataTableOther3;
        private System.Windows.Forms.TabPage tabWire;
        private AppSvrHMI.L3DataSet dsWire;
        private HMIBase.HMIRootPanel hmiRootPanel3;
        private System.Windows.Forms.BindingSource bsWire;
        private System.Data.DataTable schemadsWire;
        private System.Data.DataColumn coldsWireL3DataTableGUID;
        private System.Data.DataColumn coldsWireL3DataTableName;
        private System.Data.DataColumn coldsWireL3DataTableTreatNo;
        private System.Data.DataColumn coldsWireL3DataTableHeatID;
        private System.Data.DataColumn coldsWireL3DataTableWireCode;
        private System.Data.DataColumn coldsWireL3DataTableWeight;
        private System.Data.DataColumn coldsWireL3DataTableSpeed;
        private System.Data.DataColumn coldsWireL3DataTableWireTime;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator20;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator21;
        private System.Windows.Forms.ToolStripButton btnWireAdd;
        private System.Windows.Forms.DataGridView dvWire;
        private System.Windows.Forms.FlowLayoutPanel pnlWire;
        private System.Windows.Forms.Button btnWireCancel;
        private System.Windows.Forms.Button btnWireConfirm;
        private System.Data.DataColumn coldsOxygenL3DataTableMeasureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewCheckBoxColumn;
        private DataGridValid.CalendarColumn changeTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatNoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempDataGridViewTextBoxColumn;
        private DataGridValid.CalendarColumn measureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn measureModeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatNoDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn oxygenContentDataGridViewTextBoxColumn;
        private DataGridValid.CalendarColumn MeasureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatNoDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewCheckBoxColumn1;
        private DataGridValid.CalendarColumn logTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.TabPage tabExcept;
        private System.Windows.Forms.BindingNavigator bdExcept;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem7;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator21;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem7;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator22;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem7;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator23;
        private System.Windows.Forms.ToolStripButton btnAddExcept;
        private System.Windows.Forms.ToolStripButton btnDelExcept;
        private System.Windows.Forms.FlowLayoutPanel fLPExcept;
        private System.Windows.Forms.Button btnCancelExcept;
        private System.Windows.Forms.Button btnConfirmExcept;
        private System.Windows.Forms.DataGridView dvExcept;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableGUID;
        private System.Data.DataColumn coldsErrorL3DataTableName;
        private System.Data.DataColumn coldsErrorL3DataTableError_Code;
        private System.Data.DataColumn coldsErrorL3DataTableError_Des;
        private System.Data.DataColumn coldsErrorL3DataTableOwner;
        private System.Data.DataColumn coldsErrorL3DataTableOwner_Des;
        private System.Data.DataColumn coldsErrorL3DataTableError_Val_Long;
        private AppSvrHMI.L3Command cmdHeatExcept;
        private AppSvrHMI.L3DataSet dsExceptCode;
        private System.Data.DataTable schemadsExceptCode;
        private System.Data.DataColumn coldsExceptCodeL3DataTableGUID;
        private System.Data.DataColumn coldsExceptCodeL3DataTableName;
        private System.Data.DataColumn coldsExceptCodeL3DataTableExceptional_Code;
        private System.Data.DataColumn coldsExceptCodeL3DataTableExceptional_Des;
        private System.Data.DataColumn coldsExceptCodeL3DataTableUnit;
        private System.Data.DataColumn coldsExceptCodeL3DataTableAuto_Judge_Flag;
        private System.Windows.Forms.BindingSource bsExcept;
        private AppSvrHMI.L3DataSet dsExcept;
        private System.Data.DataTable schemadsExcept;
        private System.Data.DataColumn coldsExceptL3DataTableGUID;
        private System.Data.DataColumn coldsExceptL3DataTableName;
        private System.Data.DataColumn coldsExceptL3DataTableID_Object;
        private System.Data.DataColumn coldsExceptL3DataTableHeatID;
        private System.Data.DataColumn coldsExceptL3DataTableProcess_Count;
        private System.Data.DataColumn coldsExceptL3DataTableUnitTypeID;
        private System.Data.DataColumn coldsExceptL3DataTableUnitID;
        private System.Data.DataColumn coldsExceptL3DataTablePreHeatID;
        private System.Data.DataColumn coldsExceptL3DataTablePre_SteelGradeIndex;
        private System.Data.DataColumn coldsExceptL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsExceptL3DataTableExceptional_Code;
        private System.Data.DataColumn coldsExceptL3DataTableDecide_Code;
        private System.Data.DataColumn coldsExceptL3DataTableClassify;
        private System.Data.DataColumn coldsExceptL3DataTableExceptional_Time;
        private AppSvrHMI.L3CommandParameter l3cmdpHeatID;
        private AppSvrHMI.L3DataSet dsWireCode;
        private System.Data.DataTable schemadsWireCode;
        private System.Data.DataColumn coldsWireCodeL3DataTableCode;
        private System.Data.DataColumn coldsWireCodeL3DataTableCode_Des;
        private System.Data.DataColumn coldsMatL3DataTableBatch_ID;
        private System.Data.DataColumn coldsMatL3DataTableArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn exceptionalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exceptionalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDObjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitTypeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn preHeatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preSteelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decideCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classifyDataGridViewTextBoxColumn;
        private PxDataValid.PxTextBox txtProcessTimeDis;
        private PxDataValid.PxTextBox txtSoftBlowTimeDis;
        private System.Data.DataColumn coldsWireL3DataTableBatch_ID;
        private System.Data.DataColumn coldsMatL3DataTableEnableFlag;
        private System.Data.DataColumn coldsWireL3DataTableEnableFlag;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Data.DataColumn coldsProcessL3DataTableLadleNo;
        private System.Data.DataColumn coldsProcessL3DataTableLadleGrade;
        private PxDataValid.PxTextBox txtLadleGrade;
        private PxDataValid.PxTextBox txtLadleNo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnNoteConfirm;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbArrivalTempQuality;
        private AppSvrHMI.L3DataSet dsYesNo;
        private System.Data.DataTable schemadsYesNo;
        private System.Data.DataColumn coldsYesNoL3DataTableCode_Des;
        private System.Data.DataColumn coldsYesNoL3DataTableCode_Val_Long;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmb_Mat;
        private AppSvrHMI.L3DataSet dsMat_Alloy_Add_Man;
        private System.Data.DataTable schemadsMat_Alloy_Add_Man;
        private System.Data.DataColumn coldsMat_Alloy_Add_ManL3DataTablebatch_id;
        private System.Data.DataColumn coldsMat_Alloy_Add_ManL3DataTableCode;
        private System.Data.DataColumn coldsMat_Alloy_Add_ManL3DataTableCode_des;
        private System.Windows.Forms.BindingSource bsMat_Alloy_Add_Man;
        private System.Data.DataColumn coldsMat_Alloy_Add_ManL3DataTableAlloy_Code;
        private System.Windows.Forms.ComboBox cmb_Wire;
        private AppSvrHMI.L3DataSet dsWire_Add_man;
        private System.Data.DataTable schemadsWire_Add_man;
        private System.Data.DataColumn coldsWire_Add_manL3DataTablealloy_code;
        private System.Data.DataColumn coldsWire_Add_manL3DataTablebatch_id;
        private System.Data.DataColumn coldsWire_Add_manL3DataTablecode;
        private System.Data.DataColumn coldsWire_Add_manL3DataTablecode_des;
        private System.Windows.Forms.BindingSource bsWire_Add_man;
        private System.Windows.Forms.DataGridView dvMat;
        private System.Data.DataColumn coldsBaseL3DataTableHeatFurnace;
        private System.Data.DataColumn coldsWire_Add_manL3DataTablecode_function_group;
        private System.Data.DataColumn coldsWireL3DataTableAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatNoDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn WireCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch_ID_Wire;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedDataGridViewTextBoxColumn;
        private DataGridValid.CalendarColumn wireTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Wire;
        private System.Windows.Forms.TabPage tabLadleInfo;
        private System.Windows.Forms.FlowLayoutPanel pnlLadleInfo;
        private System.Windows.Forms.Button btnLadleInfoCancel;
        private System.Windows.Forms.Button btnLadleInfoOK;
        private AppSvrHMI.L3DataSet dsLadleInfo;
        private System.Data.DataTable schemadsLadleInfo;
        private System.Data.DataColumn coldsLadleInfoL3DataTableTreatNo;
        private System.Data.DataColumn coldsLadleInfoL3DataTableHeatID;
        private System.Data.DataColumn coldsLadleInfoL3DataTableLadleID;
        private System.Data.DataColumn coldsLadleInfoL3DataTableLast_Ladle_Grade;
        private System.Data.DataColumn coldsLadleInfoL3DataTableTemp;
        private System.Data.DataColumn coldsLadleInfoL3DataTableLast_SteelGrade;
        private System.Data.DataColumn coldsLadleInfoL3DataTableAct_Ladle_Grade;
        private System.Data.DataColumn coldsLadleInfoL3DataTableCur_SteelGrade;
        private System.Data.DataColumn coldsLadleInfoL3DataTableIn_Ladle_Grade;
        private System.Data.DataColumn coldsLadleInfoL3DataTableStop_Time_Len;
        private System.Data.DataColumn coldsLadleInfoL3DataTableLadle_Age;
        private System.Data.DataColumn coldsLadleInfoL3DataTableSmall_Fire;
        private System.Data.DataColumn coldsLadleInfoL3DataTableMiddle_Fire;
        private System.Data.DataColumn coldsLadleInfoL3DataTableBig_Fire;
        private System.Data.DataColumn coldsLadleInfoL3DataTableNote;
        private System.Data.DataColumn coldsLadleInfoL3DataTableOther1;
        private System.Data.DataColumn coldsLadleInfoL3DataTableOther2;
        private System.Data.DataColumn coldsLadleInfoL3DataTableOther3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.BindingSource bsLadleInfo;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn appIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleCodeDataGridViewTextBoxColumn;
        private DataGridValid.CalendarColumn arriveDateDataGridViewTextBoxColumn;
        private DataGridValid.CalendarColumn reportDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn unitTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sampleAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sampleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn niDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn znDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrNi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrNiCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn other1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn other2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Other3;
        private DataGridValid.CalendarColumn logTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataLogModeDataGridViewTextBoxColumn;
        private System.Data.DataColumn coldsLadleInfoL3DataTableMaxTemp;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabPage tabTundishTemp;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.BindingSource bsTundishTemp;
        private AppSvrHMI.L3DataSet dsTundishTemp;
        private System.Data.DataTable schemadsTundishTemp;
        private System.Data.DataColumn coldsTundishTempL3DataTableHeatID;
        private System.Data.DataColumn coldsTundishTempL3DataTableCCMID;
        private System.Data.DataColumn coldsTundishTempL3DataTableTempID;
        private System.Data.DataColumn coldsTundishTempL3DataTableTemp;
        private System.Data.DataColumn coldsTundishTempL3DataTableMeasure_Time;
        private System.Data.DataColumn coldsTundishTempL3DataTableInValidFlag;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AppSvrHMI.L3DataSet dsCCMTempMode;
        private System.Data.DataTable schemadsCCMTempMode;
        private System.Data.DataColumn coldsCCMTempModeL3DataTableCode_Des;
        private System.Data.DataColumn coldsCCMTempModeL3DataTableCode_Val_Long;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tempIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempDataGridViewTextBoxColumn1;
        private DataGridValid.CalendarColumn measureTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inValidFlagDataGridViewTextBoxColumn;
        private PxDataValid.PxTextBox txtTotalTime;
        private System.Windows.Forms.Label label35;
        private AppSvrHMI.L3Command cmdTotalTime;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Element;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private DataGridValid.CalendarColumn dischargeTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch_ID_Mat;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnableFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Mat;
        private AppSvrHMI.L3DataSet dsWholePumpTime;
        private System.Data.DataTable schemadsWholePumpTime;
        private System.Data.DataColumn coldsWholePumpTimeL3DataTableTreatNo;
        private System.Data.DataColumn coldsWholePumpTimeL3DataTableHeatID;
        private System.Data.DataColumn coldsWholePumpTimeL3DataTableWholePump_Time;
        private System.Windows.Forms.BindingSource bsWholePumpTime;
        private PxDataValid.PxTextBox txtWholePumpTime;
        private PxDataValid.PxTextBox txtWholePumpTimeDis;
        private System.Windows.Forms.Label label36;
    }
}