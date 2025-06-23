using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4CSharp
{
    class OverloadingEg
    {
        public int add(int a, int b) { return 0; }

        public float add(int x, float y) { return 1.5f; }

        public static void swap(int number1, int number2)
        {
            number1 = number1 + number2;   
            number2 = number1 - number2;   
            number1 = number1 - number2;
            Console.WriteLine("Swapping of 2 numbers number 1 = " + number1 + " number 2 = "  + number2);
        }

        public static void swap(char character1, char character2)
        {
            char temp = ' ';
            temp = character1;
            character1 = character2;
            character2 = temp;
            Console.WriteLine("Swapping of 2 characters, character 1 = " +  character1 + " character 2 = "+ character2);

        }
    }

    class OverloadChecker
    {
        static void Main()
        {
            OverloadingEg oeg = new OverloadingEg();
            Console.WriteLine(oeg.add(5, 5)); //goto line 11
            Console.WriteLine(oeg.add(1, 5.3f)); //goto line 13
            OverloadingEg.swap(4, 15);
            OverloadingEg.swap('a', 'z');
            Console.Read();
        }
    }
}
