using System;


namespace Day3CSharp
{

    class Customer
    {
        public Customer()
        {
            Console.WriteLine("Customer constructor 1...");
        }

        public Customer(int a) : this()
        {
            Console.WriteLine("Customer constructor 2...");
        }

        public Customer(string s, int x):this(50)
        {
            Console.WriteLine("Customer constructor 3...");
        }
}
    class Constructor_with_thiskeyword
    {
        static void Main()
        {
            Customer cust = new Customer("Hello", 10);
            Console.Read();
        }
    }
}
