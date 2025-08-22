using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Custom_ModelBinding.CustomBindings;
using Custom_ModelBinding.Models;

namespace Custom_ModelBinding.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index([ModelBinder(typeof(CustomBinder))]CustomModel cm)
        {
            ViewBag.SplTitle = cm.Title;
            ViewBag.Date = cm.Date;
            return View(cm);
        }

        //bundling scripts
        public ActionResult Bundling_Method()
        {
            return View();
        }
    }
}