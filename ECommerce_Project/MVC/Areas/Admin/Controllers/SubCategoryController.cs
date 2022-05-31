using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Areas.Admin.Controllers
{
    public class SubCategoryController : Controller
    {
        ECommerceContext db = new ECommerceContext();
        // GET: Admin/SubCategory
        public ActionResult Index()
        {
            
            return View(db.SubCategories.ToList());
        }
    }
}