using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Csharp
{
    class Employee
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public static (string,double,string)GetEmployeeDetails(long eid)
        {
            string ename = "Vikram";
            double salary = 45000;
            string dname = "HR";
            return (ename, salary, dname);
        }
    }
    class Deconstruction
    {
        static void Main()
        {
            //1. deconstruction by creating multiple variables
            var employeedetails = Employee.GetEmployeeDetails(1001);
            var EName = employeedetails.Item1;
            var ESalary = employeedetails.Item2;
            var EDept = employeedetails.Item3;
            Console.WriteLine($"{ EName}, { ESalary} and {EDept}" );

            //2. explicitly declare the type of each field inside the parenthesis
            (string name, double sal, string dept) = Employee.GetEmployeeDetails(1001);
            Console.WriteLine(name + " " + sal + " "+ dept);

            //3. using var keyword (type is inferred)
            var (Name, Salary, Dept) = Employee.GetEmployeeDetails(1001);
            Console.WriteLine(Name + " " + Salary + " " + Dept);

            //4. tuple into variables at the calling function

            string EmployeeName, DepartmentName;
            double EmpSalary;
            (EmployeeName, EmpSalary, DepartmentName) = Employee.GetEmployeeDetails(1001);
            Console.WriteLine($"{EmployeeName}, {EmpSalary} and {DepartmentName}");
            Console.Read();
        }
    }
}
