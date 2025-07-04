using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Csharp
{
    class Async_Await
    {
        static void Main()
        {
            addAsync();
            Console.Read();
        }

        async static Task addAsync()
        {
            try
            {
                int[] arr = new int[3];
                arr[2] = 10;
            }
            catch(Exception e)
            {
                await ExceptionOccured();
                Console.WriteLine("Handled Error ..");
            }
            finally
            {
                await ReleasingResources();
                Console.WriteLine("Closing Application..");
            }
        }

        async static Task ExceptionOccured()
        {
            await Task.Delay(1000);

            Console.WriteLine("Array Exception Occurred..");
        }

        async static Task ReleasingResources()
        {
            Console.WriteLine("All occupied resources released...");
        }
    }
}
