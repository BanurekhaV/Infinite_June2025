using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DisconnectedADO
{
    class Program
    {
        public static SqlConnection con = null;
        public static SqlDataAdapter da = null;

        static void Main(string[] args)
        {
            DisconnectedDataRead();
            Console.Read();
        }

        public static void DisconnectedDataRead()
        {
            con = new SqlConnection("Data Source = laptop-tjj7d977; database=northwind;" +
                "Integrated security=true;");
            con.Open();
            da = new SqlDataAdapter("select * from Region", con);
           
            DataSet ds = new DataSet();

            da.Fill(ds, "NorthwindRegion");
            DataTable dt = ds.Tables["NorthwindRegion"]; // the dt object points to the datatable of the dataset

            //to access the data 
            foreach(DataRow dr in dt.Rows)
            {
                foreach(DataColumn dc in dt.Columns)
                {
                    Console.Write(dr[dc] + " ");                
                }
                Console.WriteLine();
            }
            //adding one more datatable to the dataset collection
            Console.WriteLine("*********************************");
            da = new SqlDataAdapter("select * from shippers", con);
            da.Fill(ds, "NorthwindShippers");
            dt = ds.Tables["NorthwindShippers"];

            foreach (DataRow dr1 in dt.Rows)
            {
                foreach (DataColumn dc1 in dt.Columns)
                {
                    Console.Write(dr1[dc1] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("************Procedure Call************");
            da = new SqlDataAdapter("[ten most expensive products]", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.Fill(ds, "ExpensiveProducts");
            dt = ds.Tables["ExpensiveProducts"];

            foreach (DataRow drow in dt.Rows)
            {
                foreach (DataColumn dcol in dt.Columns)
                {
                    Console.Write(drow[dcol] + " ");
                }
                Console.WriteLine();
            }
        }


    }
}
