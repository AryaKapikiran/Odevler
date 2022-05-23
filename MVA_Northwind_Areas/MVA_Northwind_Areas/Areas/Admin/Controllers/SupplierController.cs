using MVA_Northwind_Areas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVA_Northwind_Areas.Areas.Admin.Controllers
{
    public class SupplierController : Controller
    {
        NorthWindEntities db = new NorthWindEntities();
        // GET: Admin/Supplier
        public ActionResult Index()
        {
            
            TempData["EmployeeSayısı"] = db.Employees.Count();
            TempData["OrderSayısı"] = db.Orders.Count();
            TempData["SupplierSayısı"] = db.Suppliers.Count();
            TempData["Suppliers"] = db.Suppliers.ToList();
            
            return View();
        }
    }
}