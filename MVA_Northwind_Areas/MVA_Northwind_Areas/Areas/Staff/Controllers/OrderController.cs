using MVA_Northwind_Areas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVA_Northwind_Areas.Areas.Staff.Controllers
{
    public class OrderController : Controller
    {
        NorthWindEntities db = new NorthWindEntities();
        // GET: Staff/Order
        public ActionResult Index()
        {
            TempData["Orders"] = db.Orders.Take(25).ToList();
            
            TempData["CustomerSayısı"] = db.Customers.Count();
            TempData["OrderSayısı"] = db.Orders.Count();
            TempData["ShipperSayısı"] = db.Shippers.Count();
            return View();
        }
    }
}