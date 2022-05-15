using MVC_Northwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVC_Northwind.Controllers
{
    public class HomeController : Controller
    {
        NorthWindEntities db = new NorthWindEntities();

        // GET: Home

        public static List<Customer> customers = new List<Customer>();
        public static List<Order> orders = new List<Order>();

        public ActionResult Index()
        {
           customers = db.Customers.OrderBy(x=>x.CustomerID).ToList();
           orders =db.Orders.OrderBy(x=>x.OrderID).ToList();
           
            List<Employee> employees = db.Employees.OrderBy(x=>x.EmployeeID).ToList();
            List<Product> products = db.Products.OrderBy(x=>x.ProductID).ToList();
            TempData["Customers"]= customers.ToList();
            TempData["Orders"]= orders.ToList();
            //TempData["Employees"] = employees.ToList();
            //TempData["Products"] = products.ToList();
            TempData["ProductNumber"] = products.Count().ToString();
            TempData["EmployeeNumber"] = employees.Count().ToString();
            TempData["CustomersNumber"] = customers.Count().ToString();
            TempData["OrdersNumber"]= orders.Count().ToString();
            TempData["SonSiparişler"] = orders.OrderByDescending(x=>x.OrderDate).Take(30).ToList();
            
            TempData.Keep();
            return View();
        }

        
        public ActionResult CustomerDetaylari(string id)
        {
            var customerdetay = customers.Find(x => x.CustomerID == id);
            
            return View(customerdetay);
        }

        public ActionResult OrderDetaylari(int id)
        {
            var orderdetay = orders.Find(x => x.OrderID == id);

            return View(orderdetay);
        }

        //Müşteri Ekleme
        public ActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            customers.Add(customer);
            
            return RedirectToAction("Index");
        }
    }
}