using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public delegate void DisplayDelegate(string uname,string password);
    internal class Publisher
    {
        //synatx
        //accessmodifier event <delegate> eventname;
        public event DisplayDelegate DisplayEvent;
        public void Display(string username,string password)
        {
            if (username == "Sai" && password == "123")
            {
                DisplayEvent(username,password);
            }
            else
            {
                Console.WriteLine("UserName or Password is incorrect!!!");
            }
        }
    }

    class Subscriber
    {
        //Event handler. this will be invoked by the delegate
        public void DisplayMessage(string username,string password)
        {
            Console.WriteLine($"Welcome {username}");
        }
    }
    class EventDemo1
    {
        static void Main()
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            //subscribe to the event += ,unsubscribe -=

            publisher.DisplayEvent += new DisplayDelegate(subscriber.DisplayMessage);

            publisher.Display("Sai", "123");
        }
    }
}
