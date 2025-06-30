using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Sample
    {
        internal void Swap<T>(T a, T b )
        {
            T temp;
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"a: {a} b :{b}");

          //  temp = a + b;

        }
    }
    class GenericClass_Method
    {
        static void Main()
        {
            Sample sample = new Sample();
            sample.Swap<int>(10, 30);
            sample.Swap<string>("Hello", "Hi");
        }
    }
}
