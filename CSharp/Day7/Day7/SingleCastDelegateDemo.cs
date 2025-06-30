using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    //syntax
    //delegate<return type> delegatename(parameters)

    delegate void NotificationDelegate(string message);

    class User
    {
        public string Message { get; set; }

        public void DisplayMessage(string msg)
        {
            Message = msg;
            Console.WriteLine(Message);
        }
    }
    class SingleCastDelegateDemo
    {
        public static void Main()
        {
            User user = new User();

            //   user.DisplayMessage("Welcome User!!");
            NotificationDelegate notificationDelegate = new NotificationDelegate(user.DisplayMessage);

            notificationDelegate("WelcomeUser!");
                 



        }

    }
}
