using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FollowAlongMVC.Models;
using System.Web.Mvc;


namespace FollowAlongMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Details()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 1,
                Name = "Jerod",
                Gender = "Male",
                City = "Litchfield"
            };

            return View(employee);
        }
    }
}