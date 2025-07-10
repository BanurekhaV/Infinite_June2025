using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an instance of EmployeeBAL
            //and inject the dependency object as an argument to the constructor

            EmployeeBAL employeeBAL = new EmployeeBAL(new EmployeeDALImplementor());

            List<Employee> emplist = employeeBAL.SelectAllEmployees();

            foreach(Employee e in emplist)
            {
                Console.WriteLine($"ID = {e.ID} , Name = {e.Name} and Dept = {e.Department}");
            }
            Console.Read();
        }
    }
}
