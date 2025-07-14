using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Project
{
    public class Employee
    {
        public int ? ID { get; set; }
        public string Name { get; set; }
        public double ? Salary { get; set; }

        public List<Employee>EmployeeList()
        {
            List<Employee> emplist = new List<Employee>()
            {
                new Employee{ID = 100, Name = "John", Salary= 5000},
                new Employee{ID = 101, Name = "Mary", Salary= 6000},
                new Employee{ID = 102, Name = "Bob", Salary= 4000},
            };
            return emplist;
        }

        public int Add2nos(int x, int y)
        {
            return x + y;
        }

        public string Login(string userid, string password)
        {
            if (string.IsNullOrEmpty(userid) || string.IsNullOrEmpty(password))
            {
                return "User id or Password cannot be empty";
            }
            else if (userid == "Admin" && password == "Admin@123")
            {
                return "Welcome Admin";
            }
            else
                return "Incorrect Userdid or Password";
        }
    }
}
