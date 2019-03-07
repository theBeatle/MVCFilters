using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_ActionFilter.Controllers
{
    public class HomeController : Controller
    {
        [MyActionFilter]

        public ActionResult Index()
        {
            return View();
        }
    }
}