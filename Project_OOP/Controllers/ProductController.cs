using BusinessLayer.Concrete;
using BusinessLayer.FulentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Cocrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_OOP.Controllers
{
    public class ProductController : Controller
    {

        ProductManager productmanager = new ProductManager(new EfProductDal());
        public IActionResult Index()
        {
            var values = productmanager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            ProductValidator validationRules = new ProductValidator();
            ValidationResult result = validationRules.Validate(p);
            if (result.IsValid)
            {

                productmanager.TInsert(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
