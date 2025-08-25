using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filters_Prj.CommonFilters;

namespace Filters_Prj.Controllers
{
    [TrackExecutions]
    public class CustomFilterController : Controller
    {
       
        public string Index()
        {
            return "Index action invoked";
        }

      //  [TrackExecutions]
        public string Welcome()
        {
            throw new Exception("Exception Occured");
        }
    }
}