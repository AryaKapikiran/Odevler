using MVC_Northwind.Filter;
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

        [AuthFilter]

        public ActionResult Index()
        {
          //Listeleme
           List<Customer> customers = db.Customers.OrderBy(x=>x.CustomerID).ToList();
           List<Order> orders =db.Orders.OrderBy(x=>x.OrderID).ToList();
           
            List<Employee> employees = db.Employees.OrderBy(x=>x.EmployeeID).ToList();
            List<Product> products = db.Products.OrderBy(x=>x.ProductID).ToList();

            //TempData içine atma
            TempData["Customers"]= customers.ToList();
            TempData["Orders"]= orders.ToList();
           
            //Kaç adet olduklarını yazdırma
            TempData["ProductNumber"] = products.Count().ToString();
            TempData["EmployeeNumber"] = employees.Count().ToString();
            TempData["CustomersNumber"] = customers.Count().ToString();
            TempData["OrdersNumber"]= orders.Count().ToString();

            //Son 30 siparisi listeleme
            TempData["SonSiparişler"] = orders.OrderByDescending(x=>x.OrderDate).Take(30).ToList();
            
            TempData.Keep();
            return View();
        }

        //Detayları görüntüleme

        [AuthFilter]
        public ActionResult CustomerDetaylari(string id)
        {
            var customerdetay = db.Customers.ToList().Find(x => x.CustomerID == id);
            
            return View(customerdetay);
        }

        [AuthFilter]
        public ActionResult OrderDetaylari(int id)
        {
            var orderdetay = db.Orders.ToList().Find(x => x.OrderID == id);

            return View(orderdetay);
        }

        //Müşteri Ekleme
        [AuthFilter]
        public ActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            db.Customers.Add(customer);
            
            db.SaveChanges();
            
            return RedirectToAction("Index");
        }
    }
}