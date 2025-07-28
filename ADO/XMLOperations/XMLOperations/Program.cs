using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Xml;

namespace XMLOperations
{
    class Program
    {
        static DataSet ds = new DataSet("DS");
        static void Main(string[] args)
        {
          //  XMLWriter();
          //  XMLReader();
           // XMLSchemaWriter();
            XMLSchemaReader();
            Console.Read();
        }

        static void ContenGeneration()
        {
            ds.Namespace = "StudentSpace";
            DataTable stdTable = new DataTable("Students");
            stdTable.Columns.Add("Id", typeof(int));
            stdTable.Columns.Add("Name", typeof(string));
            stdTable.Columns.Add("Address", typeof(string));

            DataRow dr = stdTable.NewRow();
            dr["Id"] = 10;
            dr["Name"] = "Mohan";
            dr["Address"] = "Bangalore";

            stdTable.Rows.Add(dr);

            dr = stdTable.NewRow();
            dr["Id"] = 11;
            dr["Name"] = "Sohan";
            dr["Address"] = "Mumbai";

            stdTable.Rows.Add(dr);
            dr = stdTable.NewRow();
            dr["Id"] = 12;
            dr["Name"] = "Rohan";
            dr["Address"] = "Hyderabad";

            stdTable.Rows.Add(dr);

            ds.Tables.Add(stdTable);
            ds.AcceptChanges();
        }

        static void XMLWriter()
        {
            try
            {
                ContenGeneration();
                StreamWriter sw = new StreamWriter("Stud.xml");

                ds.WriteXml(sw);
                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void XMLReader()
        {
            DataSet ds1 = new DataSet();
            ds1.ReadXml("Stud.xml");

            foreach(DataTable dt in ds1.Tables)
            {
                Console.WriteLine(dt);

                for(int i=0; i<dt.Columns.Count;i++)
                {
                    Console.Write("\t" + "\t" + dt.Columns[i].ColumnName);
                }
                Console.WriteLine();

                foreach(DataRow dr in dt.Rows)
                {
                    for(int j=0; j<dt.Columns.Count;j++)
                    {
                        Console.Write("\t" + "\t" + dr[j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("-----------------------------------------------------------");

                foreach(var row in dt.AsEnumerable())
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        Console.Write("\t" + "\t" + row[j]);
                    }
                    Console.WriteLine();
                }
            }
        }

        static void XMLSchemaWriter()
        {
            ContenGeneration();
            ds.WriteXmlSchema("studentschema");
        }

        static void XMLSchemaReader()
        {
            ds = new DataSet("stdschema");
            StreamReader sr = new StreamReader("studentschema");

            ds.ReadXmlSchema(sr);

            //use foreach loop and iterate the dataset

            //we can also write using the schema writer
            XmlTextWriter writer = new XmlTextWriter(Console.Out);
            ds.WriteXmlSchema(writer);
        }
    }
}
