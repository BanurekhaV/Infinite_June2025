using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using System.Web.Routing;


namespace Authentication_Prj.CustomFilters
{
    public class CustomAuthenticationFilter : ActionFilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            if(string.IsNullOrEmpty(Convert.ToString(filterContext.HttpContext.Session["UserName"])))
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
           if(filterContext.Result == null || filterContext.Result is HttpUnauthorizedResult)
            {
                //redirect the user to the login view of the account controller
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary
                    {
                        {"controller","Account" },
                        {"action", "Login" }
                    });

                //if we want to redirect to some error view then
                //filterContext.Result = new ViewResult()
                //{
                //    ViewName = "Loginerror"
                //};
            }
        }
    }
}