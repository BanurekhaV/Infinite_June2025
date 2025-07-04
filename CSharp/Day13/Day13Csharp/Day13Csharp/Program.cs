using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 5;
            int sum = Sum(a, b);
            int diff = Difference(a, b);
            Console.WriteLine($"The Sum of {a} and {b} is {sum}");
            Console.WriteLine($"The Difference between {a} and {b} is {diff}");
            
            //local function
            int Sum(int x, int y)
            {
                x = x + a;  // can access variables of the enclosing type
                y = y + b;
                int z = 100;
                return x + y;
            }

            int Difference(int x, int y)
            {
                return x - y;
            }
            Console.WriteLine("Press any key to exit..");
            Console.Read();
        }
    }
}
