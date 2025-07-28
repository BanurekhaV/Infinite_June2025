using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Queries
{
    class Employee
    {
        public string Name { get; set; }
        public int EId { get; set; }
        public float Salary { get; set; }

       public static List<Employee> GetEmployees()
        {
            List<Employee> emplist = new List<Employee>
            {
                new Employee{EId = 1, Name = "Syam", Salary=54000},
                new Employee{EId = 2, Name = "Shrinivas", Salary=30000},
                new Employee{EId = 3, Name = "Vikram", Salary=42000},
            };
            return emplist;
        }
    }
    class Immediate_Vs_Deferred
    {
        static void Main()
        {
            
            var employees = Employee.GetEmployees();

            //immediate linq construction
            var iquery = employees.Where(e => e.Salary < 35000).Select(n => n.Name).ToList();

            //deferred query
            var dquery = employees.Where(e => e.Salary < 35000).Select(n => n.Name);
            
           employees.Add(new Employee { EId = 4, Name = "Shami", Salary = 34000 });
          
            foreach( var item in dquery)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
