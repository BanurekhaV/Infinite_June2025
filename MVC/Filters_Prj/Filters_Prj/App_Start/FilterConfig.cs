using System.Web;
using System.Web.Mvc;
using Filters_Prj.CommonFilters;

namespace Filters_Prj
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
           // filters.Add(new HandleErrorAttribute());
           //   filters.Add(new TrackExecutions());
            filters.Add(new Models.LogCustomException()); // globally registering the custom filters
            filters.Add(new AdminFilter());
        }
    }
}
