using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Authentication_Prj.Models;
using System.Web.Security;

namespace Authentication_Prj.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if(ModelState.IsValid)
            {
                //here we will check the values entered using some hardcoded comparisons
                if(model.UserName.ToLower() == "admin" && model.Password == "admin")
                {
                    //store the username in a session 
                    Session["UserName"] = model.UserName;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid UserName or Password");
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }
             
    }
}