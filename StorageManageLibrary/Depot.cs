using System;
using System.Collections.Generic;
using System.Text;
using XMJ.DAO;
using System.Data;

namespace StorageManageLibrary
{
    /// <summary>
    ///  �ֿ���
    /// </summary>
    public class Depot
    {
	#region Model
		private string _depotguid;
		private string _depotname;
		private string _depotperson;
		private string _telephone;
		private string _remark;
        private string _DepotCoordinate;
        /// <summary>
        /// 
        /// </summary>
        public string DepotGuid
		{
			set{ _depotguid=value;}
			get{return _depotguid;}
		}
		/// <summary>
		/// ��λ
		/// </summary>
		public string DepotName
		{
			set{ _depotname=value;}
			get{return _depotname;}
		}
		/// <summary>
		/// ������
		/// </summary>
		public string DepotPerson
		{
			set{ _depotperson=value;}
			get{return _depotperson;}
		}
		/// <summary>
		/// �����˵绰
		/// </summary>
		public string Telephone
		{
			set{ _telephone=value;}
			get{return _telephone;}
		}
		/// <summary>
		/// ��ע
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}

        public string DepotCoordinate { get => _DepotCoordinate; set => _DepotCoordinate = value; }
        #endregion Model


        #region  ��Ա����



        /// <summary>
        /// ����һ������
        /// </summary>
        public bool Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into [Depot](");
			strSql.Append("DepotGuid,DepotName,DepotPerson,Telephone,Remark,DepotCoordinate");
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append("'"+DepotGuid+"',");
			strSql.Append("'"+DepotName+"',");
			strSql.Append("'"+DepotPerson+"',");
			strSql.Append("'"+Telephone+"',");
			strSql.Append("'"+Remark+"',");
            strSql.Append("'" + DepotCoordinate + "'");
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
			strSql.Append("update Depot set ");
			strSql.Append("DepotName='"+DepotName+"',");
			strSql.Append("DepotPerson='"+DepotPerson+"',");
			strSql.Append("Telephone='"+Telephone+"',");
			strSql.Append("Remark='"+Remark+"',");
            strSql.Append("DepotCoordinate='" + DepotCoordinate + "'");
            strSql.Append(" where DepotGuid='"+DepotGuid+"' ");
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
