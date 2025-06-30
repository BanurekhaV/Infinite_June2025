using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Day9Csharp
{
    public class Demo : IDisposable
    {
        ~Demo()
        {
             WriteLine("Finalized Called...");
             WriteLine("bye");
             ReadLine();
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose called");            
        }
    }
    class GarbageEg
    {
       static void Main()
        {
            WriteLine("Maximum number of generations : {0}", GC.MaxGeneration);
            GarbageEg ge = new GarbageEg();
            WriteLine("The generation number {0}", GC.GetGeneration(ge));
            WriteLine("The total memory {0}", GC.GetTotalMemory(false));
            WriteLine("------------");
            //ge = null;
            
            GC.Collect();
            //Console.WriteLine("The generation number {0}", GC.GetGeneration(ge));
            //Console.WriteLine("The total memory {0}", GC.GetTotalMemory(false));
            Console.WriteLine("-------------");
            Demo demo = new Demo();
             demo.Dispose();
            // demo = null;
            WriteLine("Enter a number :");
            int num = ToInt32(ReadLine());
            WriteLine(num);
            Console.ReadLine();
        }
    }


}
