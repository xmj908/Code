namespace StorageManage
{
    partial class frmDeptAdd
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
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeptPerson = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGuid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(107, 29);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(179, 22);
            this.txtDeptName.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "部门名称";
            // 
            // txtDeptPerson
            // 
            this.txtDeptPerson.Location = new System.Drawing.Point(358, 29);
            this.txtDeptPerson.Name = "txtDeptPerson";
            this.txtDeptPerson.Size = new System.Drawing.Size(180, 22);
            this.txtDeptPerson.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "负责人";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(107, 75);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(179, 22);
            this.txtTelephone.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 14);
            this.label7.TabIndex = 25;
            this.label7.Text = "联系电话";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(107, 119);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(431, 22);
            this.txtAddress.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 14);
            this.label4.TabIndex = 27;
            this.label4.Text = "地址";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(358, 71);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(180, 22);
            this.txtFax.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 14);
            this.label6.TabIndex = 31;
            this.label6.Text = "传真";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(455, 194);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 30);
            this.btnExit.TabIndex = 37;
            this.btnExit.Text = "取消(&Q)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(329, 194);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 30);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "确定(&S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label15.Location = new System.Drawing.Point(-196, 162);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(1078, 14);
            this.label15.TabIndex = 35;
            this.label15.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________";
            // 
            // txtGuid
            // 
            this.txtGuid.Location = new System.Drawing.Point(580, 253);
            this.txtGuid.Name = "txtGuid";
            this.txtGuid.Size = new System.Drawing.Size(33, 22);
            this.txtGuid.TabIndex = 38;
            this.txtGuid.Visible = false;
            // 
            // frmDeptAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 267);
            this.Controls.Add(this.txtGuid);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDeptPerson);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeptAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "部门添加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeptPerson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtGuid;
    }
}