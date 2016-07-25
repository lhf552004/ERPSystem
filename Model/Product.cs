using System;
namespace ERP.Model
{
    /// <summary>
    /// Category of Product
    /// </summary>
    public enum ProductCategory : byte
    {
        Undefined = 0,
        RawMaterial = 5,
        FinishedProduct = 10,
        App01 = 15,
        App02 = 16,
        App03 = 17,
        App04 = 18,
        App05 = 19


    }
	/// <summary>
	/// Product:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Product
	{
		public Product()
		{}
		#region Model
		private long _oid;
        private Statistics _statistics;
		private string _ident;
		private string _name;
		private string _description;
		private string _modifyuser;
        private ProductCategory? _category;
		private decimal _price;
		private DateTime? _creationdate;
		private DateTime? _modifydate;
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
        public Statistics Statistics
		{
            set { _statistics = value; }
            get { return _statistics; }
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
		public string ModifyUser
		{
			set{ _modifyuser=value;}
			get{return _modifyuser;}
		}
		/// <summary>
		/// 
		/// </summary>
        public ProductCategory? Category
		{
			set{ _category=value;}
			get{return _category;}
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
		public DateTime? CreationDate
		{
			set{ _creationdate=value;}
			get{return _creationdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ModifyDate
		{
			set{ _modifydate=value;}
			get{return _modifydate;}
		}
		#endregion Model

	}
}

