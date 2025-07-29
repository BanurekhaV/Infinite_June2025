using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace LinqToSql_SqlMetal
{
    class Program
    {
        static string connectstr =
            ConfigurationManager.ConnectionStrings["NwindConnstr"].ConnectionString;
        
        static NorthwindContext db = new NorthwindContext(connectstr);
        static void Main(string[] args)
        {
            var custdetails = from c in db.Customers
                              orderby c.ContactName
                              select c;

            foreach(var item in custdetails)
            {
                Console.WriteLine($"{item.CustomerID}, {item.ContactName}, {item.CompanyName}, {item.Country}");
            }

            Console.Read();
        }
    }
}
