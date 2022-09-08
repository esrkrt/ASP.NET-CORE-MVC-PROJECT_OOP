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
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        

        [HttpGet]
        public async Task< IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditeViewModel userEditeViewModel = new UserEditeViewModel();
            userEditeViewModel.Name = values.Name;
            userEditeViewModel.SurName = values.Surname;
            userEditeViewModel.Mail = values.Email;
            userEditeViewModel.Gender = values.Gender;
            return View(userEditeViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditeViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Name = p.Name;
            user.Surname = p.SurName;
            user.Email = p.Mail;
            user.Gender = p.Gender;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {

            }
            return View();
        }
        }
}
