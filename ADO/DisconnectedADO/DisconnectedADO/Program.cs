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
        public static DataSet ds = null;
        static void Main(string[] args)
        {
            //DisconnectedDataRead();
            //AddRegion_withAdapter();
            Update_Region();
            Console.Read();
        }

        public static void DisconnectedDataRead()
        {
            con = new SqlConnection("Data Source = laptop-tjj7d977; database=northwind;" +
                "Integrated security=true;");
            con.Open();
            da = new SqlDataAdapter("select * from Region", con);
           
             ds = new DataSet();

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

        //let us insert one record into a table
        public static void AddRegion_withAdapter()
        {
            try
            {
                con = new SqlConnection("server = laptop-tjj7d977; database=northwind;" +
                "Integrated security=true;");
                con.Open();
                da = new SqlDataAdapter("select * from Region", con);
              //  da.SelectCommand.Connection = con;
                 ds = new DataSet();

                da.Fill(ds, "NRegion");
               // da.Fill(ds);
                DataTable dt = ds.Tables["NRegion"]; // the dt object points to the datatable of the dataset

                //to access the data 
                foreach (DataRow dr in dt.Rows)
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        Console.Write(dr[dc] + " ");
                    }
                    Console.WriteLine();
                }

                //let us now add one row
                DataRow row = ds.Tables["NRegion"].NewRow();

                //let us give values to the columns of the new row
                row["regionid"] = 20;
                row["regiondescription"] = "Northwest Region";

                //now add the new row with data to the rows collection of the datatable
                ds.Tables["NRegion"].Rows.Add(row);

                SqlCommandBuilder scb = new SqlCommandBuilder(da);
                da.InsertCommand = scb.GetInsertCommand();//gives the function handler where the changes are made
                int r = da.Update(ds, "NRegion"); // is actually going to update the table with the new row
                Console.WriteLine();
                Console.WriteLine("*************Post Insertion*****************");
                Console.WriteLine();
                Console.WriteLine(r + " number of rows affected");
                //da.Fill(ds,"NRegion"); //this refreshes the dataset after changes made to the database
                da.Fill(ds,"NRegion");
                dt = ds.Tables["NRegion"];

                //to access the data 
                foreach (DataRow dr in dt.Rows)
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        Console.Write(dr[dc] + " ");
                    }
                    Console.WriteLine();
                }

            }
            catch(SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }

        //update a values of the region table

        public static void Update_Region()
        {
            try
            {
                con = new SqlConnection("server = laptop-tjj7d977; database=northwind;" +
                 "Integrated security=true;");
                con.Open();
                string query = "select * from Region";
                da = new SqlDataAdapter(query, con);
                ds = new DataSet();
                da.Fill(ds);

                //update a row
                DataTable dt = ds.Tables[0];
                dt.Rows[5]["regiondescription"] = "Cyclone Free Region";

                SqlCommandBuilder scb = new SqlCommandBuilder(da);
                da.UpdateCommand = scb.GetUpdateCommand();
                da.Update(ds);
                Console.WriteLine(  );
                Console.WriteLine("_________Post Updation______");
                da.Fill(ds);
                foreach(DataRow dr in dt.Rows)
                {
                    foreach(DataColumn dc in dt.Columns)
                    {
                        Console.Write(dr[dc] + "  ");
                    }
                    Console.WriteLine();
                }

            }
            catch(SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }
    }
}
