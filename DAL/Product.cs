using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace ERP.DAL
{
	/// <summary>
	/// 数据访问类:Product
	/// </summary>
	public partial class Product
	{
		public Product()
		{ }
        #region PrivateMember
        //Statistics dalStatistics = new Statistics();
        #endregion
        #region  BasicMethod

        /// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long OID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Product");
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
		public long Add(ERP.Model.Product model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Product(");
			strSql.Append("Sta_OID,Ident,Name,Description,ModifyUser,Category,Price,CreationDate,ModifyDate)");
			strSql.Append(" values (");
			strSql.Append("@Sta_OID,@Ident,@Name,@Description,@ModifyUser,@Category,@Price,@CreationDate,@ModifyDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Sta_OID", SqlDbType.BigInt,8),
					new SqlParameter("@Ident", SqlDbType.Char,15),
					new SqlParameter("@Name", SqlDbType.Char,15),
					new SqlParameter("@Description", SqlDbType.Char,40),
					new SqlParameter("@ModifyUser", SqlDbType.Char,15),
					new SqlParameter("@Category", SqlDbType.TinyInt,1),
					new SqlParameter("@Price", SqlDbType.Money,8),
					new SqlParameter("@CreationDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime)};
            if (model.Statistics != null)
            {
                parameters[0].Value = model.Statistics.OID;
            }
            else
            {
                parameters[0].Value = null;
            }
			parameters[1].Value = model.Ident;
			parameters[2].Value = model.Name;
			parameters[3].Value = model.Description;
			parameters[4].Value = model.ModifyUser;
			parameters[5].Value = model.Category;
			parameters[6].Value = model.Price;
			parameters[7].Value = model.CreationDate;
			parameters[8].Value = model.ModifyDate;

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
		public bool Update(ERP.Model.Product model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Product set ");
			strSql.Append("Sta_OID=@Sta_OID,");
			strSql.Append("Ident=@Ident,");
			strSql.Append("Name=@Name,");
			strSql.Append("Description=@Description,");
			strSql.Append("ModifyUser=@ModifyUser,");
			strSql.Append("Category=@Category,");
			strSql.Append("Price=@Price,");
			strSql.Append("CreationDate=@CreationDate,");
			strSql.Append("ModifyDate=@ModifyDate");
			strSql.Append(" where OID=@OID");
			SqlParameter[] parameters = {
					new SqlParameter("@Sta_OID", SqlDbType.BigInt,8),
					new SqlParameter("@Ident", SqlDbType.Char,15),
					new SqlParameter("@Name", SqlDbType.Char,15),
					new SqlParameter("@Description", SqlDbType.Char,40),
					new SqlParameter("@ModifyUser", SqlDbType.Char,15),
					new SqlParameter("@Category", SqlDbType.TinyInt,1),
					new SqlParameter("@Price", SqlDbType.Money,8),
					new SqlParameter("@CreationDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime),
					new SqlParameter("@OID", SqlDbType.BigInt,8)};
            if (model.Statistics != null)
            {
                parameters[0].Value = model.Statistics.OID;
            }
            else
            {
                parameters[0].Value = null;
            }
			parameters[1].Value = model.Ident;
			parameters[2].Value = model.Name;
			parameters[3].Value = model.Description;
			parameters[4].Value = model.ModifyUser;
			parameters[5].Value = model.Category;
			parameters[6].Value = model.Price;
			parameters[7].Value = model.CreationDate;
			parameters[8].Value = model.ModifyDate;
			parameters[9].Value = model.OID;

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
			strSql.Append("delete from Product ");
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
			strSql.Append("delete from Product ");
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
		public ERP.Model.Product GetModel(long OID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 OID,Sta_OID,Ident,Name,Description,ModifyUser,Category,Price,CreationDate,ModifyDate from Product ");
			strSql.Append(" where OID=@OID");
			SqlParameter[] parameters = {
					new SqlParameter("@OID", SqlDbType.BigInt)
			};
			parameters[0].Value = OID;

			ERP.Model.Product model=new ERP.Model.Product();
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
		public ERP.Model.Product DataRowToModel(DataRow row)
		{
			ERP.Model.Product model=new ERP.Model.Product();
			if (row != null)
			{
				if(row["OID"]!=null && row["OID"].ToString()!="")
				{
					model.OID=long.Parse(row["OID"].ToString());
				}
				if(row["Sta_OID"]!=null && row["Sta_OID"].ToString()!="")
				{
                    //ERP.Model.Statistics theStatistics = StaticDbMethod.DefaultStaticManager.DALStatistics.GetModel(long.Parse(row["Sta_OID"].ToString()));
                    //model.Statistics = theStatistics;
                    
                    //model.Sta_OID=long.Parse(row["Sta_OID"].ToString());
				}
				if(row["Ident"]!=null)
				{
					model.Ident=row["Ident"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Description"]!=null)
				{
					model.Description=row["Description"].ToString();
				}
				if(row["ModifyUser"]!=null)
				{
					model.ModifyUser=row["ModifyUser"].ToString();
				}
				if(row["Category"]!=null && row["Category"].ToString()!="")
				{
                    model.Category = (ERP.Model.ProductCategory)Enum.Parse(typeof(ERP.Model.ProductCategory), row["Category"].ToString());
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(row["Price"].ToString());
				}
				if(row["CreationDate"]!=null && row["CreationDate"].ToString()!="")
				{
					model.CreationDate=DateTime.Parse(row["CreationDate"].ToString());
				}
				if(row["ModifyDate"]!=null && row["ModifyDate"].ToString()!="")
				{
					model.ModifyDate=DateTime.Parse(row["ModifyDate"].ToString());
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
			strSql.Append("select OID,Sta_OID,Ident,Name,Description,ModifyUser,Category,Price,CreationDate,ModifyDate ");
			strSql.Append(" FROM Product ");
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
			strSql.Append(" OID,Sta_OID,Ident,Name,Description,ModifyUser,Category,Price,CreationDate,ModifyDate ");
			strSql.Append(" FROM Product ");
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
			strSql.Append("select count(1) FROM Product ");
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
			strSql.Append(")AS Row, T.*  from Product T ");
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
			parameters[0].Value = "Product";
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
        /// 得到一个对象实体
        /// </summary>
        public ERP.Model.Product GetModel(string Ident)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 OID,Sta_OID,Ident,Name,Description,ModifyUser,Category,Price,CreationDate,ModifyDate from [Product] ");
            strSql.Append(" where Ident=@Ident");
            SqlParameter[] parameters = {
					new SqlParameter("@Ident", SqlDbType.Char)
			};
            parameters[0].Value = Ident;

            ERP.Model.Product model = new ERP.Model.Product();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public long Clone(ERP.Model.Product model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Product(");
            strSql.Append("Sta_OID,Ident,Name,Description,ModifyUser,Category,Price,CreationDate,ModifyDate)");
            strSql.Append(" values (");
            strSql.Append("@Sta_OID,@Ident,@Name,@Description,@ModifyUser,@Category,@Price,@CreationDate,@ModifyDate)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Sta_OID", SqlDbType.BigInt,8),
					new SqlParameter("@Ident", SqlDbType.Char,15),
					new SqlParameter("@Name", SqlDbType.Char,15),
					new SqlParameter("@Description", SqlDbType.Char,40),
					new SqlParameter("@ModifyUser", SqlDbType.Char,15),
					new SqlParameter("@Category", SqlDbType.TinyInt,1),
					new SqlParameter("@Price", SqlDbType.Money,8),
					new SqlParameter("@CreationDate", SqlDbType.DateTime),
					new SqlParameter("@ModifyDate", SqlDbType.DateTime)};
            if (model.Statistics != null)
            {
                parameters[0].Value = model.Statistics.OID;
            }
            else
            {
                parameters[0].Value = null;
            }
            //parameters[0].Value = model.Sta_OID;
            parameters[1].Value = model.Ident + "-1";
            parameters[2].Value = model.Name;
            parameters[3].Value = model.Description;
            parameters[4].Value = model.ModifyUser;
            parameters[5].Value = model.Category;
            parameters[6].Value = model.Price;
            parameters[7].Value = model.CreationDate;
            parameters[8].Value = model.ModifyDate;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt64(obj);
            }
        }
		#endregion  ExtensionMethod
	}
}

