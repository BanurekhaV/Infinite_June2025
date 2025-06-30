using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Employee
    {
        public string EmployeeName { get; set; }
        public int Rating { get; set; }

        SortedList<int, string> ranking = new SortedList<int, string>();
        internal void AddEmployee(Employee employee)
        {

            ranking.Add(employee.Rating, employee.EmployeeName);
        }

        internal void DisplayEmployeeRating()
        {
            foreach(var item in ranking)
            {
                Console.WriteLine($"{item.Key}    {item.Value}");
            }
        }
    }
    class SortedList
    {
        static void Main()
        {
            Employee employee = new Employee();

            employee.AddEmployee(new Employee { EmployeeName = "Shiva", Rating = 4 });
            employee.AddEmployee(new Employee { EmployeeName = "Januma", Rating = 1 });
            employee.AddEmployee(new Employee { EmployeeName = "Banu", Rating = 3 });
            employee.AddEmployee(new Employee { EmployeeName = "Varsha", Rating = 2 });
            employee.AddEmployee(new Employee { EmployeeName = "Devi", Rating = 5});

            employee.DisplayEmployeeRating();

        }

    }
}
