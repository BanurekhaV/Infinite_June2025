using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using WebAPI_Client.Models;

namespace WebAPI_Client.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        //action method to consume the webapi products/get
        public ActionResult DisplayProducts()
        {
            IEnumerable<MVCProductModel> productlist = null;
            using (var webclient = new HttpClient())
            {
                webclient.BaseAddress = new Uri("https://localhost:44356/api/");
                var responsetalk = webclient.GetAsync("products");
                responsetalk.Wait();
                var result = responsetalk.Result;
                if (result.IsSuccessStatusCode)
                {
                    var resultdata =
                        result.Content.ReadAsStringAsync().Result;
                    productlist = JsonConvert.DeserializeObject<List<MVCProductModel>>(resultdata);
                }
                else
                {
                    productlist = Enumerable.Empty<MVCProductModel>();
                }
                return View(productlist);
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(MVCProductModel mvcprd)
        {
            using (var webclient = new HttpClient())
            {
                webclient.BaseAddress = new Uri("https://localhost:44356/api/");
                var posttalk = webclient.PostAsJsonAsync<MVCProductModel>("products", mvcprd);
                posttalk.Wait();
                var dataresult = posttalk.Result;

                if (dataresult.IsSuccessStatusCode)
                {
                    return RedirectToAction("DisplayProducts");
                }
                ModelState.AddModelError(String.Empty, "Insertion Failed.. try later");
                return View(mvcprd);
            }
        }

        //Edit
        [HttpGet]

        public ActionResult Edit(int Id)
        {
            if (Id == 0)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            MVCProductModel product = null;

            using (var webclient = new HttpClient())
            {
                webclient.BaseAddress = new Uri("https://localhost:44356/api/");
                var edittalk = webclient.GetAsync("products/" + Id).Result;

                if (edittalk.IsSuccessStatusCode)
                {
                    var resultdata =
                        edittalk.Content.ReadAsStringAsync().Result;

                    product = JsonConvert.DeserializeObject<MVCProductModel>(resultdata);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Some Error Occured while processing your request");
                }
            }

            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ProductId, ProductName,Price,QuantityAvailable")] MVCProductModel p)
        {
            if (ModelState.IsValid)
            {
                using (var webclient = new HttpClient())
                {
                    webclient.BaseAddress = new Uri("https://localhost:44356/api/");

                    var response = await webclient.PutAsJsonAsync("products", p);

                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("DisplayProducts");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Error Occurred..");
                    }
                }
                return RedirectToAction("Index");
            }

            return View(p);
        }
    }
}