using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_DatabaseFirst.Models;

namespace MVC_DatabaseFirst.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();

        // GET: Category
        //1. The below action method uses scaffolded  view template
        public ActionResult Index()
        {
            List<Category> catlist = db.Categories.ToList();
            return View(catlist);
        }

        //2. The below action method does not use scaffolded view
        public ActionResult GetCategoryDetails()
        {
            List<Category> catlist = db.Categories.ToList();
            return View(catlist);
        }

       [HttpGet]
        //3. Adding a new category
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category c)  //passing a model object from the view 
        {
            db.Categories.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}