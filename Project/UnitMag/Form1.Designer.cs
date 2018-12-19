namespace UnitMag
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tplBOF = new System.Windows.Forms.TableLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBOFSteelGrade = new AppSvrHMI.L3DataBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtBOFIronWeight = new AppSvrHMI.L3DataBox();
            this.txtBOFNextHeatID = new AppSvrHMI.L3DataBox();
            this.txtBOFIronTemp = new AppSvrHMI.L3DataBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtBOFBlowTime = new AppSvrHMI.L3DataBox();
            this.txtBOFSteelGradeIndex = new AppSvrHMI.L3DataBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tplBOF.SuspendLayout();
            this.SuspendLayout();
            // 
            // tplBOF
            // 
            this.tplBOF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tplBOF.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tplBOF.ColumnCount = 2;
            this.tplBOF.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tplBOF.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplBOF.Controls.Add(this.label19, 0, 2);
            this.tplBOF.Controls.Add(this.txtBOFSteelGrade, 1, 2);
            this.tplBOF.Controls.Add(this.label33, 0, 6);
            this.tplBOF.Controls.Add(this.label32, 0, 5);
            this.tplBOF.Controls.Add(this.label31, 0, 4);
            this.tplBOF.Controls.Add(this.label30, 0, 3);
            this.tplBOF.Controls.Add(this.txtBOFIronWeight, 1, 3);
            this.tplBOF.Controls.Add(this.txtBOFNextHeatID, 1, 6);
            this.tplBOF.Controls.Add(this.txtBOFIronTemp, 1, 5);
            this.tplBOF.Controls.Add(this.label29, 0, 1);
            this.tplBOF.Controls.Add(this.txtBOFBlowTime, 1, 4);
            this.tplBOF.Controls.Add(this.txtBOFSteelGradeIndex, 1, 1);
            this.tplBOF.Controls.Add(this.label28, 0, 0);
            this.tplBOF.Controls.Add(this.textBox1, 1, 0);
            this.tplBOF.Location = new System.Drawing.Point(308, 245);
            this.tplBOF.Name = "tplBOF";
            this.tplBOF.RowCount = 7;
            this.tplBOF.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tplBOF.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tplBOF.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tplBOF.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tplBOF.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tplBOF.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tplBOF.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tplBOF.Size = new System.Drawing.Size(247, 177);
            this.tplBOF.TabIndex = 17;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Location = new System.Drawing.Point(2, 50);
            this.label19.Margin = new System.Windows.Forms.Padding(0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 22);
            this.label19.TabIndex = 2;
            this.label19.Text = "钢种";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBOFSteelGrade
            // 
            this.txtBOFSteelGrade.BackColor = System.Drawing.SystemColors.Window;
            this.txtBOFSteelGrade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBOFSteelGrade.DataFormat = null;
            this.txtBOFSteelGrade.DataObject = "";
            this.txtBOFSteelGrade.DataProperty = "";
            this.txtBOFSteelGrade.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.txtBOFSteelGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBOFSteelGrade.L3DataAdapter = null;
            this.txtBOFSteelGrade.Location = new System.Drawing.Point(69, 50);
            this.txtBOFSteelGrade.Margin = new System.Windows.Forms.Padding(0);
            this.txtBOFSteelGrade.Multiline = true;
            this.txtBOFSteelGrade.Name = "txtBOFSteelGrade";
            this.txtBOFSteelGrade.ReadOnly = true;
            this.txtBOFSteelGrade.Size = new System.Drawing.Size(176, 22);
            this.txtBOFSteelGrade.TabIndex = 3;
            this.txtBOFSteelGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBOFSteelGrade.Value = null;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label33.Location = new System.Drawing.Point(2, 146);
            this.label33.Margin = new System.Windows.Forms.Padding(0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(65, 29);
            this.label33.TabIndex = 0;
            this.label33.Text = "下一炉号";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label32.Location = new System.Drawing.Point(2, 122);
            this.label32.Margin = new System.Windows.Forms.Padding(0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(65, 22);
            this.label32.TabIndex = 0;
            this.label32.Text = "开吹时间";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Location = new System.Drawing.Point(2, 98);
            this.label31.Margin = new System.Windows.Forms.Padding(0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(65, 22);
            this.label31.TabIndex = 0;
            this.label31.Text = "开吹时刻";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Location = new System.Drawing.Point(2, 74);
            this.label30.Margin = new System.Windows.Forms.Padding(0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(65, 22);
            this.label30.TabIndex = 0;
            this.label30.Text = "装入量[t]";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBOFIronWeight
            // 
            this.txtBOFIronWeight.BackColor = System.Drawing.SystemColors.Window;
            this.txtBOFIronWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBOFIronWeight.DataFormat = "N3";
            this.txtBOFIronWeight.DataObject = "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\{BOFID}";
            this.txtBOFIronWeight.DataProperty = "Load";
            this.txtBOFIronWeight.DataType = AppSvrHMI.L3DataBoxType.dtFloat;
            this.txtBOFIronWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBOFIronWeight.L3DataAdapter = null;
            this.txtBOFIronWeight.Location = new System.Drawing.Point(69, 74);
            this.txtBOFIronWeight.Margin = new System.Windows.Forms.Padding(0);
            this.txtBOFIronWeight.Multiline = true;
            this.txtBOFIronWeight.Name = "txtBOFIronWeight";
            this.txtBOFIronWeight.ReadOnly = true;
            this.txtBOFIronWeight.Size = new System.Drawing.Size(176, 22);
            this.txtBOFIronWeight.TabIndex = 1;
            this.txtBOFIronWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBOFIronWeight.Value = null;
            // 
            // txtBOFNextHeatID
            // 
            this.txtBOFNextHeatID.BackColor = System.Drawing.SystemColors.Window;
            this.txtBOFNextHeatID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBOFNextHeatID.DataFormat = null;
            this.txtBOFNextHeatID.DataObject = "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\{BOFID}";
            this.txtBOFNextHeatID.DataProperty = "NextHeatID";
            this.txtBOFNextHeatID.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.txtBOFNextHeatID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBOFNextHeatID.L3DataAdapter = null;
            this.txtBOFNextHeatID.Location = new System.Drawing.Point(69, 146);
            this.txtBOFNextHeatID.Margin = new System.Windows.Forms.Padding(0);
            this.txtBOFNextHeatID.Multiline = true;
            this.txtBOFNextHeatID.Name = "txtBOFNextHeatID";
            this.txtBOFNextHeatID.ReadOnly = true;
            this.txtBOFNextHeatID.Size = new System.Drawing.Size(176, 29);
            this.txtBOFNextHeatID.TabIndex = 1;
            this.txtBOFNextHeatID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBOFNextHeatID.Value = null;
            // 
            // txtBOFIronTemp
            // 
            this.txtBOFIronTemp.BackColor = System.Drawing.SystemColors.Window;
            this.txtBOFIronTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBOFIronTemp.DataFormat = null;
            this.txtBOFIronTemp.DataObject = "";
            this.txtBOFIronTemp.DataProperty = "";
            this.txtBOFIronTemp.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.txtBOFIronTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBOFIronTemp.L3DataAdapter = null;
            this.txtBOFIronTemp.Location = new System.Drawing.Point(69, 122);
            this.txtBOFIronTemp.Margin = new System.Windows.Forms.Padding(0);
            this.txtBOFIronTemp.Multiline = true;
            this.txtBOFIronTemp.Name = "txtBOFIronTemp";
            this.txtBOFIronTemp.ReadOnly = true;
            this.txtBOFIronTemp.Size = new System.Drawing.Size(176, 22);
            this.txtBOFIronTemp.TabIndex = 1;
            this.txtBOFIronTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBOFIronTemp.Value = null;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Location = new System.Drawing.Point(2, 26);
            this.label29.Margin = new System.Windows.Forms.Padding(0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(65, 22);
            this.label29.TabIndex = 0;
            this.label29.Text = "炼钢记号";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBOFBlowTime
            // 
            this.txtBOFBlowTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtBOFBlowTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBOFBlowTime.DataFormat = null;
            this.txtBOFBlowTime.DataObject = "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\{BOFID}";
            this.txtBOFBlowTime.DataProperty = "StartProcessTime";
            this.txtBOFBlowTime.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.txtBOFBlowTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBOFBlowTime.L3DataAdapter = null;
            this.txtBOFBlowTime.Location = new System.Drawing.Point(69, 98);
            this.txtBOFBlowTime.Margin = new System.Windows.Forms.Padding(0);
            this.txtBOFBlowTime.Multiline = true;
            this.txtBOFBlowTime.Name = "txtBOFBlowTime";
            this.txtBOFBlowTime.ReadOnly = true;
            this.txtBOFBlowTime.Size = new System.Drawing.Size(176, 22);
            this.txtBOFBlowTime.TabIndex = 1;
            this.txtBOFBlowTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBOFBlowTime.Value = null;
            // 
            // txtBOFSteelGradeIndex
            // 
            this.txtBOFSteelGradeIndex.BackColor = System.Drawing.SystemColors.Window;
            this.txtBOFSteelGradeIndex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBOFSteelGradeIndex.DataFormat = null;
            this.txtBOFSteelGradeIndex.DataObject = "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\{BOFID}";
            this.txtBOFSteelGradeIndex.DataProperty = "SteelGradeIndex";
            this.txtBOFSteelGradeIndex.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.txtBOFSteelGradeIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBOFSteelGradeIndex.L3DataAdapter = null;
            this.txtBOFSteelGradeIndex.Location = new System.Drawing.Point(69, 26);
            this.txtBOFSteelGradeIndex.Margin = new System.Windows.Forms.Padding(0);
            this.txtBOFSteelGradeIndex.Multiline = true;
            this.txtBOFSteelGradeIndex.Name = "txtBOFSteelGradeIndex";
            this.txtBOFSteelGradeIndex.ReadOnly = true;
            this.txtBOFSteelGradeIndex.Size = new System.Drawing.Size(176, 22);
            this.txtBOFSteelGradeIndex.TabIndex = 1;
            this.txtBOFSteelGradeIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBOFSteelGradeIndex.Value = null;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Location = new System.Drawing.Point(2, 2);
            this.label28.Margin = new System.Windows.Forms.Padding(0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(65, 22);
            this.label28.TabIndex = 0;
            this.label28.Text = "炉号";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(72, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 21);
            this.textBox1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 184);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tplBOF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tplBOF.ResumeLayout(false);
            this.tplBOF.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tplBOF;
        private System.Windows.Forms.Label label19;
        private AppSvrHMI.L3DataBox txtBOFSteelGrade;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private AppSvrHMI.L3DataBox txtBOFIronWeight;
        private AppSvrHMI.L3DataBox txtBOFNextHeatID;
        private AppSvrHMI.L3DataBox txtBOFIronTemp;
        private System.Windows.Forms.Label label29;
        private AppSvrHMI.L3DataBox txtBOFBlowTime;
        private AppSvrHMI.L3DataBox txtBOFSteelGradeIndex;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}