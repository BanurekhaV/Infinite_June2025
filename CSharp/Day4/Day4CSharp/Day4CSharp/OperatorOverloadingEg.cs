using System;


namespace Day4CSharp
{

    class Box
    {
       public int length;
       public int breadth;

        //operator overloading

     
        public static Box operator +(Box box1, Box box2)
        {
            Box temp = new Box();
            temp.length = box1.length + box2.length;
            temp.breadth = box1.breadth + box2.breadth;
            return temp;
        }
    }
    class OperatorOverloadingEg
    {
        static void Main()
        {
            int a = 5, b = 5, c;
            c = a + b;
            c++;
            Console.WriteLine(c);

            Box b1 = new Box();
            b1.length = 5;
            b1.breadth = 4;

            Box b2 = new Box();
            b2.length = 10;
            b2.breadth = 5;

            Box b3 = b1 + b2;  // goto line no.15
            Console.WriteLine($"The overall Length is {b3.length} and breadth is {b3.breadth}");
           // b3++;
            Console.Read();

        }
    }
}
