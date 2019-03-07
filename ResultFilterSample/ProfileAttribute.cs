﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResultFilterSample
{
    public class ProfileAttribute : ActionFilterAttribute
    {
        private Stopwatch timer;

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("OnActionExecuting<br />");
            timer = Stopwatch.StartNew();
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("OnActionExecuted<br />");
            timer.Stop();
            if (filterContext.Exception == null)
            {
                string message = string.Format("На выполнение метода действия {0} затрачено {1}<br />",
                    filterContext.ActionDescriptor.ActionName, timer.Elapsed);

                filterContext.HttpContext.Response.Write(message);
            }
        }

        
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("OnResultExecuting<br />");
            timer = Stopwatch.StartNew();
        }

        // Вызовется после выполнения результата действия
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("OnResultExecuted<br />");
            timer.Stop();
            if (filterContext.Exception == null)
            {
                string message = string.Format("На визуализацию результата затрачено {0}<br />", timer.Elapsed);

                filterContext.HttpContext.Response.Write(message);
            }
        }
    }
}