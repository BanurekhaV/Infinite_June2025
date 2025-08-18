using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServices_Prj
{
    /// <summary>
    /// Summary description for TrialWebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TrialWebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string SayHello(string username)
        {
            return "Hello : " + username; 
        }
        [WebMethod]
        public float Squareroot(float f)
        {
            return f * f;
        }

        public void Message()
        {
            Console.WriteLine("This is a Test Message..");
        }
    }
}
