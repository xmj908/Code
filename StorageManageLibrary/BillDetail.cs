using System;
using System.Collections.Generic;
using System.Text;

namespace StorageManageLibrary
{
    public class BillDetail
    {

        #region Model
        private string _billdetailguid;
        private string _remark;
        private string _billguid;
        private string _materialguid;
        private string _materialid;
        private string _materialname;
        private string _barno;
        private string _spec;
        private string _unit;
        private decimal _price;
        private decimal _qty;
        private decimal _total;
        private string _zj;
        private string _gh;
        private string _bz;
        private string _qd;
        private string _cd;
        private string _jz;
        private string _mz;
        private DateTime _scrq;
        private string _ClassName;
        private string _ProNo;
        private string _CadNo;

        /// <summary>
        /// 
        /// </summary>
        public string BillDetailGuid
        {
            set { _billdetailguid = value; }
            get { return _billdetailguid; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// 单据表头Guid
        /// </summary>
        public string BillGuid
        {
            set { _billguid = value; }
            get { return _billguid; }
        }
        /// <summary>
        /// 货品guid
        /// </summary>
        public string MaterialGuid
        {
            set { _materialguid = value; }
            get { return _materialguid; }
        }

        /// <summary>
        /// 条码号
        /// </summary>
        public string MaterialId
        {
            set { _materialid = value; }
            get { return _materialid; }
        }
        /// <summary>
        /// 品名
        /// </summary>
        public string MaterialName
        {
            set { _materialname = value; }
            get { return _materialname; }
        }
        /// <summary>
        /// 助查码
        /// </summary>
        public string BarNo
        {
            set { _barno = value; }
            get { return _barno; }
        }
        /// <summary>
        /// 型号
        /// </summary>
        public string Spec
        {
            set { _spec = value; }
            get { return _spec; }
        }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit
        {
            set { _unit = value; }
            get { return _unit; }
        }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal Price
        {
            set { _price = value; }
            get { return _price; }
        }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal Qty
        {
            set { _qty = value; }
            get { return _qty; }
        }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal Total
        {
            set { _total = value; }
            get { return _total; }
        }

        public string Zj { get => _zj; set => _zj = value; }
        public string Gh { get => _gh; set => _gh = value; }
        public string Bz { get => _bz; set => _bz = value; }
        public string Qd { get => _qd; set => _qd = value; }
        public string Cd { get => _cd; set => _cd = value; }
        public string Jz { get => _jz; set => _jz = value; }
        public string Mz { get => _mz; set => _mz = value; }
        //public string Scrq { get => Scrq1; set => Scrq1 = value; }
        public string ClassName { get => _ClassName; set => _ClassName = value; }
        public DateTime Scrq{ get => _scrq; set => _scrq = value; }
        /// <summary>
        /// 项目号
        /// </summary>
        public string ProNo { get => _ProNo; set => _ProNo = value; }
        /// <summary>
        /// 图号
        /// </summary>
        public string CadNo { get => _CadNo; set => _CadNo = value; }


        #endregion Model

    }
}
