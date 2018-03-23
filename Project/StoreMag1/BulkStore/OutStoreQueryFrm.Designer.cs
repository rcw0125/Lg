﻿namespace StoreMag.BulkStore
{
    partial class OutStoreQueryFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutStoreQueryFrm));
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvInStore = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OutType = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemaOutType = new System.Data.DataTable();
            this.colOutTypeL3DataTablecode_des = new System.Data.DataColumn();
            this.colOutTypeL3DataTablecode_val_long = new System.Data.DataColumn();
            this.storeAreaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsBulkArea = new AppSvrHMI.L3DataSet();
            this.schemadsBulkArea = new System.Data.DataTable();
            this.coldsBulkAreaL3DataTableCode = new System.Data.DataColumn();
            this.coldsBulkAreaL3DataTableCode_Des = new System.Data.DataColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bulkCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsBulkCode = new AppSvrHMI.L3DataSet();
            this.schemadsBulkCode = new System.Data.DataTable();
            this.coldsBulkCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsBulkCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsOutStore = new System.Windows.Forms.BindingSource(this.components);
            this.dsOutStore = new AppSvrHMI.L3DataSet();
            this.schemadsInStore = new System.Data.DataTable();
            this.coldsInStoreL3DataTableGUID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableName = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableMaterialType = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableLogDate = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableAmount = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableType = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableStoreAreaID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableReason = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableOperator = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableShift = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableTeam = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableNo = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableTarget = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableBatch_ID = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableBulk_Code = new System.Data.DataColumn();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.dtOutStoreEndData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dtOutStoreData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemaOutType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOutStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOutStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvInStore);
            this.hmiRootPanel1.Controls.Add(this.bdN1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(887, 533);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // dvInStore
            // 
            this.dvInStore.AllowUserToAddRows = false;
            this.dvInStore.AutoGenerateColumns = false;
            this.dvInStore.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvInStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.materialTypeDataGridViewTextBoxColumn,
            this.materialIDDataGridViewTextBoxColumn,
            this.logDateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.storeAreaIDDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.bulkCodeDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.noDataGridViewTextBoxColumn,
            this.targetDataGridViewTextBoxColumn,
            this.batchIDDataGridViewTextBoxColumn});
            this.dvInStore.DataSource = this.bsOutStore;
            this.dvInStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvInStore.Location = new System.Drawing.Point(0, 25);
            this.dvInStore.Name = "dvInStore";
            this.dvInStore.ReadOnly = true;
            this.dvInStore.RowHeadersVisible = false;
            this.dvInStore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvInStore.RowTemplate.Height = 23;
            this.dvInStore.Size = new System.Drawing.Size(887, 508);
            this.dvInStore.TabIndex = 29;
            this.dvInStore.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvInStore_DataError);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Visible = false;
            this.nameDataGridViewTextBoxColumn.Width = 54;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            this.gUIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // materialTypeDataGridViewTextBoxColumn
            // 
            this.materialTypeDataGridViewTextBoxColumn.DataPropertyName = "MaterialType";
            this.materialTypeDataGridViewTextBoxColumn.HeaderText = "入库的材料类型";
            this.materialTypeDataGridViewTextBoxColumn.Name = "materialTypeDataGridViewTextBoxColumn";
            this.materialTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialTypeDataGridViewTextBoxColumn.Visible = false;
            this.materialTypeDataGridViewTextBoxColumn.Width = 114;
            // 
            // materialIDDataGridViewTextBoxColumn
            // 
            this.materialIDDataGridViewTextBoxColumn.DataPropertyName = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.HeaderText = "入库的材料编码";
            this.materialIDDataGridViewTextBoxColumn.Name = "materialIDDataGridViewTextBoxColumn";
            this.materialIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialIDDataGridViewTextBoxColumn.Visible = false;
            this.materialIDDataGridViewTextBoxColumn.Width = 114;
            // 
            // logDateDataGridViewTextBoxColumn
            // 
            this.logDateDataGridViewTextBoxColumn.DataPropertyName = "LogDate";
            this.logDateDataGridViewTextBoxColumn.HeaderText = "出库日期";
            this.logDateDataGridViewTextBoxColumn.Name = "logDateDataGridViewTextBoxColumn";
            this.logDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = null;
            this.amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.amountDataGridViewTextBoxColumn.HeaderText = "出库量[Kg]";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.DataSource = this.OutType;
            this.typeDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.code_des";
            this.typeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.typeDataGridViewTextBoxColumn.HeaderText = "出库类型";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typeDataGridViewTextBoxColumn.ValueMember = "L3DataTable.code_val_long";
            // 
            // OutType
            // 
            this.OutType.AutoLoad = true;
            this.OutType.AutoSubscribe = false;
            this.OutType.DataSetName = "L3DataSet";
            this.OutType.DeleteMethod = "";
            this.OutType.InsertMethod = "";
            this.OutType.L3DataAdapter = this.Adapter;
            this.OutType.LoadEvent = "";
            this.OutType.LoadTrigger = null;
            this.OutType.RefreshValve = 1000;
            this.OutType.SourceCommand = null;
            this.OutType.SourceCondition = "code_group = \'OutStoreType\'";
            this.OutType.SourceMethod = "";
            this.OutType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.OutType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.OutType.SubscribeTarget = null;
            this.OutType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemaOutType});
            this.OutType.UpdateEvent = "";
            this.OutType.UpdateMethod = "";
            this.OutType.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemaOutType
            // 
            this.schemaOutType.Columns.AddRange(new System.Data.DataColumn[] {
            this.colOutTypeL3DataTablecode_des,
            this.colOutTypeL3DataTablecode_val_long});
            this.schemaOutType.TableName = "L3DataTable";
            // 
            // colOutTypeL3DataTablecode_des
            // 
            this.colOutTypeL3DataTablecode_des.Caption = "code_des";
            this.colOutTypeL3DataTablecode_des.ColumnName = "code_des";
            this.colOutTypeL3DataTablecode_des.Namespace = "";
            // 
            // colOutTypeL3DataTablecode_val_long
            // 
            this.colOutTypeL3DataTablecode_val_long.Caption = "code_val_long";
            this.colOutTypeL3DataTablecode_val_long.ColumnName = "code_val_long";
            this.colOutTypeL3DataTablecode_val_long.DataType = typeof(int);
            this.colOutTypeL3DataTablecode_val_long.Namespace = "";
            // 
            // storeAreaIDDataGridViewTextBoxColumn
            // 
            this.storeAreaIDDataGridViewTextBoxColumn.DataPropertyName = "StoreAreaID";
            this.storeAreaIDDataGridViewTextBoxColumn.DataSource = this.dsBulkArea;
            this.storeAreaIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.storeAreaIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.storeAreaIDDataGridViewTextBoxColumn.HeaderText = "出库地";
            this.storeAreaIDDataGridViewTextBoxColumn.Name = "storeAreaIDDataGridViewTextBoxColumn";
            this.storeAreaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.storeAreaIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.storeAreaIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.storeAreaIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsBulkArea
            // 
            this.dsBulkArea.AutoLoad = true;
            this.dsBulkArea.AutoSubscribe = false;
            this.dsBulkArea.DataSetName = "L3DataSet";
            this.dsBulkArea.DeleteMethod = null;
            this.dsBulkArea.InsertMethod = null;
            this.dsBulkArea.L3DataAdapter = this.Adapter;
            this.dsBulkArea.LoadEvent = "Click";
            this.dsBulkArea.LoadTrigger = null;
            this.dsBulkArea.RefreshValve = 1000;
            this.dsBulkArea.SourceCommand = null;
            this.dsBulkArea.SourceCondition = "CODE_GROUP = \'BulkArea\'";
            this.dsBulkArea.SourceMethod = "";
            this.dsBulkArea.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBulkArea.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBulkArea.SubscribeTarget = null;
            this.dsBulkArea.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBulkArea});
            this.dsBulkArea.UpdateEvent = "Click";
            this.dsBulkArea.UpdateMethod = null;
            this.dsBulkArea.UpdateTrigger = null;
            // 
            // schemadsBulkArea
            // 
            this.schemadsBulkArea.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBulkAreaL3DataTableCode,
            this.coldsBulkAreaL3DataTableCode_Des});
            this.schemadsBulkArea.TableName = "L3DataTable";
            // 
            // coldsBulkAreaL3DataTableCode
            // 
            this.coldsBulkAreaL3DataTableCode.Caption = "Code";
            this.coldsBulkAreaL3DataTableCode.ColumnName = "Code";
            this.coldsBulkAreaL3DataTableCode.Namespace = "";
            // 
            // coldsBulkAreaL3DataTableCode_Des
            // 
            this.coldsBulkAreaL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBulkAreaL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBulkAreaL3DataTableCode_Des.Namespace = "";
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "出库原因";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.reasonDataGridViewTextBoxColumn.Visible = false;
            // 
            // bulkCodeDataGridViewTextBoxColumn
            // 
            this.bulkCodeDataGridViewTextBoxColumn.DataPropertyName = "Bulk_Code";
            this.bulkCodeDataGridViewTextBoxColumn.DataSource = this.dsBulkCode;
            this.bulkCodeDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.bulkCodeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.bulkCodeDataGridViewTextBoxColumn.HeaderText = "散状料代码";
            this.bulkCodeDataGridViewTextBoxColumn.Name = "bulkCodeDataGridViewTextBoxColumn";
            this.bulkCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.bulkCodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bulkCodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bulkCodeDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsBulkCode
            // 
            this.dsBulkCode.AutoLoad = true;
            this.dsBulkCode.AutoSubscribe = false;
            this.dsBulkCode.DataSetName = "L3DataSet";
            this.dsBulkCode.DeleteMethod = null;
            this.dsBulkCode.InsertMethod = null;
            this.dsBulkCode.L3DataAdapter = this.Adapter;
            this.dsBulkCode.LoadEvent = "Click";
            this.dsBulkCode.LoadTrigger = null;
            this.dsBulkCode.RefreshValve = 1000;
            this.dsBulkCode.SourceCommand = null;
            this.dsBulkCode.SourceCondition = "CODE_GROUP = \'BULK_CODE\'";
            this.dsBulkCode.SourceMethod = "";
            this.dsBulkCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBulkCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBulkCode.SubscribeTarget = null;
            this.dsBulkCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBulkCode});
            this.dsBulkCode.UpdateEvent = "Click";
            this.dsBulkCode.UpdateMethod = null;
            this.dsBulkCode.UpdateTrigger = null;
            // 
            // schemadsBulkCode
            // 
            this.schemadsBulkCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBulkCodeL3DataTableCode,
            this.coldsBulkCodeL3DataTableCode_Des});
            this.schemadsBulkCode.TableName = "L3DataTable";
            // 
            // coldsBulkCodeL3DataTableCode
            // 
            this.coldsBulkCodeL3DataTableCode.Caption = "Code";
            this.coldsBulkCodeL3DataTableCode.ColumnName = "Code";
            this.coldsBulkCodeL3DataTableCode.Namespace = "";
            // 
            // coldsBulkCodeL3DataTableCode_Des
            // 
            this.coldsBulkCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBulkCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBulkCodeL3DataTableCode_Des.Namespace = "";
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "操作人员";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.DataSource = this.dsShiftID;
            this.shiftDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.shiftDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.shiftDataGridViewTextBoxColumn.HeaderText = "班次";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.ReadOnly = true;
            this.shiftDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shiftDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.shiftDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
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
            this.coldsShiftIDL3DataTableCode_Des,
            this.coldsShiftIDL3DataTableCode});
            this.schemadsShiftID.TableName = "L3DataTable";
            // 
            // coldsShiftIDL3DataTableCode_Des
            // 
            this.coldsShiftIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.Namespace = "";
            // 
            // coldsShiftIDL3DataTableCode
            // 
            this.coldsShiftIDL3DataTableCode.Caption = "Code";
            this.coldsShiftIDL3DataTableCode.ColumnName = "Code";
            this.coldsShiftIDL3DataTableCode.Namespace = "";
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.DataSource = this.dsTeamID;
            this.teamDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.teamDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.teamDataGridViewTextBoxColumn.HeaderText = "班别";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            this.teamDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teamDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
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
            this.coldsTeamIDL3DataTableCode_Des,
            this.coldsTeamIDL3DataTableCode});
            this.schemadsTeamID.TableName = "L3DataTable";
            // 
            // coldsTeamIDL3DataTableCode_Des
            // 
            this.coldsTeamIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.Namespace = "";
            // 
            // coldsTeamIDL3DataTableCode
            // 
            this.coldsTeamIDL3DataTableCode.Caption = "Code";
            this.coldsTeamIDL3DataTableCode.ColumnName = "Code";
            this.coldsTeamIDL3DataTableCode.Namespace = "";
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.ReadOnly = true;
            this.noDataGridViewTextBoxColumn.Visible = false;
            this.noDataGridViewTextBoxColumn.Width = 42;
            // 
            // targetDataGridViewTextBoxColumn
            // 
            this.targetDataGridViewTextBoxColumn.DataPropertyName = "Target";
            this.targetDataGridViewTextBoxColumn.HeaderText = "目的地";
            this.targetDataGridViewTextBoxColumn.Name = "targetDataGridViewTextBoxColumn";
            this.targetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // batchIDDataGridViewTextBoxColumn
            // 
            this.batchIDDataGridViewTextBoxColumn.DataPropertyName = "Batch_ID";
            this.batchIDDataGridViewTextBoxColumn.HeaderText = "批次号";
            this.batchIDDataGridViewTextBoxColumn.Name = "batchIDDataGridViewTextBoxColumn";
            this.batchIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsOutStore
            // 
            this.bsOutStore.DataMember = "L3DataTable";
            this.bsOutStore.DataSource = this.dsOutStore;
            // 
            // dsOutStore
            // 
            this.dsOutStore.AutoLoad = true;
            this.dsOutStore.AutoSubscribe = false;
            this.dsOutStore.DataSetName = "L3DataSet";
            this.dsOutStore.DeleteMethod = null;
            this.dsOutStore.InsertMethod = null;
            this.dsOutStore.L3DataAdapter = this.Adapter;
            this.dsOutStore.LoadEvent = "Click";
            this.dsOutStore.LoadTrigger = null;
            this.dsOutStore.RefreshValve = 1000;
            this.dsOutStore.SourceCommand = null;
            this.dsOutStore.SourceCondition = "1=2";
            this.dsOutStore.SourceMethod = "";
            this.dsOutStore.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsOutStore.SourceURI = "XGMESLogic\\BulkStoreMag\\CBulk_Output_Log";
            this.dsOutStore.SubscribeTarget = null;
            this.dsOutStore.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsInStore});
            this.dsOutStore.UpdateEvent = "Click";
            this.dsOutStore.UpdateMethod = null;
            this.dsOutStore.UpdateTrigger = null;
            // 
            // schemadsInStore
            // 
            this.schemadsInStore.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsInStoreL3DataTableGUID,
            this.coldsInStoreL3DataTableName,
            this.coldsInStoreL3DataTableMaterialType,
            this.coldsInStoreL3DataTableMaterialID,
            this.coldsInStoreL3DataTableLogDate,
            this.coldsInStoreL3DataTableAmount,
            this.coldsInStoreL3DataTableType,
            this.coldsInStoreL3DataTableStoreAreaID,
            this.coldsInStoreL3DataTableReason,
            this.coldsInStoreL3DataTableOperator,
            this.coldsInStoreL3DataTableShift,
            this.coldsInStoreL3DataTableTeam,
            this.coldsOutStoreL3DataTableNo,
            this.coldsOutStoreL3DataTableTarget,
            this.coldsOutStoreL3DataTableBatch_ID,
            this.coldsOutStoreL3DataTableBulk_Code});
            this.schemadsInStore.TableName = "L3DataTable";
            // 
            // coldsInStoreL3DataTableGUID
            // 
            this.coldsInStoreL3DataTableGUID.Caption = "GUID";
            this.coldsInStoreL3DataTableGUID.ColumnName = "GUID";
            this.coldsInStoreL3DataTableGUID.Namespace = "";
            // 
            // coldsInStoreL3DataTableName
            // 
            this.coldsInStoreL3DataTableName.Caption = "Name";
            this.coldsInStoreL3DataTableName.ColumnName = "Name";
            this.coldsInStoreL3DataTableName.Namespace = "";
            // 
            // coldsInStoreL3DataTableMaterialType
            // 
            this.coldsInStoreL3DataTableMaterialType.Caption = "MaterialType";
            this.coldsInStoreL3DataTableMaterialType.ColumnName = "MaterialType";
            this.coldsInStoreL3DataTableMaterialType.Namespace = "";
            // 
            // coldsInStoreL3DataTableMaterialID
            // 
            this.coldsInStoreL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsInStoreL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsInStoreL3DataTableMaterialID.Namespace = "";
            // 
            // coldsInStoreL3DataTableLogDate
            // 
            this.coldsInStoreL3DataTableLogDate.Caption = "LogDate";
            this.coldsInStoreL3DataTableLogDate.ColumnName = "LogDate";
            this.coldsInStoreL3DataTableLogDate.DataType = typeof(System.DateTime);
            this.coldsInStoreL3DataTableLogDate.Namespace = "";
            // 
            // coldsInStoreL3DataTableAmount
            // 
            this.coldsInStoreL3DataTableAmount.Caption = "Amount";
            this.coldsInStoreL3DataTableAmount.ColumnName = "Amount";
            this.coldsInStoreL3DataTableAmount.DataType = typeof(double);
            this.coldsInStoreL3DataTableAmount.Namespace = "";
            // 
            // coldsInStoreL3DataTableType
            // 
            this.coldsInStoreL3DataTableType.Caption = "Type";
            this.coldsInStoreL3DataTableType.ColumnName = "Type";
            this.coldsInStoreL3DataTableType.DataType = typeof(int);
            this.coldsInStoreL3DataTableType.Namespace = "";
            // 
            // coldsInStoreL3DataTableStoreAreaID
            // 
            this.coldsInStoreL3DataTableStoreAreaID.Caption = "StoreAreaID";
            this.coldsInStoreL3DataTableStoreAreaID.ColumnName = "StoreAreaID";
            this.coldsInStoreL3DataTableStoreAreaID.Namespace = "";
            // 
            // coldsInStoreL3DataTableReason
            // 
            this.coldsInStoreL3DataTableReason.Caption = "Reason";
            this.coldsInStoreL3DataTableReason.ColumnName = "Reason";
            this.coldsInStoreL3DataTableReason.Namespace = "";
            // 
            // coldsInStoreL3DataTableOperator
            // 
            this.coldsInStoreL3DataTableOperator.Caption = "Operator";
            this.coldsInStoreL3DataTableOperator.ColumnName = "Operator";
            this.coldsInStoreL3DataTableOperator.Namespace = "";
            // 
            // coldsInStoreL3DataTableShift
            // 
            this.coldsInStoreL3DataTableShift.Caption = "Shift";
            this.coldsInStoreL3DataTableShift.ColumnName = "Shift";
            this.coldsInStoreL3DataTableShift.Namespace = "";
            // 
            // coldsInStoreL3DataTableTeam
            // 
            this.coldsInStoreL3DataTableTeam.Caption = "Team";
            this.coldsInStoreL3DataTableTeam.ColumnName = "Team";
            this.coldsInStoreL3DataTableTeam.Namespace = "";
            // 
            // coldsOutStoreL3DataTableNo
            // 
            this.coldsOutStoreL3DataTableNo.Caption = "No";
            this.coldsOutStoreL3DataTableNo.ColumnName = "No";
            this.coldsOutStoreL3DataTableNo.Namespace = "";
            // 
            // coldsOutStoreL3DataTableTarget
            // 
            this.coldsOutStoreL3DataTableTarget.Caption = "Target";
            this.coldsOutStoreL3DataTableTarget.ColumnName = "Target";
            this.coldsOutStoreL3DataTableTarget.Namespace = "";
            // 
            // coldsOutStoreL3DataTableBatch_ID
            // 
            this.coldsOutStoreL3DataTableBatch_ID.Caption = "Batch_ID";
            this.coldsOutStoreL3DataTableBatch_ID.ColumnName = "Batch_ID";
            this.coldsOutStoreL3DataTableBatch_ID.Namespace = "";
            // 
            // coldsOutStoreL3DataTableBulk_Code
            // 
            this.coldsOutStoreL3DataTableBulk_Code.Caption = "Bulk_Code";
            this.coldsOutStoreL3DataTableBulk_Code.ColumnName = "Bulk_Code";
            this.coldsOutStoreL3DataTableBulk_Code.Namespace = "";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsOutStore;
            this.bdN1.CountItem = this.bindingNavigatorCountItem;
            this.bdN1.DeleteItem = null;
            this.bdN1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.btnQuery,
            this.dtOutStoreEndData,
            this.toolStripLabel2,
            this.dtOutStoreData,
            this.toolStripLabel6,
            this.btnOutput});
            this.bdN1.Location = new System.Drawing.Point(0, 0);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(887, 25);
            this.bdN1.TabIndex = 28;
            this.bdN1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
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
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel1.Text = "  ";
            // 
            // btnQuery
            // 
            this.btnQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(49, 22);
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dtOutStoreEndData
            // 
            this.dtOutStoreEndData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtOutStoreEndData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtOutStoreEndData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtOutStoreEndData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtOutStoreEndData.CustomFormat = "yyyy-MM-dd";
            this.dtOutStoreEndData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOutStoreEndData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtOutStoreEndData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtOutStoreEndData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtOutStoreEndData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtOutStoreEndData.Name = "dtOutStoreEndData";
            this.dtOutStoreEndData.Size = new System.Drawing.Size(100, 22);
            this.dtOutStoreEndData.Text = "2009-01-04";
            this.dtOutStoreEndData.Value = new System.DateTime(2009, 1, 4, 10, 4, 31, 140);
            this.dtOutStoreEndData.Visible = false;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel2.Text = "－";
            this.toolStripLabel2.Visible = false;
            // 
            // dtOutStoreData
            // 
            this.dtOutStoreData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtOutStoreData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtOutStoreData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtOutStoreData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtOutStoreData.CustomFormat = "yyyy-MM-dd";
            this.dtOutStoreData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOutStoreData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtOutStoreData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtOutStoreData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtOutStoreData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtOutStoreData.Name = "dtOutStoreData";
            this.dtOutStoreData.Size = new System.Drawing.Size(100, 22);
            this.dtOutStoreData.Text = "2008-11-16";
            this.dtOutStoreData.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 834);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel6.Text = "出库日期:";
            // 
            // btnOutput
            // 
            this.btnOutput.Image = ((System.Drawing.Image)(resources.GetObject("btnOutput.Image")));
            this.btnOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(91, 22);
            this.btnOutput.Text = "导出到Excel";
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // OutStoreQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 533);
            this.Controls.Add(this.hmiRootPanel1);
            this.Name = "OutStoreQueryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "散状料出库查询";
            this.Text = "出库查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OutStoreQueryFrm_FormClosing);
            this.Load += new System.EventHandler(this.OutStoreQueryFrm_Load);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemaOutType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOutStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOutStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private buttonHide.ToolStripToriDateTimePicker dtOutStoreData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private AppSvrHMI.L3DataSet dsOutStore;
        private System.Data.DataTable schemadsInStore;
        private System.Data.DataColumn coldsInStoreL3DataTableGUID;
        private System.Data.DataColumn coldsInStoreL3DataTableName;
        private System.Data.DataColumn coldsInStoreL3DataTableMaterialType;
        private System.Data.DataColumn coldsInStoreL3DataTableMaterialID;
        private System.Data.DataColumn coldsInStoreL3DataTableLogDate;
        private System.Data.DataColumn coldsInStoreL3DataTableAmount;
        private System.Data.DataColumn coldsInStoreL3DataTableType;
        private System.Data.DataColumn coldsInStoreL3DataTableStoreAreaID;
        private System.Data.DataColumn coldsInStoreL3DataTableReason;
        private System.Data.DataColumn coldsInStoreL3DataTableOperator;
        private System.Data.DataColumn coldsInStoreL3DataTableShift;
        private System.Data.DataColumn coldsInStoreL3DataTableTeam;
        private System.Windows.Forms.DataGridView dvInStore;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsOutStore;
        private System.Data.DataColumn coldsOutStoreL3DataTableNo;
        private System.Data.DataColumn coldsOutStoreL3DataTableTarget;
        private System.Data.DataColumn coldsOutStoreL3DataTableBatch_ID;
        private System.Data.DataColumn coldsOutStoreL3DataTableBulk_Code;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsBulkCode;
        private System.Data.DataTable schemadsBulkCode;
        private System.Data.DataColumn coldsBulkCodeL3DataTableCode;
        private System.Data.DataColumn coldsBulkCodeL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsBulkArea;
        private System.Data.DataTable schemadsBulkArea;
        private System.Data.DataColumn coldsBulkAreaL3DataTableCode;
        private System.Data.DataColumn coldsBulkAreaL3DataTableCode_Des;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private buttonHide.ToolStripToriDateTimePicker dtOutStoreEndData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private AppSvrHMI.L3DataSet OutType;
        private System.Data.DataTable schemaOutType;
        private System.Data.DataColumn colOutTypeL3DataTablecode_des;
        private System.Data.DataColumn colOutTypeL3DataTablecode_val_long;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn storeAreaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn bulkCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchIDDataGridViewTextBoxColumn;
    }
}