using System;
namespace ERP.Model
{
    public enum AgentLevelEnum
    {
        Undifined =0,
        NormalAgentLevel = 1,
        BronzeAgentLevel =2,
        SilverAgentLevel =3,
        GoldAgentLevel = 5

    }
	/// <summary>
	/// Agent:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Agent
	{
		public Agent()
		{}
		#region Model
		private long _oid;
		private string _ident;
		private string _address;
		private string _name;
		private string _description;
		private string _modifyuser;
        private AgentLevelEnum _agentlevel;
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
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
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
		public string ModifyUser
		{
			set{ _modifyuser=value;}
			get{return _modifyuser;}
		}
		/// <summary>
		/// 
		/// </summary>
        public AgentLevelEnum AgentLevel
		{
			set{ _agentlevel=value;}
			get{return _agentlevel;}
		}
		#endregion Model

	}
}

