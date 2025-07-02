using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day11Csharp
{
    class ThreadSyncEg
    {
        static Thread t1, t2;
        static void Main()
        {
            //Sunc using Joins

            //Thread t1 = new Thread(Func1);
            //t1.Start();
            //Thread t2 = new Thread(Func2);
            //t2.Start();
            //t1.Join();
            //t2.Join();

            //sync using locks
            ThreadSyncEg tse = new ThreadSyncEg();
            Console.WriteLine(" Threading Using Locks ---");
             t1 = new Thread(new ThreadStart(tse.DisplayNumbers));
            t1.Name = "Thread 1";

             t2 = new Thread(new ThreadStart(tse.DisplayNumbers));
            t2.Name = "Thread 2";
            
            t2.Start();
            t1.Start();
            Console.Read();
        }

        static void Func1()
        {
            Console.WriteLine("Thread 2 executed..");
        }

        static void Func2()
        {
            Console.WriteLine("Thread 1 executed..");
        }

        //sync using locks

        public void DisplayNumbers()
        {
            lock (this)
            {
                for (int i = 0; i <= 5; i++)
                {
                    Thread.Sleep(100);
                    Console.WriteLine("i = {0}  of Thread {1} ", i, Thread.CurrentThread.Name);
                }
            }
        }
    }
}
