namespace StorageManage
{
    partial class frmCheckBillAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckBillAdd));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCheckPass = new System.Windows.Forms.ToolStripButton();
            this.tsbCheckNoPass = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDepot = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cboHandlePerson = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridClassName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSurplusQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridDeficientQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemSpinEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.btnDelDetail = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.txtCreatePerson = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCreateDate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCheckDate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCheckPerson = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAutoBillID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtGuid = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.tsbSave,
            this.btnDelete,
            this.toolStripSeparator2,
            this.tsbCheckPass,
            this.tsbCheckNoPass,
            this.tsbPrint,
            this.toolStripSeparator1,
            this.exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(829, 25);
            this.toolStrip1.TabIndex = 50;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(52, 22);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(52, 22);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(52, 22);
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbCheckPass
            // 
            this.tsbCheckPass.Image = ((System.Drawing.Image)(resources.GetObject("tsbCheckPass.Image")));
            this.tsbCheckPass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCheckPass.Name = "tsbCheckPass";
            this.tsbCheckPass.Size = new System.Drawing.Size(52, 22);
            this.tsbCheckPass.Text = "审核";
            this.tsbCheckPass.Click += new System.EventHandler(this.tsbCheckPass_Click);
            // 
            // tsbCheckNoPass
            // 
            this.tsbCheckNoPass.Image = ((System.Drawing.Image)(resources.GetObject("tsbCheckNoPass.Image")));
            this.tsbCheckNoPass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCheckNoPass.Name = "tsbCheckNoPass";
            this.tsbCheckNoPass.Size = new System.Drawing.Size(52, 22);
            this.tsbCheckNoPass.Text = "反审";
            this.tsbCheckNoPass.Click += new System.EventHandler(this.tsbCheckNoPass_Click);
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(52, 22);
            this.tsbPrint.Text = "打印";
            this.tsbPrint.Visible = false;
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(52, 22);
            this.exit.Text = "退出";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 14);
            this.label1.TabIndex = 52;
            this.label1.Text = "日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 53;
            this.label2.Text = "库位";
            // 
            // cboDepot
            // 
            this.cboDepot.BackColor = System.Drawing.Color.White;
            this.cboDepot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepot.FormattingEnabled = true;
            this.cboDepot.Location = new System.Drawing.Point(325, 58);
            this.cboDepot.Name = "cboDepot";
            this.cboDepot.Size = new System.Drawing.Size(170, 22);
            this.cboDepot.TabIndex = 54;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(77, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 22);
            this.dateTimePicker1.TabIndex = 55;
            // 
            // cboHandlePerson
            // 
            this.cboHandlePerson.BackColor = System.Drawing.Color.White;
            this.cboHandlePerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHandlePerson.FormattingEnabled = true;
            this.cboHandlePerson.Location = new System.Drawing.Point(576, 58);
            this.cboHandlePerson.Name = "cboHandlePerson";
            this.cboHandlePerson.Size = new System.Drawing.Size(160, 22);
            this.cboHandlePerson.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(526, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 14);
            this.label9.TabIndex = 69;
            this.label9.Text = "经手";
            // 
            // txtRemark
            // 
            this.txtRemark.BackColor = System.Drawing.Color.White;
            this.txtRemark.Location = new System.Drawing.Point(77, 95);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(170, 22);
            this.txtRemark.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 14);
            this.label10.TabIndex = 71;
            this.label10.Text = "备注";
            // 
            // gridControl1
            // 
            this.gridControl1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridControl1.Location = new System.Drawing.Point(0, 190);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit1,
            this.repositoryItemPopupContainerEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemSpinEdit2,
            this.repositoryItemSpinEdit3});
            this.gridControl1.Size = new System.Drawing.Size(827, 386);
            this.gridControl1.TabIndex = 73;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FixedLine.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FixedLine.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.RowSeparator.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.VertLine.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.VertLine.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridMaterialName,
            this.gridClassName,
            this.gridSpec,
            this.gridUnit,
            this.gridSurplusQty,
            this.gridDeficientQty,
            this.gridRemark,
            this.gridMaterialGuid,
            this.gridMaterialId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridView1_KeyPress);
            // 
            // gridMaterialName
            // 
            this.gridMaterialName.Caption = "品名";
            this.gridMaterialName.FieldName = "MaterialName";
            this.gridMaterialName.Name = "gridMaterialName";
            this.gridMaterialName.OptionsColumn.AllowEdit = false;
            this.gridMaterialName.Visible = true;
            this.gridMaterialName.VisibleIndex = 0;
            // 
            // gridClassName
            // 
            this.gridClassName.Caption = "货品类型";
            this.gridClassName.FieldName = "ClassName";
            this.gridClassName.Name = "gridClassName";
            this.gridClassName.OptionsColumn.AllowEdit = false;
            this.gridClassName.Visible = true;
            this.gridClassName.VisibleIndex = 1;
            // 
            // gridSpec
            // 
            this.gridSpec.Caption = "型号";
            this.gridSpec.FieldName = "Spec";
            this.gridSpec.Name = "gridSpec";
            this.gridSpec.OptionsColumn.AllowEdit = false;
            this.gridSpec.Visible = true;
            this.gridSpec.VisibleIndex = 2;
            // 
            // gridUnit
            // 
            this.gridUnit.Caption = "单位";
            this.gridUnit.FieldName = "Unit";
            this.gridUnit.Name = "gridUnit";
            this.gridUnit.OptionsColumn.AllowEdit = false;
            this.gridUnit.Visible = true;
            this.gridUnit.VisibleIndex = 3;
            // 
            // gridSurplusQty
            // 
            this.gridSurplusQty.Caption = "盘盈";
            this.gridSurplusQty.ColumnEdit = this.repositoryItemSpinEdit2;
            this.gridSurplusQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridSurplusQty.FieldName = "SurplusQty";
            this.gridSurplusQty.Name = "gridSurplusQty";
            this.gridSurplusQty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gridSurplusQty.Visible = true;
            this.gridSurplusQty.VisibleIndex = 4;
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.DisplayFormat.FormatString = "0.##";
            this.repositoryItemSpinEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit2.EditFormat.FormatString = "0.##";
            this.repositoryItemSpinEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit2.HideSelection = false;
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            // 
            // gridDeficientQty
            // 
            this.gridDeficientQty.Caption = "盘亏";
            this.gridDeficientQty.ColumnEdit = this.repositoryItemSpinEdit1;
            this.gridDeficientQty.FieldName = "DeficientQty";
            this.gridDeficientQty.Name = "gridDeficientQty";
            this.gridDeficientQty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gridDeficientQty.Visible = true;
            this.gridDeficientQty.VisibleIndex = 5;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.DisplayFormat.FormatString = "0.##";
            this.repositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.EditFormat.FormatString = "0.##";
            this.repositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.HideSelection = false;
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // repositoryItemSpinEdit3
            // 
            this.repositoryItemSpinEdit3.AutoHeight = false;
            this.repositoryItemSpinEdit3.DisplayFormat.FormatString = "0.######";
            this.repositoryItemSpinEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit3.EditFormat.FormatString = "0.######";
            this.repositoryItemSpinEdit3.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit3.Name = "repositoryItemSpinEdit3";
            // 
            // gridRemark
            // 
            this.gridRemark.Caption = "备注";
            this.gridRemark.FieldName = "Remark";
            this.gridRemark.Name = "gridRemark";
            this.gridRemark.Visible = true;
            this.gridRemark.VisibleIndex = 6;
            // 
            // gridMaterialGuid
            // 
            this.gridMaterialGuid.Caption = "MaterialGuid";
            this.gridMaterialGuid.FieldName = "MaterialGuid";
            this.gridMaterialGuid.Name = "gridMaterialGuid";
            this.gridMaterialGuid.Visible = true;
            this.gridMaterialGuid.VisibleIndex = 7;
            // 
            // gridMaterialId
            // 
            this.gridMaterialId.Caption = "条码号";
            this.gridMaterialId.FieldName = "MaterialId";
            this.gridMaterialId.Name = "gridMaterialId";
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            this.repositoryItemCalcEdit1.ShowPopupShadow = false;
            this.repositoryItemCalcEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryItemPopupContainerEdit1
            // 
            this.repositoryItemPopupContainerEdit1.AutoHeight = false;
            this.repositoryItemPopupContainerEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label15.Location = new System.Drawing.Point(-397, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(1078, 14);
            this.label15.TabIndex = 74;
            this.label15.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________";
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Location = new System.Drawing.Point(15, 154);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(87, 29);
            this.btnAddDetail.TabIndex = 75;
            this.btnAddDetail.Text = "增加明细";
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // btnDelDetail
            // 
            this.btnDelDetail.Location = new System.Drawing.Point(115, 154);
            this.btnDelDetail.Name = "btnDelDetail";
            this.btnDelDetail.Size = new System.Drawing.Size(87, 29);
            this.btnDelDetail.TabIndex = 76;
            this.btnDelDetail.Text = "删除明细";
            this.btnDelDetail.UseVisualStyleBackColor = true;
            this.btnDelDetail.Click += new System.EventHandler(this.btnDelDetail_Click);
            // 
            // btnStore
            // 
            this.btnStore.Location = new System.Drawing.Point(223, 154);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(87, 29);
            this.btnStore.TabIndex = 77;
            this.btnStore.Text = "库存相关";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // txtCreatePerson
            // 
            this.txtCreatePerson.BackColor = System.Drawing.Color.White;
            this.txtCreatePerson.Enabled = false;
            this.txtCreatePerson.Location = new System.Drawing.Point(72, 583);
            this.txtCreatePerson.Name = "txtCreatePerson";
            this.txtCreatePerson.Size = new System.Drawing.Size(101, 22);
            this.txtCreatePerson.TabIndex = 81;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 587);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 14);
            this.label11.TabIndex = 80;
            this.label11.Text = "制单人";
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.BackColor = System.Drawing.Color.White;
            this.txtCreateDate.Enabled = false;
            this.txtCreateDate.Location = new System.Drawing.Point(250, 586);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Size = new System.Drawing.Size(133, 22);
            this.txtCreateDate.TabIndex = 83;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(181, 587);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 14);
            this.label12.TabIndex = 82;
            this.label12.Text = "制单时间";
            // 
            // txtCheckDate
            // 
            this.txtCheckDate.BackColor = System.Drawing.Color.White;
            this.txtCheckDate.Enabled = false;
            this.txtCheckDate.Location = new System.Drawing.Point(617, 587);
            this.txtCheckDate.Name = "txtCheckDate";
            this.txtCheckDate.Size = new System.Drawing.Size(125, 22);
            this.txtCheckDate.TabIndex = 87;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(548, 590);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 14);
            this.label13.TabIndex = 86;
            this.label13.Text = "审核时间";
            // 
            // txtCheckPerson
            // 
            this.txtCheckPerson.BackColor = System.Drawing.Color.White;
            this.txtCheckPerson.Enabled = false;
            this.txtCheckPerson.Location = new System.Drawing.Point(440, 587);
            this.txtCheckPerson.Name = "txtCheckPerson";
            this.txtCheckPerson.Size = new System.Drawing.Size(101, 22);
            this.txtCheckPerson.TabIndex = 85;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(391, 590);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 14);
            this.label14.TabIndex = 84;
            this.label14.Text = "审核人";
            // 
            // txtAutoBillID
            // 
            this.txtAutoBillID.BackColor = System.Drawing.Color.White;
            this.txtAutoBillID.Enabled = false;
            this.txtAutoBillID.Location = new System.Drawing.Point(328, 96);
            this.txtAutoBillID.Name = "txtAutoBillID";
            this.txtAutoBillID.Size = new System.Drawing.Size(160, 22);
            this.txtAutoBillID.TabIndex = 89;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(278, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 14);
            this.label16.TabIndex = 88;
            this.label16.Text = "编号";
            // 
            // txtGuid
            // 
            this.txtGuid.Location = new System.Drawing.Point(337, 156);
            this.txtGuid.Name = "txtGuid";
            this.txtGuid.Size = new System.Drawing.Size(41, 22);
            this.txtGuid.TabIndex = 90;
            this.txtGuid.Visible = false;
            // 
            // frmCheckBillAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 618);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtGuid);
            this.Controls.Add(this.txtAutoBillID);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtCheckDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCheckPerson);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCreateDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCreatePerson);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.btnDelDetail);
            this.Controls.Add(this.btnAddDetail);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboHandlePerson);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cboDepot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label15);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCheckBillAdd";
            this.Text = "盘点单添加";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbCheckPass;
        private System.Windows.Forms.ToolStripButton tsbCheckNoPass;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDepot;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cboHandlePerson;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.Button btnDelDetail;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.TextBox txtCreatePerson;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCreateDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCheckDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCheckPerson;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAutoBillID;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialName;
        private DevExpress.XtraGrid.Columns.GridColumn gridSpec;
        private DevExpress.XtraGrid.Columns.GridColumn gridUnit;
        private DevExpress.XtraGrid.Columns.GridColumn gridSurplusQty;
        private DevExpress.XtraGrid.Columns.GridColumn gridRemark;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialGuid;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private System.Windows.Forms.TextBox txtGuid;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialId;
        private DevExpress.XtraGrid.Columns.GridColumn gridDeficientQty;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn gridClassName;
    }
}