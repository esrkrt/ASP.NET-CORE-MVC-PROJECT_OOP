using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Cocrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            var values = customermanager.GetCustomerListWithJob();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCustomer()
        {
            JobManger jobmanager = new JobManger(new EfJobDal());
            List<SelectListItem> values = (from x in jobmanager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.JobId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer p)
        {
            customermanager.TInsert(p);
            return RedirectToAction("Index");

        }
        public IActionResult DeleteCustomer(int id)
        {
            var value = customermanager.TGetByID(id);
            customermanager.TDelete(value);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            JobManger jobmanager = new JobManger(new EfJobDal());
            List<SelectListItem> values = (from x in jobmanager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.JobId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            var value = customermanager.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer p)
        {
            customermanager.TUpdate(p);
            return RedirectToAction("Index");

        }
    }
}
