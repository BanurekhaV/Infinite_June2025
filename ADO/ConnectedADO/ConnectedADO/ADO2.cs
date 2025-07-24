using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConnectedADO
{
    //client
    class ADO2
    {
        public static void Main()
        {
            Region region = new Region();
            SqlDataReader ret_dr = region.SelectRegion();
            while(ret_dr.Read())
            {
                Console.WriteLine($"Region ID : {ret_dr["regionid"]} and the Region Description is :{ret_dr["regiondescription"]}");
            }
            //int res = region.InsertRegion();
            //if(res>0)
            //    Console.WriteLine("Added a record..");
            //else
            //    Console.WriteLine("Failed to Add");

            Console.WriteLine("----------------");
            Console.WriteLine($"Total regions are : {region.GetRegionCount()}");
            Console.WriteLine("---Procedure without parameters-----");
            ret_dr = region.MostExpensiveProducts();
            while (ret_dr.Read())
            {
                Console.WriteLine($"Product Name : {ret_dr["tenmostexpensiveproducts"]} and the price is :{ret_dr["unitprice"]}");
            }
            Console.WriteLine("**********************");
            region.CallprocwithParameters();
            Console.Read();
        }
    }
    //Business Logic
    class Region
    {
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }
        DataAccess da = new DataAccess();
        internal SqlDataReader SelectRegion()
        {
            return da.SelectRegionData();         
        }

        public int InsertRegion()
        {
            Console.WriteLine("Enter Region ID :");
            RegionID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Region Description :");
            RegionDescription = Console.ReadLine();
            return da.InsertRegion(RegionID,RegionDescription);
        }
        public int GetRegionCount()
        {
            return da.GetRegionCount();
        }

        public SqlDataReader MostExpensiveProducts()
        {
            //da.MostExpensiveProducts();
            return da.MostExpensiveProducts();
        }

        public void CallprocwithParameters()
        {
            da.Procedure_With_Parameter();
        }
    }

    //Data Layer
    class DataAccess
    {
        static SqlConnection con = null;
        static SqlCommand cmd = null;
        static SqlDataReader dr;
        static int result;

        public SqlConnection getConnection()
        {
            string connect = "Data Source = laptop-tjj7d977;initial catalog = Northwind;" +
                "trusted_connection = true;";
            con = new SqlConnection(connect);
            con.Open();
            return con;
        }

        public SqlDataReader SelectRegionData()
        {
            try
            {
                con = getConnection();
                cmd = new SqlCommand("Select * from Region", con);
                dr = cmd.ExecuteReader();
                return dr;
            }
            catch(SqlException se)
            {
                Console.WriteLine(se.Message);
            
            }
            
             return dr;            
        }

        public int InsertRegion(int rid, string desc)
        {
            try
            {
                con = getConnection();
                cmd= new SqlCommand("insert into region values(@rid,@desc)");
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@rid", rid);
                cmd.Parameters.AddWithValue("@desc", desc);
                result = cmd.ExecuteNonQuery();
               // return result;
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }

        //executing scalar functions (i.e that returns just one value)
        public int GetRegionCount()
        {
            con = getConnection();
            cmd = new SqlCommand("select count(regionid) from region", con);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        //calling procedure without parameters
        public SqlDataReader MostExpensiveProducts()
        {
            con = getConnection();
            cmd = new SqlCommand("Ten Most Expensive Products", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //execute scalar will ignore all the values of the output except the first [0,0]
            //object obj = cmd.ExecuteScalar().ToString();
            //Console.WriteLine(obj);
            dr = cmd.ExecuteReader();
            return dr;
        }

        //procedures with parameters
        public void Procedure_With_Parameter()
        {
            con = getConnection();
            Console.WriteLine("Enter Customer ID :");
            string custid = Console.ReadLine();
            cmd = new SqlCommand("custordersorders", con);
            cmd.CommandType = CommandType.StoredProcedure;

            //option 1
            // cmd.Parameters.AddWithValue("@customerid", custid);

            //option 2
            //cmd.Parameters.Add("@avgsal", SqlDbType.Float).Direction = ParameterDirection.Output;
            //cmd.Parameters.Add("@count", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

           // cmd.Parameters.Add(new SqlParameter("@empid", SqlDbType.Int, 0, custid));
            
            //option 3 with SqlParameter class
            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@customerid";
            param1.Value = custid;
            param1.DbType = DbType.String;
            param1.Direction = ParameterDirection.Input;

            cmd.Parameters.Add(param1);

            dr = cmd.ExecuteReader();

            //int retcount = (int)cmd.Parameters["@count"].Value;
            //float outval = (float)cmd.Parameters["avgsal"].Value;
            while(dr.Read())
            {
                Console.WriteLine(dr["orderid"] + " " + dr["orderdate"]) ;
            }

            
        }
    }

    
}
