using EntityLayer.Cocrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project_OOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_OOP.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult > Index(UserRegisterViewModel model)
        {
            AppUser appuser = new AppUser()
            {
                Name = model.Name,
                Surname = model.SurName,
                UserName = model.UserName,
                Email=model.Mail
            };
            if (model.Password == model.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appuser, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(model);
        }
    }
}
