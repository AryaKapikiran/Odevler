using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Northwind.Models
{
    public class AppUser
    {   [Required(ErrorMessage = "Kullanıcı adı bos gecilemez")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Şifre boş gecilemez")]
        public string Password { get; set; }
    }
}