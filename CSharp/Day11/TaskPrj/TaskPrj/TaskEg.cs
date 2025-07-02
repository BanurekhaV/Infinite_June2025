using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPrj
{
    class TaskEg
    {
        static async Task Main()
        {
            Console.WriteLine("Starting Async Operations...");
            await AnotherAsyncOperation();
            Console.WriteLine("Async Operations completed..");
            Console.Read();
        }

        static async Task AnotherAsyncOperation()
        {
            await Task.Delay(2000);
            Console.WriteLine("Operation in Progress....");
        }
    }
}
