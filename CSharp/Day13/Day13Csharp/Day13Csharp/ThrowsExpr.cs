using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Csharp
{
    class ThrowsExpr
    {
        static void Main()
        {
            var a = Divide(10, 2);
            Console.WriteLine(a);
            Console.Read();
        }

        public static double Divide(int x, int y)
        {
            return y != 0 ? x / y : throw new DivideByZeroException();
        }
    }
}
