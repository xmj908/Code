using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HslCommunication;
using HslCommunication.Core;
using HslCommunication.LogNet;
using HslCommunication.ModBus;
using HslCommunication.Profinet.Melsec;
using HslCommunication.Profinet.Siemens;


namespace StorageManage
{

    
    public partial class frmConnectTest : DevExpress.XtraEditors.XtraForm
    {
        SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, "192.168.99.152")
        {
            ConnectTimeOut = 5000
        };
        
        public frmConnectTest()
        {
            InitializeComponent();


        }





        private void frmConnectTest_Load(object sender, EventArgs e)
        {

           

            OperateResult connect = siemensTcpNet.ConnectServer();
            bool M18_5 = siemensTcpNet.ReadBool("M18.5").Content;
            bool M20_1 = siemensTcpNet.ReadBool("M20.1").Content;
            byte byte_4 = siemensTcpNet.ReadByte("DB22.88.4").Content;
            byte byte_6 = siemensTcpNet.ReadByte("DB22.88.6").Content;
            byte byte_3 = siemensTcpNet.ReadByte("DB22.88.3").Content;
            byte byte_5 = siemensTcpNet.ReadByte("DB22.88.5").Content;
            float float_150 = siemensTcpNet.ReadFloat("DB22.150").Content;
            float float_138 = siemensTcpNet.ReadFloat("DB22.138").Content;
            float float_154 = siemensTcpNet.ReadFloat("DB22.154").Content;
            float float_142 = siemensTcpNet.ReadFloat("DB22.142").Content;
            float float_158 = siemensTcpNet.ReadFloat("DB22.158").Content;
            float float_146 = siemensTcpNet.ReadFloat("DB22.146").Content;
            float float_50 = siemensTcpNet.ReadFloat("DB22.50").Content;
            float float_54 = siemensTcpNet.ReadFloat("DB22.54").Content;
            float float_58 = siemensTcpNet.ReadFloat("DB22.58").Content;
            float float_62 = siemensTcpNet.ReadFloat("DB22.62").Content;
            float float_66 = siemensTcpNet.ReadFloat("DB22.66").Content;
            float float_70 = siemensTcpNet.ReadFloat("DB22.70").Content;
            textEdit1.Text = M18_5.ToString();
            textEdit16.Text = M20_1.ToString();
            textEdit2.Text = byte_4.ToString();
            textEdit3.Text = byte_3.ToString();
            textEdit15.Text = byte_6.ToString();
            textEdit14.Text = byte_5.ToString();
            textEdit4.Text = float_150.ToString();
            textEdit5.Text = float_138.ToString();
            textEdit17.Text = float_154.ToString();
            textEdit7.Text = float_142.ToString();
            textEdit13.Text = float_158.ToString();
            textEdit8.Text = float_158.ToString();
            textEdit12.Text = float_146.ToString();
            textEdit9.Text = float_146.ToString();
            textEdit11.Text = float_50.ToString();
            textEdit10.Text = float_54.ToString();
            textEdit23.Text = float_58.ToString();
            textEdit22.Text = float_62.ToString();
            textEdit21.Text = float_66.ToString();
            textEdit20.Text = float_70.ToString();

        }

        public  void connect()
        {
            string ip = "192.168.99.152";
            SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            {
                ConnectTimeOut = 5000
            };

            OperateResult connect = siemensTcpNet.ConnectServer();
            //if (connect.IsSuccess)
            //{
            //    MessageBox.Show("连接成功！");
            //}
            //else
            //{
            //    MessageBox.Show("连接失败！");
            //}
        }
        public  void refresh()
        {
            //string ip = "192.168.99.152";
            //SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            //{
            //    ConnectTimeOut = 5000
            //};

            
            bool M18_5 = siemensTcpNet.ReadBool("M18.5").Content;
            bool M20_1 = siemensTcpNet.ReadBool("M20.1").Content;
            byte byte_4 = siemensTcpNet.ReadByte("DB22.88.4").Content;
            byte byte_6 = siemensTcpNet.ReadByte("DB22.88.6").Content;
            byte byte_3 = siemensTcpNet.ReadByte("DB22.88.3").Content;
            byte byte_5 = siemensTcpNet.ReadByte("DB22.88.5").Content;
            float float_150 = siemensTcpNet.ReadFloat("DB22.150").Content;
            float float_138 = siemensTcpNet.ReadFloat("DB22.138").Content;
            float float_154 = siemensTcpNet.ReadFloat("DB22.154").Content;
            float float_142 = siemensTcpNet.ReadFloat("DB22.142").Content;
            float float_158 = siemensTcpNet.ReadFloat("DB22.158").Content;
            float float_146 = siemensTcpNet.ReadFloat("DB22.146").Content;
            float float_50 = siemensTcpNet.ReadFloat("DB22.50").Content;
            float float_54 = siemensTcpNet.ReadFloat("DB22.54").Content;
            float float_58 = siemensTcpNet.ReadFloat("DB22.58").Content;
            float float_62 = siemensTcpNet.ReadFloat("DB22.62").Content;
            float float_66 = siemensTcpNet.ReadFloat("DB22.66").Content;
            float float_70 = siemensTcpNet.ReadFloat("DB22.70").Content;
            textEdit1.Text = M18_5.ToString();
            textEdit16.Text = M20_1.ToString();
            textEdit2.Text = byte_4.ToString();
            textEdit3.Text = byte_3.ToString();
            textEdit15.Text = byte_6.ToString();
            textEdit14.Text = byte_5.ToString();
            textEdit4.Text = float_150.ToString();
            textEdit5.Text = float_138.ToString();
            textEdit17.Text = float_154.ToString();
            textEdit7.Text = float_142.ToString();
            textEdit13.Text = float_158.ToString();
            textEdit8.Text = float_158.ToString();
            textEdit12.Text = float_146.ToString();
            textEdit9.Text = float_146.ToString();
            textEdit11.Text = float_50.ToString();
            textEdit10.Text = float_54.ToString();
            textEdit23.Text = float_58.ToString();
            textEdit22.Text = float_62.ToString();
            textEdit21.Text = float_66.ToString();
            textEdit20.Text = float_70.ToString();
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            

        }

        private void sn_Click(object sender, EventArgs e)
        {
            string ip = "192.168.99.152";
            SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            {
                ConnectTimeOut = 5000
            };

            OperateResult connect = siemensTcpNet.ConnectServer();
            siemensTcpNet.Write("M18.5", false);
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            string ip = "192.168.99.152";
            SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            {
                ConnectTimeOut = 5000
            };

            OperateResult connect = siemensTcpNet.ConnectServer();
            siemensTcpNet.Write("M20.1", true);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string ip = "192.168.99.152";
            SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            {
                ConnectTimeOut = 5000
            };

            OperateResult connect = siemensTcpNet.ConnectServer();
            siemensTcpNet.Write("DB22.88.4", true);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            string ip = "192.168.99.152";
            SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            {
                ConnectTimeOut = 5000
            };

            OperateResult connect = siemensTcpNet.ConnectServer();
            siemensTcpNet.Write("DB22.88.3", true);
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            string ip = "192.168.99.152";
            SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            {
                ConnectTimeOut = 5000
            };

            OperateResult connect = siemensTcpNet.ConnectServer();
            siemensTcpNet.Write("DB22.88.5", true);
        
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            string ip = "192.168.99.152";
            SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            {
                ConnectTimeOut = 5000
            };

            OperateResult connect = siemensTcpNet.ConnectServer();
            siemensTcpNet.Write("DB22.88.6", true);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string ip = "192.168.99.152";
            SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            {
                ConnectTimeOut = 5000
            };

            OperateResult connect = siemensTcpNet.ConnectServer();
            float t = Convert.ToSingle(textEdit4.Text);
            siemensTcpNet.Write("DB22.150", t);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            string ip = "192.168.99.152";
            SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            {
                ConnectTimeOut = 5000
            };

            OperateResult connect = siemensTcpNet.ConnectServer();
            float t = Convert.ToSingle(textEdit5.Text);
            siemensTcpNet.Write("DB22.138", t);
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            string ip = "192.168.99.152";
            SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            {
                ConnectTimeOut = 5000
            };

            OperateResult connect = siemensTcpNet.ConnectServer();
            float t = Convert.ToSingle(textEdit17.Text);
            siemensTcpNet.Write("DB22.154", t);
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            string ip = "192.168.99.152";
            SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            {
                ConnectTimeOut = 5000
            };

            OperateResult connect = siemensTcpNet.ConnectServer();
            float t = Convert.ToSingle(textEdit7.Text);
            siemensTcpNet.Write("DB22.142", t);
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            string ip = "192.168.99.152";
            SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            {
                ConnectTimeOut = 5000
            };

            OperateResult connect = siemensTcpNet.ConnectServer();
            float t = Convert.ToSingle(textEdit13.Text);
            siemensTcpNet.Write("DB22.158", t);
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            string ip = "192.168.99.152";
            SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            {
                ConnectTimeOut = 5000
            };

            OperateResult connect = siemensTcpNet.ConnectServer();
            float t = Convert.ToSingle(textEdit12.Text);
            siemensTcpNet.Write("DB22.146", t);
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            string ip = "192.168.99.152";
            SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            {
                ConnectTimeOut = 5000
            };

            OperateResult connect = siemensTcpNet.ConnectServer();
            float t = Convert.ToSingle(textEdit8.Text);
            siemensTcpNet.Write("DB22.158", t);
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            string ip = "192.168.99.152";
            SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            {
                ConnectTimeOut = 5000
            };

            OperateResult connect = siemensTcpNet.ConnectServer();
            float t = Convert.ToSingle(textEdit9.Text);
            siemensTcpNet.Write("DB22.146", t);
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            string ip = "192.168.99.152";
            SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            {
                ConnectTimeOut = 5000
            };

            OperateResult connect = siemensTcpNet.ConnectServer();
            float t = Convert.ToSingle(textEdit11.Text);
            siemensTcpNet.Write("DB22.50", t);
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            string ip = "192.168.99.152";
            SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            {
                ConnectTimeOut = 5000
            };

            OperateResult connect = siemensTcpNet.ConnectServer();
            float t = Convert.ToSingle(textEdit10.Text);
            siemensTcpNet.Write("DB22.54", t);
        }

        private void simpleButton23_Click(object sender, EventArgs e)
        {
            string ip = "192.168.99.152";
            SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            {
                ConnectTimeOut = 5000
            };

            OperateResult connect = siemensTcpNet.ConnectServer();
            float t = Convert.ToSingle(textEdit23.Text);
            siemensTcpNet.Write("DB22.58", t);
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {
            string ip = "192.168.99.152";
            SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            {
                ConnectTimeOut = 5000
            };

            OperateResult connect = siemensTcpNet.ConnectServer();
            float t = Convert.ToSingle(textEdit22.Text);
            siemensTcpNet.Write("DB22.62", t);
        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {
            string ip = "192.168.99.152";
            SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            {
                ConnectTimeOut = 5000
            };

            OperateResult connect = siemensTcpNet.ConnectServer();
            float t = Convert.ToSingle(textEdit21.Text);
            siemensTcpNet.Write("DB22.66", t);
        }

        private void simpleButton20_Click(object sender, EventArgs e)
        {
            string ip = "192.168.99.152";
            SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, ip)
            {
                ConnectTimeOut = 5000
            };

            OperateResult connect = siemensTcpNet.ConnectServer();
            float t = Convert.ToSingle(textEdit20.Text);
            siemensTcpNet.Write("DB22.70", t);
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            refresh();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refresh();
        }

       

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            if (simpleButton18.Text == "自动刷新")
            {
                timer1.Enabled = true;
                simpleButton18.Text = "暂停自动刷新";
                
   }
            else
            {
                timer1.Enabled =false;
                simpleButton18.Text = "自动刷新";
            }
           
        }
    }
}
