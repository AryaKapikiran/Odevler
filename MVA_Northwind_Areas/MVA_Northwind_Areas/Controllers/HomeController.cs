using MVA_Northwind_Areas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVA_Northwind_Areas.Controllers
{
    public class HomeController : Controller
    {
        NorthWindEntities db = new NorthWindEntities();


        // GET: Home
        public ActionResult Login()
        {
            return View();
        }

        //Post 

        [HttpPost]

        public ActionResult Login(AppUser appUser)
        {
            if (ModelState.IsValid)
            {
                bool result = db.Users.Any(x => x.UserName == appUser.UserName && x.Password == appUser.Password);

                if (result)
                {
                    User user = db.Users.Where(x => x.UserName == appUser.UserName && x.Password == appUser.Password).FirstOrDefault();

                    if (appUser.UserName == "admin")
                    {
                        Session["login"] = user;
                        return RedirectToAction("Index", "Employee");
                        
                    }

                    else if (appUser.UserName =="staff")
                    {
                        Session["login"] = user;
                        return RedirectToAction("Index", "Customer");
                    }

                    else if(appUser.UserName =="ziyaretçi")
                    {
                        Session["login"] = user;
                        return RedirectToAction("Category", "Product");
                    }
                    else
                    {
                        TempData["error"] = "Kullanıcı bilgileri hatalı! (Kullanıcı degilseniz bu sayfayı göremezsiniz)";

                        return View(appUser);
                    }
                }

                else
                {
                    TempData["error"] = "Kullanıcı bilgileri hatalı! (Kullanıcı degilseniz bu sayfayı göremezsiniz)";

                    return View(appUser);
                }

            }

            else
            {
                return View(appUser);
            }
           
        }
    }
}