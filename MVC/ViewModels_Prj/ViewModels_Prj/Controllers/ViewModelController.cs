using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModels_Prj.Models;

namespace ViewModels_Prj.Controllers
{
    public class ViewModelController : Controller
    {
        // GET: ViewModel
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmpAddDetails()
        {
            Employee e = new Employee()
            {
                EID = 101,
                EName = "Harshitha",
                Salary = 55000,
                AddreesId = 1
            };
            Address addr = new Address()
            {
                AddressId = 1,
                DoorNo = "4, ABC Villa",
                Street = "GulliNo 420",
                City = "MyCity"
            };

            //create a viewmodel object
            EmployeeAddress empadd = new EmployeeAddress()
            {
                employee = e,
                address = addr,
                PageTitle = "Employee Personal Details"
            };
            //ViewBag.VmTitle = "View Model Example";
            return View(empadd);
        }
    }
}