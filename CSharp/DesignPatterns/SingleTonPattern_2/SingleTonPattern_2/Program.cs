using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern_2
{
    class Program
    {
        static void Main(string[] args)
        {
            UserSession.usobj.Initialize("Banurekha", new[] { "Admin", "User" });

            //accessing the session information 
            Console.WriteLine(UserSession.usobj.UserName);

            //clear the session
            UserSession.usobj.Clear();
            Console.Read();
        }
    }
}
