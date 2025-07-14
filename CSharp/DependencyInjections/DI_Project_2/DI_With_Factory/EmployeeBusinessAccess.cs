using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_With_Factory
{
    public class EmployeeBusinessAccess
    {
        IEmployeeDataAccess _empdataaccess;

        public EmployeeBusinessAccess()
        {
            _empdataaccess = DataAccessFactory.GetEmployeeAccessObject();
        }

        public Employee GetEmployeeDetails(int id)
        {
             return _empdataaccess.GetEmployeeDetails(id);
            //Employee e = _empdataaccess.GetEmployeeDetails(id);
            //return e;
        }
    }
}
