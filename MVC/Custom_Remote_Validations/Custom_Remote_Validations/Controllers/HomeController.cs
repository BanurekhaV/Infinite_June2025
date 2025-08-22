using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Custom_Remote_Validations.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult CustomValidation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CustomValidation(Models.UserModel um)
        {
            if (ModelState.IsValid)
                return Content("Thank You for the Valid Data");
            else
                return View(um);
        }
    }
}