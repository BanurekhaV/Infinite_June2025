using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern_2
{
    public class UserSession
    {
        //static private instance for singleton

        private static readonly UserSession _userinstance = new UserSession();

        //properties to store session data
        public string UserName { get; private set; }
        public string[] Roles { get; private set; }

        //private constructor
        private UserSession() { }

        //public methods
        public void Initialize(string uname, string[] roles)
        {
            UserName = uname;
            Roles = roles;
        }
        public void Clear()
        {
            UserName = null;
            Roles = null;
        }

        //public property to access the singleton instance
        public static UserSession usobj => _userinstance;
    }
}
