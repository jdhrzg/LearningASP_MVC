﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FollowAlongMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Countries"] = new List<string>
            {
                "India",
                "US",
                "UK",
                "Canada"
            };

            return View();
        }
    }
}