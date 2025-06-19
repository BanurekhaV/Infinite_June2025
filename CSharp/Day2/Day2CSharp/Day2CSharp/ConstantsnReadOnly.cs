using System;

namespace Day2CSharp
{
    class ConstantsnReadOnly
    {
        //readonly fields
        public readonly int myvar1 = 5; // assigning value to readonly at the time of decl.
        public readonly int myvar2;  // just declaration

        //non-static field
        public float f = 10.5f;

        //static member
        static public int st = 50;

        //constant
       public const float PI = 3.14f; // value has to be assigned at the time of decl. only.
       
        //initilaizing readonly fields at construction

        ConstantsnReadOnly()
        {
            Console.WriteLine(myvar1 + " " + myvar2);

            myvar1 = 50; // this takes precedence over the assignment at declaration time
            myvar2 = 100;
        }
        public static void Main()
        {
            Console.WriteLine(ConstantsnReadOnly.st);
            ConstantsnReadOnly.st = 150;  // can change the static value
            Console.WriteLine(ConstantsnReadOnly.st);
          
            ConstantsnReadOnly cro = new ConstantsnReadOnly();
            Console.WriteLine(cro.f);
            cro.f = 25.46f;
            Console.WriteLine(cro.f);

            Console.WriteLine(cro.myvar1 + " " + cro.myvar2);

            Console.Read();

        }
    }
}
