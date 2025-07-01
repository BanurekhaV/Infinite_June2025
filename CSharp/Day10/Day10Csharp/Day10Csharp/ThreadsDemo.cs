using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day10Csharp
{
    class ThreadsDemo
    {
        static void Main()
        {
            Thread t = Thread.CurrentThread;

            t.Name = "Main Thread";
            Console.WriteLine("The executing thread is {0} and is {1}",t.Name,Thread.CurrentThread.Name);

            Method1();
            Method2();
            Method3();
            
            Console.Read();
        }

        static void Method1()
        {
            for(int i=0; i<=5; i++)
            {
                Console.WriteLine("Method 1..: " + i);
            }
        }

        static void Method2()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 2..: " + i);
                if(i==3)
                {
                    Console.WriteLine("Branching off to do database operations...");

                    //we will put the thread to sleep for 10 secs
                    Thread.Sleep(10000);
                    Console.WriteLine("Database Operations completed..");
                }
            }
        }
        static void Method3()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 3..: " + i);
            }
        }
    }
}
