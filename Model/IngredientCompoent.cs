using System;
namespace ERP.Model
{
    /// <summary>
    /// IngredientCompoent category
    /// </summary>
    public enum IngredientCategoryEnum : byte
    {
        ReceiveComp = 0,
        DispatchComp = 1

    }
	/// <summary>
	/// IngredientCompoent:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class IngredientCompoent
	{
		public IngredientCompoent()
		{}
		#region Model
		private long _oid;
		private ERP.Model.Product _product;
		private ERP.Model.Dispatch _dispatch;
		private ERP.Model.Receival _receival;
		private IngredientCategoryEnum _ingredientcategory;
		private int _num;
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
		public ERP.Model.Product Product
		{
			set{ _product=value;}
            get { return _product; }
		}
		/// <summary>
		/// 
		/// </summary>
		public ERP.Model.Dispatch Dispatch
		{
			set{ _dispatch=value;}
            get { return _dispatch; }
		}
		/// <summary>
		/// 
		/// </summary>
        public ERP.Model.Receival Receival
		{
            set { _receival = value; }
            get { return _receival; }
		}
		/// <summary>
		/// 
		/// </summary>
		public IngredientCategoryEnum IngredientCategory
		{
			set{ _ingredientcategory=value;}
			get{return _ingredientcategory;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Num
		{
            set { _num = value; }
            get { return _num; }
		}
		#endregion Model

	}
}

