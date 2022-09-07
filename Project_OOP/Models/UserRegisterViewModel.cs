using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_OOP.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen isim  giriniz...")]
       
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soyisim  giriniz...")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Lütfen kullanıcı adı  giriniz...")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen mail giriniz...")]
        public string Mail{ get; set; }
        [Required(ErrorMessage = "Lütfen şifre giriniz...")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi tekrar girinizgiriniz...")]
        [Compare("Password", ErrorMessage = "Lütfen şifrenin eşleştiğinden emin olunuz...")]
        public string ConfirmPassword { get; set; }
    }
}
