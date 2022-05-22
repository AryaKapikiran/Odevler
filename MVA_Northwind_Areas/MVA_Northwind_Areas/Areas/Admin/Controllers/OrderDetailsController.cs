using MVA_Northwind_Areas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVA_Northwind_Areas.Areas.Admin.Controllers
{
    public class OrderDetailsController : Controller
    {
        NorthWindEntities db = new NorthWindEntities();
        // GET: Admin/OrderDetails
        public ActionResult Index()
        {
            

            TempData["OrderDetails"] = db.Order_Details.Take(25).ToList();
            TempData["EmployeeSayısı"] = db.Employees.Count();
            TempData["OrderSayısı"] = db.Orders.Count();
            TempData["SupplierSayısı"] = db.Suppliers.Count();
            return View();
        }
    }
}