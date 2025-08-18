using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        //1. Normal Method
        public string NormalMethod()
        {
            return "Hi All..";
        }

        //2. ViewResult
        public ViewResult ViewMethod()
        {
            return View();
        }

        //3. ContentResult
        public ContentResult ContentMethod()
        {
            //  return Content("Hello All, This is Content", "text/plain");
            return Content("<h1 style=color:red;> Good Evening All </h1>", "text/html");
        }

        //4. EmptyResult that does not show up anything to the user
        [NonAction]
        public EmptyResult Empty()
        {
            int amt = 45000;
            float si = (amt * 3 * 2) / 100;
            return new EmptyResult();
        }

        //5. Redirect
        public ActionResult redirectMethod()
        {
            //redirecting to other actionmethods of the same controller
           // return RedirectToAction("ContentMethod");

            //redirecting to other actionmethods of the other controller
            return RedirectToAction("index", "home");
        }

        //6. JsonResult
        public JsonResult Empdata()
        {
            Employee emp = new Employee() { ID = 101, Name = "Mahesh", Age = 22 };
            return Json(emp,JsonRequestBehavior.AllowGet);
        }
    }
}