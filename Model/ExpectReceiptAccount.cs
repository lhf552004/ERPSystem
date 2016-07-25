using System;
namespace ERP.Model
{
	/// <summary>
	/// ExpectReceiptAccount:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ExpectReceiptAccount
	{
		public ExpectReceiptAccount()
		{}
		#region Model
		private long _oid;
		private Dispatch _dispatch;
		private string _ident;
		private string _description;
        private decimal _Amount;
		private DateTime? _creationdate;
        private string _lender;
		private decimal? _loaned;
		private string _modifyuser;
		private string _auditor;
		private string _operator;
		private string _payperson;
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
		public Dispatch Dispatch
		{
			set{ _dispatch=value;}
            get { return _dispatch; }
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
        public decimal Amount
		{
			set{ _Amount=value;}
            get { return _Amount; }
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
		public string Lender
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
		public string PayPerson
		{
			set{ _payperson=value;}
			get{return _payperson;}
		}
		#endregion Model

	}
}

