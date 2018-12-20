using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using StorageManageLibrary;

namespace StorageManage
{
    /// <summary>
    /// 选择货品
    /// </summary>
    public partial class frmSelectMaterial : DevExpress.XtraEditors.XtraForm
    {
        MaterialManage MaterialManage = new MaterialManage();
        public frmSelectMaterial()
        {
            InitializeComponent();
                    
        }

        private void frmSelectMaterial_Load(object sender, EventArgs e)
        {
        
            LoadData();
        }

        //载入数据
        private void LoadData()
        {
            DataTable dtl = MaterialManage.GetSelectMaterialData_CN("where 1=1");
            this.gridControl1.DataSource = dtl;

            gridView1.Columns[0].Visible = false;

        }

        //选择
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                //int intRow = gridView1.GetSelectedRows()[0];
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();
                this.Tag = guid;

                this.Close();
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                //int intRow = gridView1.GetSelectedRows()[0];
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();
                this.Tag = guid;

                this.Close();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();
                BillManage BillManage = new BillManage();
                DataTable dtl = BillManage.sp_GetMaterialSumByDepot(guid);
                this.gridControl2.DataSource = dtl;

            }
        }

        private void txtQryValue_TextChanged(object sender, EventArgs e)
        {
            string strsql="";
            if (cboQry.Text.Trim() == "条码号")
            {
                strsql = " where MaterialId like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";
            }
            else if (cboQry.Text.Trim() == "品名")
            {
                strsql = " where MaterialName like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";
            }
            else if (cboQry.Text.Trim() == "型号")
            {
                strsql = " where Spec like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";
            }
            else if (cboQry.Text.Trim() == "项目号")
            {
                strsql = " where ProNo like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";
            }
            else if (cboQry.Text.Trim() == "图号")
            {
                strsql = " where CadNo like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";
            }
            DataTable dtl = MaterialManage.GetSelectMaterialData_CN(strsql);
            this.gridControl1.DataSource = dtl;

            gridView1.Columns[0].Visible = false;

        }

        private void frmSelectMaterial_Activated(object sender, EventArgs e)
        {
            txtQryValue.Focus();
        }

        //private void frmSelectMaterial_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (gridView1.RowCount > 0)
        //    {
        //        //int intRow = gridView1.GetSelectedRows()[0];
        //        string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();
        //        this.Tag = guid;
        //        frmBillAdd frmBillAdd = new frmBillAdd(Tag.ToString());              
        //    }
        //}
    }
}