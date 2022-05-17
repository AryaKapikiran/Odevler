using MVC_Northwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Northwind.Controllers
{
    public class LoginController : Controller
    {
        NorthWindEntities db = new NorthWindEntities();

        AppUser user = new AppUser()
        {
            UserName = "admin",
            Password = "1234"

        };
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        //Post

        [HttpPost] 

        public ActionResult Index(AppUser appuser)
        {
            if(ModelState.IsValid)
            {
                bool result = db.Users.Any(x=>x.UserName == appuser.UserName && x.Password == appuser.Password);

                if(result)
                {
                    User user = db.Users.Where(x => x.UserName == appuser.UserName && x.Password == appuser.Password).FirstOrDefault();

                    Session["login"] = user;
                    return RedirectToAction("Index","Home");
                }

                else
                {
                    TempData["error"] = "Kullanıcı bilgileri hatalı! (Kullanıcı degilseniz bu sayfayı göremezsiniz)";

                    return View(appuser);
                }
            }

            else
            {
                return View(appuser);
            }
        }
    }
}