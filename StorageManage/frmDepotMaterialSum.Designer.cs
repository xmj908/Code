namespace StorageManage
{
    partial class frmDepotMaterialSum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepotMaterialSum));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridMaterialGuID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtGuid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.txtMaterialName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaterialId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnQty = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.endDate = new DevExpress.XtraEditors.DateEdit();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboDepot = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 128);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1048, 523);
            this.gridControl1.TabIndex = 55;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.gridMaterialGuID,
            this.gridMaterialID,
            this.gridMaterialName,
            this.gridSpec,
            this.gridUnit,
            this.gridQty});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridMaterialGuID
            // 
            this.gridMaterialGuID.Caption = "MaterialGuID";
            this.gridMaterialGuID.FieldName = "MaterialGuID";
            this.gridMaterialGuID.Name = "gridMaterialGuID";
            this.gridMaterialGuID.Width = 100;
            // 
            // gridMaterialID
            // 
            this.gridMaterialID.Caption = "条码号";
            this.gridMaterialID.FieldName = "MaterialID";
            this.gridMaterialID.Name = "gridMaterialID";
            this.gridMaterialID.Visible = true;
            this.gridMaterialID.VisibleIndex = 0;
            // 
            // gridMaterialName
            // 
            this.gridMaterialName.Caption = "品名";
            this.gridMaterialName.FieldName = "MaterialName";
            this.gridMaterialName.Name = "gridMaterialName";
            this.gridMaterialName.Visible = true;
            this.gridMaterialName.VisibleIndex = 1;
            // 
            // gridSpec
            // 
            this.gridSpec.Caption = "型号";
            this.gridSpec.FieldName = "Spec";
            this.gridSpec.Name = "gridSpec";
            this.gridSpec.Visible = true;
            this.gridSpec.VisibleIndex = 2;
            // 
            // gridUnit
            // 
            this.gridUnit.Caption = "单位";
            this.gridUnit.FieldName = "Unit";
            this.gridUnit.Name = "gridUnit";
            this.gridUnit.Visible = true;
            this.gridUnit.VisibleIndex = 3;
            // 
            // gridQty
            // 
            this.gridQty.Caption = "库存";
            this.gridQty.DisplayFormat.FormatString = "0.##";
            this.gridQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridQty.FieldName = "Qty";
            this.gridQty.Name = "gridQty";
            this.gridQty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gridQty.Visible = true;
            this.gridQty.VisibleIndex = 4;
            // 
            // txtGuid
            // 
            this.txtGuid.Location = new System.Drawing.Point(846, 33);
            this.txtGuid.Name = "txtGuid";
            this.txtGuid.Size = new System.Drawing.Size(41, 22);
            this.txtGuid.TabIndex = 56;
            this.txtGuid.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.txtClassID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.txtMaterialName);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtMaterialId);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnQty);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.endDate);
            this.panel1.Controls.Add(this.txtSpec);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cboDepot);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 128);
            this.panel1.TabIndex = 114;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(730, 88);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(38, 27);
            this.btnSelect.TabIndex = 157;
            this.btnSelect.Text = "...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(573, 91);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(151, 22);
            this.txtClassID.TabIndex = 156;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 155;
            this.label4.Text = "货品类型";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExport,
            this.exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1048, 25);
            this.toolStrip1.TabIndex = 152;
            this.toolStrip1.Text = "toolStrip1";
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
            // txtMaterialName
            // 
            this.txtMaterialName.Location = new System.Drawing.Point(73, 91);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.Size = new System.Drawing.Size(151, 22);
            this.txtMaterialName.TabIndex = 141;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 14);
            this.label12.TabIndex = 140;
            this.label12.Text = "品名";
            // 
            // txtMaterialId
            // 
            this.txtMaterialId.Location = new System.Drawing.Point(557, 50);
            this.txtMaterialId.Name = "txtMaterialId";
            this.txtMaterialId.Size = new System.Drawing.Size(151, 22);
            this.txtMaterialId.TabIndex = 137;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(508, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 14);
            this.label10.TabIndex = 136;
            this.label10.Text = "条码号";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(926, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 30);
            this.button1.TabIndex = 135;
            this.button1.Text = "重置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQty
            // 
            this.btnQty.Location = new System.Drawing.Point(924, 91);
            this.btnQty.Name = "btnQty";
            this.btnQty.Size = new System.Drawing.Size(97, 30);
            this.btnQty.TabIndex = 133;
            this.btnQty.Text = "查询";
            this.btnQty.UseVisualStyleBackColor = true;
            this.btnQty.Click += new System.EventHandler(this.btnQty_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 131;
            this.label6.Text = "截止日期";
            // 
            // endDate
            // 
            this.endDate.EditValue = null;
            this.endDate.Location = new System.Drawing.Point(315, 50);
            this.endDate.Name = "endDate";
            this.endDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.endDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.endDate.Size = new System.Drawing.Size(152, 20);
            this.endDate.TabIndex = 130;
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(315, 91);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new System.Drawing.Size(151, 22);
            this.txtSpec.TabIndex = 123;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 14);
            this.label7.TabIndex = 122;
            this.label7.Text = "型号";
            // 
            // cboDepot
            // 
            this.cboDepot.FormattingEnabled = true;
            this.cboDepot.Location = new System.Drawing.Point(73, 49);
            this.cboDepot.Name = "cboDepot";
            this.cboDepot.Size = new System.Drawing.Size(151, 22);
            this.cboDepot.TabIndex = 116;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 115;
            this.label2.Text = "库位";
            // 
            // frmDepotMaterialSum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 651);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtGuid);
            this.Name = "frmDepotMaterialSum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "库存查询";
            this.Load += new System.EventHandler(this.frmBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox txtGuid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQty;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit endDate;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboDepot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMaterialName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaterialId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialGuID;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialID;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialName;
        private DevExpress.XtraGrid.Columns.GridColumn gridSpec;
        private DevExpress.XtraGrid.Columns.GridColumn gridUnit;
        private DevExpress.XtraGrid.Columns.GridColumn gridQty;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.Label label4;
    }
}