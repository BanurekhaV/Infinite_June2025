using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2CSharp
{
    class InstanceVsStatic
    {
        int mydata;  // non static member  or instance member
        static int ourdata = 15;  //static member 
        float floatdata;
        string str;

        public void Display()  // non static or instance member
        {
            Console.WriteLine(str);
        }
        public static void accessFunction()
        {
            InstanceVsStatic instobj1 = new InstanceVsStatic();
            instobj1.mydata = 5;
            InstanceVsStatic instobj2 = new InstanceVsStatic();
            instobj2.mydata = 10;
            Console.WriteLine(instobj1.mydata + "  " + instobj2.mydata);
            instobj1.mydata = 100;
            Console.WriteLine(instobj1.mydata + "  " + instobj2.mydata);
            Console.WriteLine("Static data {0}", ourdata);

            InstanceVsStatic.ourdata = 25;
            Console.WriteLine("Static data {0}", ourdata);

            Console.WriteLine("************");
            instobj1.str = "I am Object 1";
            instobj1.Display();
            instobj2.str = "I am Object 2";
            instobj2.Display();
        }

        static void Main()
        {
            //InstanceVsStatic.accessFunction();
            //accessFunction();

            //strings and its workings
            string str;
            str = "I am a string";
            Console.WriteLine("str for the first time is : {0}", str.GetHashCode());
           
            string str2 = "I am a string";
            Console.WriteLine("str2 is {0}", str2.GetHashCode());

            str2 = "I am a String";  // changing str2 value
            Console.WriteLine("str2 is {0}", str2.GetHashCode());
            string str3 = str;  // reference of str is assigned to str3
            Console.WriteLine(str3);
            Console.WriteLine("str is :{0} and str3 is {1}", str.GetHashCode(), str3.GetHashCode());
            str2 = "I am String.";

            char[] carr = new char[] { 'H', 'e', 'l', 'l', 'o' };
            string s4 = new string(carr);
            Console.WriteLine("s4 hashcode is " + " " + s4.GetHashCode());
            Console.Read();
        }
    }
}
