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
    public class JobController : Controller
    {
        JobManger jobManger = new JobManger(new EfJobDal());
        public IActionResult Index()
        {
            var values = jobManger.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddJob()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddJob(Job p)
        {

            jobManger.TInsert(p);
            return RedirectToAction("Index");

        }
    }
}
