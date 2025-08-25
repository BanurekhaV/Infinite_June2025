using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViews_Prj.Models;

namespace PartialViews_Prj.Controllers
{
    public class ProductController : Controller
    {
        List<Product> productList;
        public ProductController()
        {
            productList = new List<Product>()
            {
                new Product{ProductId = 1, ProductName= "Shoes", Category= "Accessories",
                 Description = "Smooth Soles for Comfort", Price = 3500},
                 new Product{ProductId = 2, ProductName= "Watches", Category= "Accessories",
                 Description = "Smart and User Freindly", Price = 6500},
                  new Product{ProductId = 3, ProductName= "Curtains", Category= "Furnishings",
                 Description = "Valence for Windows", Price = 4000},
                   new Product{ProductId = 4, ProductName= "Pillows", Category= "Beddings",
                 Description = "Memory Foam for Comfort", Price = 2000},
            };
        }
        public ActionResult Index()
        {
            return View(productList);
        }

        //2. Normal method that takes up the list of products object
        public ActionResult JustMethod()
        {
            return View();
        }

        //3. partial views
        public PartialViewResult GetAllProducts()
        {
            List<Product> prdlist= new List<Product>()
            {
                new Product{ProductId = 1, ProductName= "Shoes", Category= "Accessories",
                 Description = "Smooth Soles for Comfort", Price = 3500},
                 new Product{ProductId = 2, ProductName= "Watches", Category= "Accessories",
                 Description = "Smart and User Freindly", Price = 6500},
                  new Product{ProductId = 3, ProductName= "Curtains", Category= "Furnishings",
                 Description = "Valence for Windows", Price = 4000},
                   new Product{ProductId = 4, ProductName= "Pillows", Category= "Beddings",
                 Description = "Memory Foam for Comfort", Price = 2000},
            };
            return PartialView("ProductDetails", prdlist);
        }
    }
}