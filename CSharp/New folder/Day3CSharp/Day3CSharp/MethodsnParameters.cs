using System;


namespace Day3CSharp
{
    class MethodsnParameters
    {
        //by value
              
        public static void SimpleValueMethod(int j)
        {
            j = 100;
            Console.WriteLine("J's value is  {0}" ,  j);
           
        }

        //by reference
        public static void SimpleRefMethod(ref int j)
        {
            j = 100;
            Console.WriteLine("J's value is " + j);           
        }

        //using out
        public static int Calculate(int n1, int n2, out int sum, out int product)
        {
            sum = n1 + n2;   //output value
            product = n1 * n2;  //output value
            return n1 - n2;  // return value
        }

        //parameter array 1
        public static int AddElements(params int[] arr )
        {
            int sum = 0;
            foreach(int n in arr)
            {
                sum += n;
            }
            return sum;
        }

        //parameter array 2
        
        public static void ParamsMethod(params int[] number)
        {
            Console.WriteLine("There are {0} elements ", number.Length);
            foreach(int i in number)
            {
                Console.WriteLine(i);
            }

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
            Console.WriteLine("----With Out Parameters------");
            int total, prod, difference;
            difference = MethodsnParameters.Calculate(10, 5, out total, out prod);
            Console.WriteLine($"Sum of 2 nos is {total}, product is {prod} and difference is {difference}");
            Console.WriteLine("------Parameter Array------");
            Console.WriteLine(MethodsnParameters.AddElements());
            Console.WriteLine(MethodsnParameters.AddElements(5,6,2));
            Console.WriteLine(MethodsnParameters.AddElements(10,20,30,40,50));

            Console.WriteLine("*********************");
            int[] num = new int[3];
            num[0] = 10;
            num[1] = 20;
            num[2] = 30;
            MethodsnParameters.ParamsMethod(); // 0 argument
            MethodsnParameters.ParamsMethod(num);  // array argument
            MethodsnParameters.ParamsMethod(1, 2, 3, 4, 5, 6, 7); // comma separated values
            Console.Read();
        }
    }
}
