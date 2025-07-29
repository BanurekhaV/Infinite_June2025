using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseFirst_EntityStates
{
    class Program
    {
        //let us create an instance of the context class

        static InfiniteDBEntities db = new InfiniteDBEntities();

        static Employee employee = new Employee(); //Detached state
        static void Main(string[] args)
        {
            Console.WriteLine("------------Entity States------------");
            Console.WriteLine($"State of the newly created Employee Entity : {db.Entry(employee).State}");
            Console.WriteLine();

            employee.EmpId = 11;
            employee.EmpName = "Junk";
            employee.Gender = "Female";
            employee.Salary = 10000;
            employee.DepartmentId = 3;
            employee.Phone = "1111111";
            Console.WriteLine("********** Inserting a Row ***********");
          //  AddEmp(employee);
            Console.WriteLine("*********** Updation ***************");
          //  UpdateEmp();
            Console.WriteLine("********** Deletion **********");
         //   DeleteEmp();
            Console.WriteLine("********** All Employees *******");
            ShowAllEmp();
            Console.WriteLine("********** Procedures ************");
             CallProc();
            Console.WriteLine("******** Functions *************");
            Callfunction();
            Console.Read();

        }

        static void CallProc()
        {
            ObjectParameter param = new ObjectParameter("Salary", typeof(float));
            ObjectParameter param2 = new ObjectParameter("avgsal", typeof(float));
            ObjectParameter param3 = new ObjectParameter("count", typeof(Int32));
            
            db.GetSal_byName("Alexa", param);
            Console.WriteLine((param.Value).ToString());
           int count =  db.sp_getavgsal_empcount(1, param2);
            Console.WriteLine("Average Salary of Dept : 1 is : {0} and the Employee count is {1}", param2.Value, count);

        }

        static void Callfunction()
        {
            var results = db.fn_GetEmp_ByGender("Male");
            foreach(var v in results)
            {
                Console.WriteLine($"{v.EmpNumber}, {v.EmployeeName}, {v.Gender}");
            }
        }
        static void ShowAllEmp()
        {
           // var emplist = db.Employees.ToList();

            foreach (var item in db.Employees)
            {
                Console.WriteLine($"{item.EmpName}, {item.DepartmentId}, {item.Salary}, {item.AnnualSalary}");
            }
        }
        static void AddEmp(Employee e)
        {
            Console.WriteLine($"Before Insertion, the state of Employee Entity : {db.Entry(e).State}");
            db.Employees.Add(e);  //changes are made only to the dbset in the memory(datatable)
            Console.WriteLine($"After calling add and before Saving, the state of Employee Entity : {db.Entry(e).State}");

            db.SaveChanges();  // going make changes to the database permanently
            Console.WriteLine($"After Saving, the state of Employee Entity : {db.Entry(e).State}");
        }

        static void UpdateEmp()
        {
            Console.WriteLine("Enter Empid to Update :");
            int eid = Convert.ToInt32(Console.ReadLine());
            employee = db.Employees.Find(eid);

            if(employee !=null)
            {
                Console.WriteLine($"Before Update, the state : {db.Entry(employee).State}");
                employee.DepartmentId = 5;
                Console.WriteLine($"After Update, the state : {db.Entry(employee).State}");

                db.SaveChanges();
                Console.WriteLine($"After save changes, the state : {db.Entry(employee).State}");
            }
            else
            {
                Console.WriteLine("No matching employee found");
            }
        }

        static void DeleteEmp()
        {
            Console.WriteLine("Enter empid to delete :");
            int eid = int.Parse(Console.ReadLine());
            employee = db.Employees.Find(eid);
            if (employee != null)
            {
                Console.WriteLine($"Before Delete, the state : {db.Entry(employee).State}");
                db.Employees.Remove(employee);
                Console.WriteLine($"After Delete before save, the state : {db.Entry(employee).State}");

                db.SaveChanges();
                Console.WriteLine($"After save changes, the state : {db.Entry(employee).State}");
            }
            else
            {
                Console.WriteLine("No matching employee found");
            }
        }
    }
}
