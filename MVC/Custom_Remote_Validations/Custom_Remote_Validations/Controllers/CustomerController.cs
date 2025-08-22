using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Custom_Remote_Validations.Models;

namespace Custom_Remote_Validations.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            CustomerModel cm = new CustomerModel();
            return View(cm);
        }

       [HttpGet]
       public JsonResult IsEmailExists(string Email)
        {
            bool isExist = false;
            if(Email.Equals("abc@email.com"))
            {
                isExist = true;
            }
            return Json(!isExist, JsonRequestBehavior.AllowGet);
        }
    }
}