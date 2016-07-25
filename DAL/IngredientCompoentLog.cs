using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace ERP.DAL
{
	/// <summary>
	/// 数据访问类:IngredientCompoentLog
	/// </summary>
	public partial class IngredientCompoentLog
	{
		public IngredientCompoentLog()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long OID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from IngredientCompoentLog");
			strSql.Append(" where OID=@OID");
			SqlParameter[] parameters = {
					new SqlParameter("@OID", SqlDbType.BigInt)
			};
			parameters[0].Value = OID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(ERP.Model.IngredientCompoentLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into IngredientCompoentLog(");
			strSql.Append("ProductIdent,Ingr_OIDText,IngredientCategory,Num,FinishDate)");
			strSql.Append(" values (");
			strSql.Append("@ProductIdent,@Ingr_OIDText,@IngredientCategory,@Num,@FinishDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ProductIdent", SqlDbType.VarChar,15),
					new SqlParameter("@Ingr_OIDText", SqlDbType.VarChar,20),
					new SqlParameter("@IngredientCategory", SqlDbType.TinyInt,1),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@FinishDate", SqlDbType.DateTime)};
			parameters[0].Value = model.ProductIdent;
			parameters[1].Value = model.Ingr_OIDText;
			parameters[2].Value = model.IngredientCategory;
			parameters[3].Value = model.Num;
			parameters[4].Value = model.FinishDate;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt64(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ERP.Model.IngredientCompoentLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update IngredientCompoentLog set ");
			strSql.Append("ProductIdent=@ProductIdent,");
			strSql.Append("Ingr_OIDText=@Ingr_OIDText,");
			strSql.Append("IngredientCategory=@IngredientCategory,");
			strSql.Append("Num=@Num,");
			strSql.Append("FinishDate=@FinishDate");
			strSql.Append(" where OID=@OID");
			SqlParameter[] parameters = {
					new SqlParameter("@ProductIdent", SqlDbType.VarChar,15),
					new SqlParameter("@Ingr_OIDText", SqlDbType.VarChar,20),
					new SqlParameter("@IngredientCategory", SqlDbType.TinyInt,1),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@FinishDate", SqlDbType.DateTime),
					new SqlParameter("@OID", SqlDbType.BigInt,8)};
			parameters[0].Value = model.ProductIdent;
			parameters[1].Value = model.Ingr_OIDText;
			parameters[2].Value = model.IngredientCategory;
			parameters[3].Value = model.Num;
			parameters[4].Value = model.FinishDate;
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
			strSql.Append("delete from IngredientCompoentLog ");
			strSql.Append(" where OID=@OID");
			SqlParameter[] parameters = {
					new SqlParameter("@OID", SqlDbType.BigInt)
			};
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
			strSql.Append("delete from IngredientCompoentLog ");
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
		public ERP.Model.IngredientCompoentLog GetModel(long OID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 OID,ProductIdent,Ingr_OIDText,IngredientCategory,Num,FinishDate from IngredientCompoentLog ");
			strSql.Append(" where OID=@OID");
			SqlParameter[] parameters = {
					new SqlParameter("@OID", SqlDbType.BigInt)
			};
			parameters[0].Value = OID;

			ERP.Model.IngredientCompoentLog model=new ERP.Model.IngredientCompoentLog();
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
		public ERP.Model.IngredientCompoentLog DataRowToModel(DataRow row)
		{
			ERP.Model.IngredientCompoentLog model=new ERP.Model.IngredientCompoentLog();
			if (row != null)
			{
				if(row["OID"]!=null && row["OID"].ToString()!="")
				{
					model.OID=long.Parse(row["OID"].ToString());
				}
				if(row["ProductIdent"]!=null)
				{
					model.ProductIdent=row["ProductIdent"].ToString();
				}
				if(row["Ingr_OIDText"]!=null)
				{
					model.Ingr_OIDText=row["Ingr_OIDText"].ToString();
				}
				if(row["IngredientCategory"]!=null && row["IngredientCategory"].ToString()!="")
				{
                    model.IngredientCategory = (ERP.Model.IngredientCategoryEnum)Enum.Parse(typeof(ERP.Model.IngredientCategoryEnum), row["IngredientCategory"].ToString());
				}
				if(row["Num"]!=null && row["Num"].ToString()!="")
				{
					model.Num=int.Parse(row["Num"].ToString());
				}
				if(row["FinishDate"]!=null && row["FinishDate"].ToString()!="")
				{
					model.FinishDate=DateTime.Parse(row["FinishDate"].ToString());
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
			strSql.Append("select OID,ProductIdent,Ingr_OIDText,IngredientCategory,Num,FinishDate ");
			strSql.Append(" FROM IngredientCompoentLog ");
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
			strSql.Append(" OID,ProductIdent,Ingr_OIDText,IngredientCategory,Num,FinishDate ");
			strSql.Append(" FROM IngredientCompoentLog ");
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
			strSql.Append("select count(1) FROM IngredientCompoentLog ");
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
			strSql.Append(")AS Row, T.*  from IngredientCompoentLog T ");
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
			parameters[0].Value = "IngredientCompoentLog";
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
        /// <summary>
        /// get monthly statistics
        /// </summary>
        /// <param name="ProdIdent"></param>
        /// <param name="Month"></param>
        /// <param name="Year"></param>
        /// <param name="RecOrDis">True is receival,false is dispatch</param>
        /// <returns></returns>
        public int GetMonthStatistics(string ProdIdent, int Month, int Year,bool RecOrDis)
        {
            DateTime startDatetime = new DateTime(Year, Month, 1);
            DateTime endDatetime = new DateTime(Year, Month, DateTime.DaysInMonth(Year, Month));

            ERP.Model.IngredientCategoryEnum theCategory = ERP.Model.IngredientCategoryEnum.DispatchComp;
            if (RecOrDis)
            {
                theCategory= ERP.Model.IngredientCategoryEnum.ReceiveComp;
            }

            StringBuilder strSql=new StringBuilder();
            strSql.Append("select sum(Num) from IngredientCompoentLog ");
			strSql.Append(" where ProductIdent=@ProductIdent");
            strSql.Append(" and IngredientCategory=@theCategory");
            strSql.Append(" and FinishDate between @startDatetime and @endDatetime");
            SqlParameter[] parameters = {
					new SqlParameter("@ProductIdent", SqlDbType.VarChar,15),
                    new SqlParameter("@theCategory", SqlDbType.TinyInt),
					new SqlParameter("@startDatetime", SqlDbType.DateTime),
					new SqlParameter("@endDatetime", SqlDbType.DateTime)};
			parameters[0].Value = ProdIdent;
            parameters[1].Value = theCategory;
			parameters[2].Value = startDatetime;
			parameters[3].Value = endDatetime;
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows[0][0].ToString()!="")
            {
                return int.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                return 0;
            }
        }
		#endregion  ExtensionMethod
	}
}

