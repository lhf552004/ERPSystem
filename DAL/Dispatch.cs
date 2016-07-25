using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace ERP.DAL
{
	/// <summary>
	/// 数据访问类:Dispatch
	/// </summary>
	public partial class Dispatch
	{
		public Dispatch()
		{ }

        #region privateMember
        private Agent dalAgent = new Agent();
        #endregion
        #region  BasicMethod

        /// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long OID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Dispatch");
			strSql.Append(" where OID=@OID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OID", SqlDbType.BigInt,8)			};
			parameters[0].Value = OID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ERP.Model.Dispatch model)
		{
            if (model.Ident == null)
            {
                model.Ident = StaticDbMethod.GetNextAutoIdent(typeof(ERP.Model.Dispatch).Name,"D:");
            }
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Dispatch(");
			strSql.Append("Age_OID,Ident,CreationDate,Description,Price,auditState,DispatchState,ModifyUser,DispatchDate,Auditor,Operator)");
			strSql.Append(" values (");
			strSql.Append("@Age_OID,@Ident,@CreationDate,@Description,@Price,@auditState,@DispatchState,@ModifyUser,@DispatchDate,@Auditor,@Operator)");
			SqlParameter[] parameters = {
					new SqlParameter("@Age_OID", SqlDbType.BigInt,8),
					new SqlParameter("@Ident", SqlDbType.Char,15),
					new SqlParameter("@CreationDate", SqlDbType.DateTime),
					new SqlParameter("@Description", SqlDbType.Char,40),
					new SqlParameter("@Price", SqlDbType.Money,8),
					new SqlParameter("@auditState", SqlDbType.TinyInt,1),
					new SqlParameter("@DispatchState", SqlDbType.TinyInt,1),
					new SqlParameter("@ModifyUser", SqlDbType.Char,15),
					new SqlParameter("@DispatchDate", SqlDbType.DateTime),
					new SqlParameter("@Auditor", SqlDbType.Char,15),
					new SqlParameter("@Operator", SqlDbType.Char,15)};

            if (model.Agent != null)
            {
                parameters[0].Value = model.Agent.OID;
            }
            else
            {
                parameters[0].Value = null;
            }
			parameters[1].Value = model.Ident;
			parameters[2].Value = model.CreationDate;
			parameters[3].Value = model.Description;
			parameters[4].Value = model.Price;
			parameters[5].Value = model.auditState;
			parameters[6].Value = model.DispatchState;
			parameters[7].Value = model.ModifyUser;
			parameters[8].Value = model.DispatchDate;
			parameters[9].Value = model.Auditor;
			parameters[10].Value = model.Operator;

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
		public bool Update(ERP.Model.Dispatch model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Dispatch set ");
			strSql.Append("Age_OID=@Age_OID,");
			strSql.Append("Ident=@Ident,");
			strSql.Append("CreationDate=@CreationDate,");
			strSql.Append("Description=@Description,");
			strSql.Append("Price=@Price,");
			strSql.Append("auditState=@auditState,");
			strSql.Append("DispatchState=@DispatchState,");
			strSql.Append("ModifyUser=@ModifyUser,");
			strSql.Append("DispatchDate=@DispatchDate,");
			strSql.Append("Auditor=@Auditor,");
			strSql.Append("Operator=@Operator");
			strSql.Append(" where OID=@OID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Age_OID", SqlDbType.BigInt,8),
					new SqlParameter("@Ident", SqlDbType.Char,15),
					new SqlParameter("@CreationDate", SqlDbType.DateTime),
					new SqlParameter("@Description", SqlDbType.Char,40),
					new SqlParameter("@Price", SqlDbType.Money,8),
					new SqlParameter("@auditState", SqlDbType.TinyInt,1),
					new SqlParameter("@DispatchState", SqlDbType.TinyInt,1),
					new SqlParameter("@ModifyUser", SqlDbType.Char,15),
					new SqlParameter("@DispatchDate", SqlDbType.DateTime),
					new SqlParameter("@Auditor", SqlDbType.Char,15),
					new SqlParameter("@Operator", SqlDbType.Char,15),
					new SqlParameter("@OID", SqlDbType.BigInt,8)};
            if (model.Agent !=null)
            {
                parameters[0].Value = model.Agent.OID;
            }
			
			parameters[1].Value = model.Ident;
			parameters[2].Value = model.CreationDate;
			parameters[3].Value = model.Description;
			parameters[4].Value = model.Price;
			parameters[5].Value = model.auditState;
			parameters[6].Value = model.DispatchState;
			parameters[7].Value = model.ModifyUser;
			parameters[8].Value = model.DispatchDate;
			parameters[9].Value = model.Auditor;
			parameters[10].Value = model.Operator;
			parameters[11].Value = model.OID;

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
			strSql.Append("delete from Dispatch ");
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
			strSql.Append("delete from Dispatch ");
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
		public ERP.Model.Dispatch GetModel(long OID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 OID,Age_OID,Ident,CreationDate,Description,Price,auditState,DispatchState,ModifyUser,DispatchDate,Auditor,Operator from Dispatch ");
			strSql.Append(" where OID=@OID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OID", SqlDbType.BigInt,8)			};
			parameters[0].Value = OID;

			ERP.Model.Dispatch model=new ERP.Model.Dispatch();
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
		public ERP.Model.Dispatch DataRowToModel(DataRow row)
		{
			ERP.Model.Dispatch model=new ERP.Model.Dispatch();
			if (row != null)
			{
				if(row["OID"]!=null && row["OID"].ToString()!="")
				{
					model.OID=long.Parse(row["OID"].ToString());
				}
				if(row["Age_OID"]!=null && row["Age_OID"].ToString()!="")
				{
                    ERP.Model.Agent theAgent = dalAgent.GetModel(long.Parse(row["Age_OID"].ToString()));
                    model.Agent = theAgent;
                    //model.Age_OID=long.Parse(row["Age_OID"].ToString());
				}
				if(row["Ident"]!=null)
				{
					model.Ident=row["Ident"].ToString();
				}
				if(row["CreationDate"]!=null && row["CreationDate"].ToString()!="")
				{
					model.CreationDate=DateTime.Parse(row["CreationDate"].ToString());
				}
				if(row["Description"]!=null)
				{
					model.Description=row["Description"].ToString();
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(row["Price"].ToString());
				}
				if(row["auditState"]!=null && row["auditState"].ToString()!="")
				{
                    model.auditState = (ERP.Model.AuditStateEnum)Enum.Parse(typeof(ERP.Model.AuditStateEnum), row["auditState"].ToString());
                    //model.auditState=int.Parse(row["auditState"].ToString());
				}
				if(row["DispatchState"]!=null && row["DispatchState"].ToString()!="")
				{
                    model.DispatchState = (ERP.Model.DispatchStateEnum)Enum.Parse(typeof(ERP.Model.DispatchStateEnum), row["DispatchState"].ToString());
                    //model.DispatchState=int.Parse(row["DispatchState"].ToString());
				}
				if(row["ModifyUser"]!=null)
				{
					model.ModifyUser=row["ModifyUser"].ToString();
				}
				if(row["DispatchDate"]!=null && row["DispatchDate"].ToString()!="")
				{
					model.DispatchDate=DateTime.Parse(row["DispatchDate"].ToString());
				}
				if(row["Auditor"]!=null)
				{
					model.Auditor=row["Auditor"].ToString();
				}
				if(row["Operator"]!=null)
				{
					model.Operator=row["Operator"].ToString();
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
			strSql.Append("select OID,Age_OID,Ident,CreationDate,Description,Price,auditState,DispatchState,ModifyUser,DispatchDate,Auditor,Operator ");
			strSql.Append(" FROM Dispatch ");
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
			strSql.Append(" OID,Age_OID,Ident,CreationDate,Description,Price,auditState,DispatchState,ModifyUser,DispatchDate,Auditor,Operator ");
			strSql.Append(" FROM Dispatch ");
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
			strSql.Append("select count(1) FROM Dispatch ");
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
			strSql.Append(")AS Row, T.*  from Dispatch T ");
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
			parameters[0].Value = "Dispatch";
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

