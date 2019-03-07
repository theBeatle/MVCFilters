using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _005_FilterOrder.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/


        [SimpleMessage(Message = "A",DimaQuantity = 2, Order = 1)]
        [SimpleMessage(Message = "C", DimaQuantity = 2, Order = -1)]
        [SimpleMessage(Message = "B",DimaQuantity = 10, Order = 1)]
        public ActionResult Index()
        {
            return View();
        }

    }
}
