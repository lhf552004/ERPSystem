using System;
namespace ERP.Model
{
    /// <summary>
    /// receival Receival state
    /// </summary>
    public enum DispatchStateEnum : byte
    {
        Undefined = 0,
        WaitDispatch = 1,
        Dispatched = 2,
        App01 = 15,
        App02 = 16,
        App03 = 17,
        App04 = 18,
        App05 = 19

    }
	/// <summary>
	/// Dispatch:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Dispatch
	{
		public Dispatch()
		{}
		#region Model
		private long _oid;
		private Agent _agent;
		private string _ident;
		private DateTime? _creationdate;
		private string _description;
		private decimal _price;
		private AuditStateEnum _auditstate;
        private DispatchStateEnum _dispatchstate;
		private string _modifyuser;
		private DateTime? _dispatchdate;
		private string _auditor;
		private string _operator;
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
		public Agent Agent
		{
            set { _agent = value; }
            get { return _agent; }
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
		public DateTime? CreationDate
		{
			set{ _creationdate=value;}
			get{return _creationdate;}
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
		public decimal Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public AuditStateEnum auditState
		{
			set{ _auditstate=value;}
			get{return _auditstate;}
		}
		/// <summary>
		/// 
		/// </summary>
        public DispatchStateEnum DispatchState
		{
			set{ _dispatchstate=value;}
			get{return _dispatchstate;}
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
		public DateTime? DispatchDate
		{
			set{ _dispatchdate=value;}
			get{return _dispatchdate;}
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
		#endregion Model

	}
}

