using System;
namespace ERP.Model
{
	/// <summary>
	/// ExpectPayAccount:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ExpectPayAccount
	{
		public ExpectPayAccount()
		{}
		#region Model
		private long _oid;
		private string _ident;
		private string _description;
		private DateTime? _creationdate;
		private decimal? _lender;
		private decimal? _loaned;
		private string _modifyuser;
		private string _payreason;
		private string _auditor;
		private string _operator;
		private string _getmoneyperson;
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
		public DateTime? CreationDate
		{
			set{ _creationdate=value;}
			get{return _creationdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Lender
		{
			set{ _lender=value;}
			get{return _lender;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Loaned
		{
			set{ _loaned=value;}
			get{return _loaned;}
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
		public string PayReason
		{
			set{ _payreason=value;}
			get{return _payreason;}
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
		public string Operator
		{
			set{ _operator=value;}
			get{return _operator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GetMoneyPerson
		{
			set{ _getmoneyperson=value;}
			get{return _getmoneyperson;}
		}
		#endregion Model

	}
}

