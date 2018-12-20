using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace StorageManage
{
    public partial class XtraReportBillI : DevExpress.XtraReports.UI.XtraReport
    {
        public DataSet ds;
        public XtraReportBillI(DataSet dataset)
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
            //lblBillAutoID.DataBindings.Add("Text", DataSource, "BillAutoID");
            //lblBillDate.DataBindings.Add("Text", DataSource, "BillDate");
            //lblDepotGuid.DataBindings.Add("Text", DataSource, "DepotGuid");
            //lblStorageTypeGuid.DataBindings.Add("Text", DataSource, "StorageTypeGuid");
            //SupplierGuid.DataBindings.Add("Text", DataSource, "SupplierGuid");
            //xrTableCell6.DataBindings.Add("Text", DataSource, "DeptGuid");
            //xrTableCell7.DataBindings.Add("Text", DataSource, "HandlePerson");
            //xrTableCell8.DataBindings.Add("Text", DataSource, "Remark");
            lblBillAutoID.Text = ds.Tables[0].Rows[0]["BillAutoID"].ToString();
            lblBillDate.Text = ds.Tables[0].Rows[0]["BillDate"].ToString();
            lblDepotGuid.Text = ds.Tables[0].Rows[0]["DepotGuid"].ToString();
            lblStorageTypeGuid.Text = ds.Tables[0].Rows[0]["StorageTypeGuid"].ToString();
            //SupplierGuid.Text = ds.Tables[0].Rows[0]["SupplierGuid"].ToString();
        
            xrTableCell7.Text = ds.Tables[0].Rows[0]["HandlePerson"].ToString();
            xrTableCell8.Text = ds.Tables[0].Rows[0]["Remark"].ToString();


            //明细表
            this.DataSource = ds.Tables[1];
            xrTableCell1.DataBindings.Add("Text", DataSource, "dtlBillDetail.MaterialName");
            xrTableCell2.DataBindings.Add("Text", DataSource, "dtlBillDetail.Spec");
            //xrTableCell3.DataBindings.Add("Text", DataSource, "dtlBillDetail.Unit");
            //xrTableCell5.DataBindings.Add("Text", DataSource, "dtlBillDetail.Price");
            xrTableCell9.DataBindings.Add("Text", DataSource, "dtlBillDetail.Qty");
            //xrTableCell17.DataBindings.Add("Text", DataSource, "dtlBillDetail.Total");
            xrTableCell18.DataBindings.Add("Text", DataSource, "dtlBillDetail.Remark");
            xrBarCode2.DataBindings.Add("Text", DataSource, "dtlBillDetail.MaterialId");

            decimal qty = 0;
            decimal total = 0;
            for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
            {
                qty = qty + decimal.Parse(ds.Tables[1].Rows[i]["Qty"].ToString());
                //total = total + decimal.Parse(ds.Tables[1].Rows[i]["total"].ToString());
            }

            xrLabel10.Text = qty.ToString();
            xrLabel11.Text = total.ToString();


        }




    }



}
