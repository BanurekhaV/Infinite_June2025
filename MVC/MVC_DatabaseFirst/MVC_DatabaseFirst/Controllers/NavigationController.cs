using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_DatabaseFirst.Models;

namespace MVC_DatabaseFirst.Controllers
{
    public class NavigationController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Navigation
        public ActionResult Index()
        {
            return View();
        }

        //1. Fetching data from multiple tables/objects/models using navigation property
        public ActionResult MultipleData()
        {
            //dynamic mymodel = new ExpandoObject();
            //mymodel.OrderList = db.Orders.ToList();
            //mymodel.CustList = db.Customers.ToList();
            //mymodel.Emplist = db.Employees.ToList();
            //mymodel.ShipList = db.Shippers.ToList();
            return View(db.Orders.ToList());
        }
    }
}