using DevExpress.XtraEditors;
using HslCommunication;
using HslCommunication.Profinet.Siemens;
using StorageManage.Properties;
using StorageManageLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManage
{
    public partial class frmWarehouseState : frmBase
    {
        
        SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, "192.168.99.152")
        {
            ConnectTimeOut = 50
        };
        
        public frmWarehouseState()
        {
            InitializeComponent();
        }

        private void frmWarehouseState_Load(object sender, EventArgs e)
        {
            OperateResult connect = siemensTcpNet.ConnectServer();
            DepotManage DepotManage = new DepotManage();
            BillManage billManage = new BillManage();
            DataTable dtrk = new DataTable();
            string strsql1 = "";
            string strsql2 = "";
            string strsql3 = "";
            string strDepot = "1";
            string strsql4 = "";
            string strsql5 = "";
            int a = Convert.ToInt32(strDepot);
            for (a = 1; a < 50; a++)
            {
                strsql1 = "";
                strsql2 = "";
                strsql3 = "";
                strDepot = "";
                strsql4 = "";
                strsql5 = "";
                strsql1 = strsql1 + " and depotguid=\"" + a.ToString().Replace("'", "''") + "\"";
                strsql2 = strsql2 + " and DepotIn=\"" + a.ToString().Replace("'", "''") + "\"";
                strsql3 = strsql3 + " and DepotOut=\"" + a.ToString().Replace("'", "''") + "\"";
                strDepot = a.ToString().Replace("'", "''");
                strsql5 = strsql5 + " and Depot=\"" + a.ToString().Replace("'", "''") + "\"";
                dtrk = billManage.sp_GetDepotMaterailSum(strsql1, strsql2, strsql3, strDepot, strsql4, strsql5);
                decimal sumQty = Convert.ToDecimal(dtrk.Compute("sum(Qty)", "TRUE"));
                if (sumQty !=0)
                { 
                string picture = "pictureEdit" + a;
                Control[] ctrls = this.Controls.Find(picture, true);
                PictureEdit pe = (PictureEdit)ctrls[0];
                pe.EditValue = Resources.boproduct_32x32;
                }



            }
        }
        public  void con()
        {
            string ip = "192.168.99.152";
            SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            {
                ConnectTimeOut = 50
            };
            OperateResult connect = siemensTcpNet.ConnectServer();
        }

        private void sn_Click(object sender, EventArgs e)
        {
            
            
            siemensTcpNet.Write("M18.5", false);
        }

        private void jt_Click(object sender, EventArgs e)
        {
            //string ip = "192.168.99.152";
            //SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            //{
            //    ConnectTimeOut = 5000
            //};
            //OperateResult connect = siemensTcpNet.ConnectServer();
            siemensTcpNet.Write("M20.1", true);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //string ip = "192.168.99.152";
            //SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            //{
            //    ConnectTimeOut = 5000
            //};

            //OperateResult connect = siemensTcpNet.ConnectServer();
            siemensTcpNet.Write("DB22.88.4", true);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //string ip = "192.168.99.152";
            //SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            //{
            //    ConnectTimeOut = 5000
            //};

            //OperateResult connect = siemensTcpNet.ConnectServer();
            siemensTcpNet.Write("DB22.88.3", true);
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            //string ip = "192.168.99.152";
            //SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            //{
            //    ConnectTimeOut = 5000
            //};

            //OperateResult connect = siemensTcpNet.ConnectServer();
            siemensTcpNet.Write("DB22.88.6", true);
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            //string ip = "192.168.99.152";
            //SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            //{
            //    ConnectTimeOut = 5000
            //};

            //OperateResult connect = siemensTcpNet.ConnectServer();
            siemensTcpNet.Write("DB22.88.5", true);
        }

        private void pictureEdit11_Click(object sender, EventArgs e)
        {
            //string ip = "192.168.99.152";
            //SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            //{
            //    ConnectTimeOut = 5000
            //};
            //OperateResult connect = siemensTcpNet.ConnectServer();            
            siemensTcpNet.Write("DB22.150", -1110f);
            siemensTcpNet.Write("DB22.158", 630f);
            siemensTcpNet.Write("DB22.154", 0f);
            if (pictureEdit11.EditValue == null)
            {
                pictureEdit11.EditValue = Resources.boproduct_32x32;
                
            }
            else
            {
                pictureEdit11.EditValue = null;
            }
        }

        private void pictureEdit13_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -1110f);
            siemensTcpNet.Write("DB22.158", 630f);
            siemensTcpNet.Write("DB22.154", 1310f);
            if (pictureEdit13.EditValue == null)
            {
                pictureEdit13.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit13.EditValue = null;
            }
        }

        private void pictureEdit15_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -1110f);
            siemensTcpNet.Write("DB22.158", 630f);
            siemensTcpNet.Write("DB22.154", 2620f);
            if (pictureEdit15.EditValue == null)
            {
                pictureEdit15.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit15.EditValue = null;
            }
        }

        private void pictureEdit17_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -1110f);
            siemensTcpNet.Write("DB22.158", 630f);
            siemensTcpNet.Write("DB22.154", 3930f);
            if (pictureEdit17.EditValue == null)
            {
                pictureEdit17.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit17.EditValue = null;
            }
        }

        private void pictureEdit19_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -1110f);
            siemensTcpNet.Write("DB22.158", 630f);
            siemensTcpNet.Write("DB22.154", 5240f);
            if (pictureEdit19.EditValue == null)
            {
                pictureEdit19.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit19.EditValue = null;
            }
        }

        private void pictureEdit21_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -2220f);
            siemensTcpNet.Write("DB22.158", 630f);
            siemensTcpNet.Write("DB22.154", 0f);
            if (pictureEdit21.EditValue == null)
            {
                pictureEdit21.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit21.EditValue = null;
            }
        }

        private void pictureEdit23_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -2220f);
            siemensTcpNet.Write("DB22.158", 630f);
            siemensTcpNet.Write("DB22.154", 1310f);
            if (pictureEdit23.EditValue == null)
            {
                pictureEdit23.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit23.EditValue = null;
            }
        }

        private void pictureEdit25_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -2220f);
            siemensTcpNet.Write("DB22.158", 630f);
            siemensTcpNet.Write("DB22.154", 2620f);
            if (pictureEdit25.EditValue == null)
            {
                pictureEdit25.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit25.EditValue = null;
            }
        }

        private void pictureEdit27_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -2220f);
            siemensTcpNet.Write("DB22.158", 630f);
            siemensTcpNet.Write("DB22.154", 3930f);
            if (pictureEdit27.EditValue == null)
            {
                pictureEdit27.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit27.EditValue = null;
            }
        }

        private void pictureEdit29_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -2220f);
            siemensTcpNet.Write("DB22.158", 630f);
            siemensTcpNet.Write("DB22.154", 5240f);
            if (pictureEdit29.EditValue == null)
            {
                pictureEdit29.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit29.EditValue = null;
            }
        }

        private void pictureEdit31_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -3340f);
            siemensTcpNet.Write("DB22.158", 630f);
            siemensTcpNet.Write("DB22.154", 0f);
            if (pictureEdit31.EditValue == null)
            {
                pictureEdit31.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit31.EditValue = null;
            }
        }

        private void pictureEdit33_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -3340f);
            siemensTcpNet.Write("DB22.158", 630f);
            siemensTcpNet.Write("DB22.154", 1310f);
            if (pictureEdit33.EditValue == null)
            {
                pictureEdit33.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit33.EditValue = null;
            }
        }

        private void pictureEdit35_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -3340f);
            siemensTcpNet.Write("DB22.158", 630f);
            siemensTcpNet.Write("DB22.154", 2620f);
            if (pictureEdit35.EditValue == null)
            {
                pictureEdit35.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit18.EditValue = null;
            }
        }

        private void pictureEdit37_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -3340f);
            siemensTcpNet.Write("DB22.158", 630f);
            siemensTcpNet.Write("DB22.154", 3930f);
            if (pictureEdit37.EditValue == null)
            {
                pictureEdit37.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit37.EditValue = null;
            }
        }

        private void pictureEdit39_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -3340f);
            siemensTcpNet.Write("DB22.158", 630f);
            siemensTcpNet.Write("DB22.154", 5240f);
            if (pictureEdit39.EditValue == null)
            {
                pictureEdit39.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit39.EditValue = null;
            }
        }

        private void pictureEdit41_Click(object sender, EventArgs e)
        {

        }

        private void pictureEdit43_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -4450f);
            siemensTcpNet.Write("DB22.158", 630f);
            siemensTcpNet.Write("DB22.154", 1310f);
            if (pictureEdit43.EditValue == null)
            {
                pictureEdit43.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit43.EditValue = null;
            }
        }

        private void pictureEdit45_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -4450f);
            siemensTcpNet.Write("DB22.158", 630f);
            siemensTcpNet.Write("DB22.154", 2620f);
            if (pictureEdit45.EditValue == null)
            {
                pictureEdit45.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit45.EditValue = null;
            }
        }

        private void pictureEdit47_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -4450f);
            siemensTcpNet.Write("DB22.158", 630f);
            siemensTcpNet.Write("DB22.154", 3930f);
            if (pictureEdit47.EditValue == null)
            {
                pictureEdit47.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit47.EditValue = null;
            }
        }

        private void pictureEdit49_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -4450f);
            siemensTcpNet.Write("DB22.158", 630f);
            siemensTcpNet.Write("DB22.154", 5240f);
            if (pictureEdit49.EditValue == null)
            {
                pictureEdit49.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit49.EditValue = null;
            }
        }

        private void pictureEdit12_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -1110f);
            siemensTcpNet.Write("DB22.158", -630f);
            siemensTcpNet.Write("DB22.154", 0f);
            if (pictureEdit12.EditValue == null)
            {
                pictureEdit12.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit12.EditValue = null;
            }
        }

        private void pictureEdit14_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -1110f);
            siemensTcpNet.Write("DB22.158", -630f);
            siemensTcpNet.Write("DB22.154", 1310f);
            if (pictureEdit14.EditValue == null)
            {
                pictureEdit14.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit14.EditValue = null;
            }
        }

        private void pictureEdit16_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -1110f);
            siemensTcpNet.Write("DB22.158", -630f);
            siemensTcpNet.Write("DB22.154", 2620f);
            if (pictureEdit16.EditValue == null)
            {
                pictureEdit16.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit16.EditValue = null;
            }
        }

        private void pictureEdit18_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -1110f);
            siemensTcpNet.Write("DB22.158", -630f);
            siemensTcpNet.Write("DB22.154", 3930f);
            if (pictureEdit18.EditValue == null)
            {
                pictureEdit18.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit18.EditValue = null;
            }
        }

        private void pictureEdit20_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -1110f);
            siemensTcpNet.Write("DB22.158", -630f);
            siemensTcpNet.Write("DB22.154", 5240f);
            if (pictureEdit20.EditValue == null)
            {
                pictureEdit20.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit20.EditValue = null;
            }
        }

        private void pictureEdit22_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -2220f);
            siemensTcpNet.Write("DB22.158", -630f);
            siemensTcpNet.Write("DB22.154", 0f);
            if (pictureEdit22.EditValue == null)
            {
                pictureEdit22.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit22.EditValue = null;
            }
        }

        private void pictureEdit24_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -2220f);
            siemensTcpNet.Write("DB22.158", -630f);
            siemensTcpNet.Write("DB22.154", 1310f);
            if (pictureEdit24.EditValue == null)
            {
                pictureEdit24.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit24.EditValue = null;
            }
        }

        private void pictureEdit26_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -2220f);
            siemensTcpNet.Write("DB22.158", -630f);
            siemensTcpNet.Write("DB22.154", 2620f);
            if (pictureEdit26.EditValue == null)
            {
                pictureEdit26.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit26.EditValue = null;
            }
        }

        private void pictureEdit28_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -2220f);
            siemensTcpNet.Write("DB22.158", -630f);
            siemensTcpNet.Write("DB22.154", 3930f);
            if (pictureEdit28.EditValue == null)
            {
                pictureEdit28.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit28.EditValue = null;
            }
        }

        private void pictureEdit30_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -2220f);
            siemensTcpNet.Write("DB22.158", -630f);
            siemensTcpNet.Write("DB22.154", 5240f);
            if (pictureEdit30.EditValue == null)
            {
                pictureEdit30.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit30.EditValue = null;
            }
        }

        private void pictureEdit32_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -3340f);
            siemensTcpNet.Write("DB22.158", -630f);
            siemensTcpNet.Write("DB22.154", 0f);
            if (pictureEdit32.EditValue == null)
            {
                pictureEdit32.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit32.EditValue = null;
            }
        }

        private void pictureEdit34_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -3340f);
            siemensTcpNet.Write("DB22.158", -630f);
            siemensTcpNet.Write("DB22.154", 1310f);
            if (pictureEdit34.EditValue == null)
            {
                pictureEdit34.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit34.EditValue = null;
            }
        }

        private void pictureEdit36_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -3340f);
            siemensTcpNet.Write("DB22.158", -630f);
            siemensTcpNet.Write("DB22.154", 2620f);
            if (pictureEdit36.EditValue == null)
            {
                pictureEdit36.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit36.EditValue = null;
            }
        }

        private void pictureEdit38_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -3340f);
            siemensTcpNet.Write("DB22.158", -630f);
            siemensTcpNet.Write("DB22.154", 3930f);
            if (pictureEdit38.EditValue == null)
            {
                pictureEdit38.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit38.EditValue = null;
            }
        }

        private void pictureEdit40_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -3340f);
            siemensTcpNet.Write("DB22.158", -630f);
            siemensTcpNet.Write("DB22.154", 5240f);
            if (pictureEdit40.EditValue == null)
            {
                pictureEdit40.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit40.EditValue = null;
            }
        }

        private void pictureEdit42_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -4450f);
            siemensTcpNet.Write("DB22.158", -630f);
            siemensTcpNet.Write("DB22.154", 0f);
            if (pictureEdit42.EditValue == null)
            {
                pictureEdit42.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit42.EditValue = null;
            }
        }

        private void pictureEdit44_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -4450f);
            siemensTcpNet.Write("DB22.158", -630f);
            siemensTcpNet.Write("DB22.154", 1310f);
            if (pictureEdit44.EditValue == null)
            {
                pictureEdit44.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit44.EditValue = null;
            }
        }

        private void pictureEdit46_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -4450f);
            siemensTcpNet.Write("DB22.158", -630f);
            siemensTcpNet.Write("DB22.154", 4460f);
            if (pictureEdit46.EditValue == null)
            {
                pictureEdit46.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit46.EditValue = null;
            }
        }

        private void pictureEdit48_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -4450f);
            siemensTcpNet.Write("DB22.158", -630f);
            siemensTcpNet.Write("DB22.154", 3930f);
            if (pictureEdit48.EditValue == null)
            {
                pictureEdit48.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit48.EditValue = null;
            }
        }

        private void pictureEdit50_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", -4450f);
            siemensTcpNet.Write("DB22.158", -630f);
            siemensTcpNet.Write("DB22.154", 5240f);
            if (pictureEdit50.EditValue == null)
            {
                pictureEdit50.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit50.EditValue = null;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //panelControl1.Refresh();
            //panelControlR.Refresh();
          
            DepotManage DepotManage = new DepotManage();
            BillManage billManage = new BillManage();
            DataTable dtrk = new DataTable();
            string strsql1 = "";
            string strsql2 = "";
            string strsql3 = "";
            string strDepot = "1";
            string strsql4 = "";
            string strsql5 = "";
            int a = Convert.ToInt32(strDepot);
            for (a = 1; a < 50; a++)
            {
                strsql1 = "";
                strsql2 = "";
                strsql3 = "";
                strDepot = "";
                strsql4 = "";
                strsql5 = "";
                strsql1 = strsql1 + " and depotguid=\"" + a.ToString().Replace("'", "''") + "\"";
                strsql2 = strsql2 + " and DepotIn=\"" + a.ToString().Replace("'", "''") + "\"";
                strsql3 = strsql3 + " and DepotOut=\"" + a.ToString().Replace("'", "''") + "\"";
                strDepot = a.ToString().Replace("'", "''");
                strsql5 = strsql5 + " and Depot=\"" + a.ToString().Replace("'", "''") + "\"";
                dtrk = billManage.sp_GetDepotMaterailSum(strsql1, strsql2, strsql3, strDepot, strsql4, strsql5);
                decimal sumQty = Convert.ToDecimal(dtrk.Compute("sum(Qty)", "TRUE"));
                string picture = "pictureEdit" + a;
                Control[] ctrls = this.Controls.Find(picture, true);
                PictureEdit pe = (PictureEdit)ctrls[0];
                pe.EditValue = null;
                if (sumQty != 0)
                {                   
                    pe.EditValue = Resources.boproduct_32x32;
                }
            }
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", 0f);
            siemensTcpNet.Write("DB22.158", 630f);
            siemensTcpNet.Write("DB22.154", 0f);
            if (pictureEdit1.EditValue == null)
            {
                pictureEdit1.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit1.EditValue = null;
            }
        }

        private void pictureEdit3_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", 0f);
            siemensTcpNet.Write("DB22.158", 630f);
            siemensTcpNet.Write("DB22.154", 1310f);
            if (pictureEdit2.EditValue == null)
            {
                pictureEdit2.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit2.EditValue = null;
            }
        }

        private void pictureEdit5_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", 0f);
            siemensTcpNet.Write("DB22.158", 630f);
            siemensTcpNet.Write("DB22.154", 2620f);
            if (pictureEdit3.EditValue == null)
            {
                pictureEdit3.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit3.EditValue = null;
            }
        }

        private void pictureEdit7_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", 0f);
            siemensTcpNet.Write("DB22.158", 630f);
            siemensTcpNet.Write("DB22.154", 3930f);
            if (pictureEdit4.EditValue == null)
            {
                pictureEdit4.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit4.EditValue = null;
            }
        }

        private void pictureEdit9_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", 0f);
            siemensTcpNet.Write("DB22.158", 630f);
            siemensTcpNet.Write("DB22.154", 5240f);
            if (pictureEdit5.EditValue == null)
            {
                pictureEdit5.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit6.EditValue = null;
            }
        }

        private void pictureEdit4_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", 0f);
            siemensTcpNet.Write("DB22.158", -630f);
            siemensTcpNet.Write("DB22.154", 1310f);
            if (pictureEdit27.EditValue == null)
            {
                pictureEdit27.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit27.EditValue = null;
            }
        }

        private void pictureEdit6_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", 0f);
            siemensTcpNet.Write("DB22.158", -630f);
            siemensTcpNet.Write("DB22.154",2620f);
            if (pictureEdit28.EditValue == null)
            {
                pictureEdit28.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit28.EditValue = null;
            }
        }

        private void pictureEdit8_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", 0f);
            siemensTcpNet.Write("DB22.158", -630f);
            siemensTcpNet.Write("DB22.154", 3930f);
            if (pictureEdit29.EditValue == null)
            {
                pictureEdit29.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit29.EditValue = null;
            }
        }

        private void pictureEdit10_Click(object sender, EventArgs e)
        {
            siemensTcpNet.Write("DB22.150", 0f);
            siemensTcpNet.Write("DB22.158", -630f);
            siemensTcpNet.Write("DB22.154", 5240f);
            if (pictureEdit30.EditValue == null)
            {
                pictureEdit30.EditValue = Resources.boproduct_32x32;
            }
            else
            {
                pictureEdit30.EditValue = null;
            }
        }
    }
    }

