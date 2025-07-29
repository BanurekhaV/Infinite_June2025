using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            employee.EmpId = 501;
            employee.EmpName = "Alexa";
            employee.Gender = "Female";
            employee.Salary = 10000;
            employee.DepartmentId = null;
            employee.Phone = "999777888";
            Console.WriteLine("********** Inserting a Row ***********");
            AddEmp(employee);
            Console.WriteLine("*********** Updation ***************");
            //UpdateEmp();
            Console.WriteLine("********** Deletion**********");
            //DeleteEmp();
            //ShowAllEmp();

            Console.Read();

        }

        static void AddEmp(Employee e)
        {
            Console.WriteLine($"Before Insertion, the state of Employee Entity : {db.Entry(e).State}");
            db.Employees.Add(e);  //changes are made only to the dbset in the memory(datatable)
            Console.WriteLine($"After calling add and before Saving, the state of Employee Entity : {db.Entry(e).State}");

            db.SaveChanges();  // going make changes to the database permanently
            Console.WriteLine($"After Saving, the state of Employee Entity : {db.Entry(e).State}");
        }
    }
}
