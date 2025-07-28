using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Building_DataSets
{
    class Datasets_Manipulations
    {
        public static void Main()
        {
            DataSet_Ops();
            Console.Read();
        }
        public static void DataSet_Ops()
        {
            DataTable tableCust = new DataTable("Customers");
            tableCust.Columns.Add("CustomerID", typeof(int));
            tableCust.Columns.Add("CustomerName", typeof(string));
            tableCust.Columns.Add("AID", typeof(int));

            tableCust.Columns["AID"].AutoIncrement = true;
            tableCust.Columns["AID"].AutoIncrementSeed = 5;
            tableCust.Columns["AID"].AutoIncrementStep = 5;
            tableCust.Columns["AID"].ReadOnly = true;

            //populate data
            DataRow row = tableCust.NewRow();
            row["CustomerID"] = 1;
            row["CustomerName"] = "Infinite Ltd.";
            tableCust.Rows.Add(row);

            row = tableCust.NewRow();
            row["CustomerID"] = 4;
            row["CustomerName"] = "CTS.";
            tableCust.Rows.Add(row);

            row = tableCust.NewRow();
            row["CustomerID"] = 3;
            row["CustomerName"] = "Infosys Ltd.";
            tableCust.Rows.Add(row);

            row=tableCust.NewRow();
            row["CustomerID"] = 5;
            row["CustomerName"] = "TCS Ltd.";
            tableCust.Rows.Add(row);

            DataTable tableOrders = new DataTable("Orders");
            tableOrders.Columns.Add("OrderID", typeof(int));
            tableOrders.Columns.Add("OrderValue", typeof(decimal));

            //setting primary key
            DataColumn[] pk = new DataColumn[0];
            tableOrders.PrimaryKey = pk;

            DataRow r = tableOrders.NewRow();
            r["OrderID"] = 100;
            r["OrderValue"] = 25000.75;

            tableOrders.Rows.Add(r);

            //filtering
            DataRow[] result = tableCust.Select("CustomerID > 2","CustomerID DESC");

            foreach(DataRow srows in result)
            {
                Console.WriteLine(srows["CustomerID"] + " " + srows["CustomerName"]+ " " + srows["AID"]);
            }
            Console.WriteLine("________________________________");
            //sorting
            //  tableCust.DefaultView.Sort = "CustomerName";


            //converting the datatable to a list

            //modifying data in a data table
            tableCust.Rows[2]["CustomerName"] = "Wipro";

            tableCust.AcceptChanges();

            //deleting data in a data table
            tableCust.Rows[3].Delete();
            tableCust.AcceptChanges();

            List<DataRow> dtlist = tableCust.AsEnumerable().ToList();

            //var custlist = tableCust.AsEnumerable().Select(r1 => new Cust
            //{
            //    CustomerId = r1.Field<int>("CustomerID"),
            //    CustomerName = r1.Field<string>("CustomerName")

            //}).ToList();
            foreach(DataRow var in dtlist)
            {
                Console.WriteLine(var["CustomerID"] +  " " + var["CustomerName"] + 
                  " "  + var["AID"] );
            }

            Console.WriteLine("*****************XML******************");
            //visulaizing data as an xml document
            DataSet ds = new DataSet("CustOrders");
            ds.Tables.Add(tableCust);
            ds.Tables.Add(tableOrders);
            Console.WriteLine(ds.GetXml());
            Console.WriteLine("********************");
            Console.WriteLine(ds.GetXmlSchema());


        }

    }
}
