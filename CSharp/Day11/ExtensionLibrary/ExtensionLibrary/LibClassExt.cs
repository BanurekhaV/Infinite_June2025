using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryPrj;

namespace ExtensionLibrary
{
    public static class LibClassExt
    {
        public static int Add2Nos(this LibClass lcobj, int a, int b)
        {
            return a + b;
        }

        public static void Message(this LibClass lcobj)
        {
            Console.WriteLine("Message Delivered...");
        }
    }
}
