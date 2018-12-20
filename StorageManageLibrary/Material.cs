using System;
using System.Collections.Generic;
using System.Text;
using XMJ.DAO;
using System.Data;
namespace StorageManageLibrary
{
    /// <summary>
    ///  ��Ʒʵ����
    /// </summary>
    public class Material
    {
	   #region Model
		private string _materialguid;
		private int _upperlimit;
		private int _lowerlimit;
		private decimal _iconsultprice;
		private decimal _econsultprice;
		private string _calculatemethod;
		private string _remark;
		private string _materialid;
		private string _materialname;
		private string _classid;
		private string _spec;
		private string _unit;
		private string _barno;
		private string _place;
		private string _encapsulation;
        private string _zj;
        private string _gh;
        private string _bz;
        private string _qd;
        private string _cd;
        private string _jz;
        private string _mz;
        private DateTime _scrq;
        private String _ProNo;
        private String _CadNo;


        /// <summary>
        /// 
        /// </summary>
        public string MaterialGuid
		{
			set{ _materialguid=value;}
			get{return _materialguid;}
		}
		/// <summary>
		/// �������
		/// </summary>
		public int UpperLimit
		{
			set{ _upperlimit=value;}
			get{return _upperlimit;}
		}
		/// <summary>
		/// �������
		/// </summary>
		public int LowerLimit
		{
			set{ _lowerlimit=value;}
			get{return _lowerlimit;}
		}
		/// <summary>
		/// ���ο���
		/// </summary>
		public decimal IConsultPrice
		{
			set{ _iconsultprice=value;}
			get{return _iconsultprice;}
		}
		/// <summary>
		/// ����ο���
		/// </summary>
		public decimal EConsultPrice
		{
			set{ _econsultprice=value;}
			get{return _econsultprice;}
		}
		/// <summary>
		/// �Ƽ۷���
		/// </summary>
		public string CalculateMethod
		{
			set{ _calculatemethod=value;}
			get{return _calculatemethod;}
		}
		/// <summary>
		/// ��ע
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// �����
		/// </summary>
		public string MaterialId
		{
			set{ _materialid=value;}
			get{return _materialid;}
		}
		/// <summary>
		/// Ʒ��
		/// </summary>
		public string MaterialName
		{
			set{ _materialname=value;}
			get{return _materialname;}
		}
		/// <summary>
		/// �������
		/// </summary>
		public string ClassId
		{
			set{ _classid=value;}
			get{return _classid;}
		}
		/// <summary>
		/// �ͺ�
		/// </summary>
		public string Spec
		{
			set{ _spec=value;}
			get{return _spec;}
		}
		/// <summary>
		/// ��λ
		/// </summary>
		public string Unit
		{
			set{ _unit=value;}
			get{return _unit;}
		}
		/// <summary>
		/// ������
		/// </summary>
		public string BarNo
		{
			set{ _barno=value;}
			get{return _barno;}
		}
		/// <summary>
		/// ��λ
		/// </summary>
		public string Place
		{
			set{ _place=value;}
			get{return _place;}
		}
		/// <summary>
		/// ��װ
		/// </summary>
		public string Encapsulation
		{
			set{ _encapsulation=value;}
			get{return _encapsulation;}
		}

        public string Cd { get => _cd; set => _cd = value; }
        public string Zj { get => _zj; set => _zj = value; }
        public string Gh { get => _gh; set => _gh = value; }
        public string Bz { get => _bz; set => _bz = value; }
        public string Jz { get => _jz; set => _jz = value; }
        public string Mz { get => _mz; set => _mz = value; }
      
        public DateTime Scrq { get => _scrq; set => _scrq = value; }
        public string Qd { get => _qd; set => _qd = value; }
        public string ProNo { get => _ProNo; set => _ProNo = value; }
        public string CadNo { get => _CadNo; set => _CadNo = value; }
        #endregion Model


        #region  ��Ա����

        /// <summary>
        /// ����һ������
        /// </summary>
        public bool Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into [Material](");
			strSql.Append("MaterialGuid,MaterialId,MaterialName,ClassId,Spec,ProNo,CadNo,Unit,zj,gh,bz,qd,cd,jz,mz,scrq,Remark");
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append("'"+MaterialGuid+"',");
			//strSql.Append(""+UpperLimit+",");
			//strSql.Append(""+LowerLimit+",");
			//strSql.Append(""+IConsultPrice+",");
			//strSql.Append(""+EConsultPrice+",");
			//strSql.Append("'"+CalculateMethod+"',");
			
			strSql.Append("'"+MaterialId+"',");
			strSql.Append("'"+MaterialName+"',");
			strSql.Append("'"+ClassId+"',");
			strSql.Append("'"+Spec+"',");
            strSql.Append("'" + ProNo + "',");
            strSql.Append("'" + CadNo + "',");
            strSql.Append("'"+Unit+"',");
			//strSql.Append("'"+BarNo+"',");
			//strSql.Append("'"+Place+"',");
			//strSql.Append("'"+Encapsulation+"'");
            strSql.Append("'" + Zj + "',");
            strSql.Append("'" + Gh + "',");
            strSql.Append("'" + Bz + "',");
            strSql.Append("'" + Qd + "',");
            strSql.Append("'" + Cd + "',");
            strSql.Append("'" + Jz + "',");
            strSql.Append("'" + Mz + "',");
            strSql.Append("'" + Scrq + "',");
            strSql.Append("'" + Remark + "'");
            strSql.Append(")");
			CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);

            try
            {
                pComm.Execute(strSql.ToString());//ִ��Sql����޷���ֵ
                pComm.Close();
                return true;
            }
            catch (System.Exception e)
            {
                pComm.Close();
                throw e;
            }		
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Material set ");
			//strSql.Append("UpperLimit="+UpperLimit+",");
			//strSql.Append("LowerLimit="+LowerLimit+",");
			//strSql.Append("IConsultPrice="+IConsultPrice+",");
			//strSql.Append("EConsultPrice="+EConsultPrice+",");
			//strSql.Append("CalculateMethod='"+CalculateMethod+"',");
		
			strSql.Append("MaterialId='"+MaterialId+"',");
			strSql.Append("MaterialName='"+MaterialName+"',");
			strSql.Append("ClassId='"+ClassId+"',");
			strSql.Append("Spec='"+Spec+"',");
            strSql.Append("ProNo='" + ProNo + "',");
            strSql.Append("CadNo='" + CadNo + "',");
            strSql.Append("Unit='"+Unit+"',");
			strSql.Append("BarNo='"+BarNo+"',");
			strSql.Append("Place='"+Place+"',");
			strSql.Append("Zj='" + Zj + "',");
            strSql.Append("Gh='" + Gh + "',");
            strSql.Append("Bz='" + Bz + "',");
            strSql.Append("Qd='" + Qd + "',");
            strSql.Append("Cd='" + Cd + "',");
            strSql.Append("Jz='" + Jz + "',");
            strSql.Append("Mz='" + Mz + "',");
            strSql.Append("Scrq='" + Scrq + "',");
            strSql.Append("Remark='" + Remark + "'");
            strSql.Append(" where MaterialGuid='"+MaterialGuid+"' ");
			CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);

            try
            {
                pComm.Execute(strSql.ToString());//ִ��Sql����޷���ֵ
                pComm.Close();
                return true;
            }
            catch (System.Exception e)
            {
                pComm.Close();
                throw e;
            }		
		}
		#endregion  ��Ա����
	}
}

