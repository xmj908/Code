namespace StorageManage
{
    partial class frmDepotDetailSum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepotDetailSum));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtGuid = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gridTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDepot = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboStorageType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboHandlePerson = new System.Windows.Forms.ComboBox();
            this.BeginDate = new DevExpress.XtraEditors.DateEdit();
            this.endDate = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.btnQty = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaterialId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaterialName = new System.Windows.Forms.TextBox();
            this.txtBillAutoID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 175);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(978, 439);
            this.gridControl1.TabIndex = 55;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DimGray;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Gainsboro;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.DimGray;
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.LightGray;
            this.gridView1.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Preview.BackColor = System.Drawing.Color.Gainsboro;
            this.gridView1.Appearance.Preview.ForeColor = System.Drawing.Color.DimGray;
            this.gridView1.Appearance.Preview.Options.UseBackColor = true;
            this.gridView1.Appearance.Preview.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.DimGray;
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.DimGray;
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.VertLine.BackColor = System.Drawing.Color.LightGray;
            this.gridView1.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridMaterialName,
            this.gridSpec,
            this.gridUnit,
            this.gridQty});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridMaterialName
            // 
            this.gridMaterialName.Caption = "品名";
            this.gridMaterialName.FieldName = "MaterialName";
            this.gridMaterialName.Name = "gridMaterialName";
            this.gridMaterialName.Visible = true;
            this.gridMaterialName.VisibleIndex = 0;
            this.gridMaterialName.Width = 100;
            // 
            // gridSpec
            // 
            this.gridSpec.Caption = "型号";
            this.gridSpec.FieldName = "Spec";
            this.gridSpec.Name = "gridSpec";
            this.gridSpec.Visible = true;
            this.gridSpec.VisibleIndex = 1;
            this.gridSpec.Width = 100;
            // 
            // gridUnit
            // 
            this.gridUnit.Caption = "单位";
            this.gridUnit.FieldName = "Unit";
            this.gridUnit.Name = "gridUnit";
            this.gridUnit.Visible = true;
            this.gridUnit.VisibleIndex = 2;
            this.gridUnit.Width = 100;
            // 
            // gridQty
            // 
            this.gridQty.Caption = "数量";
            this.gridQty.FieldName = "OutQty";
            this.gridQty.Name = "gridQty";
            this.gridQty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gridQty.Visible = true;
            this.gridQty.VisibleIndex = 3;
            this.gridQty.Width = 100;
            // 
            // txtGuid
            // 
            this.txtGuid.Location = new System.Drawing.Point(846, 33);
            this.txtGuid.Name = "txtGuid";
            this.txtGuid.Size = new System.Drawing.Size(41, 22);
            this.txtGuid.TabIndex = 56;
            this.txtGuid.Visible = false;
            // 
            // gridTotal
            // 
            this.gridTotal.Caption = "成本金额";
            this.gridTotal.FieldName = "InTotal";
            this.gridTotal.Name = "gridTotal";
            this.gridTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gridTotal.Visible = true;
            this.gridTotal.VisibleIndex = 4;
            this.gridTotal.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "成本金额";
            this.gridColumn2.FieldName = "InTotal";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 100;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "成本金额";
            this.gridColumn3.FieldName = "InTotal";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 100;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "销售金额";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "新项选择";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(149, 3);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(840, 25);
            this.miniToolStrip.TabIndex = 154;
            // 
            // tsbExport
            // 
            this.tsbExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport.Image")));
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(88, 22);
            this.tsbExport.Text = "导出EXCEL";
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(52, 22);
            this.exit.Text = "退出";
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 114;
            this.label1.Text = "开始日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 115;
            this.label2.Text = "库位";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboDepot
            // 
            this.cboDepot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepot.FormattingEnabled = true;
            this.cboDepot.Location = new System.Drawing.Point(93, 72);
            this.cboDepot.Name = "cboDepot";
            this.cboDepot.Size = new System.Drawing.Size(149, 22);
            this.cboDepot.TabIndex = 116;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 14);
            this.label3.TabIndex = 117;
            this.label3.Text = "类型";
            // 
            // cboStorageType
            // 
            this.cboStorageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStorageType.FormattingEnabled = true;
            this.cboStorageType.Location = new System.Drawing.Point(584, 72);
            this.cboStorageType.Name = "cboStorageType";
            this.cboStorageType.Size = new System.Drawing.Size(170, 22);
            this.cboStorageType.TabIndex = 118;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(309, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 14);
            this.label9.TabIndex = 126;
            this.label9.Text = "经手";
            // 
            // cboHandlePerson
            // 
            this.cboHandlePerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHandlePerson.FormattingEnabled = true;
            this.cboHandlePerson.Location = new System.Drawing.Point(358, 72);
            this.cboHandlePerson.Name = "cboHandlePerson";
            this.cboHandlePerson.Size = new System.Drawing.Size(151, 22);
            this.cboHandlePerson.TabIndex = 127;
            // 
            // BeginDate
            // 
            this.BeginDate.EditValue = null;
            this.BeginDate.Location = new System.Drawing.Point(93, 42);
            this.BeginDate.Name = "BeginDate";
            this.BeginDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.BeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BeginDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.BeginDate.Size = new System.Drawing.Size(149, 20);
            this.BeginDate.TabIndex = 129;
            // 
            // endDate
            // 
            this.endDate.EditValue = null;
            this.endDate.Location = new System.Drawing.Point(358, 42);
            this.endDate.Name = "endDate";
            this.endDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.endDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.endDate.Size = new System.Drawing.Size(149, 20);
            this.endDate.TabIndex = 130;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 131;
            this.label6.Text = "结束日期";
            // 
            // btnQty
            // 
            this.btnQty.Location = new System.Drawing.Point(780, 64);
            this.btnQty.Name = "btnQty";
            this.btnQty.Size = new System.Drawing.Size(107, 30);
            this.btnQty.TabIndex = 133;
            this.btnQty.Text = "查询";
            this.btnQty.UseVisualStyleBackColor = true;
            this.btnQty.Click += new System.EventHandler(this.btnQty_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(780, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 30);
            this.button1.TabIndex = 135;
            this.button1.Text = "重置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 14);
            this.label10.TabIndex = 136;
            this.label10.Text = "条码号";
            // 
            // txtMaterialId
            // 
            this.txtMaterialId.Location = new System.Drawing.Point(93, 107);
            this.txtMaterialId.Name = "txtMaterialId";
            this.txtMaterialId.Size = new System.Drawing.Size(151, 22);
            this.txtMaterialId.TabIndex = 137;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(535, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 14);
            this.label12.TabIndex = 140;
            this.label12.Text = "品名";
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.Location = new System.Drawing.Point(584, 41);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.Size = new System.Drawing.Size(170, 22);
            this.txtMaterialName.TabIndex = 141;
            // 
            // txtBillAutoID
            // 
            this.txtBillAutoID.Location = new System.Drawing.Point(358, 110);
            this.txtBillAutoID.Name = "txtBillAutoID";
            this.txtBillAutoID.Size = new System.Drawing.Size(151, 22);
            this.txtBillAutoID.TabIndex = 143;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBillAutoID);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtMaterialName);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtMaterialId);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnQty);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.endDate);
            this.panel1.Controls.Add(this.BeginDate);
            this.panel1.Controls.Add(this.cboHandlePerson);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cboStorageType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboDepot);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 175);
            this.panel1.TabIndex = 114;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExport,
            this.exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(840, 25);
            this.toolStrip1.TabIndex = 154;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(309, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 14);
            this.label14.TabIndex = 142;
            this.label14.Text = "编号";
            // 
            // frmDepotDetailSum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 614);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtGuid);
            this.Name = "frmDepotDetailSum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "利润汇总表查询";
            this.Load += new System.EventHandler(this.frmBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox txtGuid;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialName;
        private DevExpress.XtraGrid.Columns.GridColumn gridSpec;
        private DevExpress.XtraGrid.Columns.GridColumn gridUnit;
        private DevExpress.XtraGrid.Columns.GridColumn gridQty;
        private DevExpress.XtraGrid.Columns.GridColumn gridTotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDepot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboStorageType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboHandlePerson;
        private DevExpress.XtraEditors.DateEdit BeginDate;
        private DevExpress.XtraEditors.DateEdit endDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnQty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaterialId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaterialName;
        private System.Windows.Forms.TextBox txtBillAutoID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label14;
    }
}