using System;


namespace Day3CSharp
{
    class MethodsnParameters
    {
        //by value

        public static void SimpleValueMethod(int j)
        {
            j = 100;
            Console.WriteLine("J's value is " +  j);
        }

        //by reference
        public static void SimpleRefMethod(ref int j)
        {
            j = 100;
            Console.WriteLine("J's value is " + j);
        }
    }

    class Tester
    {
        static void Main()
        {
            int i = 10;
            MethodsnParameters.SimpleValueMethod(i);
            Console.WriteLine("I's values is {0}", i);
            Console.WriteLine("__________________");
            MethodsnParameters.SimpleRefMethod(ref i);
            Console.WriteLine("I's values is {0}", i);
            Console.Read();
        }
    }
}
