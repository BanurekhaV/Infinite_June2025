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

        //below action method is just to appreciate inbui;t model binders
        public ActionResult GetCustomerById(int Id)  
        {
            List<CustomerModel> custmodel;
            // var Id = RouteData.Values["ID"]; //1.
           // var Id = Request.QueryString["ID"];

            custmodel = new List<CustomerModel>()
            {
                new CustomerModel(){ID=1,Name="Ram",Email="aa@e.com"},
                new CustomerModel(){ID=2,Name="Rohit",Email="roh@e.com"},
                new CustomerModel(){ID=3,Name="Rakshitha",Email="rak@e.com"},
            };
            CustomerModel cm = custmodel.Where(c => c.ID == Convert.ToInt32(Id)).SingleOrDefault();
            return View(cm);
        }

        //form post with the model object
        public void Save(CustomerModel cm)
        {
            //int Id = Convert.ToInt32(Request.Form["ID"]);
            //string name = Request.Form["Name"];

            //logic for saving
        }
    }
}