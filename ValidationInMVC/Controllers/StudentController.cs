using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationInMVC.Models;

namespace ValidationInMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SubmitDataUsingLooslyBinding(Student stud)
        {
            if(ModelState.IsValid)
            {
                return View();
            }
            return View("Index");
        }

        [HttpPost]
        public ActionResult SubmitDataUsingStronglyBinding(Student stud)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View("Index");
        }


        [HttpGet]
        public ActionResult ValidationSummary()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitDataUsingValidationSummary(Student stud)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View("ValidationSummary");
        }
    }
}