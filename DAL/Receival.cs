using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace ERP.DAL
{
	/// <summary>
	/// 数据访问类:Receival
	/// </summary>
	public partial class Receival
	{
		public Receival()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long OID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Receival");
			strSql.Append(" where OID=@OID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OID", SqlDbType.BigInt,8)			};
			parameters[0].Value = OID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ERP.Model.Receival model)
		{
            if (model.Ident ==null)
            {
                model.Ident = StaticDbMethod.GetNextAutoIdent(typeof(ERP.Model.Receival).Name, SearchStr.PrefixOfReceival);
            }
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Receival(");
			strSql.Append("Ident,Name,Description,auditState,ReceivalState,FinishReceiptDate,CreationDate,Auditor,Operator)");
			strSql.Append(" values (");
			strSql.Append("@Ident,@Name,@Description,@auditState,@ReceivalState,@FinishReceiptDate,@CreationDate,@Auditor,@Operator)");
			SqlParameter[] parameters = {
					new SqlParameter("@Ident", SqlDbType.Char,15),
					new SqlParameter("@Name", SqlDbType.Char,15),
					new SqlParameter("@Description", SqlDbType.Char,40),
					new SqlParameter("@auditState", SqlDbType.TinyInt,1),
					new SqlParameter("@ReceivalState", SqlDbType.TinyInt,1),
					new SqlParameter("@FinishReceiptDate", SqlDbType.DateTime),
					new SqlParameter("@CreationDate", SqlDbType.DateTime),
					new SqlParameter("@Auditor", SqlDbType.Char,15),
					new SqlParameter("@Operator", SqlDbType.Char,15)};
            //parameters[0].Value = model.OID;
			parameters[0].Value = model.Ident;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.Description;
			parameters[3].Value = model.auditState;
			parameters[4].Value = model.ReceivalState;
			parameters[5].Value = model.FinishReceiptDate;
			parameters[6].Value = model.CreationDate;
			parameters[7].Value = model.Auditor;
			parameters[8].Value = model.Operator;

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
		public bool Update(ERP.Model.Receival model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Receival set ");
			strSql.Append("Ident=@Ident,");
			strSql.Append("Name=@Name,");
			strSql.Append("Description=@Description,");
			strSql.Append("auditState=@auditState,");
			strSql.Append("ReceivalState=@ReceivalState,");
			strSql.Append("FinishReceiptDate=@FinishReceiptDate,");
			strSql.Append("CreationDate=@CreationDate,");
			strSql.Append("Auditor=@Auditor,");
			strSql.Append("Operator=@Operator");
			strSql.Append(" where OID=@OID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Ident", SqlDbType.Char,15),
					new SqlParameter("@Name", SqlDbType.Char,15),
					new SqlParameter("@Description", SqlDbType.Char,40),
					new SqlParameter("@auditState", SqlDbType.TinyInt,1),
					new SqlParameter("@ReceivalState", SqlDbType.TinyInt,1),
					new SqlParameter("@FinishReceiptDate", SqlDbType.DateTime),
					new SqlParameter("@CreationDate", SqlDbType.DateTime),
					new SqlParameter("@Auditor", SqlDbType.Char,15),
					new SqlParameter("@Operator", SqlDbType.Char,15),
					new SqlParameter("@OID", SqlDbType.BigInt,8)};
			parameters[0].Value = model.Ident;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.Description;
			parameters[3].Value = model.auditState;
			parameters[4].Value = model.ReceivalState;
			parameters[5].Value = model.FinishReceiptDate;
			parameters[6].Value = model.CreationDate;
			parameters[7].Value = model.Auditor;
			parameters[8].Value = model.Operator;
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
			strSql.Append("delete from Receival ");
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
			strSql.Append("delete from Receival ");
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
		public ERP.Model.Receival GetModel(long OID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 OID,Ident,Name,Description,auditState,ReceivalState,FinishReceiptDate,CreationDate,Auditor,Operator from Receival ");
			strSql.Append(" where OID=@OID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OID", SqlDbType.BigInt,8)			};
			parameters[0].Value = OID;

			ERP.Model.Receival model=new ERP.Model.Receival();
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
		public ERP.Model.Receival DataRowToModel(DataRow row)
		{
			ERP.Model.Receival model=new ERP.Model.Receival();
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
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Description"]!=null)
				{
					model.Description=row["Description"].ToString();
				}
				if(row["auditState"]!=null && row["auditState"].ToString()!="")
				{
                    model.auditState = (ERP.Model.AuditStateEnum)Enum.Parse(typeof(ERP.Model.AuditStateEnum), row["auditState"].ToString());
				}
				if(row["ReceivalState"]!=null && row["ReceivalState"].ToString()!="")
				{
                    model.ReceivalState = (ERP.Model.ReceiveStateEnum)Enum.Parse(typeof(ERP.Model.ReceiveStateEnum), row["ReceivalState"].ToString());
                   
				}
				if(row["FinishReceiptDate"]!=null && row["FinishReceiptDate"].ToString()!="")
				{
					model.FinishReceiptDate=DateTime.Parse(row["FinishReceiptDate"].ToString());
				}
				if(row["CreationDate"]!=null && row["CreationDate"].ToString()!="")
				{
					model.CreationDate=DateTime.Parse(row["CreationDate"].ToString());
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
			strSql.Append("select OID,Ident,Name,Description,auditState,ReceivalState,FinishReceiptDate,CreationDate,Auditor,Operator ");
			strSql.Append(" FROM Receival ");
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
			strSql.Append(" OID,Ident,Name,Description,auditState,ReceivalState,FinishReceiptDate,CreationDate,Auditor,Operator ");
			strSql.Append(" FROM Receival ");
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
			strSql.Append("select count(1) FROM Receival ");
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
			strSql.Append(")AS Row, T.*  from Receival T ");
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
			parameters[0].Value = "Receival";
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

