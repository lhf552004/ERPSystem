using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace ERP.DAL
{
	/// <summary>
	/// 数据访问类:ExpectPayAccount
	/// </summary>
	public partial class ExpectPayAccount
	{
		public ExpectPayAccount()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long OID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ExpectPayAccount");
			strSql.Append(" where OID=@OID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OID", SqlDbType.BigInt,8)			};
			parameters[0].Value = OID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ERP.Model.ExpectPayAccount model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ExpectPayAccount(");
			strSql.Append("OID,Ident,Description,CreationDate,Lender,Loaned,ModifyUser,PayReason,Auditor,Operator,GetMoneyPerson)");
			strSql.Append(" values (");
			strSql.Append("@OID,@Ident,@Description,@CreationDate,@Lender,@Loaned,@ModifyUser,@PayReason,@Auditor,@Operator,@GetMoneyPerson)");
			SqlParameter[] parameters = {
					new SqlParameter("@OID", SqlDbType.BigInt,8),
					new SqlParameter("@Ident", SqlDbType.Char,15),
					new SqlParameter("@Description", SqlDbType.Char,40),
					new SqlParameter("@CreationDate", SqlDbType.DateTime),
					new SqlParameter("@Lender", SqlDbType.Money,8),
					new SqlParameter("@Loaned", SqlDbType.Money,8),
					new SqlParameter("@ModifyUser", SqlDbType.Char,15),
					new SqlParameter("@PayReason", SqlDbType.Char,40),
					new SqlParameter("@Auditor", SqlDbType.Char,15),
					new SqlParameter("@Operator", SqlDbType.Char,15),
					new SqlParameter("@GetMoneyPerson", SqlDbType.Char,15)};
			parameters[0].Value = model.OID;
			parameters[1].Value = model.Ident;
			parameters[2].Value = model.Description;
			parameters[3].Value = model.CreationDate;
			parameters[4].Value = model.Lender;
			parameters[5].Value = model.Loaned;
			parameters[6].Value = model.ModifyUser;
			parameters[7].Value = model.PayReason;
			parameters[8].Value = model.Auditor;
			parameters[9].Value = model.Operator;
			parameters[10].Value = model.GetMoneyPerson;

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
		public bool Update(ERP.Model.ExpectPayAccount model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ExpectPayAccount set ");
			strSql.Append("Ident=@Ident,");
			strSql.Append("Description=@Description,");
			strSql.Append("CreationDate=@CreationDate,");
			strSql.Append("Lender=@Lender,");
			strSql.Append("Loaned=@Loaned,");
			strSql.Append("ModifyUser=@ModifyUser,");
			strSql.Append("PayReason=@PayReason,");
			strSql.Append("Auditor=@Auditor,");
			strSql.Append("Operator=@Operator,");
			strSql.Append("GetMoneyPerson=@GetMoneyPerson");
			strSql.Append(" where OID=@OID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Ident", SqlDbType.Char,15),
					new SqlParameter("@Description", SqlDbType.Char,40),
					new SqlParameter("@CreationDate", SqlDbType.DateTime),
					new SqlParameter("@Lender", SqlDbType.Money,8),
					new SqlParameter("@Loaned", SqlDbType.Money,8),
					new SqlParameter("@ModifyUser", SqlDbType.Char,15),
					new SqlParameter("@PayReason", SqlDbType.Char,40),
					new SqlParameter("@Auditor", SqlDbType.Char,15),
					new SqlParameter("@Operator", SqlDbType.Char,15),
					new SqlParameter("@GetMoneyPerson", SqlDbType.Char,15),
					new SqlParameter("@OID", SqlDbType.BigInt,8)};
			parameters[0].Value = model.Ident;
			parameters[1].Value = model.Description;
			parameters[2].Value = model.CreationDate;
			parameters[3].Value = model.Lender;
			parameters[4].Value = model.Loaned;
			parameters[5].Value = model.ModifyUser;
			parameters[6].Value = model.PayReason;
			parameters[7].Value = model.Auditor;
			parameters[8].Value = model.Operator;
			parameters[9].Value = model.GetMoneyPerson;
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
			strSql.Append("delete from ExpectPayAccount ");
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
			strSql.Append("delete from ExpectPayAccount ");
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
		public ERP.Model.ExpectPayAccount GetModel(long OID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 OID,Ident,Description,CreationDate,Lender,Loaned,ModifyUser,PayReason,Auditor,Operator,GetMoneyPerson from ExpectPayAccount ");
			strSql.Append(" where OID=@OID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OID", SqlDbType.BigInt,8)			};
			parameters[0].Value = OID;

			ERP.Model.ExpectPayAccount model=new ERP.Model.ExpectPayAccount();
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
		public ERP.Model.ExpectPayAccount DataRowToModel(DataRow row)
		{
			ERP.Model.ExpectPayAccount model=new ERP.Model.ExpectPayAccount();
			if (row != null)
			{
				if(row["OID"]!=null && row["OID"].ToString()!="")
				{
					model.OID=long.Parse(row["OID"].ToString());
				}
				if(row["Ident"]!=null)
				{
					model.Ident=row["Ident"].ToString();
				}
				if(row["Description"]!=null)
				{
					model.Description=row["Description"].ToString();
				}
				if(row["CreationDate"]!=null && row["CreationDate"].ToString()!="")
				{
					model.CreationDate=DateTime.Parse(row["CreationDate"].ToString());
				}
				if(row["Lender"]!=null && row["Lender"].ToString()!="")
				{
					model.Lender=decimal.Parse(row["Lender"].ToString());
				}
				if(row["Loaned"]!=null && row["Loaned"].ToString()!="")
				{
					model.Loaned=decimal.Parse(row["Loaned"].ToString());
				}
				if(row["ModifyUser"]!=null)
				{
					model.ModifyUser=row["ModifyUser"].ToString();
				}
				if(row["PayReason"]!=null)
				{
					model.PayReason=row["PayReason"].ToString();
				}
				if(row["Auditor"]!=null)
				{
					model.Auditor=row["Auditor"].ToString();
				}
				if(row["Operator"]!=null)
				{
					model.Operator=row["Operator"].ToString();
				}
				if(row["GetMoneyPerson"]!=null)
				{
					model.GetMoneyPerson=row["GetMoneyPerson"].ToString();
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
			strSql.Append("select OID,Ident,Description,CreationDate,Lender,Loaned,ModifyUser,PayReason,Auditor,Operator,GetMoneyPerson ");
			strSql.Append(" FROM ExpectPayAccount ");
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
			strSql.Append(" OID,Ident,Description,CreationDate,Lender,Loaned,ModifyUser,PayReason,Auditor,Operator,GetMoneyPerson ");
			strSql.Append(" FROM ExpectPayAccount ");
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
			strSql.Append("select count(1) FROM ExpectPayAccount ");
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
			strSql.Append(")AS Row, T.*  from ExpectPayAccount T ");
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
			parameters[0].Value = "ExpectPayAccount";
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

