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
        public ActionResult GetEmployeeByID(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.EmployeeSet.Single(emp => emp.ID == id);

            return View(employee);
        }
    }
}