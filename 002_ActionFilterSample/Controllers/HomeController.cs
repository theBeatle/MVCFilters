using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _002_ActionFilterSample.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [MyActionFilter]

        public ActionResult Index()
        {
            return View();
        }

    }
}
