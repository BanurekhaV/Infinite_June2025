using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.IO;

namespace Exception_Prj
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            //Exception ex = Server.GetLastError();
            //Server.ClearError();
            //Server.Transfer("~/DefaultError.aspx");

            //for looging exceptions onto a file
            Exception ex = Server.GetLastError();
            Server.ClearError();
            string str = "";
            str += str + " " + ex.Message + " " + ex.Source + " " + ex.InnerException.Message;
           // Response.Write(str);
            string path = @"C:\Banu\Infinite_June25\ASP\AppError.txt";
            File.WriteAllText(path, str);
            Server.Transfer("~/DefaultError.aspx");
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}