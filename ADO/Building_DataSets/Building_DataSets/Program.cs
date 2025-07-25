using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Building_DataSets
{
    class Program
    {
        static void Datasets_Build()
        {
            //let us create in-memory cache
            DataSet dsEmployement = new DataSet("Employment");

            //2. add data table 1
            DataTable dtEmployees = new DataTable("Employees");

            //3. add columns to the datatable - size
            DataColumn[] dcEmployees = new DataColumn[4];

            //4. add/create column details
            dcEmployees[0] = new DataColumn("EmpCode", System.Type.GetType("System.Int32"));
            dcEmployees[1] = new DataColumn("EmpName", System.Type.GetType("System.String"));
            dcEmployees[2] = new DataColumn("EmpDept", System.Type.GetType("System.String"));
            dcEmployees[3] = new DataColumn("EmpStatusId", System.Type.GetType("System.Int32"));

            //5. Add the columns to the datatable
            dtEmployees.Columns.Add(dcEmployees[0]);
            dtEmployees.Columns.Add(dcEmployees[1]);
            dtEmployees.Columns.Add(dcEmployees[2]);
            dtEmployees.Columns.Add(dcEmployees[3]);

            //6. Add rows with data to the data table
            DataRow drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "1";
            drEmpRows["EmpName"] = "Rajesh";
            drEmpRows["EmpDept"] = "IT";
            drEmpRows["EmpStatusId"] = "1";

            //7. add the above row to the rows collection of the data table
            dtEmployees.Rows.Add(drEmpRows);

            //repeat steps 6 and 7 for no.of rows that we want to insert

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "2";
            drEmpRows["EmpName"] = "Ramya";
            drEmpRows["EmpDept"] = "Finance";
            drEmpRows["EmpStatusId"] = "3";

            dtEmployees.Rows.Add(drEmpRows);

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "3";
            drEmpRows["EmpName"] = "Satvika";
            drEmpRows["EmpDept"] = "Accounts";
            drEmpRows["EmpStatusId"] = "1";

            dtEmployees.Rows.Add(drEmpRows);

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "4";
            drEmpRows["EmpName"] = "Mahesh";
            drEmpRows["EmpDept"] = "Ops";
            drEmpRows["EmpStatusId"] = "3";

            dtEmployees.Rows.Add(drEmpRows);

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "5";
            drEmpRows["EmpName"] = "Divya";
            drEmpRows["EmpDept"] = "Finance";
            drEmpRows["EmpStatusId"] = "4";

            dtEmployees.Rows.Add(drEmpRows);

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "6";
            drEmpRows["EmpName"] = "Priya";
            drEmpRows["EmpDept"] = "Admin";
            drEmpRows["EmpStatusId"] = "4";

            dtEmployees.Rows.Add(drEmpRows);

            //8. create another Data Table

            DataTable dtEmpStatus = new DataTable("EmployeeStatus");

            //9 Create columns for the new table
            DataColumn[] dcStatus = new DataColumn[2];
            dcStatus[0] = new DataColumn("EmpStatusId", System.Type.GetType("System.Int32"));
            dcStatus[1] = new DataColumn("EmpStatus", System.Type.GetType("System.String"));

            //10. attach the columns to the table
            dtEmpStatus.Columns.Add(dcStatus[0]);
            dtEmpStatus.Columns.Add(dcStatus[1]);

            //11. Rows for the table
            DataRow drStatusRows = dtEmpStatus.NewRow();

            // 12. give values to the rows
            drStatusRows["EmpStatusId"] = "1";
            drStatusRows["EmpStatus"] = "Full Time";

            dtEmpStatus.Rows.Add(drStatusRows);

            drStatusRows = dtEmpStatus.NewRow();

            // 12. give values to the rows
            drStatusRows["EmpStatusId"] = "2";
            drStatusRows["EmpStatus"] = "Part Time";

            dtEmpStatus.Rows.Add(drStatusRows);
            drStatusRows = dtEmpStatus.NewRow();

            drStatusRows["EmpStatusId"] = "3";
            drStatusRows["EmpStatus"] = "Contract";

            dtEmpStatus.Rows.Add(drStatusRows);
            drStatusRows = dtEmpStatus.NewRow();

            drStatusRows["EmpStatusId"] = "4";
            drStatusRows["EmpStatus"] = "Interns";

            dtEmpStatus.Rows.Add(drStatusRows);

            //13. add both the tables to the dataset
            dsEmployement.Tables.Add(dtEmployees);
            dsEmployement.Tables.Add(dtEmpStatus);

            //14. associate the 2 tables using PK and FK
            //14.1 primary key and foreign key

            DataColumn parent = dsEmployement.Tables["EmployeeStatus"].Columns["EmpStatusId"];
            DataColumn child = dsEmployement.Tables["Employees"].Columns["EmpStatusId"];

            //14.2 set the relation
            DataRelation Emprel = new DataRelation("EmpStatusRelation", parent, child);

            //14.3 add the relation to the dataset
            dsEmployement.Relations.Add(Emprel);

            //15. Display the data as per the relation

            Console.WriteLine
           ("******************************************************************************");
            Console.WriteLine("Status ID             |             Employee Status");
            Console.WriteLine
           ("--------------------------------------------------------------------");
            foreach(DataRow row in dsEmployement.Tables["EmployeeStatus"].Rows)
            
                Console.WriteLine("{0}                 |                       {1}",
                    row["EmpStatusId"], row["EmpStatus"]);
            Console.WriteLine
            ("-----------------------------------------------------------------------");
            foreach(DataRow row in dsEmployement.Tables["Employees"].Rows)
            {
                //Console.WriteLine("{0} \t | {1}    \t  | " +
                //    "         {2}          \t          |        {3}     \t",row["EmpCode"],
                //    row["EmpName"], row["EmpDept"], row["EmpStatusId"]);

                //if we want the status names and not the id
                int irow = int.Parse(row["EmpStatusId"].ToString());
               // Console.WriteLine(irow);
                Console.WriteLine();
                DataRow currentrow = dsEmployement.Tables["EmployeeStatus"].Rows[irow - 1];

                Console.WriteLine(currentrow);

                Console.WriteLine("{0} \t | {1}    \t  | " +
                   "         {2}          \t          |        {3}     \t", row["EmpCode"],
                   row["EmpName"], row["EmpDept"], currentrow["EmpStatus"]);
            }
            

        }
        static void Main(string[] args)
        {
            Datasets_Build();
            Console.Read();
        }
    }
}
