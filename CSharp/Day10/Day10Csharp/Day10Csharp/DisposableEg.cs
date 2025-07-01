using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Csharp
{
    class DisposableEg : IDisposable
    {
        //constructor
        public DisposableEg()
        {
            Console.WriteLine("Allocating Resources.....");
        }

        public void DoSomething()
        {
            Console.WriteLine("Using the allotted resources for the application...");
        }
        public void Dispose()
        {
            Console.WriteLine("Releasing all the Resources...");            
        }

        static void Main()
        {
            using(var dispobj = new DisposableEg())
            {
                dispobj.Dispose();  // calling explicitly
                dispobj.DoSomething();
            }  // the end of using block will call dispose() implicitly

            Console.Read();
        }
    }
}
