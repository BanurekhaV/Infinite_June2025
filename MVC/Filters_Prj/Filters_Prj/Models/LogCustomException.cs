using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Filters_Prj.Models
{
    public class LogCustomException : FilterAttribute,IExceptionFilter
    {
       public void OnException(ExceptionContext filterContext)
        {
           if(!filterContext.ExceptionHandled)
            {
                var exceptiommessage = filterContext.Exception.Message;
                var stacktrace = filterContext.Exception.StackTrace;
                var controllername = filterContext.RouteData.Values["controller"].ToString();
                var actionname = filterContext.RouteData.Values["action"].ToString();

                string msg = "Date : " + DateTime.Now.ToString() + ", Controller Name :" + controllername +
                    ", Action name : " + actionname + ", Error Message : " + exceptiommessage +
                    Environment.NewLine + ", Stacxk Trace : " + stacktrace;

                //save the data onto a text file/ or database

                File.AppendAllText(HttpContext.Current.Server.MapPath("~/ErrorLogs/Log.txt"), msg);

                filterContext.ExceptionHandled = true;
                filterContext.Result = new ViewResult()
                {
                    ViewName = "Error"  // redirecting to common error page for all exception types
                };
            }
        }
    }
}