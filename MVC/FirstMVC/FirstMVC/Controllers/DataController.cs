using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            //1. Passing an object to the view that will be used as a model
            ViewBag.MyData = "Flower Index";
            List<string> flowers = new List<string>
            {
                "Roses", "Lillies", "Jasmines", "Marigolds"
            };
            return View(flowers);
        }

        //2. Checking if the ViewBag can pass on the information to further requests
        public ActionResult TestDataTransfer()
        {
            //ViewBag.Data1 = "Data One";
            //ViewData["Data2"] = "Data Two";

              return View();   // data passed to the current View
            //return RedirectToAction("Index");
        }

        //3. Passing data thru viewbag and viewdata
        public ActionResult OfficeRules()
        {
            List<string> rules = new List<string>()
            {
                "Be on Time", "Carry Your ID Card", "Avoid T-Shirts","Complete Work as per Deadlines"
            };
            //1. transfer data using View Bag
             ViewBag.OfficeRules = rules;

            //2. transfer data thru ViewData
            ViewData["followrules"] = rules;

            // return View();
            return RedirectToAction("TestDataTransfer");
        }
    }
}