using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace ERP.DAL
{
	/// <summary>
	/// 数据访问类:IngredientCompoent
	/// </summary>
	public partial class IngredientCompoent
	{
		public IngredientCompoent()
		{ }

        #region PrivateMember
        private Product dalProduct = new Product();
        private Dispatch dalDispatch = new Dispatch();
        private Receival dalReceival = new Receival();
        #endregion
        #region  BasicMethod

        
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long OID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from IngredientCompoent");
			strSql.Append(" where OID=@OID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OID", SqlDbType.BigInt,8)			};
			parameters[0].Value = OID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ERP.Model.IngredientCompoent model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into IngredientCompoent(");
			strSql.Append("Pro_OID,Dis_OID,Rec_OID,IngredientCategory,Num)");
			strSql.Append(" values (");
			strSql.Append("@Pro_OID,@Dis_OID,@Rec_OID,@IngredientCategory,@Num)");
			SqlParameter[] parameters = {
					new SqlParameter("@Pro_OID", SqlDbType.BigInt,8),
					new SqlParameter("@Dis_OID", SqlDbType.BigInt,8),
					new SqlParameter("@Rec_OID", SqlDbType.BigInt,8),
					new SqlParameter("@IngredientCategory", SqlDbType.TinyInt,1),
					new SqlParameter("@Num", SqlDbType.Int,4)};
            //parameters[0].Value = model.OID;
            if (model.Product != null)
            {
                parameters[0].Value = model.Product.OID;
            }
            else
            {
                parameters[0].Value = null;
            }
            if (model.Dispatch != null)
            {
                parameters[1].Value = model.Dispatch.OID;
            }
            else
            {
                parameters[1].Value =null;
            }
            if (model.Receival != null)
            {
                parameters[2].Value = model.Receival.OID;
            }
            else
            {
                parameters[2].Value = null;
            }
			parameters[3].Value = model.IngredientCategory;
			parameters[4].Value = model.Num;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ERP.Model.IngredientCompoent model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update IngredientCompoent set ");
			strSql.Append("Pro_OID=@Pro_OID,");
			strSql.Append("Dis_OID=@Dis_OID,");
			strSql.Append("Rec_OID=@Rec_OID,");
			strSql.Append("IngredientCategory=@IngredientCategory,");
			strSql.Append("Num=@Num");
			strSql.Append(" where OID=@OID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Pro_OID", SqlDbType.BigInt,8),
					new SqlParameter("@Dis_OID", SqlDbType.BigInt,8),
					new SqlParameter("@Rec_OID", SqlDbType.BigInt,8),
					new SqlParameter("@IngredientCategory", SqlDbType.TinyInt,1),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@OID", SqlDbType.BigInt,8)};
			parameters[0].Value = model.Product.OID;
			parameters[1].Value = model.Dispatch.OID;
			parameters[2].Value = model.Receival.OID;
			parameters[3].Value = model.IngredientCategory;
			parameters[4].Value = model.Num;
			parameters[5].Value = model.OID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(long OID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from IngredientCompoent ");
			strSql.Append(" where OID=@OID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OID", SqlDbType.BigInt,8)			};
			parameters[0].Value = OID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string OIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from IngredientCompoent ");
			strSql.Append(" where OID in ("+OIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ERP.Model.IngredientCompoent GetModel(long OID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 OID,Pro_OID,Dis_OID,Rec_OID,IngredientCategory,Num from IngredientCompoent ");
			strSql.Append(" where OID=@OID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OID", SqlDbType.BigInt,8)			};
			parameters[0].Value = OID;

			ERP.Model.IngredientCompoent model=new ERP.Model.IngredientCompoent();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ERP.Model.IngredientCompoent DataRowToModel(DataRow row)
		{
			ERP.Model.IngredientCompoent model=new ERP.Model.IngredientCompoent();
			if (row != null)
			{
				if(row["OID"]!=null && row["OID"].ToString()!="")
				{
					model.OID=long.Parse(row["OID"].ToString());
				}
				if(row["Pro_OID"]!=null && row["Pro_OID"].ToString()!="")
				{
                    ERP.Model.Product theProduct = dalProduct.GetModel(long.Parse(row["Pro_OID"].ToString()));
					model.Product =theProduct;
				}
				if(row["Dis_OID"]!=null && row["Dis_OID"].ToString()!="")
				{
                    ERP.Model.Dispatch theDispatch = dalDispatch.GetModel(long.Parse(row["Dis_OID"].ToString()));
					model.Dispatch=theDispatch;
				}
				if(row["Rec_OID"]!=null && row["Rec_OID"].ToString()!="")
				{
                    ERP.Model.Receival theReceival = dalReceival.GetModel(long.Parse(row["Rec_OID"].ToString()));
                    model.Receival = theReceival;
                    //model.Rec_OID=long.Parse(row["Rec_OID"].ToString());
				}
				if(row["IngredientCategory"]!=null && row["IngredientCategory"].ToString()!="")
				{
                    model.IngredientCategory = (ERP.Model.IngredientCategoryEnum)Enum.Parse(typeof(ERP.Model.IngredientCategoryEnum), row["IngredientCategory"].ToString());
                        //int.Parse(row["IngredientCategory"].ToString());
				}
				if(row["Num"]!=null && row["Num"].ToString()!="")
				{
					model.Num=int.Parse(row["Num"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select OID,Pro_OID,Dis_OID,Rec_OID,IngredientCategory,Num ");
			strSql.Append(" FROM IngredientCompoent ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" OID,Pro_OID,Dis_OID,Rec_OID,IngredientCategory,Num ");
			strSql.Append(" FROM IngredientCompoent ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM IngredientCompoent ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.OID desc");
			}
			strSql.Append(")AS Row, T.*  from IngredientCompoent T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "IngredientCompoent";
			parameters[1].Value = "OID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

