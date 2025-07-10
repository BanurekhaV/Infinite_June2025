using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
   public class SingleTonClass
   {
        //private field to increment a counter every time object is created
        private static int counter = 0;

        //instance object to store the singleton instance
        private static SingleTonClass spobj = null;

        //public method that returns the singleton object
        public static SingleTonClass GetInstance()
        {
            if(spobj == null)
            {
                spobj = new SingleTonClass();               
            }
            return spobj;
        }

        //private constructor (parameter less)
        private SingleTonClass()
        {
            counter++;
            Console.WriteLine("Counter Value : " + counter.ToString());
        }

        //other normal instance methods
        public void Show(string msg)
        {
            Console.WriteLine(msg);
        }
   }
}
