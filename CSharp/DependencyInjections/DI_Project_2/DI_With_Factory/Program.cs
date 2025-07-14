using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_With_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeBusinessAccess Eba = new EmployeeBusinessAccess();

            Employee retEmp = Eba.GetEmployeeDetails(1);

            Console.WriteLine($"ID : {retEmp.ID}, Name : {retEmp.Name}, " +
                $"Department : {retEmp.Department} and Salary : {retEmp.Salary}");
            Console.Read();
        }
    }
}
