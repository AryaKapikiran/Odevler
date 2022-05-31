using DataAccess.Context;
using Service.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        CategoryService categoryService = new CategoryService();

        // GET: Admin/Category
        public ActionResult Index()
        {
            
            return View(categoryService.GetList());
        }
    }
}