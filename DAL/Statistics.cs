using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace ERP.DAL
{
	/// <summary>
	/// 数据访问类:Statistics
	/// </summary>
	public partial class Statistics
	{
		public Statistics()
		{ }
        #region PrivateMember
        //Product dalProduct = new Product();
        #endregion

        #region  BasicMethod

        /// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long OID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [Statistics]");
			strSql.Append(" where OID=@OID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OID", SqlDbType.BigInt,8)			};
			parameters[0].Value = OID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ERP.Model.Statistics model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into [Statistics](");
			strSql.Append("Dis_OID,War_OID,Pro_OID,Ident,[Description],ModifyUser,Number,StatisticMonth,ReceivalStatistic,DispatchStatistic)");
			strSql.Append(" values (");
			strSql.Append("@Dis_OID,@War_OID,@Pro_OID,@Ident,@Description,@ModifyUser,@Number,@StatisticMonth,@ReceivalStatistic,@DispatchStatistic)");
			SqlParameter[] parameters = {
					new SqlParameter("@Dis_OID", SqlDbType.BigInt,8),
					new SqlParameter("@War_OID", SqlDbType.BigInt,8),
					new SqlParameter("@Pro_OID", SqlDbType.BigInt,8),
					new SqlParameter("@Ident", SqlDbType.Char,15),
					new SqlParameter("@Description", SqlDbType.Char,40),
					new SqlParameter("@ModifyUser", SqlDbType.Char,15),
					new SqlParameter("@Number", SqlDbType.Int,4),
					new SqlParameter("@StatisticMonth", SqlDbType.TinyInt,1),
					new SqlParameter("@ReceivalStatistic", SqlDbType.Int,4),
					new SqlParameter("@DispatchStatistic", SqlDbType.Int,4)};
            //parameters[0].Value = model.OID;
			parameters[0].Value = model.Dis_OID;
			parameters[1].Value = model.War_OID;
            if (model.Product != null)
            {
                parameters[2].Value = model.Product.OID;
            }
            else
            {
                parameters[2].Value = null;
            }
			
			parameters[3].Value = model.Ident;
			parameters[4].Value = model.Description;
			parameters[5].Value = model.ModifyUser;
			parameters[6].Value = model.Number;
			parameters[7].Value = model.StatisticMonth;
			parameters[8].Value = model.ReceivalStatistic;
			parameters[9].Value = model.DispatchStatistic;

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
		public bool Update(ERP.Model.Statistics model)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("update [Statistics] set ");
			strSql.Append("Dis_OID=@Dis_OID,");
			strSql.Append("War_OID=@War_OID,");
			strSql.Append("Pro_OID=@Pro_OID,");
			strSql.Append("Ident=@Ident,");
			strSql.Append("Description=@Description,");
			strSql.Append("ModifyUser=@ModifyUser,");
			strSql.Append("Number=@Number,");
			strSql.Append("StatisticMonth=@StatisticMonth,");
			strSql.Append("ReceivalStatistic=@ReceivalStatistic,");
			strSql.Append("DispatchStatistic=@DispatchStatistic");
			strSql.Append(" where OID=@OID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Dis_OID", SqlDbType.BigInt,8),
					new SqlParameter("@War_OID", SqlDbType.BigInt,8),
					new SqlParameter("@Pro_OID", SqlDbType.BigInt,8),
					new SqlParameter("@Ident", SqlDbType.Char,15),
					new SqlParameter("@Description", SqlDbType.Char,40),
					new SqlParameter("@ModifyUser", SqlDbType.Char,15),
					new SqlParameter("@Number", SqlDbType.Int,4),
					new SqlParameter("@StatisticMonth", SqlDbType.TinyInt,1),
					new SqlParameter("@ReceivalStatistic", SqlDbType.Int,4),
					new SqlParameter("@DispatchStatistic", SqlDbType.Int,4),
					new SqlParameter("@OID", SqlDbType.BigInt,8)};
			parameters[0].Value = model.Dis_OID;
			parameters[1].Value = model.War_OID;
            if (model.Product != null)
            {
                parameters[2].Value = model.Product.OID;
            }
            else
            {
                parameters[2].Value = null;
            }
            //parameters[2].Value = model.Pro_OID;
			parameters[3].Value = model.Ident;
			parameters[4].Value = model.Description;
			parameters[5].Value = model.ModifyUser;
			parameters[6].Value = model.Number;
			parameters[7].Value = model.StatisticMonth;
			parameters[8].Value = model.ReceivalStatistic;
			parameters[9].Value = model.DispatchStatistic;
			parameters[10].Value = model.OID;

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
            strSql.Append("delete from [Statistics] ");
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
            strSql.Append("delete from [Statistics] ");
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
		public ERP.Model.Statistics GetModel(long OID)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select  top 1 OID,Dis_OID,War_OID,Pro_OID,Ident,[Description],ModifyUser,Number,StatisticMonth,ReceivalStatistic,DispatchStatistic from [Statistics] ");
			strSql.Append(" where OID=@OID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OID", SqlDbType.BigInt,8)			};
			parameters[0].Value = OID;

			ERP.Model.Statistics model=new ERP.Model.Statistics();
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
		public ERP.Model.Statistics DataRowToModel(DataRow row)
		{
			ERP.Model.Statistics model=new ERP.Model.Statistics();
			if (row != null)
			{
				if(row["OID"]!=null && row["OID"].ToString()!="")
				{
					model.OID=long.Parse(row["OID"].ToString());
				}
				if(row["Dis_OID"]!=null && row["Dis_OID"].ToString()!="")
				{
					model.Dis_OID=long.Parse(row["Dis_OID"].ToString());
				}
				if(row["War_OID"]!=null && row["War_OID"].ToString()!="")
				{
					model.War_OID=long.Parse(row["War_OID"].ToString());
				}
				if(row["Pro_OID"]!=null && row["Pro_OID"].ToString()!="")
				{
                    ERP.Model.Product theProduct = StaticDbMethod.DefaultStaticManager.DALProduct.GetModel(long.Parse(row["Pro_OID"].ToString()));
                    model.Product = theProduct;
                    //model.Pro_OID=long.Parse(row["Pro_OID"].ToString());
				}
				if(row["Ident"]!=null)
				{
					model.Ident=row["Ident"].ToString();
				}
				if(row["Description"]!=null)
				{
					model.Description=row["Description"].ToString();
				}
				if(row["ModifyUser"]!=null)
				{
					model.ModifyUser=row["ModifyUser"].ToString();
				}
				if(row["Number"]!=null && row["Number"].ToString()!="")
				{
					model.Number=int.Parse(row["Number"].ToString());
				}
				if(row["StatisticMonth"]!=null && row["StatisticMonth"].ToString()!="")
				{
					model.StatisticMonth=int.Parse(row["StatisticMonth"].ToString());
				}
				if(row["ReceivalStatistic"]!=null && row["ReceivalStatistic"].ToString()!="")
				{
					model.ReceivalStatistic=int.Parse(row["ReceivalStatistic"].ToString());
				}
				if(row["DispatchStatistic"]!=null && row["DispatchStatistic"].ToString()!="")
				{
					model.DispatchStatistic=int.Parse(row["DispatchStatistic"].ToString());
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
			strSql.Append("select OID,Dis_OID,War_OID,Pro_OID,Ident,[Description],ModifyUser,Number,StatisticMonth,ReceivalStatistic,DispatchStatistic ");
            strSql.Append(" FROM [Statistics] ");
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
			strSql.Append(" OID,Dis_OID,War_OID,Pro_OID,Ident,[Description],ModifyUser,Number,StatisticMonth,ReceivalStatistic,DispatchStatistic ");
            strSql.Append(" FROM [Statistics] ");
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
            strSql.Append("select count(1) FROM [Statistics] ");
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
            strSql.Append(")AS Row, T.*  from [Statistics] T ");
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
			parameters[0].Value = "Statistics";
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
        public ERP.Model.Statistics GetModelByProduct(long Pro_OID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 OID,Dis_OID,War_OID,Pro_OID,Ident,[Description],ModifyUser,Number,StatisticMonth,ReceivalStatistic,DispatchStatistic from [Statistics] ");
            strSql.Append(" where Pro_OID=@Pro_OID ");
            SqlParameter[] parameters = {
					new SqlParameter("@Pro_OID", SqlDbType.BigInt,8)			};
            parameters[0].Value = Pro_OID;

            ERP.Model.Statistics model = new ERP.Model.Statistics();
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
		#endregion  ExtensionMethod
	}
}

