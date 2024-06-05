using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KKProje.CvApp.Web.Models
{
    public class AppUserLoginModel
    {
        [Required(ErrorMessage = "Kullanıcı Adı Gereklidir!")]
        public  string UserName { get; set; }
        [Required(ErrorMessage = "Şifre Gereklidir!")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
