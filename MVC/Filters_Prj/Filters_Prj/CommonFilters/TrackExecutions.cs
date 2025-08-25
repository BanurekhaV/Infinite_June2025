using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Filters_Prj.CommonFilters
{
    public class TrackExecutions : ActionFilterAttribute,IExceptionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string message = "\n" + filterContext.ActionDescriptor.ControllerDescriptor.ControllerName +
                 "-->" + filterContext.ActionDescriptor.ActionName + " -->OnActionExceuting \t- " +
                 DateTime.Now.ToString() + "\n";
            LogExecutionTime(message);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string message = "\n" + filterContext.ActionDescriptor.ControllerDescriptor.ControllerName +
                 "-->" + filterContext.ActionDescriptor.ActionName + " -->OnActionExceuted \t- " +
                 DateTime.Now.ToString() + "\n";
            LogExecutionTime(message);
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            string message = "\n" + filterContext.RouteData.Values["controller"].ToString() +
                "-->" + filterContext.RouteData.Values["action"].ToString()+ " -->OnResultExecuted \t- " +
                DateTime.Now.ToString() + "\n";
            LogExecutionTime(message);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            string message = "\n" + filterContext.RouteData.Values["controller"].ToString() +
               "-->" + filterContext.RouteData.Values["action"].ToString() + " -->OnResultExecuting \t- " +
               DateTime.Now.ToString() + "\n";
            LogExecutionTime(message);
        }

        public void OnException(ExceptionContext filterContext)
        {
            string message = "\n" + filterContext.RouteData.Values["controller"].ToString() +
               "-->" + filterContext.RouteData.Values["action"].ToString() + " -->OnException \t- " +
               DateTime.Now.ToString() + "\n";
            LogExecutionTime(message);
        }
        private void LogExecutionTime(string data)
        {
            File.AppendAllText(HttpContext.Current.Server.MapPath("~/DataFolder/Data.txt"), data);
        }
    }
}