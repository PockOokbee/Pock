﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestGit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string pock1 = "local";
            string pock2 = "2";
            string pock3 = "3";

            return View();
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