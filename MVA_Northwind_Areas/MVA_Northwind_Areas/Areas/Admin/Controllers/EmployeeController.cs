using MVA_Northwind_Areas.Filter;
using MVA_Northwind_Areas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVA_Northwind_Areas.Areas.Admin.Controllers
{
    public class EmployeeController : Controller
    {
        NorthWindEntities db = new NorthWindEntities();
        // GET: Admin/Employee

        [AuthFilter]
        public ActionResult Index()
        {
            
            TempData["Employee"] = db.Employees.ToList();
            TempData["EmployeeSayısı"] = db.Employees.Count();
            TempData["OrderSayısı"] = db.Orders.Count();
            TempData["SupplierSayısı"] = db.Suppliers.Count();
            return View();
        }
    }
}