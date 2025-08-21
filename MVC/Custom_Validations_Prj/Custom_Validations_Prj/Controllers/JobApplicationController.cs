using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Custom_Validations_Prj.Controllers
{
    public class JobApplicationController : Controller
    {
        // GET: JobApplication
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Models.JobApplication JA)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Result = "Application Form Submitted Successfully";
            }
            else
            {
                ViewBag.Result = "Invalid Entries, Check and resubmit..";
            }
            return View();
        }
    }
}