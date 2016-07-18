﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FollowAlongMVC.Models;
using System.Web.Mvc;


namespace FollowAlongMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.Employees.Single(emp => emp.EmployeeId == id);

            return View(employee);
        }
    }
}