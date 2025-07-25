using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Transactions;

namespace ConnectionPooling_Transaction
{
    class Program
    {
        public static string connectstr = "Data Source=laptop-tjj7d977;initial catalog=northwind;" +
            "integrated security=true;Pooling = true;";
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            //stopwatch.Start();

            //for(int i=0; i<1000; i++)
            //{
            //    SqlConnection con = new SqlConnection(connectstr);
            //    con.Open();
            //    con.Close();
            //}
            //stopwatch.Stop();
            //Console.WriteLine($"The Time Taken :{stopwatch.ElapsedMilliseconds} ms");
            //  Transaction_Northwind(connectstr);
            Transaction_ScopeEg(connectstr);
            Console.Read();
        }

        //Transaction example
        public static void Transaction_Northwind(string str)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand(); //an sql command object is created and returned

                //for transaction
                SqlTransaction tran;
                tran = con.BeginTransaction(); //associating a transaction object to the connection
                cmd.Transaction = tran;
                try
                {
                    cmd.CommandText = "insert into region values(21,'Infinite Region')";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "update region set regiondescription = 'Monsoon Region'" +
                        "where regionid=200";
                    cmd.ExecuteNonQuery();
                    tran.Commit();
                    Console.WriteLine("Transaction completed...");
                }
                catch(SqlException se)
                {
                    //Console.WriteLine(se.Message);
                    Console.WriteLine("OOPS !! something went wrong");
                    try
                    {
                        tran.Rollback();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }

        //Transaction Sccope Eg
        public static void Transaction_ScopeEg(string str)
        {
            TransactionOptions options = new TransactionOptions();
            options.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            using(TransactionScope ts = new TransactionScope())
            {
                using(SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand("Insert into region values(25,'New Region')",con))
                    {
                        try
                        {
                          int rowsupdated = cmd.ExecuteNonQuery();
                           if(rowsupdated > 0)
                           {
                                using (SqlConnection con1 = new SqlConnection(str))
                                {
                                    con1.Open();
                                    using (SqlCommand cmd1 = new SqlCommand("insert into shippers values(10,'DTDC','(100)-12345')", con1))
                                    {
                                        int noofrows = cmd1.ExecuteNonQuery();
                                        if (noofrows > 0)
                                        {
                                            ts.Complete();
                                            Console.WriteLine("Transaction Completed..");
                                            con1.Close();
                                        }
                                    }
                                }
                           }
                        }
                        catch (SqlException s)
                        {
                            Console.WriteLine("Transaction Failed..");
                            ts.Dispose();
                        }
                       
                    }
                    con.Close();
                }
            }
        }
    }
}
