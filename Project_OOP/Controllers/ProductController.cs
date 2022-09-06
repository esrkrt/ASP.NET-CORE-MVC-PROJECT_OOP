using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Cocrete;
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
            productmanager.TInsert(p);
            return RedirectToAction("Index");
        }
    }
}
