using MVA_Northwind_Areas.Filter;
using MVA_Northwind_Areas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVA_Northwind_Areas.Controllers
{
    public class ProductController : Controller
    {
        NorthWindEntities db = new NorthWindEntities();
        // GET: Product

        [AuthFilter]
        public ActionResult Category()
        {
            List<Product> products = db.Products.ToList();
            List<Category> categories = db.Categories.ToList();
            TempData["Products"] = products.Take(25).ToList();
            TempData["Categories"] = categories;
            return View();
        }
    }
}