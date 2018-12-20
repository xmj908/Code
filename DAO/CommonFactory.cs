using System;

namespace XMJ.DAO
{
	/// <summary>
	/// ���ߣ�������
	/// ���ã���������ö�١�
	/// ���ڣ�2018-01-24
	/// </summary>
	public enum CommonData
	{
		/// <summary>
		/// ��SQL Server��ʽ
		/// </summary>
		sql = 1,
		/// <summary>
		/// ��OLEDB��ʽ
		/// </summary>
		oledb = 2,
		/// <summary>
		/// ��oracle��ʽ
		/// </summary>
		Oracle = 3,
	} ;

	/// <summary>
	/// ���ߣ�������
	/// ���ã� ���ݿ���ʹ����ࡣ
	/// ���ڣ�2018-01-24
	/// </summary>
	public class CommonFactory
	{
		/// <summary>
		/// ����һ�����ݷ��ʽӿ�
		/// </summary>
		/// <param name="CommonData_Parameter">���ݷ�������</param>
		/// <returns>CommonInterface�ӿ�</returns>
		/// <example>ʾ����
		///	<code>
		///	using XMJ.DAO;
		///	����ʹ��Ĭ���������ӵ�SQL���ݷ��ʽӿ�
		///	CommonInterface pComm=CommonFactory.CreateInstance(CommonData.sql);
		///	</code>
		/// </example>
		public static CommonInterface CreateInstance(CommonData CommonData_Parameter)
		{
			switch ((int) CommonData_Parameter)
			{
				case 1:
					return new CommonSql();
				case 2:
					return new CommonOle();
				case 3:
					return new CommonOracle();
				default:
					return new CommonSql();
			}
		}

		/// <summary>
		/// ����һ�����ݷ��ʽӿ�
		/// </summary>
		/// <param name="CommonData_Parameter">���ݷ�������</param>
		/// <param name="connstr">���ݿ�����Ӵ�</param>
		/// <returns>CommonInterface�ӿ�</returns>
		/// <example>ʾ����
		///	<code>
		///	using XMJ.DAO;	
		///	string pConnectionString="";	
		///	ConnectionDefaultStr = "server=.;database=readsystem;uid=sa;pwd=";
		///	����ʹ��Ĭ���������ӵ�SQL���ݷ��ʽӿ�
		///	CommonInterface pComm=CommonFactory.CreateInstance(CommonData.sql,pConnectionString);
		///	</code>
		/// </example>
		public static CommonInterface CreateInstance(CommonData CommonData_Parameter, String connstr)
		{
			switch ((int) CommonData_Parameter)
			{
				case 1:
					return new CommonSql(connstr);
				case 2:
					return new CommonOle(connstr);
				case 3:
					return new CommonOracle(connstr);
				default:
					return new CommonSql(connstr);
			}
		}

	}
}