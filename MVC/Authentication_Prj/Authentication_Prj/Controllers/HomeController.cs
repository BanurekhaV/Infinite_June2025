using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Authentication_Prj.CustomFilters;

namespace Authentication_Prj.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [CustomAuthenticationFilter]
        public ActionResult Index()
        {
            return View();
        }

        [CustomAuthenticationFilter]
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}