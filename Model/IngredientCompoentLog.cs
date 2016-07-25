using System;
namespace ERP.Model
{
	/// <summary>
	/// IngredientCompoentLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class IngredientCompoentLog
	{
		public IngredientCompoentLog()
		{}
		#region Model
		private long _oid;
		private string _productident;
		private string _ingr_oidtext;
        private IngredientCategoryEnum _ingredientcategory;
		private int? _num;
		private DateTime? _finishdate;
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
		public string ProductIdent
		{
			set{ _productident=value;}
			get{return _productident;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Ingr_OIDText
		{
			set{ _ingr_oidtext=value;}
			get{return _ingr_oidtext;}
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
		public int? Num
		{
			set{ _num=value;}
			get{return _num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? FinishDate
		{
			set{ _finishdate=value;}
			get{return _finishdate;}
		}
		#endregion Model

	}
}

