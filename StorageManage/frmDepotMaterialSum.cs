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
    /// ����ѯ
    /// </summary>
    public partial class frmDepotMaterialSum : frmBase
    {
        BillManage BillManage = new BillManage();
        public static frmDepotMaterialSum frmdepotMaterialSum;
        public frmDepotMaterialSum()
        {
            InitializeComponent();
          

            frmdepotMaterialSum = this;
        }

      

        private void frmBill_Load(object sender, EventArgs e)
        {
          
            endDate.Text = DateTime.Now.ToShortDateString();

            //�󶨲ֿ�
            DepotManage DepotManage = new DepotManage();
            DataTable dtl = DepotManage.GetDepotData();
            for (int i = 0; i < dtl.Rows.Count; i++)
            {
                cboDepot.Items.Add(dtl.Rows[i]["��λ"].ToString());
            }

            cboDepot.SelectedIndex = 0;
           // cboDepot.Text = "�ֿ�";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
           
        }
        public void GetClass(string ClassID, string ClassName)
        {
            txtClassID.Text = ClassName;
            txtClassID.Tag = ClassID;
        }

    
        //����ѯ
        private void btnQty_Click(object sender, EventArgs e)
        {
            if (cboDepot.Text == "")
            {
                this.ShowAlertMessage("��ѡ��ֿ�!");
                return;
            }
            
            
            string strsql1 = "";
            string strsql2 = "";
            string strsql3 = "";
            string strDepot = "";
            string strsql4 = "";
            string strsql5 = "";
            

            if (cboDepot.Text != "")
            {
                strsql1 = strsql1 + " and depotguid=\"" + cboDepot.Text.Replace("'", "''") + "\"";
                strsql2 = strsql2 + " and DepotIn=\"" + cboDepot.Text.Replace("'", "''") + "\"";
                strsql3 = strsql3 + " and DepotOut=\"" + cboDepot.Text.Replace("'", "''") + "\"";
                strDepot = cboDepot.Text.Replace("'", "''");
                strsql5 = strsql5 + " and Depot=\"" + cboDepot.Text.Replace("'", "''") + "\"";
            }
            if (endDate.Text != "")
            {
                strsql1 = strsql1 + " and BillDate<=\"" + endDate.Text.Replace("'", "''") + " 23:59:59\"";
                strsql2 = strsql2 + " and BillDate<=\"" + endDate.Text.Replace("'", "''") + " 23:59:59\"";
                strsql3 = strsql3 + " and BillDate<=\"" + endDate.Text.Replace("'", "''") + " 23:59:59\"";
                strsql5 = strsql5 + " and BillDate<=\"" + endDate.Text.Replace("'", "''") + " 23:59:59\"";
            }
            if (txtMaterialId.Text != "")
            {
                strsql1 = strsql1 + " and MaterialId=\"" + txtMaterialId.Text.Replace("'", "''") + "\"";
                strsql2 = strsql2 + " and MaterialId=\"" + txtMaterialId.Text.Replace("'", "''") + "\"";
                strsql3 = strsql3 + " and MaterialId=\"" + txtMaterialId.Text.Replace("'", "''") + "\"";
                strsql4 = strsql4 + " and mat.MaterialId=\"" + txtMaterialId.Text.Replace("'", "''") + "\"";
            }

            //if (txtBarNo.Text != "")
            //{
            //    strsql4 = strsql4 + " and mat.BarNo=\"" + txtBarNo.Text.Replace("'", "''") + "\"";
            //}
            if (txtMaterialName.Text != "")
            {
                strsql4 = strsql4 + " and mat.MaterialName=\"" + txtMaterialName.Text.Replace("'", "''") + "\"";
            }

            if (txtSpec.Text != "")
            {
                strsql4 = strsql4 + " and mat.Spec=\"" + txtSpec.Text.Replace("'", "''") + "\"";
            }

            if (txtClassID.Text != "")
            {
                strsql4 = strsql4 + " and mat.ClassID=\"" + txtClassID.Tag.ToString()+ "\"";
            }


            DataTable dtl = BillManage.sp_GetDepotMaterailSum(strsql1, strsql2, strsql3, strDepot, strsql4, strsql5);
            this.gridControl1.DataSource = dtl;

          
           
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Excel�ļ�|*.XLS|�����ļ�|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string filename = saveFileDialog1.FileName;
                gridView1.ExportToXls(filename);

                this.ShowMessage("�����ɹ�");
            }
        }

        //����
        private void button1_Click(object sender, EventArgs e)
        {
          
            endDate.Text = "";
            cboDepot.Text = "";
            txtMaterialId.Text = "";
            //txtBarNo.Text = "";
            txtMaterialName.Text = "";
            txtClassID.Text = "";
            txtClassID.Tag = "";
        
         

        }


        

        private void tsbExport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Excel�ļ�|*.XLS|�����ļ�|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string filename = saveFileDialog1.FileName;
                gridView1.ExportToXls(filename);

                this.ShowMessage("�����ɹ�");
            }
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmSelectType frmSelectType = new frmSelectType();
            frmSelectType.InValue = 3;//�ӿ���ѯ����
            frmSelectType.ShowDialog();
        }
    }
}