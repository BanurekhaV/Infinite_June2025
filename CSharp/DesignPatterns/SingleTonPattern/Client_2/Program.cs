using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleTonPattern;

namespace Client_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleTonClass training = SingleTonClass.GetInstance();
            {
                training.Show("This is a dotnet Training on Design Patterns...");
                Console.Read();
            }
        }
    }
}
