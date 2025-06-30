using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Checked_Unchecked
    {
        //Checked and Unchecked statements helps to handle Arthimatic Overflow
        public static void Main()
        {
            int max = int.MaxValue;
            // int result = max + 2;
            //int result = checked(max + 2);

            int result = unchecked(max + 2);
            Console.WriteLine($"Result : {result}");
        }
    }
}
