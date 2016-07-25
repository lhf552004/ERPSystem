using System;
namespace ERP.Model
{
    /// <summary>
    /// receival Receival state
    /// </summary>
    public enum ReceiveStateEnum : byte
    {
        Undefined = 0,
        WaitReceive = 1,
        Finished = 2,
        App01 = 15,
        App02 = 16,
        App03 = 17,
        App04 = 18,
        App05 = 19

    }
    /// <summary>
    /// receival audit state
    /// </summary>
    public enum AuditStateEnum : byte
    {
        Undefined = 0,
        WaitAudit = 1,
        Audited = 2,
        App01 = 15,
        App02 = 16,
        App03 = 17,
        App04 = 18,
        App05 = 19

    }
	/// <summary>
	/// Receival:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Receival
	{
		public Receival()
		{}
		#region Model
		private long _oid;
		private string _ident;
		private string _name;
		private string _description;
        private AuditStateEnum? _auditstate;
        private ReceiveStateEnum? _receivalstate;
		private DateTime? _finishreceiptdate;
		private DateTime? _creationdate;
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
		public string Ident
		{
			set{ _ident=value;}
			get{return _ident;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
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
        public AuditStateEnum? auditState
		{
			set{ _auditstate=value;}
			get{return _auditstate;}
		}
		/// <summary>
		/// 
		/// </summary>
        public ReceiveStateEnum? ReceivalState
		{
			set{ _receivalstate=value;}
			get{return _receivalstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? FinishReceiptDate
		{
			set{ _finishreceiptdate=value;}
			get{return _finishreceiptdate;}
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

