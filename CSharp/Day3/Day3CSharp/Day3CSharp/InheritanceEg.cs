using System;


namespace Day3CSharp
{

    class Parent
    {
        int parentdata;

        //public Parent()  // empty constrauctor
        //{
        //    parentdata = 100;
        //    Console.WriteLine("Hi from parent..");
        //}

        public Parent(int x)  // parameterized xonstructor
        {
            parentdata = x;
            Console.WriteLine(" Hi from Parent " + " " + parentdata);
        }
    }

    class Derived : Parent
    {
        int deriveddata;

        public Derived(int a, int b) : base(b)
        {
            deriveddata = a;
            Console.WriteLine("Hi from Derived.." + " " + deriveddata);
        }
    }
    class InheritanceEg
    {
        static void Main()
        {
            Derived d = new Derived(5, 10);
            Console.Read();
        }
    }
}
