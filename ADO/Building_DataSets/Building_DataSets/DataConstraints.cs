using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Building_DataSets
{
    class DataConstraints
    {
        static void Main()
        {
            OurDataConstraints();
            Console.Read();
        }

        public static void OurDataConstraints()
        {
            DataSet ds = new DataSet();
            DataTable ClassTable = ds.Tables.Add("OurClass");

            ClassTable.Columns.Add("CId", typeof(int));
            ClassTable.Columns.Add("ClassName", typeof(string));

            DataTable StudentTable = ds.Tables.Add("Students");

            StudentTable.Columns.Add("SId", typeof(int));
            StudentTable.Columns.Add("SName", typeof(string));
            StudentTable.Columns.Add("ClassId", typeof(int));

            //initialize the PK constraint
            ClassTable.PrimaryKey = new DataColumn[] { ClassTable.Columns["CId"] };

            //add relation to the dataset
            ds.Relations.Add("class_student", ClassTable.Columns["CId"], StudentTable.Columns["ClassId"]);

            //set the foreign key
            DataColumn dcclassid = ds.Tables["OurClass"].Columns["CId"];
            DataColumn dcstudent = ds.Tables["Students"].Columns["ClassId"];

            ForeignKeyConstraint fkc = new ForeignKeyConstraint("csfkc", dcclassid, dcstudent);

            //we can set the rules for foreign key
            fkc.DeleteRule = Rule.SetNull;
            fkc.UpdateRule = Rule.Cascade;

            //we may even have unique constraint
            UniqueConstraint ucnames = new UniqueConstraint(new DataColumn[] { ClassTable.Columns["ClassName"] });
            ds.Tables["OurClass"].Constraints.Add(ucnames);

            //now we will tets the constraints
            DataRow dr1 = ds.Tables["OurClass"].NewRow();

            dr1["CId"] = 1;
            dr1["ClassName"] = null;

            ClassTable.Rows.Add(dr1);

            //2nd row
            dr1 = ds.Tables["OurClass"].NewRow();

            dr1["CId"] = 2;
            dr1["ClassName"] = "Sixth";

            ClassTable.Rows.Add(dr1);


            //student table

            DataRow dr2 = ds.Tables["Students"].NewRow();
            dr2["Sid"] = 1;
            dr2["SName"] = "Banurekha";
            dr2["ClassId"] = 1;

            StudentTable.Rows.Add(dr2);
           
        }
    }
}
