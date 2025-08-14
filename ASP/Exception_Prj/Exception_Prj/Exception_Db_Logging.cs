using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using context = System.Web.HttpContext;

namespace Exception_Prj
{
    public static class Exception_Db_Logging
    {
        static string exurl;
        static SqlConnection con;

        private static void getConnection()
        {
            con = new SqlConnection("Data Source=laptop-tjj7d977; initial catalog=infinitedb;" +
                "integrated security=true;");
            con.Open();
        } 

        public static void LogExceptiontoDB(Exception exdb)
        {
            getConnection();
            exurl = context.Current.Request.Url.ToString();
            SqlCommand cmd = new SqlCommand("sp_ExceptionLogging_DB", con);
            cmd.CommandType = CommandType.StoredProcedure;

            //add parameters 
            cmd.Parameters.AddWithValue("@exceptionmsg", exdb.Message.ToString());
            cmd.Parameters.AddWithValue("@exceptiontype", exdb.GetType().Name.ToString());
            cmd.Parameters.AddWithValue("@exceptionsource", exdb.StackTrace.ToString());
            cmd.Parameters.AddWithValue("@exceptionurl", exurl);

            cmd.ExecuteNonQuery();
        }
    }
}