using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using ERP.Model;
namespace ERP.BLL
{
	/// <summary>
	/// IngredientCompoentLog
	/// </summary>
	public partial class IngredientCompoentLog
	{
		private readonly ERP.DAL.IngredientCompoentLog dal=new ERP.DAL.IngredientCompoentLog();
		public IngredientCompoentLog()
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
		public long Add(ERP.Model.IngredientCompoentLog model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ERP.Model.IngredientCompoentLog model)
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
		public ERP.Model.IngredientCompoentLog GetModel(long OID)
		{
			
			return dal.GetModel(OID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public ERP.Model.IngredientCompoentLog GetModelByCache(long OID)
		{
			
			string CacheKey = "IngredientCompoentLogModel-" + OID;
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
			return (ERP.Model.IngredientCompoentLog)objModel;
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
		public List<ERP.Model.IngredientCompoentLog> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ERP.Model.IngredientCompoentLog> DataTableToList(DataTable dt)
		{
			List<ERP.Model.IngredientCompoentLog> modelList = new List<ERP.Model.IngredientCompoentLog>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ERP.Model.IngredientCompoentLog model;
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
        /// get monthly statistics
        /// </summary>
        /// <param name="ProdIdent"></param>
        /// <param name="Month"></param>
        /// <param name="Year"></param>
        /// <param name="RecOrDis">True is receival,false is dispatch</param>
        /// <returns></returns>
        public int GetMonthStatistics(string ProdIdent, int Month, int Year, bool RecOrDis)
        {
            return dal.GetMonthStatistics(ProdIdent, Month, Year, RecOrDis);
        }
		#endregion  ExtensionMethod
	}
}

