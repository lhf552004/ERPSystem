using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references

namespace ERP
{
    public class StaticDbMethod
    {
        private StaticDbMethod()
        { 
        }
        public static StaticDbMethod DefaultStaticManager
        {
            get{
                if (_defaultStaticManager==null)
                {
                    _defaultStaticManager = new StaticDbMethod();
                
		        }
                return _defaultStaticManager;
            }

           
        }
        private static StaticDbMethod _defaultStaticManager = null;

        /// <summary>
        /// get a DAL product object
        /// </summary>
        /// <returns></returns>
        public  ERP.DAL.Product DALProduct
        {
            get
            {
                if (_dalProduct == null)
                {
                    _dalProduct = new ERP.DAL.Product();
                }
                return _dalProduct;
            }
            
        }
        private ERP.DAL.Product _dalProduct;

        /// <summary>
        /// get a DAL Statistics object
        /// </summary>
        /// <returns></returns>
        public  ERP.DAL.Statistics DALStatistics
        {
            get
            {
                if (_dalStatistics == null)
                {
                    _dalStatistics = new ERP.DAL.Statistics();
                }
                return _dalStatistics;
            }
            
        }
        private ERP.DAL.Statistics _dalStatistics;

        public static string GetNextAutoIdent(string className,string prefix)
        {
            string NewIdent = "";
            int MaxOID = 0;
            DataSet ds = null;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select MAX(OID)");
            strSql.Append(" FROM " + className);
            ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows[0][0].ToString()!= "")
            {
                MaxOID = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            if (MaxOID==0)
            {
                MaxOID++;
            }
            NewIdent = prefix +(MaxOID + 1).ToString("000000");
            return NewIdent;
        }

         
    }
}
