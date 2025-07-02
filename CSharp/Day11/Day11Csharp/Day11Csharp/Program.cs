using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day11Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using Thread Pool
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(MyMethod));
            }

            //without Thread Pool
            //for(int i =0; i<10;i++)
            //{
            //    Thread t = new Thread(MyMethod) { Name = "Thread  " + i };
            //    t.Start();
            //}
            Console.Read();
        }

        public static void MyMethod(object obj)
        {
            Thread thread = Thread.CurrentThread;
            string message = $"Background : {thread.IsBackground}, Is it From Pool :" +
                $" {thread.IsThreadPoolThread}, Name of the Thread {thread.Name} and the Thread ID : {thread.ManagedThreadId}";
            Console.WriteLine(message);
        }
    }

    partial class Employee
    {
        public void f2() { }
         partial void Add(ref int a);  // decl
    }
}
