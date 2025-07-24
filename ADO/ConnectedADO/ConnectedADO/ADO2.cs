using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            int res = region.InsertRegion();
            if(res>0)
                Console.WriteLine("Added a record..");
            else
                Console.WriteLine("Failed to Add");
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
    }

    
}
