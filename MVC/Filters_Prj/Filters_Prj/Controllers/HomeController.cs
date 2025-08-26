using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filters_Prj.Models;
using Filters_Prj.CommonFilters;

namespace Filters_Prj.Controllers
{
    //diffrent error pages for different types of errors
    //[HandleError(ExceptionType =typeof(DivideByZeroException), View = "DivideByZero")]
    //[HandleError(ExceptionType =typeof(NullReferenceException), View = "NullReference")]
    //[HandleError]
    // [AllowAnonymous]

    //[LogCustomException]
    public class HomeController : Controller
    {
        // [HandleError]
        // [Authorize]
        public ActionResult Index()
        {
            throw new Exception("Something went wrong.");
            //  return View();
        }

        //2 testing various error pages
        public ActionResult TestMethod1()
        {
            throw new NullReferenceException();
        }

        public ActionResult TestMethod2()
        {
            throw new DivideByZeroException();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]

        public ActionResult Login()
        {
            //ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }

        [HttpPost]
        [AdminFilter]
        public ActionResult Login(string UserName, string Password, bool Rememberme, string ReturnUrl)
        {
            Session["IsAdmin"] = false;
            if (UserName == "Banurekha" && Password == "banu@123")
            {
                Session["IsAdmin"] = true;
                return Redirect(ReturnUrl);
            }
            return View("Login");
        }
    }

}