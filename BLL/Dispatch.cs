using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using ERP.Model;
namespace ERP.BLL
{
	/// <summary>
	/// Dispatch
	/// </summary>
	public partial class Dispatch
	{
		private readonly ERP.DAL.Dispatch dal=new ERP.DAL.Dispatch();
        private readonly ERP.DAL.IngredientCompoent dalIngredientCompoent = new ERP.DAL.IngredientCompoent();
        private readonly ERP.BLL.IngredientCompoent bllIngredientCompoent = new ERP.BLL.IngredientCompoent();
		public Dispatch()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long OID)
		{
			return dal.Exists(OID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ERP.Model.Dispatch model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ERP.Model.Dispatch model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(long OID)
		{
			
			return dal.Delete(OID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string OIDlist )
		{
			return dal.DeleteList(OIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ERP.Model.Dispatch GetModel(long OID)
		{
			
			return dal.GetModel(OID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public ERP.Model.Dispatch GetModelByCache(long OID)
		{
			
			string CacheKey = "DispatchModel-" + OID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(OID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (ERP.Model.Dispatch)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ERP.Model.Dispatch> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ERP.Model.Dispatch> DataTableToList(DataTable dt)
		{
			List<ERP.Model.Dispatch> modelList = new List<ERP.Model.Dispatch>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ERP.Model.Dispatch model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(ERP.Model.IngredientCompoent model)
        {
            return dalIngredientCompoent.Add(model);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(ERP.Model.IngredientCompoent model)
        {

            return dalIngredientCompoent.Delete(model.OID);
        }
        /// <summary>
        /// 获取所有组份
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        public DataSet GetAllIngredientCompoents(Model.Dispatch Model)
        {

            string strWhere = "Dis_OID = " + Model.OID;
            return dalIngredientCompoent.GetList(strWhere);

        }
        //public bool Add()
        //{

        //}
        /// <summary>
        /// 获取所有组份
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        public List<ERP.Model.IngredientCompoent> GetAllIngredientCompoentModels(Model.Dispatch Model)
        {

            DataSet ds = GetAllIngredientCompoents(Model);
            return bllIngredientCompoent.DataTableToList(ds.Tables[0]);


        }
		#endregion  ExtensionMethod
	}
}

