using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationInMVC.Models;
using System.Data.SqlClient;

namespace ValidationInMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitData(Employee emp)
        {
            if (ModelState.IsValid)
            {
                SqlConnection sqlConnection = null;
                SqlCommand cmd = null;
                string sql = "insert into tablename values('" + emp.Name + "','" + emp.Address + "')";
                return View();
            }
            return View("Index");
        }
    }
}