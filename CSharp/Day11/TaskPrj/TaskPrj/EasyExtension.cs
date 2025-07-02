using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPrj
{
    class EasyExtension
    {
        public void Method1()
        {
            Console.WriteLine("Method 1..");
        }

        public void Method2()
        {
            Console.WriteLine("Method 2..");
        }

        public void Method3()
        {
            Console.WriteLine("Method 3..");
        }
    }

    static class doubleEasyExt
    {
        public static void Method4(this EasyExtension ee)
        {
            Console.WriteLine("Method 4..");
        }

        public static void NewMethod3(this EasyExtension ee)
        {
            Console.WriteLine("This is new Method 3");
        }

        public static void Method5(this EasyExtension ee, string s)
        {
            Console.WriteLine(s);
        }

        public static void TestFunc(this TestLibrary tl)
        {
            Console.WriteLine("Reached TestLibrary Method..");
        }
    }

    class TestExtension
    {
        static void Main()
        {
            EasyExtension ee = new EasyExtension();
            ee.Method1();
            ee.Method2();
            ee.Method3();
            ee.NewMethod3();
            ee.Method4();
            ee.Method5("Hello Extensions");

           

            TestLibrary tl = new TestLibrary();
            tl.TestFunc();
            Console.Read();
        }
    }
}
