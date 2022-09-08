﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_OOP.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz...")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi giriniz...")]
        public string Password { get; set; }
    }
}
