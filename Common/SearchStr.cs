using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Data.SqlClient;


namespace ERP
{
    public class SearchStr
    {
        public static string connectingstring = "";
        public static List<string> users = new List<string>();
        public static string CurrentUser = "";
        public static string PrefixOfReceival = "M:";
        public static string PrefixOfWarhouse = "W:";
        public static string PrefixOfAgent = "A:";
        public static string CompanyName = "BEST";
        public static int ReserveMonth = 12;
        public static string[] GetMonthList()
        {
            string[] MonthList = new string[ReserveMonth];
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;
            MonthList[0] = currentMonth + "/" + currentYear;
            for (int i = 1; i < ReserveMonth; i++)
            {
                currentMonth--;
                if (currentMonth > 0)
                {
                    MonthList[i] = currentMonth + "/" + currentYear;
                }
                else
                {
                    currentMonth = 12;
                    currentYear--;
                    MonthList[i] = currentMonth + "/" + currentYear;
                }
            }

            return MonthList;

        }
    }
}
