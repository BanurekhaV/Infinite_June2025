using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryPrj;
using ExtensionLibrary;

namespace TaskPrj
{

    class TestLibrary
    {
        static void Main()
        {
            LibClass lc = new LibClass();
            Console.WriteLine(lc.Greetings());
            Console.WriteLine(lc.CalculateTax(35456.58f));

            //extension methods
            
            Console.WriteLine(lc.Add2Nos(10, 20));
            lc.Message();
            Console.Read();
        }
    }
}
