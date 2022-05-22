using MVA_Northwind_Areas.Filter;
using MVA_Northwind_Areas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVA_Northwind_Areas.Areas.Staff.Controllers
{
    public class CustomerController : Controller
    {
        NorthWindEntities db = new NorthWindEntities();
        // GET: Staff/Customer

        [AuthFilter]
        public ActionResult Index()
        {
            TempData["Customers"]= db.Customers.Take(25).ToList();

            TempData["CustomerSayısı"] = db.Customers.Count();
            TempData["OrderSayısı"] = db.Orders.Count();
            TempData["ShipperSayısı"] = db.Shippers.Count();
            return View();
        }
    }
}