extern alias Lib1;
extern alias Lib2;

using System;
//using LibPrj1;
//using LibPrj2;

namespace Day13Csharp
{
    class TestAliases
    {
        
        static void Main()
        {
            //1. calling instance members with  extern alias

            // Lib1.LibPrj1.LibClass lc1 = new Lib1.LibPrj1.LibClass();
            // Lib2.LibPrj2.LibClass lc2 = new Lib2.LibPrj2.LibClass();

            //2. calling instance members with objects without extern alias
            //  LibPrj1.LibClass lc = new LibPrj1.LibClass();
            //  lc.Method1();
            //  LibPrj2.LibClass lc2 = new LibPrj2.LibClass();
            // lc1.Method1();
            // lc2.Method1();

            Lib1.LibPrj1.LibClass._m1 = 5;
            Lib2.LibPrj2.LibClass._m2 = 10;
            Console.WriteLine(Lib1.LibPrj1.LibClass._m1 + " " + Lib2.LibPrj2.LibClass._m2);
            Console.Read();
        }
    }
}
