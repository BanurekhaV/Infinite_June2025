using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxPosting_Prj.Models;

namespace AjaxPosting_Prj.Controllers
{
    public class StudentController : Controller
    {
        StudentContext context = new StudentContext();

        public ActionResult Index()
        {
            return View();
        }

        //creating a post fro new student record
        [HttpPost]
        public ActionResult CreateStudent(Student std)
        {
            context.Students.Add(std);
            context.SaveChanges();
            string message = "SUCCESS";
            return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        }

        //get a student
        public ActionResult GetStudent(string id)
        {
            List<Student> students = new List<Student>();
            students = context.Students.ToList();
            return Json(students, JsonRequestBehavior.AllowGet);
        }
    }
}