﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day10Csharp
{
    class MultiThreadsEg
    {
        static void Main()
        {
            Console.WriteLine("Main Thread Started...");

            //Thread t1 = new Thread(Method1) { Name = "Thread 1" };
            //Thread t2 = new Thread(Method2) { Name = "Thread 2" };
            //Thread t3 = new Thread(Method3) { Name = "Thread 3" };
            ////to strat the threads
            //t1.Start();
            //t2.Start();
            //t3.Start();
            //Console.WriteLine("Main Thread Ending ..");
            ThreadStartFunction();
            Console.Read();
        }
        static void Method1()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 1..: " + i);
            }
        }

        static void Method2()
        {            
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 2..: " + i);
                if (i == 3)
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

        //creating threadstart delegate object to start a thread
        static void ThreadStartFunction()
        {
            ThreadStart obj = new ThreadStart(Method3);

            Thread t = new Thread(obj);
            t.Start();

            ////Multiple ways of instantiating and starting a thread
            //Thread thread1 = new Thread(new ThreadStart(Method3));
            //Thread thread2 = new Thread(delegate () { Method3(); });
            //Thread thread3 = new Thread(() => { Method3(); });
            //Thread thread4 = new Thread(() => Method3());

            //Anonymous method call using thread delegate
            Thread thread5 = new Thread(() =>
            {
                for(int i=0; i<=5; i++)
                {
                    Console.WriteLine("Hi "+ i);
                }
            });
            thread5.Start();
        }
    }
}
