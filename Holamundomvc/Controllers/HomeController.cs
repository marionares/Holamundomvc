﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Holamundomvc.Models;

namespace Holamundomvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new HelloWorldModel { message = "Hola mundo" };
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}