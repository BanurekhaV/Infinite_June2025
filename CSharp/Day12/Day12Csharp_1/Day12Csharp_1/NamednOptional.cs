using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day12Csharp_1
{
    class NamednOptional
    {
        public static int Function1(int x, int y )
        {
            return x * y;
        }

        public static int Add(int fn, int secn = 5) // default argument
        {
            return fn + secn;
        }

        public static int Add2(int n1, int n2, [Optional] int n3)
        {
            return n1 + n2 + n3;
        }
        static void Main()
        {
            Console.WriteLine(Function1(5,6));  // positional parameters

            //named arguments
            Console.WriteLine(Function1(y: 5, x: 6));
            Console.WriteLine(Function1(x: 5, y:10));

            //positional + named arguments
            Console.WriteLine(Function1(x:20,10));

            //positional arguments cannot follow named arguments if the position does not match
            // Console.WriteLine(Function1(y:20,10));

           // Student s = new Student(nm: "Banu", id: 4, em: "ee");

            //optional/default - arguments/parameters

            Console.WriteLine(Add(10));  // uses default value
            Console.WriteLine(Add2(10,10,10)); // replace a value for the optional parameter
            Console.WriteLine(Add2(100,100));  // 3 arg is optional

            //literal movement '_'
            var lit1 = 4789_5624_3749_60574;  // digits

            var lit2 = 0xa_3ef5d_d3f6;   // hexadecimal

            var lit3 = 1100_0000_1010_1100;  // binary
            Console.WriteLine($"{lit1}, {lit2},{lit3}");
            Console.Read();
        }
    }
}
