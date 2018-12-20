using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using StorageManageLibrary;
using DevExpress.XtraReports.UI;
using HslCommunication.Profinet.Siemens;
using HslCommunication;

namespace StorageManage
{
    /// <summary>
    /// 单据新增
    /// </summary>
    public partial class frmBillAdd : frmBase
    {
        
        MaterialManage MaterialManage = new MaterialManage();
        BillManage bm = new BillManage();
        BillAutoIDManage BillAutoIDManage = new BillAutoIDManage();
        DataSet ds = new DataSet();
        public int SendFlag = 0;//1：是从入库明细单处进入  0: 从出入库单处进入
        SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, "192.168.99.152")
        {
                ConnectTimeOut = 50
        };

    public frmBillAdd()
        {            
            InitializeComponent();         
        }
        //public frmBillAdd(string str)
        //{
        //    InitializeComponent();
            
        //}

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            frmSelectMaterial frmSelectMaterial = new frmSelectMaterial();
            frmSelectMaterial.Tag = "";
            frmSelectMaterial.ShowDialog();

            //选择的料件填充
            if (frmSelectMaterial.Tag.ToString() != "")
            { 
                 //得到选择的料件guid，然后得到
                Material material= MaterialManage.GetMaterialByGuid(frmSelectMaterial.Tag.ToString());
                
                //填充数据
                gridView1.AddNewRow();
                gridView1.SetFocusedRowCellValue(gridMaterialGuid, material.MaterialGuid);
                gridView1.SetFocusedRowCellValue(gridMaterialId, material.MaterialId);
                gridView1.SetFocusedRowCellValue(gridMaterialName, material.MaterialName);
                gridView1.SetFocusedRowCellValue(gridCN, material.ClassId);
                gridView1.SetFocusedRowCellValue(gridSpec , material.Spec);
                gridView1.SetFocusedRowCellValue(gridProNo, material.ProNo);
                gridView1.SetFocusedRowCellValue(gridCadNo, material.CadNo);
                gridView1.SetFocusedRowCellValue(gridUnit, material.Unit);
                //gridView1.SetFocusedRowCellValue(gridzj, material.Zj);
                //gridView1.SetFocusedRowCellValue(gridgh, material.Gh);
                //gridView1.SetFocusedRowCellValue(gridbz, material.Bz);
                //gridView1.SetFocusedRowCellValue(gridqd, material.Qd);
                //gridView1.SetFocusedRowCellValue(gridcd, material.Cd);
                gridView1.SetFocusedRowCellValue(gridjz, material.Jz);
                //gridView1.SetFocusedRowCellValue(gridmz, material.Mz);
                gridView1.SetFocusedRowCellValue(gridscrq, material.Scrq);
                gridView1.SetFocusedRowCellValue(gridRemark, material.Remark);
            }
        }

        //新增
        public  void BillAdd(string flag,IWin32Window ifrm)
        {
            txtGuid.Text = Guid.NewGuid().ToString();
            txtAutoBillID.Text = GetAutoId(flag);
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreatePerson.Text = SysParams.UserName;

            this.Tag = flag;// flag 中I:入库单 E：出库单
            if (flag == "I")
            {
                //入库
                //cboBearing.Items.Clear();
                ////cboBearing.Items.Add("");
                //cboBearing.Items.Add("收货");
                //cboBearing.Items.Add("退货");
                this.Text = "入库单新增";
                //label5.Text = "供应商";              
                CboBind("I");
                //cboStorageType.Text = "原料采购入库";
              

            }
            else
            {
                //出库
                //cboBearing.Items.Clear();
                //cboBearing.Items.Add("");
                //cboBearing.Items.Add("发货");
                //cboBearing.Items.Add("退货");
                this.Text = "出库单新增";
                //label5.Text = "客户";
              

                CboBind("E");

                //cboStorageType.Text = "销售发货出库";
                cboDepot.Text = "库位";

                

                
            }

            //反审不可用,审核可用
            tsbCheckNoPass.Enabled = false;
            tsbCheckPass.Enabled = false;
           
         
            
            this.gridControl1.DataSource = IniBindTable();
            gridMaterialGuid.Visible = false;


            this.Show(ifrm);
        }



        //修改
        public void BillEdit(string billguid,string flag,IWin32Window ifrm)
        {
            txtGuid.Text = billguid;

            if (flag == "I")
            {
                //入库
                //cboBearing.Items.Clear();
                //cboBearing.Items.Add("");
                //cboBearing.Items.Add("收货");
                //cboBearing.Items.Add("退货");
                //cboBearing.SelectedIndex = 0;
                this.Text = "入库单编辑";
                //label5.Text = "供应商";

                //加载选择项
                CboBind("I");
            }
            else
            {
                //出库
                //cboBearing.Items.Clear();
                //cboBearing.Items.Add("");
                //cboBearing.Items.Add("发货");
                //cboBearing.Items.Add("退货");
                //cboBearing.SelectedIndex = 0;
                this.Text = "出库单编辑";
                //label5.Text = "客户";
              
                //加载选择项
                CboBind("E");

                cboDepot.Text = "库位";

            
            }


           
        

            //得到主表数据
            DataTable dtl = bm.GetBillData(txtGuid.Text);
            txtGuid.Text = dtl.Rows[0]["billGuid"].ToString();
            dateTimePicker1.Text = dtl.Rows[0]["BillDate"].ToString();
            //txtBillID.Text = dtl.Rows[0]["BillDate"].ToString();
            //txtBatchNo.Text = dtl.Rows[0]["BatchNo"].ToString();
             string Depot = dtl.Rows[0]["DepotGuid"].ToString();
            cboDepot.SelectedIndex = Convert.ToInt32(Depot)-1;
            //cboDept.Text = dtl.Rows[0]["DeptGuid"].ToString();
            txtRemark.Text = dtl.Rows[0]["Remark"].ToString();
            //cboSupplier.Text = dtl.Rows[0]["SupplierGuid"].ToString();
            //cboStorageType.Text = dtl.Rows[0]["StorageTypeGuid"].ToString();
            //cboBearing.Text = dtl.Rows[0]["Bearing"].ToString();
            cboHandlePerson.Text = dtl.Rows[0]["HandlePerson"].ToString();
            txtAutoBillID.Text = dtl.Rows[0]["BillAutoID"].ToString();
            //txtBillID.Text = dtl.Rows[0]["BillID"].ToString();
            this.Tag = flag;// flag 中I:入库单 E：出库单

            txtCreateDate.Text = dtl.Rows[0]["CreateDate"].ToString();
            txtCreatePerson.Text = dtl.Rows[0]["CreatePerson"].ToString();
            if (dtl.Rows[0]["CheckDate"].ToString().Contains("1900-01-01")==false)
            {
                txtCheckDate.Text = dtl.Rows[0]["CheckDate"].ToString();
            }
            else
            {
                txtCheckDate.Text = "";
            }
            txtCheckPerson.Text = dtl.Rows[0]["CheckPerson"].ToString();

            if (dtl.Rows[0]["CheckPerson"].ToString() != "")
            {
                //设置为：已审核
                SetControlEnable(1);
            }
            else
            {
                //设置为：没有审核
                SetControlEnable(0);
            }
           
            //得到明细表数据
            DataTable dtlDetail = bm.GetBillDetailData(txtGuid.Text);
            this.gridControl1.DataSource = dtlDetail;
            gridMaterialGuid.Visible = false;
            gridMaterialId.Visible = true;

            ds.Tables.Add(dtl.Copy());
            ds.Tables[0].TableName = "dtlBill";
            ds.Tables.Add(dtlDetail.Copy());
            ds.Tables[1].TableName = "dtlBillDetail";


            this.Show(ifrm);
        }
      

        private void CboBind(string flag)
        { 
            //绑定仓库
            DepotManage DepotManage = new DepotManage();
            DataTable dtl = DepotManage.GetDepotData();
            
            //cboDepot.Items.Add("");
            for (int i = 0; i < dtl.Rows.Count; i++)
            {
                cboDepot.Items.Add(dtl.Rows[i]["库位坐标"].ToString());
            }
            BillManage billManage = new BillManage();
            DataTable dtrk = new DataTable();
            string strsql1 = "";
            string strsql2 = "";
            string strsql3 = "";
            string strDepot = "1";
            string strsql4 = "";
            string strsql5 = "";
            int a = Convert.ToInt32(strDepot);
            for ( a= 1; a < 51; a++)
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
                if (sumQty == 0) { 
                if(a==1)
                {
                   cboDepot.SelectedIndex = 0;
                        break;
                }
                else
                {

                    cboDepot.SelectedIndex = a-1;
                        break;
                }
                }
            }

            


                //绑定类型
                dtl = DepotManage.GetStorageTypeData(flag);
            //cboStorageType.Items.Add("");
            for (int i = 0; i < dtl.Rows.Count; i++)
            {
                //cboStorageType.Items.Add(dtl.Rows[i]["StorageTypeName"].ToString());
            }
            //cboStorageType.SelectedIndex = 0;

            //绑定部门
            DeptManage DeptManage = new DeptManage();
            dtl = DeptManage.GetDeptData();
            //cboDept.Items.Add("");
            for (int i = 0; i < dtl.Rows.Count; i++)
            {
                //cboDept.Items.Add(dtl.Rows[i]["部门名称"].ToString());
            }


            //绑定经手人
            EmployeeManage EmployeeManage = new EmployeeManage();
            dtl = EmployeeManage.GetEmployeeData();
            //cboHandlePerson.Items.Add("");
            for (int i = 0; i < dtl.Rows.Count; i++)
            {
                cboHandlePerson.Items.Add(dtl.Rows[i]["员工姓名"].ToString());
            }
            cboHandlePerson.SelectedIndex = 0;

            //绑定供应商
            if (flag == "I")
            {
                SupplierManage SupplierManage = new SupplierManage();
                dtl = SupplierManage.GetSupplierData();
                //cboSupplier.Items.Add("");
                for (int i = 0; i < dtl.Rows.Count; i++)
                {
                    //cboSupplier.Items.Add(dtl.Rows[i]["供应商名称"].ToString());
                }
               // cboSupplier.SelectedIndex = 0;
            }
            else
            {
                ClientManage ClientManage = new ClientManage();
                dtl = ClientManage.GetClientData();
                //cboSupplier.Items.Add("");
                for (int i = 0; i < dtl.Rows.Count; i++)
                {
                    //cboSupplier.Items.Add(dtl.Rows[i]["客户名称"].ToString());
                }
                //cboSupplier.SelectedIndex = 0;
            }


        
        }



        //初始经表格
        private DataTable IniBindTable()
        {
            DataTable _dt = new DataTable();
            DataColumn _datacol0 = new DataColumn("MaterialGuid");
            DataColumn _datacol1 = new DataColumn("MaterialId");
            DataColumn _datacol2 = new DataColumn("MaterialName");
            DataColumn _datacol3 = new DataColumn("ClassName");
            DataColumn _datacol4 = new DataColumn("Spec");
            DataColumn _datacol5 = new DataColumn("ProNo");
            DataColumn _datacol6 = new DataColumn("CadNo");
            DataColumn _datacol7 = new DataColumn("Unit");
            DataColumn _datacol8 = new DataColumn("Qty");         
            //DataColumn _datacol9 = new DataColumn("zj");
            //DataColumn _datacol10 = new DataColumn("gh");
            //DataColumn _datacol11= new DataColumn("bz");
            //DataColumn _datacol12 = new DataColumn("qd");
            //DataColumn _datacol13 = new DataColumn("cd");
            DataColumn _datacol9 = new DataColumn("jz");
            //DataColumn _datacol15 = new DataColumn("mz");
            DataColumn _datacol10= new DataColumn("scrq");
            DataColumn _datacol11 = new DataColumn("Remark");

            _dt.Columns.Add(_datacol0);
            _dt.Columns.Add(_datacol1);
            _dt.Columns.Add(_datacol2);
            _dt.Columns.Add(_datacol3);
            _dt.Columns.Add(_datacol4);
            _dt.Columns.Add(_datacol5);
            _dt.Columns.Add(_datacol6);
            _dt.Columns.Add(_datacol7);
            _dt.Columns.Add(_datacol8);
            //_dt.Columns.Add(_datacol9);            
            //_dt.Columns.Add(_datacol10);
            //_dt.Columns.Add(_datacol11);
            //_dt.Columns.Add(_datacol12);
            //_dt.Columns.Add(_datacol13);
            _dt.Columns.Add(_datacol9);
            //_dt.Columns.Add(_datacol15);
            _dt.Columns.Add(_datacol10);
            _dt.Columns.Add(_datacol11);

            return _dt;

        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelDetail_Click(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
        }
        /// <summary>
        /// 库存不小于0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            BillManage billManage = new BillManage();
            string flag = Form.ActiveForm.Text;
            if (e.Column.Name != "gridMaterialGuid" && e.Column.Name != "gridMaterialName" && e.Column.Name != "gridMaterialId"
                && e.Column.Name != "gridSpec" && e.Column.Name != "gridUnit" && e.Column.Name != "gridRemark" && e.Column.Name != "gridCN"
                 && e.Column.Name != "gridzj" && e.Column.Name != "gridgh" && e.Column.Name != "gridbz" && e.Column.Name != "gridqd"
                 && e.Column.Name != "gridcd" && e.Column.Name != "gridProNo" && e.Column.Name != "gridCadNo" && e.Column.Name != "gridjz"
                 && e.Column.Name != "gridmz" && e.Column.Name != "gridscrq" && (flag == "出库单新增" || flag == "出库单编辑"))
            {
                DepotManage depotManage = new DepotManage();
                //frmSelectMaterial frmSelectMaterial = new frmSelectMaterial();
                DataTable dt = new DataTable();
                dt = depotManage.GetDepotData3(cboDepot.Text);//根据库位坐标寻找库位号
                string dpt = dt.Rows[0]["库位"].ToString();
                //获取新输入的数量值
                decimal Qty = Convert.ToDecimal(e.Value);
                int rowIndex = e.RowHandle; //获取被编辑的单元格在第几列，可理解为X坐标
                int columnindex = e.Column.AbsoluteIndex;//获取绑定到这个单元格的字段名
                int[] pRows = this.gridView1.GetSelectedRows();//传递实体类过去 获取选中的行
                string MaterialId = this.gridView1.GetRowCellValue(pRows[0], "MaterialId").ToString();
                DataTable dtl = new DataTable();
                string strsql1 = "";
                string strsql2 = "";
                string strsql3 = "";
                string strDepot = "";
                string strsql4 = "";
                string strsql5 = "";
                strsql1 = strsql1 + " and depotguid=\"" + dpt.Replace("'", "''") + "\"";
                strsql2 = strsql2 + " and DepotIn=\"" + dpt.Replace("'", "''") + "\"";
                strsql3 = strsql3 + " and DepotOut=\"" + dpt.Replace("'", "''") + "\"";
                strDepot = dpt.Replace("'", "''");
                strsql5 = strsql5 + " and Depot=\"" + dpt.Replace("'", "''") + "\"";
                strsql1 = strsql1 + " and MaterialId=\"" + MaterialId.Replace("'", "''") + "\"";
                strsql2 = strsql2 + " and MaterialId=\"" + MaterialId.Replace("'", "''") + "\"";
                strsql3 = strsql3 + " and MaterialId=\"" + MaterialId.Replace("'", "''") + "\"";
                strsql4 = strsql4 + " and mat.MaterialId=\"" + MaterialId.Replace("'", "''") + "\"";
                dtl = billManage.sp_GetDepotMaterailSum(strsql1, strsql2, strsql3, strDepot, strsql4, strsql5);
                decimal m = Convert.ToDecimal(dtl.Rows[0]["Qty"]);
                decimal a = m - Qty;
                if (a < 0)
                {
                    ShowAlertMessage("库存数量不足,请查询后重新输入!");
                    gridView1.GetDataRow(rowIndex)["Qty"] = 0;

                }
            }



        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                //int intRow = gridView1.GetSelectedRows()[0];
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();
                frmDepotMaterialStatusQty fdms = new frmDepotMaterialStatusQty();
              
                fdms.ShowData(guid,this);
               
            }
           
        }

        //保存
        private void tsbSave_Click(object sender, EventArgs e)
        {
            gridView1.UpdateCurrentRow();

            if (cboDepot.Text == "")
            {
                this.ShowAlertMessage("必须选择仓库!");
                return;
            }
            
            //if (cboStorageType.Text== "")
            //{
            //    this.ShowAlertMessage("必须选择类型!");
            //    return;
            //}

          //  if (this.Tag.ToString() == "I")
           // {
                //if (cboSupplier.Text == "")
                //{
                //    this.ShowAlertMessage("必须选择供应商!");
                //    return;
                //}
           // }
            //else
            //{
                //if (cboSupplier.Text == "")
                //{
                //    this.ShowAlertMessage("必须选择客户!");
                //    return;
                //}
           // }

            //if (cboDept.Text == "")
            //{
            //    this.ShowAlertMessage("必须选择部门!");
            //    return;
            //}

            //if (cboBearing.Text == "")
            //{
            //    this.ShowAlertMessage("必须选择方向!");
            //    return;
            //}

            if (cboHandlePerson.Text == "")
            {
                this.ShowAlertMessage("必须选择经手人!");
                return;
            }

            if (gridView1.RowCount <= 0)
            {
                this.ShowAlertMessage("必须增加货品明细数据!");
                return;
            }
            DepotManage DepotManage = new DepotManage();
            DataTable dt = DepotManage.GetDepotData3(cboDepot.Text);


            Bill Bill = new Bill();
            Bill.BillGuid = txtGuid.Text;
            Bill.BillDate =DateTime.Parse(dateTimePicker1.Text);
            //Bill.BillID = txtBillID.Text;
            //Bill.BatchNo = txtBatchNo.Text;
            Bill.DepotGuid = dt.Rows[0]["库位"].ToString(); 
            //Bill.DeptGuid = cboDept.Text;
            //Bill.SupplierGuid =cboSupplier.Text;
            //Bill.StorageTypeGuid = cboStorageType.Text;
            Bill.Flag = this.Tag.ToString();
            //Bill.Bearing = cboBearing.Text;
            if (txtCreateDate.Text.Trim() == "")
            {
                Bill.CreateDate = DateTime.Now;
            }
            else
            {
                Bill.CreateDate = DateTime.Parse(txtCreateDate.Text);
            }
            Bill.CreatePerson = SysParams.UserName;
            Bill.CheckDate = DateTime.Parse("1900-01-01");
            Bill.CheckPerson = "";
            Bill.Remark = txtRemark.Text;
            Bill.BillAutoID = txtAutoBillID.Text;
            Bill.HandlePerson = cboHandlePerson.Text;
         

            List<BillDetail> list = new List<BillDetail>();
            BillDetail BillDetail = new BillDetail();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                BillDetail = new BillDetail();
                BillDetail.BillDetailGuid = Guid.NewGuid().ToString();
                BillDetail.BillGuid = Bill.BillGuid;
                BillDetail.MaterialGuid =dr[0].ToString(); //gridView1.GetRowCellValue(i, gridMaterialGuid).ToString();
                BillDetail.MaterialId = dr[1].ToString(); //gridView1.GetRowCellValue(i, gridMaterialGuid).ToString();
                BillDetail.MaterialName = dr[2].ToString();  //gridView1.GetRowCellValue(i, gridMaterialName).ToString();
                BillDetail.ClassName = dr[3].ToString();
                BillDetail.Spec = dr[4].ToString();// gridView1.GetRowCellValue(i, gridSpec).ToString(); 
                BillDetail.ProNo = dr[5].ToString(); //gridView1.GetRowCellValue(i, gridMaterialGuid).ToString();
                BillDetail.CadNo = dr[6].ToString();  //gridView1.GetRowCellValue(i, gridMaterialName).ToString(); 
                BillDetail.Unit = dr[7].ToString();//gridView1.GetRowCellValue(i, gridUnit).ToString();
                if (dr[8].ToString().Trim() != "")
                {
                    BillDetail.Qty = decimal.Parse(dr[8].ToString()); }//int.Parse(gridView1.GetRowCellValue(i, gridQty).ToString());                              
                else
                {
                    BillDetail.Qty = 0;
                }
                //BillDetail.Zj = dr[9].ToString();
                //BillDetail.Gh = dr[10].ToString();
                //BillDetail.Bz = dr[11].ToString();
                //BillDetail.Qd = dr[12].ToString();
                //BillDetail.Cd = dr[11].ToString();
                BillDetail.Jz = dr[9].ToString();
                //BillDetail.Mz = dr[13].ToString();
                BillDetail.Scrq = Convert.ToDateTime(dr[10]);
                BillDetail.Remark = dr[11].ToString();//gridView1.GetRowCellValue(i, gridRemark).ToString();           
                list.Add(BillDetail);
                //BillDetail.BarNo = dr[2].ToString();  //gridView1.GetRowCellValue(i, gridMaterialName).ToString();    
                //if (dr[7].ToString().Trim() != "")
                //{
                //    BillDetail.Price = decimal.Parse(dr[7].ToString()); //decimal.Parse(gridView1.GetRowCellValue(i, gridPrice).ToString());

                //}
                //else
                //{
                //    BillDetail.Price = 0;
                //}

                //if (dr[8].ToString().Trim() != "")
                //{
                //    BillDetail.Total = decimal.Parse(dr[8].ToString()); //decimal.Parse(gridView1.GetRowCellValue(i, gridTotal ).ToString());
                //}
                //else
                //{
                //    BillDetail.Total = 0;
                //}




            }

            //保存
            bm.SaveBill(Bill, list);

            // 如果sendflag等于1则是从入库明细查询中进入本窗口，不用刷新父窗口
            if (SendFlag == 0)
            {
                if (this.Tag.ToString() == "I")
                {
                    frmBill.frmbill.LoadBill();
                }
                else if (this.Tag.ToString() == "E")
                {
                    frmBillE.frmbille.LoadBill();
                }
            }

            tsbCheckPass.Enabled = true;

            //得到明细表数据
            DataTable dtl = bm.GetBillData(txtGuid.Text);
            DataTable dtlDetail = bm.GetBillDetailData(txtGuid.Text);
            this.gridControl1.DataSource = dtlDetail;

            ds.Tables.Clear();
            ds.Tables.Add(dtl.Copy());
            ds.Tables[0].TableName = "dtlBill";
            ds.Tables.Add(dtlDetail.Copy());
            ds.Tables[1].TableName = "dtlBillDetail";


            this.ShowMessage("保存成功");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public string GetAutoId(string flag)
        {

            //得到自动编号
            string strautoid = "";
            int autoid = BillAutoIDManage.GetAutoIDAdd(flag);//得到入库单的单据自增号
            if (autoid < 10)
            {
                strautoid = "000" + autoid.ToString();
            }
            else if (autoid >= 10 && autoid < 100)
            {
                strautoid = "00" + autoid.ToString();
            }
            else if (autoid >= 100 && autoid < 1000)
            {
                strautoid = "0" + autoid.ToString();
            }
            else if (autoid >= 1000 && autoid < 10000)
            {
                strautoid = autoid.ToString();
            }

            strautoid=DateTime.Now.ToString("yyyyMMdd")+strautoid;
            return strautoid;
        }

        //新增
        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserRightManage urm = new UserRightManage();
            if (urm.IsOperateRight(SysParams.UserID, "lkdxz") == false)
            {
                this.ShowAlertMessage("对不起，你没有该功能的操作权限，请与管理员联系！");
                return;
            }


            //清空主表数据
            txtGuid.Text = Guid.NewGuid().ToString();
            //txtBillID.Text = "";
            //txtBatchNo.Text ="";
            cboDepot.Text = "";
            //cboDept.Text = "";
            txtRemark.Text = "";
            //cboSupplier.Text = "";
            //cboStorageType.Text = "";
            //cboBearing.Text = "";
            cboHandlePerson.Text = "";
            
            txtAutoBillID.Text = GetAutoId(this.Tag.ToString());
            

            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreatePerson.Text = SysParams.UserName;
            txtCheckDate.Text = "";
            txtCheckPerson.Text = "";

            if (this.Tag.ToString() == "I")
            {
                this.Text = "入库单新增";
                //cboStorageType.Text = "原料采购入库";
                CboBind("I");
            }
            else
            {
                this.Text = "出库单新增";
                //cboStorageType.Text = "销售发货出库";
            }

         

            //清空明细表
            this.gridControl1.DataSource = IniBindTable();
            gridMaterialGuid.Visible = false;

            //初始化成没有审核
            SetControlEnable(0);

            tsbCheckPass.Enabled = false;
        }



        //审核
        private void tsbCheckPass_Click(object sender, EventArgs e)
        {
            UserRightManage urm = new UserRightManage();
            if (urm.IsOperateRight(SysParams.UserID, "lkdsh") == false)
            {
                this.ShowAlertMessage("对不起，你没有该功能的操作权限，请与管理员联系！");
                return;
            }

            //更新审核状态
            bm.ChcekBill(txtGuid.Text, 1);

            //设置为：已审核
            SetControlEnable(1);

            // 如果sendflag等于1则是从入库明细查询中进入本窗口，不用刷新父窗口
            if (SendFlag == 0)
            {
                if (this.Tag.ToString() == "I")
                {
                    frmBill.frmbill.LoadBill();
                }
                else if (this.Tag.ToString() == "E")
                {
                    frmBillE.frmbille.LoadBill();
                }
            }

            txtCheckDate.Text = DateTime.Now.ToString();
            txtCheckPerson.Text = SysParams.UserName;

        }

        //反审
        private void tsbCheckNoPass_Click(object sender, EventArgs e)
        {
            UserRightManage urm = new UserRightManage();
            if (urm.IsOperateRight(SysParams.UserID, "lkdsh") == false)
            {
                this.ShowAlertMessage("对不起，你没有该功能的操作权限，请与管理员联系！");
                return;
            }

            //更新审核状态
            bm.ChcekBill(txtGuid.Text,0);

            //设置为：没有审核
            SetControlEnable(0);

            // 如果sendflag等于1则是从入库明细查询中进入本窗口，不用刷新父窗口
            if (SendFlag == 0)
            {
                if (this.Tag.ToString() == "I")
                {
                    frmBill.frmbill.LoadBill();
                }
                else if (this.Tag.ToString() == "E")
                {
                    frmBillE.frmbille.LoadBill();
                }
            }

            txtCheckDate.Text = "";
            txtCheckPerson.Text = "";

        }

        private void SetControlEnable(int pass)
        {
            if (pass == 1)
            {
                //已审核
                tsbCheckNoPass.Enabled = true;
                tsbCheckPass.Enabled = false;

                tsbSave.Enabled = false;
                btnDelete.Enabled = false;

                btnAddDetail.Enabled = false;
                btnDelDetail.Enabled = false;
            }
            else
            { 
                //没有审核
                tsbCheckNoPass.Enabled = false;
                tsbCheckPass.Enabled = true;

                tsbSave.Enabled = true;
                btnDelete.Enabled = true;

                btnAddDetail.Enabled = true;
                btnDelDetail.Enabled = true;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除该单据！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //删除
                bm.DeleteBill(txtGuid.Text);

                //清空
                btnAdd_Click(null, null);

                 // 如果sendflag等于1则是从入库明细查询中进入本窗口，不用刷新父窗口
                if (SendFlag == 0)
                {
                    if (this.Tag.ToString() == "I")
                    {
                        frmBill.frmbill.LoadBill();
                    }
                    else if (this.Tag.ToString() == "E")
                    {
                        frmBillE.frmbille.LoadBill();
                    }
                }

               
               
            }
        }
        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbPrint_Click(object sender, EventArgs e)
        {

            if (this.Tag.ToString() == "I")
            {
                //打印入库单
                XtraReportBillI XtraReportBillI = new XtraReportBillI(ds);
                XtraReportBillI.ShowPreview();

            }
            else
            {

                //打印入库单
                XtraReportBillE XtraReportBillE = new XtraReportBillE(ds);
                XtraReportBillE.ShowPreview();
            }
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            frmMaterialAdd frmMaterialAdd = new frmMaterialAdd();
            frmMaterialAdd.Invalue = 1;
            frmMaterialAdd.MaterialAdd("", "");
        }

        private void repositoryItemSpinEdit2_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

    

        private void repositoryItemSpinEdit3_KeyUp(object sender, KeyEventArgs e)
        {
            //try
            //{
            //    if (this.Text == "出库单新增" || this.Text == "出库单编辑")
            //    {
            //        //调拨单货品是否自动计算平均单价
            //        if (e.KeyValue == 8 || e.KeyValue == 46)
            //        {
            //            string AutoFillRemovePrice = System.Configuration.ConfigurationSettings.AppSettings["IsAutoFillRemovePrice"].ToString(); ;
            //            if (AutoFillRemovePrice == "true")
            //            {
            //                if (gridView1.GetFocusedRow() != null)
            //                {
            //                    decimal priceAVG = 0;
            //                    string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();
            //                    //得到此料件在某个仓库中的平均价,写入单价列中
            //                    priceAVG = bm.sp_GetMaterialPrice(guid, cboDepot.Text);
            //                    //gridView1.SetFocusedRowCellValue(gridPrice, priceAVG);
            //                }
            //            }
            //        }
            //    }
            //}
            //catch
            //{ }
        }

       
        /// <summary>
        /// 左放物
        /// </summary>
        public void zf()
        {
            siemensTcpNet.Write("DB22.88.4", true);
        }
        /// <summary>
        /// 右放物
        /// </summary>
        public void yf()
        {
            siemensTcpNet.Write("DB22.88.6", true);
        }
        /// <summary>
        /// 左取物
        /// </summary>
        public void zq()
        {
            siemensTcpNet.Write("DB22.88.3", true);
        }
        /// <summary>
        /// 右取物
        /// </summary>
        public void yq()
        {
            siemensTcpNet.Write("DB22.88.5", true);
        }
        /// <summary>
        /// 入库（放物）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnrk_Click(object sender, EventArgs e)
        {
            DepotManage DepotManage = new DepotManage();
            DataTable dt = DepotManage.GetDepotData3(cboDepot.Text);//根据库位坐标寻找库位号
            string depot = dt.Rows[0]["库位"].ToString();

            switch (depot)
            {
                case "1":
                    siemensTcpNet.Write("DB22.150", 0f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 0f);
                    zf();
                    break;
                case "3":
                    siemensTcpNet.Write("DB22.150", 0f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 1310f);
                    zf();
                    break;
                case "5":
                    siemensTcpNet.Write("DB22.150", 0f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 2620f);
                    zf();
                    break;
                case "7":
                    siemensTcpNet.Write("DB22.150", 0f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 3930f);
                    zf();
                    break;
                case "9":
                    siemensTcpNet.Write("DB22.150", 0f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 5240f);
                    zf();
                    break;
                case "11":
                    siemensTcpNet.Write("DB22.150", -1110f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 0f);
                    zf();
                    break;
                case "13":
                    siemensTcpNet.Write("DB22.150", -1110f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 1310f);
                    zf();
                    break;
                case "15":
                    siemensTcpNet.Write("DB22.150", -1110f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 2620f);
                    zf();
                    break;
                case "17":
                    siemensTcpNet.Write("DB22.150", -1110f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 3930f);
                    zf();
                    break;
                case "19":
                    siemensTcpNet.Write("DB22.150", -1110f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 5240f);
                    zf();
                    break;
                case "21":
                    siemensTcpNet.Write("DB22.150", -2220f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 0f);
                    zf();
                    break;
                case "23":
                    siemensTcpNet.Write("DB22.150", -2220f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 1310f);
                    zf();
                    break;
                case "25":
                    siemensTcpNet.Write("DB22.150", -2220f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 2620f);
                    zf();
                    break;
                case "27":
                    siemensTcpNet.Write("DB22.150", -2220f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 3930f);
                    zf();
                    break;
                case "29":
                    siemensTcpNet.Write("DB22.150", -2220f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 5240f);
                    zf();
                    break;
                case "31":
                    siemensTcpNet.Write("DB22.150", -3340f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 0f);
                    zf();
                    break;
                case "33":
                    siemensTcpNet.Write("DB22.150", -3340f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 1310f);
                    zf();
                    break;
                case "35":
                    siemensTcpNet.Write("DB22.150", -3340f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 2620f);
                    zf();
                    break;
                case "37":
                    siemensTcpNet.Write("DB22.150", -3340f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 3930f);
                    zf();
                    break;
                case "39":
                    siemensTcpNet.Write("DB22.150", -3340f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 5240f);
                    zf();
                    break;
                case "41":
                    siemensTcpNet.Write("DB22.150", -4450f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 0f);
                    zf();
                    break;
                case "43":
                    siemensTcpNet.Write("DB22.150", -4450f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 1310f);
                    zf();
                    break;
                case "45":
                    siemensTcpNet.Write("DB22.150", -4450f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 2620f);
                    zf();
                    break;
                case "47":
                    siemensTcpNet.Write("DB22.150", -4450f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 3930f);
                    zf();
                    break;
                case "49":
                    siemensTcpNet.Write("DB22.150", -4450f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 5240f);
                    zf();
                    break;
                case "2":                 
                    break;
                case "4":
                    siemensTcpNet.Write("DB22.150", 0f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 1310f);
                    yf();
                    break;
                case "6":
                    siemensTcpNet.Write("DB22.150", 0f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 2620f);
                    yf();
                    break;
                case "8":
                    siemensTcpNet.Write("DB22.150", 0f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 3930f);
                    yf();
                    break;
                case "10":
                    siemensTcpNet.Write("DB22.150", 0f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 5240f);
                    yf();
                    break;
                case "12":
                    siemensTcpNet.Write("DB22.150", -1110f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 0f);
                    yf();
                    break;
                case "14":
                    siemensTcpNet.Write("DB22.150", -1110f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 1310f);                  
                    yf();
                    break;
                case "16":
                    siemensTcpNet.Write("DB22.150", -1110f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 2620f);
                    yf();
                    break;
                case "18":
                    siemensTcpNet.Write("DB22.150", -1110f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 3930f);
                    yf();
                    break;
                case "20":
                    siemensTcpNet.Write("DB22.150", -1110f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 5240f);
                    yf();
                    break;
                case "22":
                    siemensTcpNet.Write("DB22.150", -2220f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 0f);
                    yf();
                    break;
                case "24":
                    siemensTcpNet.Write("DB22.150", -2220f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 1310f);
                    yf();
                    break;
                case "26":
                    siemensTcpNet.Write("DB22.150", -2220f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 2620f);
                    yf();
                    break;
                case "28":
                    siemensTcpNet.Write("DB22.150", -2220f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 3930f);
                    yf();
                    break;
                case "30":
                    siemensTcpNet.Write("DB22.150", -2220f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 5240f);
                    yf();
                    break;
                case "32":
                    siemensTcpNet.Write("DB22.150", -3340f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 0f);
                    yf();
                    break;
                case "34":
                    siemensTcpNet.Write("DB22.150", -3340f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 1310f);
                    yf();
                    break;
                case "36":
                    siemensTcpNet.Write("DB22.150", -3340f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 2620f);
                    yf();
                    break;
                case "38":
                    siemensTcpNet.Write("DB22.150", -3340f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 3930f);
                    yf();
                    break;
                case "40":
                    siemensTcpNet.Write("DB22.150", -3340f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 5240f);
                    yf();
                    break;
                case "42":
                    siemensTcpNet.Write("DB22.150", -4450f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 0f);
                    yf();
                    break;
                case "44":
                    siemensTcpNet.Write("DB22.150", -4450f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 1310f);
                    yf();
                    break;
                case "46":
                    siemensTcpNet.Write("DB22.150", -4450f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 4460f);
                    yf();
                    break;
                case "48":
                    siemensTcpNet.Write("DB22.150", -4450f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 3930f);
                    yf();
                    break;
                case "50":
                    siemensTcpNet.Write("DB22.150", -4450f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 5240f);
                    yf();
                    break;
            }

        }
        /// <summary>
        /// 出库（取物）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnck_Click(object sender, EventArgs e)
        {
            DepotManage DepotManage = new DepotManage();
            DataTable dt = DepotManage.GetDepotData3(cboDepot.Text);
            string depot = dt.Rows[0]["库位"].ToString();
            switch (depot)
            {
                case "1":
                    siemensTcpNet.Write("DB22.150", 0f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 0f);
                    zq();
                    break;
                case "3":
                    siemensTcpNet.Write("DB22.150", 0f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 1310f);
                    zq();
                    break;
                case "5":
                    siemensTcpNet.Write("DB22.150", 0f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 2620f);
                    zq();
                    break;
                case "7":
                    siemensTcpNet.Write("DB22.150", 0f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 3930f);
                    zq();
                    break;
                case "9":
                    siemensTcpNet.Write("DB22.150", 0f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 5240f);
                    zq();
                    break;
                case "11":
                    siemensTcpNet.Write("DB22.150", -1110f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 0f);
                    zq();
                    break;
                case "13":
                    siemensTcpNet.Write("DB22.150", -1110f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 1310f);
                    zq();
                    break;
                case "15":
                    siemensTcpNet.Write("DB22.150", -1110f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 2620f);
                    zq();
                    break;
                case "17":
                    siemensTcpNet.Write("DB22.150", -1110f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 3930f);
                    zq();
                    break;
                case "19":
                    siemensTcpNet.Write("DB22.150", -1110f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 5240f);
                    zq();
                    break;
                case "21":
                    siemensTcpNet.Write("DB22.150", -2220f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 0f);
                    zq();
                    break;
                case "23":
                    siemensTcpNet.Write("DB22.150", -2220f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 1310f);
                    zq();
                    break;
                case "25":
                    siemensTcpNet.Write("DB22.150", -2220f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 2620f);
                    zq();
                    break;
                case "27":
                    siemensTcpNet.Write("DB22.150", -2220f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 3930f);
                    zq();
                    break;
                case "29":
                    siemensTcpNet.Write("DB22.150", -2220f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 5240f);
                    zq();
                    break;
                case "31":
                    siemensTcpNet.Write("DB22.150", -3340f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 0f);
                    zq();
                    break;
                case "33":
                    siemensTcpNet.Write("DB22.150", -3340f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 1310f);
                    zq();
                    break;
                case "35":
                    siemensTcpNet.Write("DB22.150", -3340f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 2620f);
                    zq();
                    break;
                case "37":
                    siemensTcpNet.Write("DB22.150", -3340f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 3930f);
                    zq();
                    break;
                case "39":
                    siemensTcpNet.Write("DB22.150", -3340f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 5240f);
                    zq();
                    break;
                case "41":
                    siemensTcpNet.Write("DB22.150", -4450f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 0f);
                    zq();
                    break;
                case "43":
                    siemensTcpNet.Write("DB22.150", -4450f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 1310f);
                    zq();
                    break;
                case "45":
                    siemensTcpNet.Write("DB22.150", -4450f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 2620f);
                    zq();
                    break;
                case "47":
                    siemensTcpNet.Write("DB22.150", -4450f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 3930f);
                    zq();
                    break;
                case "49":
                    siemensTcpNet.Write("DB22.150", -4450f);
                    siemensTcpNet.Write("DB22.158", 630f);
                    siemensTcpNet.Write("DB22.154", 5240f);
                    zq();
                    break;
                case "2":
                    break;
                case "4":
                    siemensTcpNet.Write("DB22.150", 0f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 1310f);
                    yq();
                    break;
                case "6":
                    siemensTcpNet.Write("DB22.150", 0f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 2620f);
                    yq();
                    break;
                case "8":
                    siemensTcpNet.Write("DB22.150", 0f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 3930f);
                    yq();
                    break;
                case "10":
                    siemensTcpNet.Write("DB22.150", 0f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 5240f);
                    yq();
                    break;
                case "12":
                    siemensTcpNet.Write("DB22.150", -1110f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 0f);
                    yq();
                    break;
                case "14":
                    siemensTcpNet.Write("DB22.150", -1110f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 1310f);
                    yq();
                    break;
                case "16":
                    siemensTcpNet.Write("DB22.150", -1110f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 2620f);
                    yq();
                    break;
                case "18":
                    siemensTcpNet.Write("DB22.150", -1110f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 3930f);
                    yq();
                    break;
                case "20":
                    siemensTcpNet.Write("DB22.150", -1110f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 5240f);
                    yq();
                    break;
                case "22":
                    siemensTcpNet.Write("DB22.150", -2220f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 0f);
                    yq();
                    break;
                case "24":
                    siemensTcpNet.Write("DB22.150", -2220f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 1310f);
                    yq();
                    break;
                case "26":
                    siemensTcpNet.Write("DB22.150", -2220f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 2620f);
                    yq();
                    break;
                case "28":
                    siemensTcpNet.Write("DB22.150", -2220f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 3930f);
                    yq();
                    break;
                case "30":
                    siemensTcpNet.Write("DB22.150", -2220f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 5240f);
                    yq();
                    break;
                case "32":
                    siemensTcpNet.Write("DB22.150", -3340f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 0f);
                    yq();
                    break;
                case "34":
                    siemensTcpNet.Write("DB22.150", -3340f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 1310f);
                    yq();
                    break;
                case "36":
                    siemensTcpNet.Write("DB22.150", -3340f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 2620f);
                    yq();
                    break;
                case "38":
                    siemensTcpNet.Write("DB22.150", -3340f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 3930f);
                    yq();
                    break;
                case "40":
                    siemensTcpNet.Write("DB22.150", -3340f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 5240f);
                    yq();
                    break;
                case "42":
                    siemensTcpNet.Write("DB22.150", -4450f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 0f);
                    yq();
                    break;
                case "44":
                    siemensTcpNet.Write("DB22.150", -4450f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 1310f);
                    yq();
                    break;
                case "46":
                    siemensTcpNet.Write("DB22.150", -4450f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 4460f);
                    yq();
                    break;
                case "48":
                    siemensTcpNet.Write("DB22.150", -4450f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 3930f);
                    yq();
                    break;
                case "50":
                    siemensTcpNet.Write("DB22.150", -4450f);
                    siemensTcpNet.Write("DB22.158", -630f);
                    siemensTcpNet.Write("DB22.154", 5240f);
                    yq();
                    break;
            }
        }
        /// <summary>
        /// PLC连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBillAdd_Load(object sender, EventArgs e)
        {
            OperateResult connect = siemensTcpNet.ConnectServer();
            if (connect.IsSuccess)
            {
                lblcon.Text = "PLC连接成功";
                btnrk.Enabled = true;
                btnck.Enabled = true;
                btnrecon.Enabled = true;
                
            }
            else
            {
                lblcon.Text = "PLC连接失败,请重新连接";
                siemensTcpNet.ConnectClose();
            }
        }
        /// <summary>
        /// PLC重连
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnrecon_Click(object sender, EventArgs e)
        {
            SiemensS7Net siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500, "192.168.99.152")
            {
                ConnectTimeOut = 500
            };
            OperateResult connect = siemensTcpNet.ConnectServer();
            if (connect.IsSuccess)
            {
                lblcon.Text = "PLC连接成功";
                btnrk.Enabled = true;
                btnck.Enabled = true;
                btnrecon.Enabled = false;               
            }
            else
            {
                lblcon.Text = "PLC连接失败,请重新连接";
                siemensTcpNet.ConnectClose();               
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            btnrk.Enabled = true;
            btnck.Enabled = true;
            btnrecon.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnrk.Enabled = true;
            btnck.Enabled = true;
        }

        private void frmBillAdd_KeyPress(object sender, KeyPressEventArgs e)
        {

            gridView1.AddNewRow();
            gridView1.SetFocusedRowCellValue(gridMaterialId, 1);
        }

        //private void label3_TextChanged(object sender, EventArgs e)
        //{

        //    if (Tag.ToString() != "")
        //    {
        //        //得到选择的料件guid，然后得到
        //        Material material = MaterialManage.GetMaterialByGuid(Tag.ToString());

        //        //填充数据
        //        gridView1.AddNewRow();
        //        gridView1.SetFocusedRowCellValue(gridMaterialGuid, material.MaterialGuid);
        //        gridView1.SetFocusedRowCellValue(gridMaterialId, material.MaterialId);
        //        gridView1.SetFocusedRowCellValue(gridMaterialName, material.MaterialName);
        //        gridView1.SetFocusedRowCellValue(gridCN, material.ClassId);
        //        gridView1.SetFocusedRowCellValue(gridSpec, material.Spec);
        //        gridView1.SetFocusedRowCellValue(gridProNo, material.ProNo);
        //        gridView1.SetFocusedRowCellValue(gridCadNo, material.CadNo);
        //        gridView1.SetFocusedRowCellValue(gridUnit, material.Unit);
        //        //gridView1.SetFocusedRowCellValue(gridzj, material.Zj);
        //        //gridView1.SetFocusedRowCellValue(gridgh, material.Gh);
        //        //gridView1.SetFocusedRowCellValue(gridbz, material.Bz);
        //        //gridView1.SetFocusedRowCellValue(gridqd, material.Qd);
        //        //gridView1.SetFocusedRowCellValue(gridcd, material.Cd);
        //        gridView1.SetFocusedRowCellValue(gridjz, material.Jz);
        //        //gridView1.SetFocusedRowCellValue(gridmz, material.Mz);
        //        gridView1.SetFocusedRowCellValue(gridscrq, material.Scrq);
        //        gridView1.SetFocusedRowCellValue(gridRemark, material.Remark);
        //    }
        //}

        

 

        private void frmBillAdd_Activated(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {//如果输入的是回车键 
                string value = textBox1.Text;
                DataTable dtl = MaterialManage.GetSelectMaterialData_CN("where MaterialId='" + value + "'");
                if (dtl.Rows.Count > 0)
                { 
                gridView1.AddNewRow();
                gridView1.SetFocusedRowCellValue(gridMaterialGuid, dtl.Rows[0]["MaterialGuid"].ToString());
                gridView1.SetFocusedRowCellValue(gridMaterialId, dtl.Rows[0]["条码号"].ToString());
                gridView1.SetFocusedRowCellValue(gridMaterialName, dtl.Rows[0]["品名"].ToString());
                gridView1.SetFocusedRowCellValue(gridCN, dtl.Rows[0]["货品分类"].ToString());
                gridView1.SetFocusedRowCellValue(gridSpec, dtl.Rows[0]["型号"].ToString());
                gridView1.SetFocusedRowCellValue(gridProNo, dtl.Rows[0]["项目号"].ToString());
                gridView1.SetFocusedRowCellValue(gridCadNo, dtl.Rows[0]["图号"].ToString());
                gridView1.SetFocusedRowCellValue(gridUnit, dtl.Rows[0]["单位"].ToString());
                gridView1.SetFocusedRowCellValue(gridjz, dtl.Rows[0]["重量"].ToString());
                gridView1.SetFocusedRowCellValue(gridscrq, dtl.Rows[0]["生产日期"].ToString());
                gridView1.SetFocusedRowCellValue(gridRemark, dtl.Rows[0]["备注"].ToString());
                textBox1.Text = "";
                }
                else{
                    MessageBox.Show("无此条码，请查询后重试！");
                    textBox1.Text ="" ;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "开启扫码模式")
            { 
                textBox1.Visible = true;
                textBox1.Enabled = true;
                textBox1.Focus();
                button2.Text = "关闭扫码模式";
            }
            else
            {
                textBox1.Visible = false;
                textBox1.Enabled = false;
                button2.Text = "开启扫码模式";
            }
        }
    }
}