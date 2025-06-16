using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDotnet_Prj
{
    
    class Student
    {       
        static void Main()
        {
            //Let us see how to read and write using c#
            Console.WriteLine("This is the Main of Class Student");
            Console.WriteLine("Enter your First Name :");
            string fname, lname;
            fname = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name:");
            lname = Console.ReadLine();
            Console.WriteLine("Enter your Age :");
            int age;
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your First Name is : " + fname);  //concatenation
            Console.WriteLine("Your Last name is {0}" , lname); // place holder
            Console.WriteLine("Your First name is {0} and last name is {1}", fname,lname); //multiple placeholder 
            Console.WriteLine($"Your Firstname is {fname} last name is {lname} and you are {age} years old"); //string interpolation
            Console.ReadKey();
        }
        static void Myfunction()
        {
            Console.Write("Hi");
        }
    }
}
