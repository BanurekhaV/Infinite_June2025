using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace LINQ_Queries
{
    class Linq_With_DataTables
    {
        public static DataTable GetData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Product", typeof(string));

            dt.Rows.Add(1, "Swiss Chocolates");
            dt.Rows.Add(2, "Gucci Bags");
            dt.Rows.Add(3, "Sports Shoes");
            dt.Rows.Add(4, "USBs");
            return dt;
        }

        static void Main()
        {
            DataTable dtforReturn = GetData();

            //method syntax to query the datatable

            var result = dtforReturn.AsEnumerable().Where(x => x.Field<int>("Id")
            == 4).FirstOrDefault();

            if(result != null)
            {
                Console.WriteLine(result["Id"] + " " + result["Product"]);
            }
            else
                Console.WriteLine("No Product with the ID found..");

            Console.WriteLine("*****************************");

            //query syntax
            var dtrows = (from prod in dtforReturn.AsEnumerable()
                          where prod.Field<int>("Id") == 3
                          select prod).FirstOrDefault();

            if(dtrows !=null)
            {
                Console.WriteLine(dtrows["Id"] + " " + dtrows["Product"]);
            }
            else
                Console.WriteLine("No Matching Product..");

            //convert the enumerable collection back to a data table
            Console.WriteLine("-----------------------------");

            var dt = dtforReturn.AsEnumerable().Where(f => f.Field<int>("Id") > 1);

            DataTable tableagain = dt.CopyToDataTable<DataRow>();

            foreach(DataRow dr in tableagain.Rows)
            {
                foreach(DataColumn dc in tableagain.Columns)
                {
                    Console.Write(dr[dc] + "  ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
