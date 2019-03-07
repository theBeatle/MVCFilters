﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_ExceptionFilters.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HandleError(ExceptionType = typeof(DivideByZeroException), View = "DivideError")]
        public ActionResult Divide()
        {

            //throw new IndexOutOfRangeException();
            int a = 10, b = 0;
            int result = a / b;

            return Content(result.ToString());
        }
    }
}