using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
    }
}
