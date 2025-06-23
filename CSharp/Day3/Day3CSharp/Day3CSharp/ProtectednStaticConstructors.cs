using System;


namespace Day3CSharp
{
    class Dog
    {
        public string Name;
        public int Age;

        protected Dog()
        {
            Console.WriteLine("We are in the process of constructing a Dog..");
            Console.WriteLine(Name + " " + Age);
        }
    }

    class Labdrador : Dog
    {
        public double measurements;

        public Labdrador(string name, int age, double m)
        {
            Console.WriteLine("Labrador getting constructed..");
            Name = name;
            Age = age;
            measurements = m;
            Console.WriteLine(name + " " + age + " " + measurements);
        }
    }

    class Account
    {
        public int id;
        public string name;
        public static float rateofInterest;

        public Account(int id, string name)
        {
            this.id = id;
            this.name = name;
           // rateofInterest = 6.5f;
        }

        //static constructor
        static Account()
        {
            Console.WriteLine("Static constructor here...");
            rateofInterest = 7.5f;   
        }

        public void DisplayAccount()
        {
            Console.WriteLine(id + " " + name + " "+ rateofInterest) ;
        }

    }
    class ProtectednStaticConstructors
    {
        static void Main()
        {
            //invoking the protected constructor of the base class thru the child class constructor
            Labdrador l = new Labdrador("Tuffy", 5, 12.5);

            //static constructor usage
            Account a1 = new Account(101, "Hari");
            Account a2 = new Account(102, "Hema");
            a1.DisplayAccount();
            a2.DisplayAccount();
            Console.Read();
        }
    }
}
