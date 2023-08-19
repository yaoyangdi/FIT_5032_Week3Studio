﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week3.Models.Exercise;
using Week3.Models.HelloWorld;

namespace Week3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            Hello hello = new Hello();

            ViewBag.Message = hello.GetHello();

            ExampleDictionary ed = new ExampleDictionary();
            ed.Example();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}