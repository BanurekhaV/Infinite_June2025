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
            Console.WriteLine(Name + " "+ Age);
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

    class ProtectedConstructors
    {
        static void Main()
        {
            Labdrador l = new Labdrador("Tuffy", 5, 12.5);
            Console.Read();
        }
    }
}
