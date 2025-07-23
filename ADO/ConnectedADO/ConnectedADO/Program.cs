using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConnectedADO
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        static void Main(string[] args)
        {            
                SelectData();          

            Console.Read();
        }

        //common function to get the connection
        static SqlConnection getConnection()
        {
            con = new SqlConnection("Data Source=LAPTOP-TJJ7D977;Initial Catalog=InfiniteDB;" +
                "Integrated Security = true;");
            con.Open();
            return con;
        }

        static void SelectData()
        {
            try
            {
                con = getConnection();
                cmd = new SqlCommand("select * from employee", con);
                //cmd.Connection = con;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    // Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[3] + " " + dr[4]);
                    Console.WriteLine("Employee ID : " + dr["Empid"]);
                    Console.WriteLine("Employee name: " + dr["empname"]);
                }
            }
            catch(SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }

    }
}
