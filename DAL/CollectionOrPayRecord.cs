using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace ERP.DAL
{
	/// <summary>
	/// 数据访问类:CollectionOrPayRecord
	/// </summary>
	public partial class CollectionOrPayRecord
	{
		public CollectionOrPayRecord()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long OID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CollectionOrPayRecord");
			strSql.Append(" where OID=@OID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OID", SqlDbType.BigInt,8)			};
			parameters[0].Value = OID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ERP.Model.CollectionOrPayRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CollectionOrPayRecord(");
			strSql.Append("OID,Exp_OID,Exp_OID2,TradeDate,Money,Auditor,auditState,Operator,Invoice,Description)");
			strSql.Append(" values (");
			strSql.Append("@OID,@Exp_OID,@Exp_OID2,@TradeDate,@Money,@Auditor,@auditState,@Operator,@Invoice,@Description)");
			SqlParameter[] parameters = {
					new SqlParameter("@OID", SqlDbType.BigInt,8),
					new SqlParameter("@Exp_OID", SqlDbType.BigInt,8),
					new SqlParameter("@Exp_OID2", SqlDbType.BigInt,8),
					new SqlParameter("@TradeDate", SqlDbType.DateTime),
					new SqlParameter("@Money", SqlDbType.Money,8),
					new SqlParameter("@Auditor", SqlDbType.Char,15),
					new SqlParameter("@auditState", SqlDbType.TinyInt,1),
					new SqlParameter("@Operator", SqlDbType.Char,15),
					new SqlParameter("@Invoice", SqlDbType.Char,40),
					new SqlParameter("@Description", SqlDbType.Char,40)};
			parameters[0].Value = model.OID;
			parameters[1].Value = model.Exp_OID;
			parameters[2].Value = model.Exp_OID2;
			parameters[3].Value = model.TradeDate;
			parameters[4].Value = model.Money;
			parameters[5].Value = model.Auditor;
			parameters[6].Value = model.auditState;
			parameters[7].Value = model.Operator;
			parameters[8].Value = model.Invoice;
			parameters[9].Value = model.Description;

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
		public bool Update(ERP.Model.CollectionOrPayRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CollectionOrPayRecord set ");
			strSql.Append("Exp_OID=@Exp_OID,");
			strSql.Append("Exp_OID2=@Exp_OID2,");
			strSql.Append("TradeDate=@TradeDate,");
			strSql.Append("Money=@Money,");
			strSql.Append("Auditor=@Auditor,");
			strSql.Append("auditState=@auditState,");
			strSql.Append("Operator=@Operator,");
			strSql.Append("Invoice=@Invoice,");
			strSql.Append("Description=@Description");
			strSql.Append(" where OID=@OID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Exp_OID", SqlDbType.BigInt,8),
					new SqlParameter("@Exp_OID2", SqlDbType.BigInt,8),
					new SqlParameter("@TradeDate", SqlDbType.DateTime),
					new SqlParameter("@Money", SqlDbType.Money,8),
					new SqlParameter("@Auditor", SqlDbType.Char,15),
					new SqlParameter("@auditState", SqlDbType.TinyInt,1),
					new SqlParameter("@Operator", SqlDbType.Char,15),
					new SqlParameter("@Invoice", SqlDbType.Char,40),
					new SqlParameter("@Description", SqlDbType.Char,40),
					new SqlParameter("@OID", SqlDbType.BigInt,8)};
			parameters[0].Value = model.Exp_OID;
			parameters[1].Value = model.Exp_OID2;
			parameters[2].Value = model.TradeDate;
			parameters[3].Value = model.Money;
			parameters[4].Value = model.Auditor;
			parameters[5].Value = model.auditState;
			parameters[6].Value = model.Operator;
			parameters[7].Value = model.Invoice;
			parameters[8].Value = model.Description;
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
			strSql.Append("delete from CollectionOrPayRecord ");
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
			strSql.Append("delete from CollectionOrPayRecord ");
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
		public ERP.Model.CollectionOrPayRecord GetModel(long OID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 OID,Exp_OID,Exp_OID2,TradeDate,Money,Auditor,auditState,Operator,Invoice,Description from CollectionOrPayRecord ");
			strSql.Append(" where OID=@OID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OID", SqlDbType.BigInt,8)			};
			parameters[0].Value = OID;

			ERP.Model.CollectionOrPayRecord model=new ERP.Model.CollectionOrPayRecord();
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
		public ERP.Model.CollectionOrPayRecord DataRowToModel(DataRow row)
		{
			ERP.Model.CollectionOrPayRecord model=new ERP.Model.CollectionOrPayRecord();
			if (row != null)
			{
				if(row["OID"]!=null && row["OID"].ToString()!="")
				{
					model.OID=long.Parse(row["OID"].ToString());
				}
				if(row["Exp_OID"]!=null && row["Exp_OID"].ToString()!="")
				{
					model.Exp_OID=long.Parse(row["Exp_OID"].ToString());
				}
				if(row["Exp_OID2"]!=null && row["Exp_OID2"].ToString()!="")
				{
					model.Exp_OID2=long.Parse(row["Exp_OID2"].ToString());
				}
				if(row["TradeDate"]!=null && row["TradeDate"].ToString()!="")
				{
					model.TradeDate=DateTime.Parse(row["TradeDate"].ToString());
				}
				if(row["Money"]!=null && row["Money"].ToString()!="")
				{
					model.Money=decimal.Parse(row["Money"].ToString());
				}
				if(row["Auditor"]!=null)
				{
					model.Auditor=row["Auditor"].ToString();
				}
				if(row["auditState"]!=null && row["auditState"].ToString()!="")
				{
					model.auditState=int.Parse(row["auditState"].ToString());
				}
				if(row["Operator"]!=null)
				{
					model.Operator=row["Operator"].ToString();
				}
				if(row["Invoice"]!=null)
				{
					model.Invoice=row["Invoice"].ToString();
				}
				if(row["Description"]!=null)
				{
					model.Description=row["Description"].ToString();
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
			strSql.Append("select OID,Exp_OID,Exp_OID2,TradeDate,Money,Auditor,auditState,Operator,Invoice,Description ");
			strSql.Append(" FROM CollectionOrPayRecord ");
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
			strSql.Append(" OID,Exp_OID,Exp_OID2,TradeDate,Money,Auditor,auditState,Operator,Invoice,Description ");
			strSql.Append(" FROM CollectionOrPayRecord ");
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
			strSql.Append("select count(1) FROM CollectionOrPayRecord ");
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
			strSql.Append(")AS Row, T.*  from CollectionOrPayRecord T ");
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
			parameters[0].Value = "CollectionOrPayRecord";
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

