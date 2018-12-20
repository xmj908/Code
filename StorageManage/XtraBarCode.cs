using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace StorageManage
{
    public partial class XtraBarCode : DevExpress.XtraReports.UI.XtraReport
    {
     
        public DataSet ds;
        public XtraBarCode(DataSet dataset)
        {
            InitializeComponent();
  
            ds = dataset;

            DataBind();
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void DataBind()
        {
            this.DataSource = ds;
          
            xrBarCode1.Text= ds.Tables[0].Rows[0]["MaterialId"].ToString();
            xrLabel2.Text = ds.Tables[0].Rows[0]["ProNo"].ToString();
            xrLabel4.Text = ds.Tables[0].Rows[0]["CadNo"].ToString();
            xrLabel6.Text = ds.Tables[0].Rows[0]["MaterialName"].ToString();      
            xrLabel8.Text = ds.Tables[0].Rows[0]["Spec"].ToString();
        }
    }
}
