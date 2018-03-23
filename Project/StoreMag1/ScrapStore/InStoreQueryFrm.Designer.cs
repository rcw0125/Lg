﻿namespace StoreMag.ScrapStore
{
    partial class InStoreQueryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InStoreQueryFrm));
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvInStore = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsScrapCode = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsScrapCode = new System.Data.DataTable();
            this.coldsScrapCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsScrapCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.logDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeAreaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsScrapArea = new AppSvrHMI.L3DataSet();
            this.schemadsScrapArea = new System.Data.DataTable();
            this.coldsScrapAreaL3DataTableCode = new System.Data.DataColumn();
            this.coldsScrapAreaL3DataTableCode_Des = new System.Data.DataColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.bsInStore = new System.Windows.Forms.BindingSource(this.components);
            this.dsInStore = new AppSvrHMI.L3DataSet();
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
            this.coldsInStoreL3DataTableSource = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableOperator = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableShift = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableTeam = new System.Data.DataColumn();
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
            this.dtInStoreEndData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dtInStoreData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInStore)).BeginInit();
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
            this.sourceDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn});
            this.dvInStore.DataSource = this.bsInStore;
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
            this.materialIDDataGridViewTextBoxColumn.DataSource = this.dsScrapCode;
            this.materialIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.materialIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.materialIDDataGridViewTextBoxColumn.HeaderText = "入库的材料编码";
            this.materialIDDataGridViewTextBoxColumn.Name = "materialIDDataGridViewTextBoxColumn";
            this.materialIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.materialIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.materialIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsScrapCode
            // 
            this.dsScrapCode.AutoSubscribe = false;
            this.dsScrapCode.DataSetName = "L3DataSet";
            this.dsScrapCode.DeleteMethod = null;
            this.dsScrapCode.InsertMethod = null;
            this.dsScrapCode.L3DataAdapter = this.Adapter;
            this.dsScrapCode.LoadEvent = "Click";
            this.dsScrapCode.LoadTrigger = null;
            this.dsScrapCode.RefreshValve = 1000;
            this.dsScrapCode.SourceCommand = null;
            this.dsScrapCode.SourceCondition = "CODE_GROUP = \'SCRAP_CODE\'";
            this.dsScrapCode.SourceMethod = "";
            this.dsScrapCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsScrapCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsScrapCode.SubscribeTarget = null;
            this.dsScrapCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsScrapCode});
            this.dsScrapCode.UpdateEvent = "Click";
            this.dsScrapCode.UpdateMethod = null;
            this.dsScrapCode.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsScrapCode
            // 
            this.schemadsScrapCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsScrapCodeL3DataTableCode,
            this.coldsScrapCodeL3DataTableCode_Des});
            this.schemadsScrapCode.TableName = "L3DataTable";
            // 
            // coldsScrapCodeL3DataTableCode
            // 
            this.coldsScrapCodeL3DataTableCode.Caption = "Code";
            this.coldsScrapCodeL3DataTableCode.ColumnName = "Code";
            this.coldsScrapCodeL3DataTableCode.Namespace = "";
            // 
            // coldsScrapCodeL3DataTableCode_Des
            // 
            this.coldsScrapCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsScrapCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsScrapCodeL3DataTableCode_Des.Namespace = "";
            // 
            // logDateDataGridViewTextBoxColumn
            // 
            this.logDateDataGridViewTextBoxColumn.DataPropertyName = "LogDate";
            this.logDateDataGridViewTextBoxColumn.HeaderText = "入库日期";
            this.logDateDataGridViewTextBoxColumn.Name = "logDateDataGridViewTextBoxColumn";
            this.logDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "入库量";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "入库类型";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storeAreaIDDataGridViewTextBoxColumn
            // 
            this.storeAreaIDDataGridViewTextBoxColumn.DataPropertyName = "StoreAreaID";
            this.storeAreaIDDataGridViewTextBoxColumn.DataSource = this.dsScrapArea;
            this.storeAreaIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.storeAreaIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.storeAreaIDDataGridViewTextBoxColumn.HeaderText = "库位";
            this.storeAreaIDDataGridViewTextBoxColumn.Name = "storeAreaIDDataGridViewTextBoxColumn";
            this.storeAreaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.storeAreaIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.storeAreaIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.storeAreaIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsScrapArea
            // 
            this.dsScrapArea.AutoSubscribe = false;
            this.dsScrapArea.DataSetName = "L3DataSet";
            this.dsScrapArea.DeleteMethod = null;
            this.dsScrapArea.InsertMethod = null;
            this.dsScrapArea.L3DataAdapter = this.Adapter;
            this.dsScrapArea.LoadEvent = "Click";
            this.dsScrapArea.LoadTrigger = null;
            this.dsScrapArea.RefreshValve = 1000;
            this.dsScrapArea.SourceCommand = null;
            this.dsScrapArea.SourceCondition = "CODE_GROUP = \'ScrapArea\'";
            this.dsScrapArea.SourceMethod = "";
            this.dsScrapArea.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsScrapArea.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsScrapArea.SubscribeTarget = null;
            this.dsScrapArea.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsScrapArea});
            this.dsScrapArea.UpdateEvent = "Click";
            this.dsScrapArea.UpdateMethod = null;
            this.dsScrapArea.UpdateTrigger = null;
            // 
            // schemadsScrapArea
            // 
            this.schemadsScrapArea.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsScrapAreaL3DataTableCode,
            this.coldsScrapAreaL3DataTableCode_Des});
            this.schemadsScrapArea.TableName = "L3DataTable";
            // 
            // coldsScrapAreaL3DataTableCode
            // 
            this.coldsScrapAreaL3DataTableCode.Caption = "Code";
            this.coldsScrapAreaL3DataTableCode.ColumnName = "Code";
            this.coldsScrapAreaL3DataTableCode.Namespace = "";
            // 
            // coldsScrapAreaL3DataTableCode_Des
            // 
            this.coldsScrapAreaL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsScrapAreaL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsScrapAreaL3DataTableCode_Des.Namespace = "";
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "入库原因";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            this.sourceDataGridViewTextBoxColumn.HeaderText = "材料的来源";
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            this.sourceDataGridViewTextBoxColumn.ReadOnly = true;
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
            // bsInStore
            // 
            this.bsInStore.DataMember = "L3DataTable";
            this.bsInStore.DataSource = this.dsInStore;
            // 
            // dsInStore
            // 
            this.dsInStore.AutoSubscribe = false;
            this.dsInStore.DataSetName = "L3DataSet";
            this.dsInStore.DeleteMethod = null;
            this.dsInStore.InsertMethod = null;
            this.dsInStore.L3DataAdapter = null;
            this.dsInStore.LoadEvent = "Click";
            this.dsInStore.LoadTrigger = null;
            this.dsInStore.RefreshValve = 1000;
            this.dsInStore.SourceCommand = null;
            this.dsInStore.SourceCondition = "1=2";
            this.dsInStore.SourceMethod = "";
            this.dsInStore.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsInStore.SourceURI = "XGMESLogic\\ScrapStoreMag\\CScrap_Input_Log";
            this.dsInStore.SubscribeTarget = null;
            this.dsInStore.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsInStore});
            this.dsInStore.UpdateEvent = "Click";
            this.dsInStore.UpdateMethod = null;
            this.dsInStore.UpdateTrigger = null;
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
            this.coldsInStoreL3DataTableSource,
            this.coldsInStoreL3DataTableOperator,
            this.coldsInStoreL3DataTableShift,
            this.coldsInStoreL3DataTableTeam});
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
            // coldsInStoreL3DataTableSource
            // 
            this.coldsInStoreL3DataTableSource.Caption = "Source";
            this.coldsInStoreL3DataTableSource.ColumnName = "Source";
            this.coldsInStoreL3DataTableSource.Namespace = "";
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
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsInStore;
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
            this.dtInStoreEndData,
            this.toolStripLabel2,
            this.dtInStoreData,
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
            // dtInStoreEndData
            // 
            this.dtInStoreEndData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtInStoreEndData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtInStoreEndData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtInStoreEndData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtInStoreEndData.CustomFormat = "yyyy-MM-dd";
            this.dtInStoreEndData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInStoreEndData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtInStoreEndData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtInStoreEndData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtInStoreEndData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtInStoreEndData.Name = "dtInStoreEndData";
            this.dtInStoreEndData.Size = new System.Drawing.Size(100, 22);
            this.dtInStoreEndData.Text = "2009-01-04";
            this.dtInStoreEndData.Value = new System.DateTime(2009, 1, 4, 10, 4, 31, 140);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel2.Text = "－";
            // 
            // dtInStoreData
            // 
            this.dtInStoreData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtInStoreData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtInStoreData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtInStoreData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtInStoreData.CustomFormat = "yyyy-MM-dd";
            this.dtInStoreData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInStoreData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtInStoreData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtInStoreData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtInStoreData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtInStoreData.Name = "dtInStoreData";
            this.dtInStoreData.Size = new System.Drawing.Size(100, 22);
            this.dtInStoreData.Text = "2008-11-16";
            this.dtInStoreData.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 834);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel6.Text = "入库日期:";
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
            // InStoreQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 533);
            this.Controls.Add(this.hmiRootPanel1);
            this.Name = "InStoreQueryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "废钢入库查询";
            this.Text = "入库查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InStoreQueryFrm_FormClosing);
            this.Load += new System.EventHandler(this.InStoreQueryFrm_Load);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInStore)).EndInit();
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
        private buttonHide.ToolStripToriDateTimePicker dtInStoreData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private AppSvrHMI.L3DataSet dsInStore;
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
        private System.Data.DataColumn coldsInStoreL3DataTableSource;
        private System.Data.DataColumn coldsInStoreL3DataTableOperator;
        private System.Data.DataColumn coldsInStoreL3DataTableShift;
        private System.Data.DataColumn coldsInStoreL3DataTableTeam;
        private System.Windows.Forms.DataGridView dvInStore;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsInStore;
        private AppSvrHMI.L3DataSet dsScrapArea;
        private System.Data.DataTable schemadsScrapArea;
        private System.Data.DataColumn coldsScrapAreaL3DataTableCode;
        private System.Data.DataColumn coldsScrapAreaL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsShiftID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private AppSvrHMI.L3DataSet dsScrapCode;
        private System.Data.DataTable schemadsScrapCode;
        private System.Data.DataColumn coldsScrapCodeL3DataTableCode;
        private System.Data.DataColumn coldsScrapCodeL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private buttonHide.ToolStripToriDateTimePicker dtInStoreEndData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn materialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn storeAreaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamDataGridViewTextBoxColumn;
    }
}