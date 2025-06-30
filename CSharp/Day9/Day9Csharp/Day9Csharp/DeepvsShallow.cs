using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Csharp
{
    class PersonDescription
    {
        public string Firstname, Lastname;

        public PersonDescription(string f, string l)
        {
            this.Firstname = f;
            this.Lastname = l;
        }
    }
    class Person
    {
        public int Age;
        public PersonDescription desc;  //composition

        public Person(int a, string fn, string ln)
        {
            Age = a;
            desc = new PersonDescription(fn, ln);
        }

        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person pcopy = new Person(this.Age, desc.Firstname, desc.Lastname);
            return pcopy;
        }
    }
    class DeepvsShallow
    {
        static void Main()
        {
            Person p1 = new Person(21, "Manoj", "Kumar");
            Person p2 = (Person)p1.ShallowCopy();
            Console.WriteLine($"P1.Age is{p1.Age}, P1's FirstName is {p1.desc.Firstname} ");
            Console.WriteLine($"P2.Age is{p2.Age}, P2's FirstName is {p2.desc.Firstname} ");

            p2.desc.Firstname = "Kishore";
            Console.WriteLine("---Changes in Shallow Copied Object----");
            Console.WriteLine(p1.desc.Firstname);
            Console.WriteLine(p2.desc.Firstname);
            Console.WriteLine("-----Hashcodes of P1 and P2------");
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());

            //if we equate both the objects
            p2 = p1;
            Console.WriteLine("-----Hasgcodes of P1 and P2 after assigning objects------");
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
            Console.WriteLine("------Deep Copy-------");

            Person p3 = p1.DeepCopy();
            Console.WriteLine($"P1.Age is {p1.Age}, P1's FirstName is {p1.desc.Firstname} ");
            Console.WriteLine($"P3.Age is {p2.Age}, P3's FirstName is {p3.desc.Firstname} ");

            p3.desc.Lastname = "Krishna";
            Console.WriteLine("-----changes on a deep copied object-----");
            Console.WriteLine($"P1.Age is {p1.Age}, P1's LastName is {p1.desc.Lastname} ");
            Console.WriteLine($"P3.Age is {p2.Age}, P3's LastName is {p3.desc.Lastname} ");

            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p3.GetHashCode());
            Console.Read();
        }
    }
}
