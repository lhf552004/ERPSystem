using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using ERP.Model;
namespace ERP.BLL
{
	/// <summary>
	/// Product
	/// </summary>
	public partial class Product
	{
		private readonly ERP.DAL.Product dal=new ERP.DAL.Product();
        //private readonly ERP.BLL.Statistics bllStatistics = new ERP.BLL.Statistics();
        //private readonly ERP.BLL.Warehouse bllWarehouse = new ERP.BLL.Warehouse();
		public Product()
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
		public long Add(ERP.Model.Product model)
		{
           return dal.Add(model);
            //if (flag!= 0)
            //{
            //    ERP.Model.Statistics newStatistics = new ERP.Model.Statistics();
            //    if (bllWarehouse.GetRecordCount("") == 0)
            //    {
            //        ERP.Model.Warehouse newWarehouse = new ERP.Model.Warehouse();
            //        bllWarehouse.Add(newWarehouse);

            //    }
            //    newStatistics.War_OID = bllWarehouse.GetTop1Model().OID;
            //    newStatistics.Product = model;
            //    newStatistics.Ident = model.Ident;
            //    newStatistics.Number = 0;
            //    bllStatistics.Add(newStatistics);
            //}
            //return flag;
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ERP.Model.Product model)
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
		public ERP.Model.Product GetModel(long OID)
		{
			
			return dal.GetModel(OID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public ERP.Model.Product GetModelByCache(long OID)
		{
			
			string CacheKey = "ProductModel-" + OID;
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
			return (ERP.Model.Product)objModel;
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
		public List<ERP.Model.Product> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ERP.Model.Product> DataTableToList(DataTable dt)
		{
			List<ERP.Model.Product> modelList = new List<ERP.Model.Product>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ERP.Model.Product model;
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
        /// 得到一个对象实体
        /// </summary>
        public ERP.Model.Product GetModel(string Ident)
        {

            return dal.GetModel(Ident);
        }
        public long Clone(Model.Product Model)
        {
            return dal.Clone(Model);
        }
		#endregion  ExtensionMethod
	}
}

