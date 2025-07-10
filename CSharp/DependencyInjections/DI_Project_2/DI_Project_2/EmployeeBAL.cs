using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Project_2
{
    public class EmployeeBAL
    {
        //client class or dependant class
       public IEmployeeDAL employeeDAL;

        //injecting dependency object into the constructor of the dependant object
        public EmployeeBAL(IEmployeeDAL _edal)
        {
            employeeDAL = _edal;
        }
        public List<Employee>SelectAllEmployees()
        {
            //create an instance of the dependency class
            //employeeDAL = new EmployeeDAL();  // is a tight coupled code
            
            return employeeDAL.GetAllEmployees();
        }
    }
}
