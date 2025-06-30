using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Student
    {

    }
    class Equality_Demo
    {
        static void Main()
        {

            //Value Equality
            int x = 5, y = 5;

            Console.WriteLine(x == y); // x and y = 5
            Console.WriteLine(x.Equals(y)); // 5 = 5

            //Refence Equality

           
            Student s1 = new Student();
            //Student s2 = new Student();
            Student s2 = s1;
                 
            Console.WriteLine( s1 == s2); 
            Console.WriteLine(Object.ReferenceEquals(s1,s2));

            Console.WriteLine("-----------------------------------------------------------");
            string str1 = "Morning";
            string str2 = "morning";

            Console.WriteLine($"str1 == str2 :{str1 == str2}"); //true

            Console.WriteLine($"str1.equals(str2) :{str1.Equals(str2)}"); // true
            Console.WriteLine($"ReferenceEquals:{Object.ReferenceEquals(str1,str2)}"); // true
            Console.WriteLine($"str1.CompareTo(str2) :{str1.CompareTo(str2)}");//

        }
    }
}
