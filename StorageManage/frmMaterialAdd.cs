using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using StorageManageLibrary;

namespace StorageManage
{
    public partial class frmMaterialAdd :frmBase
    {
        MaterialManage MaterialManage = new MaterialManage();
        public static frmMaterialAdd frmmaterialadd;
        private bool IsEdit = false;
        public  int Invalue = 0;//���Ϊ1���Ǵӵ������Ǳ�������
        DataSet ds = new DataSet();

        
        /// <summary>
        /// ��Ʒ����
        /// </summary>
        public frmMaterialAdd()
        {
            InitializeComponent();
            frmmaterialadd = this;
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// �������б���ͨ�÷���
        /// </summary>
        public void cboDataBind(ComboBox obj, int flag)
        {
            BasicDataManage BasicDataManage = new BasicDataManage();
            obj.Items.Clear();

            DataTable dtl = BasicDataManage.GetBasicData(flag);
            for (int i = 0; i < dtl.Rows.Count; i++)
            {
                obj.Items.Add(dtl.Rows[i]["UnitName"].ToString());
            }
           

        }

        private void frmMaterialAdd_Load(object sender, EventArgs e)
        {
           
        }

        private void LoadCboBindData()
        {
            //��λ
            cboDataBind(cboUnit, 1);
            //�ͺ�
            cboDataBind(cboSpec, 2);

            //��װ
            //cboDataBind(cboEncapsulation, 3);
            //�Ƽ۷�
           // cboDataBind(cboCalculateMethod, 4);
        }

        //����
        public void MaterialAdd(string classid,string classname)
        {
            txtClass.Text = classname;
            txtClass.Tag = classid;

            IsEdit = false;
            LoadCboBindData();

            if (txtGuid.Text == "")
            {
                txtGuid.Text = Guid.NewGuid().ToString();
            }

            this.ShowDialog();
        
        }

        //�༭
        public void MaterialEdit(string MaterialGuid)
        {

            IsEdit = true;

            frmmaterialadd.Text = "��Ʒ�༭";

            LoadCboBindData();

            FillData(MaterialGuid);

            

        }


        //����ʱ��ѡ���Ʒ���ര�ڷ��������ø����ֵ
        public void GetMaterialClass(string classid, string classname)
        {
            txtClass.Text = classname;
            txtClass.Tag = classid;
        }

        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="MaterialGuid"></param>
        private void FillData(string MaterialGuid)
        {
        

            DataTable dtl = MaterialManage.GetMaterial(MaterialGuid);
            ds.Tables.Clear();
            ds.Tables.Add(dtl.Copy());
            ds.Tables[0].TableName = "dtlMaterial";



            if (dtl.Rows.Count > 0)
            {
                txtGuid.Text = dtl.Rows[0]["MaterialGuId"].ToString();
                txtMaterialId.Text = dtl.Rows[0]["MaterialId"].ToString();
                txtMaterialName.Text = dtl.Rows[0]["MaterialName"].ToString();
                cboSpec.Text = dtl.Rows[0]["Spec"].ToString();
                textProNo.Text = dtl.Rows[0]["ProNo"].ToString();
                textCadNo.Text = dtl.Rows[0]["CadNo"].ToString();
                cboUnit.Text = dtl.Rows[0]["Unit"].ToString();
                txtClass.Text = dtl.Rows[0]["ClassName"].ToString();
                txtClass.Tag = dtl.Rows[0]["Classid"].ToString();              
                textjz.Text = dtl.Rows[0]["jz"].ToString();              
                date.Text = dtl.Rows[0]["scrq"].ToString();
                textRemark.Text = dtl.Rows[0]["Remark"].ToString();
               
                //txtscrq.Text = dtl.Rows[0]["BarNo"].ToString();
                //txtPlace.Text = dtl.Rows[0]["Place"].ToString();
                // cboCalculateMethod.Text = dtl.Rows[0]["CalculateMethod"].ToString();
                //cboEncapsulation.Text = dtl.Rows[0]["Encapsulation"].ToString();
                //txtRemark.Text = dtl.Rows[0]["Remark"].ToString();

                //txtUpperLimit.Text = dtl.Rows[0]["UpperLimit"].ToString();
                //txtLowerLimit.Text = dtl.Rows[0]["LowerLimit"].ToString();
                //txtIConsultPrice.Text = dtl.Rows[0]["IConsultPrice"].ToString();
                //txtEConsultPrice.Text = dtl.Rows[0]["EConsultPrice"].ToString();
            }

            this.ShowDialog();
        }

        //����
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtClass.Text.Trim()== "")
            {
                this.ShowAlertMessage("��ѡ���Ʒ����!");
                return;
            }
            if (txtMaterialName.Text.Trim() == "")
            {
                this.ShowAlertMessage("�������Ʒ����!");
                txtMaterialName.Focus();
                return;
            }
            if (cboUnit.Text.Trim() == "")
            {
                this.ShowAlertMessage("�����뵥λ!");
                cboUnit.Focus();
                return;
            }
            //if (cboSpec.Text.Trim()== "")
            //{
            //    this.ShowAlertMessage("�������ͺ�!");
            //    cboSpec.Focus();
            //    return;
            //}


             MaterialManage MaterialManage = new MaterialManage();

            //���Ǳ༭�޸�ʱ�Ž����жϣ���ȷ�������Ͻ�������Ϊ�༭�޸�
             if (IsEdit == false)
             {
                 //�жϵ�ǰ�ϼ��Ƿ��Ѿ�������ͬ��,����Ѿ������������ʾ
                 if (MaterialManage.IsExistMaterial(txtClass.Tag.ToString(),txtMaterialName.Text.Trim(), txtMaterialId.Text.Trim(), date.Text.Trim(),
                                                     cboSpec.Text.Trim(), cboUnit.Text.Trim()))
                 {
                     this.ShowAlertMessage("������Ļ�Ʒ��Ϣ�Ѿ�����,���޸ĺ���ȷ��!");
                     return;
                 }
             }
            
           
            Material material = new Material();
            material.MaterialGuid = txtGuid.Text;
            material.MaterialId = txtMaterialId.Text;
            material.MaterialName = txtMaterialName.Text;
            material.Spec = cboSpec.Text;
            material.Unit = cboUnit.Text;
            material.ClassId = txtClass.Tag.ToString();  
            material.Zj= textzj.Text;
            material.Gh = textgh.Text;
            material.Bz = textbz.Text;
            material.Qd = textqd.Text;
            material.Cd = textcd.Text;
            material.Jz = textjz.Text;
            material.Mz = textmz.Text;
            material.Scrq = Convert.ToDateTime(date.Text);
            material.Remark = textRemark.Text;
            material.CadNo = textCadNo.Text;
            material.ProNo = textProNo.Text;
          


            //material.Place =txtPlace.Text;
            //material.CalculateMethod = cboCalculateMethod.Text;
            //material.Encapsulation = cboEncapsulation.Text;
            //material.Remark = txtRemark.Text;

            //if (txtUpperLimit.Text == "")
            //{
            //    material.UpperLimit = 0;
            //}
            //else
            //{
            //    material.UpperLimit = int.Parse(txtUpperLimit.Text);
            //}
            //if (txtLowerLimit.Text == "")
            //{
            //    material.LowerLimit = 0;
            //}
            //else
            //{
            //    material.LowerLimit = int.Parse(txtLowerLimit.Text);
            //}

            //if (txtIConsultPrice.Text == "")
            //{
            //    material.IConsultPrice = 0;
            //}
            //else
            //{
            //    material.IConsultPrice = decimal.Parse(txtIConsultPrice.Text);
            //}

            //if (txtEConsultPrice.Text == "")
            //{
            //    material.EConsultPrice = 0;
            //}
            //else
            //{
            //    material.EConsultPrice = decimal.Parse(txtEConsultPrice.Text);
            //}

            //����
            MaterialManage.Save(material);

          
          
            IsEdit = false;

            txtGuid.Text = Guid.NewGuid().ToString();

            //ˢ��
            string strsql = " where ClassId='" + txtClass.Tag.ToString() + "'";

            //����Ǵӵ����������������ˢ�¸�����
            if (Invalue == 0)
            {
                frmMaterial.frmmaterial.LoadMaterial(strsql);
            }
            Close();
           
        }

       
        /// <summary>
        /// ѡ���Ʒ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmSelectType frmSelectType = new frmSelectType();
            frmSelectType.ShowDialog();
        }
        /// <summary>
        /// ��ӡ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBarCodePrint_Click(object sender, EventArgs e)
        {
          
            XtraBarCode xtraBarCode = new XtraBarCode(ds);
            xtraBarCode.ShowPreview();
        }
    }
}