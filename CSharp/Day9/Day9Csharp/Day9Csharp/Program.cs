using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Csharp
{
    public delegate int CalculatorDel(int x);
    class Program
    {
        static int p;

        public int Square(int x)
        {
            p = x * x;
            return p;
        }

        public int Triple(int q)
        {
            p = q * q * q;
            return p;
        }
        static void Main(string[] args)
        {
            Program prog = new Program();
            CalculatorDel cd = new CalculatorDel(prog.Square);
           // cd += prog.Triple;
            int result = cd(5);
            Console.WriteLine("Return value is {0}", result);
            cd = prog.Triple;
            Console.WriteLine(cd(5));
            cd = new CalculatorDel(prog.Triple);
            Console.Read();
        }
    }
}
