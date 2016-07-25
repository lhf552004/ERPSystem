using System;
namespace ERP.Model
{
	/// <summary>
	/// Statistics:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Statistics
	{
		public Statistics()
		{}
		#region Model
		private long _oid;
		private long? _dis_oid;
		private long _war_oid;
		private Product _product;
		private string _ident;
		private string _description;
		private string _modifyuser;
		private int? _number;
		private int? _statisticmonth;
		private int? _receivalstatistic;
		private int? _dispatchstatistic;
		/// <summary>
		/// 
		/// </summary>
		public long OID
		{
			set{ _oid=value;}
			get{return _oid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? Dis_OID
		{
			set{ _dis_oid=value;}
			get{return _dis_oid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long War_OID
		{
			set{ _war_oid=value;}
			get{return _war_oid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Product Product
		{
			set{ _product=value;}
			get{return _product;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Ident
		{
			set{ _ident=value;}
			get{return _ident;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ModifyUser
		{
			set{ _modifyuser=value;}
			get{return _modifyuser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Number
		{
			set{ _number=value;}
			get{return _number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? StatisticMonth
		{
			set{ _statisticmonth=value;}
			get{return _statisticmonth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ReceivalStatistic
		{
			set{ _receivalstatistic=value;}
			get{return _receivalstatistic;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DispatchStatistic
		{
			set{ _dispatchstatistic=value;}
			get{return _dispatchstatistic;}
		}
		#endregion Model

	}
}

