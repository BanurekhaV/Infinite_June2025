using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers
{
    public class HRController : Controller
    {
        // GET: HR

        //3. calling another View and passing the model object
        public ActionResult Index()
        {
            List<Department> d = new List<Department>();
            d.Add(new Department { ID = 10, DeptName = "CSE" });
            d.Add(new Department { ID = 11, DeptName = "ECE" });
            d.Add(new Department { ID = 12, DeptName = "IT" });
            d.Add(new Department { ID = 13, DeptName = "EEE" });
            return View("DepartmentList", d);
        }

        public ActionResult DepartmentList(Department dept)
        {
            return View(dept);
        }
        //1. Binding a model object to the view
        public ActionResult DisplayEmployee()
        {
            Employee e = new Employee() { ID = 1, Name = "Rahul", Age = 23 };
            return View(e);
        }

        //2. Binding a collection model object to the view
        public ActionResult EmployeeList()
        {
            List<Employee> emplist = new List<Employee>()
            {
                new Employee{ID=100, Name="Rama",Age=17},
                new Employee{ID=101, Name="Sita",Age=14},
                new Employee{ID=102, Name="Lakshman",Age=15},
            };
            return View(emplist);
        }

        //4. To change the name of the view different from actionmethod
        //4.1 We can give action name selector and map it to a view of different name
        //4.2 We can change the name of the view to match the action name
        [ActionName("Test")]
        public ActionResult DifferentName()
        {
            ViewBag.sample = " Testing Views with Different name";
          //  return View("DifferentName"); //4.1
            return View(); //4.2
        }

    }
}