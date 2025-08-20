using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CodeFirst.Models;
using MVC_CodeFirst.Repository;

namespace MVC_CodeFirst.Controllers
{
    public class ProductsController : Controller
    {
        IProductRepository<Products> _prdrepo = null;

        //controller constructor
        public ProductsController()
        {
            _prdrepo = new ProductRepository<Products>();
        }

        // 1. GET: Products
        public ActionResult Index()
        {
            var prod = _prdrepo.GetAll();
            return View(prod);
        }

        //2. creating anew product
        public ActionResult Create()
        {
            return View();
        }

        //2.1 Post create
        [HttpPost]
        public ActionResult Create(Products p)
        {
            if(ModelState.IsValid)
            {
                _prdrepo.Insert(p);
                _prdrepo.Save();
                return RedirectToAction("Index");
            }
            return View(p);
        }
    }
}