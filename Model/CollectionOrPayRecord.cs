using System;
namespace ERP.Model
{
	/// <summary>
	/// CollectionOrPayRecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CollectionOrPayRecord
	{
		public CollectionOrPayRecord()
		{}
		#region Model
		private long _oid;
		private long _exp_oid;
		private long _exp_oid2;
		private DateTime? _tradedate;
		private decimal? _money;
		private string _auditor;
		private int? _auditstate;
		private string _operator;
		private string _invoice;
		private string _description;
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
		public long Exp_OID
		{
			set{ _exp_oid=value;}
			get{return _exp_oid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long Exp_OID2
		{
			set{ _exp_oid2=value;}
			get{return _exp_oid2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? TradeDate
		{
			set{ _tradedate=value;}
			get{return _tradedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Auditor
		{
			set{ _auditor=value;}
			get{return _auditor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? auditState
		{
			set{ _auditstate=value;}
			get{return _auditstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Operator
		{
			set{ _operator=value;}
			get{return _operator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Invoice
		{
			set{ _invoice=value;}
			get{return _invoice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		#endregion Model

	}
}

