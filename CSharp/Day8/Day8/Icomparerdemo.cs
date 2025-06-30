using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{

    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }

    class AgeComparer : IComparer<Employee>
    {
        public int Compare(Employee e , Employee e1)
        {
            return e.Age.CompareTo(e1.Age);
        }
    }
    class Icomparerdemo
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Name ="Bob",Age = 45 });
            employees.Add(new Employee { Name = "smith", Age = 25 });
            employees.Add(new Employee { Name = "Jim", Age = 35 });

            employees.Sort(new AgeComparer());

            foreach(var e in employees)
            {
                Console.WriteLine(e.Name+" "+e.Age);
            }
        }
    }
}
