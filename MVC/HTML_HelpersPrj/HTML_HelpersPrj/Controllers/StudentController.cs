using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTML_HelpersPrj.Models;

namespace HTML_HelpersPrj.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        //1. StronglyTyped Helper
        public ActionResult StronglyTyped_Helper()
        {
            return View();
        }

        //2. Templated Helper individual
        public ActionResult TemplatedHelper()
        {
            return View();
        }

        //3. Templated helper for the entire model
        public ActionResult TemplateForModel()
        {
            return View();
        }

        //4. Standard Helper
        public ActionResult StandardHelper()
        {
            return View();
        }
        //5. Display Template
        public ActionResult StudentDetails()
        {
            Student stud = new Student()
            {
                RNo = 1,
                Name = "Karthick",
                Address = "Chennai",
            };
            ViewData["stddata"] = stud;
            return View(stud);
        }

        //6. Custom Helpers

    }
}