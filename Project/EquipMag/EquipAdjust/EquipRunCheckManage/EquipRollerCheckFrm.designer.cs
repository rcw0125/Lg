﻿namespace EquipMag.EquipAdjust.EquipRunCheckManage
{
    partial class EquipRollerCheckFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipRollerCheckFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsAdjustSet = new System.Windows.Forms.BindingSource(this.components);
            this.dsAdjustSet = new AppSvrHMI.L3DataSet();
            this.schemadsEnergyData = new System.Data.DataTable();
            this.coldsEnergyDataL3DataTableGUID = new System.Data.DataColumn();
            this.coldsEnergyDataL3DataTableName = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableCCMID = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableStrandNo = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableRoller_Std = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableRoller1_Act = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableRoller2_Act = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableRoller3_Act = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableRoller4_Act = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableRoller5_Act = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableRoller6_Act = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableRoller7_Act = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableCheck_Date = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableCreate_Time = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableOperator = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableStatus = new System.Data.DataColumn();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.dvAdjustSet = new System.Windows.Forms.DataGridView();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.dsAdjustStd = new AppSvrHMI.L3DataSet();
            this.schemadsAdjustStd = new System.Data.DataTable();
            this.coldsAdjustStdL3DataTableGUID = new System.Data.DataColumn();
            this.coldsAdjustStdL3DataTableName = new System.Data.DataColumn();
            this.coldsAdjustStdL3DataTableAdjustType = new System.Data.DataColumn();
            this.coldsAdjustStdL3DataTableUnitID = new System.Data.DataColumn();
            this.coldsAdjustStdL3DataTableAdjustObject = new System.Data.DataColumn();
            this.coldsAdjustStdL3DataTableItems = new System.Data.DataColumn();
            this.coldsAdjustStdL3DataTableStandard = new System.Data.DataColumn();
            this.coldsAdjustStdL3DataTableValidFlag = new System.Data.DataColumn();
            this.dsStatus = new AppSvrHMI.L3DataSet();
            this.dsAdjustObject = new AppSvrHMI.L3DataSet();
            this.dsUnitID = new AppSvrHMI.L3DataSet();
            this.schemadsStatus = new System.Data.DataTable();
            this.coldsStatusL3DataTableID = new System.Data.DataColumn();
            this.coldsStatusL3DataTableDesc = new System.Data.DataColumn();
            this.schemadsAdjustObject = new System.Data.DataTable();
            this.coldsAdjustObjectL3DataTableCode = new System.Data.DataColumn();
            this.coldsAdjustObjectL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsAdjustObjectL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsAdjustObjectL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.schemadsUnitID = new System.Data.DataTable();
            this.coldsUnitIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsUnitIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsUnitIDL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsUnitIDL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.cCMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.strandNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rollerStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roller1ActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roller2ActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roller3ActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roller4ActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roller5ActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roller6ActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roller7ActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdjustSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEnergyData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvAdjustSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAdjustStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAdjustObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitID)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.AutoSize = false;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnAdd,
            this.btnDel,
            this.toolStripSeparator2,
            this.btnConfirm,
            this.btnCancel});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1000, 43);
            this.toolStripMain.TabIndex = 15;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 40);
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "btnEquipRollerCheck");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "btnEquipRollerCheck");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "btnEquipRollerCheck");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "btnEquipRollerCheck");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsAdjustSet;
            this.bindingNavigator1.CountItem = this.toolStripLabel4;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripTextBox1,
            this.toolStripLabel4,
            this.toolStripSeparator4,
            this.toolStripButton4,
            this.toolStripButton5,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 43);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton2;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton5;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton4;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton3;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(1000, 25);
            this.bindingNavigator1.TabIndex = 19;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bsAdjustSet
            // 
            this.bsAdjustSet.DataMember = "L3DataTable";
            this.bsAdjustSet.DataSource = this.dsAdjustSet;
            // 
            // dsAdjustSet
            // 
            this.dsAdjustSet.AutoSubscribe = false;
            this.dsAdjustSet.DataSetName = "L3DataSet";
            this.dsAdjustSet.DeleteMethod = "";
            this.dsAdjustSet.InsertMethod = "";
            this.dsAdjustSet.L3DataAdapter = this.Adapter;
            this.dsAdjustSet.LoadEvent = "";
            this.dsAdjustSet.LoadTrigger = null;
            this.dsAdjustSet.RefreshValve = 1000;
            this.dsAdjustSet.SourceCommand = null;
            this.dsAdjustSet.SourceCondition = "CCMID is not null order by CCMID,StrandNo";
            this.dsAdjustSet.SourceMethod = "";
            this.dsAdjustSet.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAdjustSet.SourceURI = "XGMESLogic\\EquipMag\\CEquip_Roller_Log";
            this.dsAdjustSet.SubscribeTarget = null;
            this.dsAdjustSet.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsEnergyData});
            this.dsAdjustSet.UpdateEvent = "";
            this.dsAdjustSet.UpdateMethod = "";
            this.dsAdjustSet.UpdateTrigger = null;
            // 
            // schemadsEnergyData
            // 
            this.schemadsEnergyData.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsEnergyDataL3DataTableGUID,
            this.coldsEnergyDataL3DataTableName,
            this.coldsAdjustSetL3DataTableCCMID,
            this.coldsAdjustSetL3DataTableStrandNo,
            this.coldsAdjustSetL3DataTableRoller_Std,
            this.coldsAdjustSetL3DataTableRoller1_Act,
            this.coldsAdjustSetL3DataTableRoller2_Act,
            this.coldsAdjustSetL3DataTableRoller3_Act,
            this.coldsAdjustSetL3DataTableRoller4_Act,
            this.coldsAdjustSetL3DataTableRoller5_Act,
            this.coldsAdjustSetL3DataTableRoller6_Act,
            this.coldsAdjustSetL3DataTableRoller7_Act,
            this.coldsAdjustSetL3DataTableCheck_Date,
            this.coldsAdjustSetL3DataTableCreate_Time,
            this.coldsAdjustSetL3DataTableOperator,
            this.coldsAdjustSetL3DataTableStatus});
            this.schemadsEnergyData.TableName = "L3DataTable";
            // 
            // coldsEnergyDataL3DataTableGUID
            // 
            this.coldsEnergyDataL3DataTableGUID.Caption = "GUID";
            this.coldsEnergyDataL3DataTableGUID.ColumnName = "GUID";
            this.coldsEnergyDataL3DataTableGUID.Namespace = "";
            // 
            // coldsEnergyDataL3DataTableName
            // 
            this.coldsEnergyDataL3DataTableName.Caption = "Name";
            this.coldsEnergyDataL3DataTableName.ColumnName = "Name";
            this.coldsEnergyDataL3DataTableName.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableCCMID
            // 
            this.coldsAdjustSetL3DataTableCCMID.Caption = "CCMID";
            this.coldsAdjustSetL3DataTableCCMID.ColumnName = "CCMID";
            this.coldsAdjustSetL3DataTableCCMID.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableStrandNo
            // 
            this.coldsAdjustSetL3DataTableStrandNo.Caption = "StrandNo";
            this.coldsAdjustSetL3DataTableStrandNo.ColumnName = "StrandNo";
            this.coldsAdjustSetL3DataTableStrandNo.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableRoller_Std
            // 
            this.coldsAdjustSetL3DataTableRoller_Std.Caption = "Roller_Std";
            this.coldsAdjustSetL3DataTableRoller_Std.ColumnName = "Roller_Std";
            this.coldsAdjustSetL3DataTableRoller_Std.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableRoller1_Act
            // 
            this.coldsAdjustSetL3DataTableRoller1_Act.Caption = "Roller1_Act";
            this.coldsAdjustSetL3DataTableRoller1_Act.ColumnName = "Roller1_Act";
            this.coldsAdjustSetL3DataTableRoller1_Act.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableRoller2_Act
            // 
            this.coldsAdjustSetL3DataTableRoller2_Act.Caption = "Roller2_Act";
            this.coldsAdjustSetL3DataTableRoller2_Act.ColumnName = "Roller2_Act";
            this.coldsAdjustSetL3DataTableRoller2_Act.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableRoller3_Act
            // 
            this.coldsAdjustSetL3DataTableRoller3_Act.Caption = "Roller3_Act";
            this.coldsAdjustSetL3DataTableRoller3_Act.ColumnName = "Roller3_Act";
            this.coldsAdjustSetL3DataTableRoller3_Act.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableRoller4_Act
            // 
            this.coldsAdjustSetL3DataTableRoller4_Act.Caption = "Roller4_Act";
            this.coldsAdjustSetL3DataTableRoller4_Act.ColumnName = "Roller4_Act";
            this.coldsAdjustSetL3DataTableRoller4_Act.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableRoller5_Act
            // 
            this.coldsAdjustSetL3DataTableRoller5_Act.Caption = "Roller5_Act";
            this.coldsAdjustSetL3DataTableRoller5_Act.ColumnName = "Roller5_Act";
            this.coldsAdjustSetL3DataTableRoller5_Act.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableRoller6_Act
            // 
            this.coldsAdjustSetL3DataTableRoller6_Act.Caption = "Roller6_Act";
            this.coldsAdjustSetL3DataTableRoller6_Act.ColumnName = "Roller6_Act";
            this.coldsAdjustSetL3DataTableRoller6_Act.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableRoller7_Act
            // 
            this.coldsAdjustSetL3DataTableRoller7_Act.Caption = "Roller7_Act";
            this.coldsAdjustSetL3DataTableRoller7_Act.ColumnName = "Roller7_Act";
            this.coldsAdjustSetL3DataTableRoller7_Act.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableCheck_Date
            // 
            this.coldsAdjustSetL3DataTableCheck_Date.Caption = "Check_Date";
            this.coldsAdjustSetL3DataTableCheck_Date.ColumnName = "Check_Date";
            this.coldsAdjustSetL3DataTableCheck_Date.DataType = typeof(System.DateTime);
            this.coldsAdjustSetL3DataTableCheck_Date.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableCreate_Time
            // 
            this.coldsAdjustSetL3DataTableCreate_Time.Caption = "Create_Time";
            this.coldsAdjustSetL3DataTableCreate_Time.ColumnName = "Create_Time";
            this.coldsAdjustSetL3DataTableCreate_Time.DataType = typeof(System.DateTime);
            this.coldsAdjustSetL3DataTableCreate_Time.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableOperator
            // 
            this.coldsAdjustSetL3DataTableOperator.Caption = "Operator";
            this.coldsAdjustSetL3DataTableOperator.ColumnName = "Operator";
            this.coldsAdjustSetL3DataTableOperator.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableStatus
            // 
            this.coldsAdjustSetL3DataTableStatus.Caption = "Status";
            this.coldsAdjustSetL3DataTableStatus.ColumnName = "Status";
            this.coldsAdjustSetL3DataTableStatus.DataType = typeof(int);
            this.coldsAdjustSetL3DataTableStatus.Namespace = "";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel4.Text = "/ {0}";
            this.toolStripLabel4.ToolTipText = "总项数";
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // dvAdjustSet
            // 
            this.dvAdjustSet.AllowUserToAddRows = false;
            this.dvAdjustSet.AllowUserToDeleteRows = false;
            this.dvAdjustSet.AllowUserToResizeRows = false;
            this.dvAdjustSet.AutoGenerateColumns = false;
            this.dvAdjustSet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvAdjustSet.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvAdjustSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCMIDDataGridViewTextBoxColumn,
            this.strandNoDataGridViewTextBoxColumn,
            this.rollerStdDataGridViewTextBoxColumn,
            this.roller1ActDataGridViewTextBoxColumn,
            this.roller2ActDataGridViewTextBoxColumn,
            this.roller3ActDataGridViewTextBoxColumn,
            this.roller4ActDataGridViewTextBoxColumn,
            this.roller5ActDataGridViewTextBoxColumn,
            this.roller6ActDataGridViewTextBoxColumn,
            this.roller7ActDataGridViewTextBoxColumn,
            this.checkDateDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dvAdjustSet.DataSource = this.bsAdjustSet;
            this.dvAdjustSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvAdjustSet.Location = new System.Drawing.Point(0, 68);
            this.dvAdjustSet.MultiSelect = false;
            this.dvAdjustSet.Name = "dvAdjustSet";
            this.dvAdjustSet.RowTemplate.Height = 23;
            this.dvAdjustSet.Size = new System.Drawing.Size(1000, 532);
            this.dvAdjustSet.TabIndex = 20;
            this.dvAdjustSet.CurrentCellDirtyStateChanged += new System.EventHandler(this.dvAdjustSet_CurrentCellDirtyStateChanged);
            this.dvAdjustSet.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvAdjustSet_DataError);
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
            // l3CommandParameter4
            // 
            this.l3CommandParameter4.AcceptAfterExecuted = false;
            this.l3CommandParameter4.ConstantValue = null;
            this.l3CommandParameter4.MergeTarget = false;
            this.l3CommandParameter4.SourceFilter = null;
            this.l3CommandParameter4.SourceObject = null;
            this.l3CommandParameter4.SourceProperty = null;
            this.l3CommandParameter4.TargetObject = null;
            this.l3CommandParameter4.TargetProperty = null;
            // 
            // dsAdjustStd
            // 
            this.dsAdjustStd.AutoSubscribe = false;
            this.dsAdjustStd.DataSetName = "L3DataSet";
            this.dsAdjustStd.DeleteMethod = "";
            this.dsAdjustStd.InsertMethod = "";
            this.dsAdjustStd.L3DataAdapter = this.Adapter;
            this.dsAdjustStd.LoadEvent = "Click";
            this.dsAdjustStd.LoadTrigger = null;
            this.dsAdjustStd.RefreshValve = 1000;
            this.dsAdjustStd.SourceCommand = null;
            this.dsAdjustStd.SourceCondition = "";
            this.dsAdjustStd.SourceMethod = "";
            this.dsAdjustStd.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAdjustStd.SourceURI = "XGMESLogic\\EquipMag\\CEupip_Adjust_Std";
            this.dsAdjustStd.SubscribeTarget = "";
            this.dsAdjustStd.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAdjustStd});
            this.dsAdjustStd.UpdateEvent = "Click";
            this.dsAdjustStd.UpdateMethod = "";
            this.dsAdjustStd.UpdateTrigger = null;
            // 
            // schemadsAdjustStd
            // 
            this.schemadsAdjustStd.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAdjustStdL3DataTableGUID,
            this.coldsAdjustStdL3DataTableName,
            this.coldsAdjustStdL3DataTableAdjustType,
            this.coldsAdjustStdL3DataTableUnitID,
            this.coldsAdjustStdL3DataTableAdjustObject,
            this.coldsAdjustStdL3DataTableItems,
            this.coldsAdjustStdL3DataTableStandard,
            this.coldsAdjustStdL3DataTableValidFlag});
            this.schemadsAdjustStd.TableName = "L3DataTable";
            // 
            // coldsAdjustStdL3DataTableGUID
            // 
            this.coldsAdjustStdL3DataTableGUID.Caption = "GUID";
            this.coldsAdjustStdL3DataTableGUID.ColumnName = "GUID";
            this.coldsAdjustStdL3DataTableGUID.Namespace = "";
            // 
            // coldsAdjustStdL3DataTableName
            // 
            this.coldsAdjustStdL3DataTableName.Caption = "Name";
            this.coldsAdjustStdL3DataTableName.ColumnName = "Name";
            this.coldsAdjustStdL3DataTableName.Namespace = "";
            // 
            // coldsAdjustStdL3DataTableAdjustType
            // 
            this.coldsAdjustStdL3DataTableAdjustType.Caption = "AdjustType";
            this.coldsAdjustStdL3DataTableAdjustType.ColumnName = "AdjustType";
            this.coldsAdjustStdL3DataTableAdjustType.Namespace = "";
            // 
            // coldsAdjustStdL3DataTableUnitID
            // 
            this.coldsAdjustStdL3DataTableUnitID.Caption = "UnitID";
            this.coldsAdjustStdL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsAdjustStdL3DataTableUnitID.Namespace = "";
            // 
            // coldsAdjustStdL3DataTableAdjustObject
            // 
            this.coldsAdjustStdL3DataTableAdjustObject.Caption = "AdjustObject";
            this.coldsAdjustStdL3DataTableAdjustObject.ColumnName = "AdjustObject";
            this.coldsAdjustStdL3DataTableAdjustObject.Namespace = "";
            // 
            // coldsAdjustStdL3DataTableItems
            // 
            this.coldsAdjustStdL3DataTableItems.Caption = "Items";
            this.coldsAdjustStdL3DataTableItems.ColumnName = "Items";
            this.coldsAdjustStdL3DataTableItems.Namespace = "";
            // 
            // coldsAdjustStdL3DataTableStandard
            // 
            this.coldsAdjustStdL3DataTableStandard.Caption = "Standard";
            this.coldsAdjustStdL3DataTableStandard.ColumnName = "Standard";
            this.coldsAdjustStdL3DataTableStandard.Namespace = "";
            // 
            // coldsAdjustStdL3DataTableValidFlag
            // 
            this.coldsAdjustStdL3DataTableValidFlag.Caption = "ValidFlag";
            this.coldsAdjustStdL3DataTableValidFlag.ColumnName = "ValidFlag";
            this.coldsAdjustStdL3DataTableValidFlag.DataType = typeof(int);
            this.coldsAdjustStdL3DataTableValidFlag.Namespace = "";
            // 
            // dsStatus
            // 
            this.dsStatus.AutoSubscribe = false;
            this.dsStatus.DataSetName = "L3DataSet";
            this.dsStatus.DeleteMethod = "";
            this.dsStatus.InsertMethod = "";
            this.dsStatus.L3DataAdapter = null;
            this.dsStatus.LoadEvent = "Click";
            this.dsStatus.LoadTrigger = null;
            this.dsStatus.RefreshValve = 1000;
            this.dsStatus.SourceCommand = null;
            this.dsStatus.SourceCondition = "";
            this.dsStatus.SourceMethod = "";
            this.dsStatus.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsStatus.SourceURI = "";
            this.dsStatus.SubscribeTarget = "";
            this.dsStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStatus});
            this.dsStatus.UpdateEvent = "Click";
            this.dsStatus.UpdateMethod = "";
            this.dsStatus.UpdateTrigger = null;
            // 
            // dsAdjustObject
            // 
            this.dsAdjustObject.AutoSubscribe = false;
            this.dsAdjustObject.DataSetName = "L3DataSet";
            this.dsAdjustObject.DeleteMethod = "";
            this.dsAdjustObject.InsertMethod = "";
            this.dsAdjustObject.L3DataAdapter = this.Adapter;
            this.dsAdjustObject.LoadEvent = "Click";
            this.dsAdjustObject.LoadTrigger = null;
            this.dsAdjustObject.RefreshValve = 1000;
            this.dsAdjustObject.SourceCommand = null;
            this.dsAdjustObject.SourceCondition = "Code_Group = \'AdjustObject\' order by Code";
            this.dsAdjustObject.SourceMethod = "";
            this.dsAdjustObject.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAdjustObject.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsAdjustObject.SubscribeTarget = "";
            this.dsAdjustObject.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAdjustObject});
            this.dsAdjustObject.UpdateEvent = "Click";
            this.dsAdjustObject.UpdateMethod = "";
            this.dsAdjustObject.UpdateTrigger = null;
            // 
            // dsUnitID
            // 
            this.dsUnitID.AutoSubscribe = false;
            this.dsUnitID.DataSetName = "L3DataSet";
            this.dsUnitID.DeleteMethod = "";
            this.dsUnitID.InsertMethod = "";
            this.dsUnitID.L3DataAdapter = this.Adapter;
            this.dsUnitID.LoadEvent = "Click";
            this.dsUnitID.LoadTrigger = null;
            this.dsUnitID.RefreshValve = 1000;
            this.dsUnitID.SourceCommand = null;
            this.dsUnitID.SourceCondition = "Code_Group = \'UnitID\' order by Code";
            this.dsUnitID.SourceMethod = "";
            this.dsUnitID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsUnitID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsUnitID.SubscribeTarget = "";
            this.dsUnitID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsUnitID});
            this.dsUnitID.UpdateEvent = "Click";
            this.dsUnitID.UpdateMethod = "";
            this.dsUnitID.UpdateTrigger = null;
            // 
            // schemadsStatus
            // 
            this.schemadsStatus.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStatusL3DataTableID,
            this.coldsStatusL3DataTableDesc});
            this.schemadsStatus.TableName = "L3DataTable";
            // 
            // coldsStatusL3DataTableID
            // 
            this.coldsStatusL3DataTableID.Caption = "ID";
            this.coldsStatusL3DataTableID.ColumnName = "ID";
            this.coldsStatusL3DataTableID.DataType = typeof(int);
            this.coldsStatusL3DataTableID.Namespace = "";
            // 
            // coldsStatusL3DataTableDesc
            // 
            this.coldsStatusL3DataTableDesc.Caption = "Desc";
            this.coldsStatusL3DataTableDesc.ColumnName = "Desc";
            this.coldsStatusL3DataTableDesc.Namespace = "";
            // 
            // schemadsAdjustObject
            // 
            this.schemadsAdjustObject.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAdjustObjectL3DataTableCode,
            this.coldsAdjustObjectL3DataTableCode_Des,
            this.coldsAdjustObjectL3DataTableCode_Group,
            this.coldsAdjustObjectL3DataTableCode_Group_Des});
            this.schemadsAdjustObject.TableName = "L3DataTable";
            // 
            // coldsAdjustObjectL3DataTableCode
            // 
            this.coldsAdjustObjectL3DataTableCode.Caption = "Code";
            this.coldsAdjustObjectL3DataTableCode.ColumnName = "Code";
            this.coldsAdjustObjectL3DataTableCode.Namespace = "";
            // 
            // coldsAdjustObjectL3DataTableCode_Des
            // 
            this.coldsAdjustObjectL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsAdjustObjectL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsAdjustObjectL3DataTableCode_Des.Namespace = "";
            // 
            // coldsAdjustObjectL3DataTableCode_Group
            // 
            this.coldsAdjustObjectL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsAdjustObjectL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsAdjustObjectL3DataTableCode_Group.Namespace = "";
            // 
            // coldsAdjustObjectL3DataTableCode_Group_Des
            // 
            this.coldsAdjustObjectL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsAdjustObjectL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsAdjustObjectL3DataTableCode_Group_Des.Namespace = "";
            // 
            // schemadsUnitID
            // 
            this.schemadsUnitID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsUnitIDL3DataTableCode,
            this.coldsUnitIDL3DataTableCode_Des,
            this.coldsUnitIDL3DataTableCode_Group,
            this.coldsUnitIDL3DataTableCode_Group_Des});
            this.schemadsUnitID.TableName = "L3DataTable";
            // 
            // coldsUnitIDL3DataTableCode
            // 
            this.coldsUnitIDL3DataTableCode.Caption = "Code";
            this.coldsUnitIDL3DataTableCode.ColumnName = "Code";
            this.coldsUnitIDL3DataTableCode.Namespace = "";
            // 
            // coldsUnitIDL3DataTableCode_Des
            // 
            this.coldsUnitIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsUnitIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsUnitIDL3DataTableCode_Des.Namespace = "";
            // 
            // coldsUnitIDL3DataTableCode_Group
            // 
            this.coldsUnitIDL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsUnitIDL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsUnitIDL3DataTableCode_Group.Namespace = "";
            // 
            // coldsUnitIDL3DataTableCode_Group_Des
            // 
            this.coldsUnitIDL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsUnitIDL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsUnitIDL3DataTableCode_Group_Des.Namespace = "";
            // 
            // cCMIDDataGridViewTextBoxColumn
            // 
            this.cCMIDDataGridViewTextBoxColumn.DataPropertyName = "CCMID";
            this.cCMIDDataGridViewTextBoxColumn.DataSource = this.dsUnitID;
            this.cCMIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.cCMIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cCMIDDataGridViewTextBoxColumn.HeaderText = "铸机";
            this.cCMIDDataGridViewTextBoxColumn.Name = "cCMIDDataGridViewTextBoxColumn";
            this.cCMIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cCMIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cCMIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.cCMIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // strandNoDataGridViewTextBoxColumn
            // 
            this.strandNoDataGridViewTextBoxColumn.DataPropertyName = "StrandNo";
            this.strandNoDataGridViewTextBoxColumn.DataSource = this.dsAdjustObject;
            this.strandNoDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.strandNoDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.strandNoDataGridViewTextBoxColumn.HeaderText = "流号";
            this.strandNoDataGridViewTextBoxColumn.Name = "strandNoDataGridViewTextBoxColumn";
            this.strandNoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.strandNoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.strandNoDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.strandNoDataGridViewTextBoxColumn.Width = 54;
            // 
            // rollerStdDataGridViewTextBoxColumn
            // 
            this.rollerStdDataGridViewTextBoxColumn.DataPropertyName = "Roller_Std";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.rollerStdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.rollerStdDataGridViewTextBoxColumn.HeaderText = "标定值";
            this.rollerStdDataGridViewTextBoxColumn.Name = "rollerStdDataGridViewTextBoxColumn";
            this.rollerStdDataGridViewTextBoxColumn.ReadOnly = true;
            this.rollerStdDataGridViewTextBoxColumn.Width = 66;
            // 
            // roller1ActDataGridViewTextBoxColumn
            // 
            this.roller1ActDataGridViewTextBoxColumn.DataPropertyName = "Roller1_Act";
            this.roller1ActDataGridViewTextBoxColumn.HeaderText = "一号辊实测值";
            this.roller1ActDataGridViewTextBoxColumn.Name = "roller1ActDataGridViewTextBoxColumn";
            this.roller1ActDataGridViewTextBoxColumn.Width = 102;
            // 
            // roller2ActDataGridViewTextBoxColumn
            // 
            this.roller2ActDataGridViewTextBoxColumn.DataPropertyName = "Roller2_Act";
            this.roller2ActDataGridViewTextBoxColumn.HeaderText = "二号辊实测值";
            this.roller2ActDataGridViewTextBoxColumn.Name = "roller2ActDataGridViewTextBoxColumn";
            this.roller2ActDataGridViewTextBoxColumn.Width = 102;
            // 
            // roller3ActDataGridViewTextBoxColumn
            // 
            this.roller3ActDataGridViewTextBoxColumn.DataPropertyName = "Roller3_Act";
            this.roller3ActDataGridViewTextBoxColumn.HeaderText = "三号辊实测值";
            this.roller3ActDataGridViewTextBoxColumn.Name = "roller3ActDataGridViewTextBoxColumn";
            this.roller3ActDataGridViewTextBoxColumn.Width = 102;
            // 
            // roller4ActDataGridViewTextBoxColumn
            // 
            this.roller4ActDataGridViewTextBoxColumn.DataPropertyName = "Roller4_Act";
            this.roller4ActDataGridViewTextBoxColumn.HeaderText = "四号辊实测值";
            this.roller4ActDataGridViewTextBoxColumn.Name = "roller4ActDataGridViewTextBoxColumn";
            this.roller4ActDataGridViewTextBoxColumn.Width = 102;
            // 
            // roller5ActDataGridViewTextBoxColumn
            // 
            this.roller5ActDataGridViewTextBoxColumn.DataPropertyName = "Roller5_Act";
            this.roller5ActDataGridViewTextBoxColumn.HeaderText = "五号辊实测值";
            this.roller5ActDataGridViewTextBoxColumn.Name = "roller5ActDataGridViewTextBoxColumn";
            this.roller5ActDataGridViewTextBoxColumn.Width = 102;
            // 
            // roller6ActDataGridViewTextBoxColumn
            // 
            this.roller6ActDataGridViewTextBoxColumn.DataPropertyName = "Roller6_Act";
            this.roller6ActDataGridViewTextBoxColumn.HeaderText = "六号辊实测值";
            this.roller6ActDataGridViewTextBoxColumn.Name = "roller6ActDataGridViewTextBoxColumn";
            this.roller6ActDataGridViewTextBoxColumn.Width = 102;
            // 
            // roller7ActDataGridViewTextBoxColumn
            // 
            this.roller7ActDataGridViewTextBoxColumn.DataPropertyName = "Roller7_Act";
            this.roller7ActDataGridViewTextBoxColumn.HeaderText = "七号辊实测值";
            this.roller7ActDataGridViewTextBoxColumn.Name = "roller7ActDataGridViewTextBoxColumn";
            this.roller7ActDataGridViewTextBoxColumn.Width = 102;
            // 
            // checkDateDataGridViewTextBoxColumn
            // 
            this.checkDateDataGridViewTextBoxColumn.DataPropertyName = "Check_Date";
            this.checkDateDataGridViewTextBoxColumn.HeaderText = "校准日期";
            this.checkDateDataGridViewTextBoxColumn.Name = "checkDateDataGridViewTextBoxColumn";
            this.checkDateDataGridViewTextBoxColumn.Width = 78;
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "责任人";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.Width = 66;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.DataSource = this.dsStatus;
            this.statusDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Desc";
            this.statusDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.statusDataGridViewTextBoxColumn.HeaderText = "状态";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusDataGridViewTextBoxColumn.ValueMember = "L3DataTable.ID";
            this.statusDataGridViewTextBoxColumn.Width = 54;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "Create_Time";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.createTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "创建时刻";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.createTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            this.gUIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Visible = false;
            this.nameDataGridViewTextBoxColumn.Width = 54;
            // 
            // EquipRollerCheckFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dvAdjustSet);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EquipRollerCheckFrm";
            this.TabText = "拉矫机运行检查";
            this.Text = "拉矫机运行检查";
            this.Load += new System.EventHandler(this.EnergyDataManageFrm_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdjustSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEnergyData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvAdjustSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAdjustStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAdjustObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dvAdjustSet;
        private AppSvrHMI.L3DataSet dsAdjustSet;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Data.DataTable schemadsEnergyData;
        private System.Data.DataColumn coldsEnergyDataL3DataTableGUID;
        private System.Data.DataColumn coldsEnergyDataL3DataTableName;
        private System.Windows.Forms.BindingSource bsAdjustSet;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private System.Data.DataColumn coldsAdjustSetL3DataTableCCMID;
        private System.Data.DataColumn coldsAdjustSetL3DataTableStrandNo;
        private System.Data.DataColumn coldsAdjustSetL3DataTableRoller_Std;
        private System.Data.DataColumn coldsAdjustSetL3DataTableRoller1_Act;
        private System.Data.DataColumn coldsAdjustSetL3DataTableRoller2_Act;
        private System.Data.DataColumn coldsAdjustSetL3DataTableRoller3_Act;
        private System.Data.DataColumn coldsAdjustSetL3DataTableRoller4_Act;
        private System.Data.DataColumn coldsAdjustSetL3DataTableRoller5_Act;
        private System.Data.DataColumn coldsAdjustSetL3DataTableRoller6_Act;
        private System.Data.DataColumn coldsAdjustSetL3DataTableRoller7_Act;
        private System.Data.DataColumn coldsAdjustSetL3DataTableCheck_Date;
        private System.Data.DataColumn coldsAdjustSetL3DataTableCreate_Time;
        private System.Data.DataColumn coldsAdjustSetL3DataTableOperator;
        private System.Data.DataColumn coldsAdjustSetL3DataTableStatus;
        private AppSvrHMI.L3DataSet dsAdjustStd;
        private System.Data.DataTable schemadsAdjustStd;
        private System.Data.DataColumn coldsAdjustStdL3DataTableGUID;
        private System.Data.DataColumn coldsAdjustStdL3DataTableName;
        private System.Data.DataColumn coldsAdjustStdL3DataTableAdjustType;
        private System.Data.DataColumn coldsAdjustStdL3DataTableUnitID;
        private System.Data.DataColumn coldsAdjustStdL3DataTableAdjustObject;
        private System.Data.DataColumn coldsAdjustStdL3DataTableItems;
        private System.Data.DataColumn coldsAdjustStdL3DataTableStandard;
        private System.Data.DataColumn coldsAdjustStdL3DataTableValidFlag;
        private AppSvrHMI.L3DataSet dsStatus;
        private System.Data.DataTable schemadsStatus;
        private System.Data.DataColumn coldsStatusL3DataTableID;
        private System.Data.DataColumn coldsStatusL3DataTableDesc;
        private AppSvrHMI.L3DataSet dsAdjustObject;
        private System.Data.DataTable schemadsAdjustObject;
        private System.Data.DataColumn coldsAdjustObjectL3DataTableCode;
        private System.Data.DataColumn coldsAdjustObjectL3DataTableCode_Des;
        private System.Data.DataColumn coldsAdjustObjectL3DataTableCode_Group;
        private System.Data.DataColumn coldsAdjustObjectL3DataTableCode_Group_Des;
        private AppSvrHMI.L3DataSet dsUnitID;
        private System.Data.DataTable schemadsUnitID;
        private System.Data.DataColumn coldsUnitIDL3DataTableCode;
        private System.Data.DataColumn coldsUnitIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsUnitIDL3DataTableCode_Group;
        private System.Data.DataColumn coldsUnitIDL3DataTableCode_Group_Des;
        private System.Windows.Forms.DataGridViewComboBoxColumn cCMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn strandNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollerStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roller1ActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roller2ActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roller3ActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roller4ActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roller5ActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roller6ActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roller7ActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}