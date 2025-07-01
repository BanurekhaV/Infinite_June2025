using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Csharp
{
    public class Person { }
    public class Employee : Person { }
    public class Manager : Employee { }
    delegate void persondelegate(Employee eobj);
    class CoContraVariance
    {
        public static void Message(Person pobj)
        {
            Console.WriteLine("Hi");
        }
        static void Main()
        {
            var personobj = new Person();
            var empobj = new Employee();
            var mgrobj = new Manager();

            personobj = empobj;
            personobj = mgrobj;

            empobj = (Employee)personobj;
             
            persondelegate pd = Message;
            pd(empobj);  // contravariance

           // Co variance in Arrays
            Person[] p = new Employee[3];
            p[0] = new Manager();

            //Contra in Arrays
            Person[] p1 = { new Person() };
           // Employee[] emp = p1; // implicit conversion not possible
            Console.Read();

        }
        
    }
}
