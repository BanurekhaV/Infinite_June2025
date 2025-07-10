using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Project_2
{
    //service class responsible for interacting with the database
    //hence this can be a dependency object
    //dependency objects should always be interface based

    public interface IEmployeeDAL
    {
        List<Employee> GetAllEmployees();
    }
    public class EmployeeDALImplementor : IEmployeeDAL
    {
        //populate some data (in real life data comes from the database)
        public List<Employee> GetAllEmployees()
        {
            List<Employee> empList = new List<Employee>
            {
               new Employee(){ID=1, Name = "Nandini", Department="IT"},
               new Employee(){ID=2, Name = "Rakesh", Department="Admin"},
               new Employee(){ID=3, Name = "Susmitha", Department="Quality"},
            };
            return empList;
        }
    }
}
