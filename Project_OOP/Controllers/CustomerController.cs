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
    public class CustomerController : Controller
    {

        CustomerManager customermanager = new CustomerManager(new EfCustomerDal());
        public IActionResult Index()
        {
            var values = customermanager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer p)
        {
            customermanager.TInsert(p);
            return RedirectToAction("Index");

        }
    }
}
