using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //object instances to test singleton objects

            //SingleTonClass trainer = SingleTonClass.GetInstance();

            //trainer.Show("Working with single Object instance of the trainer...");

            ////let us create another instance
            //SingleTonClass trainee = SingleTonClass.GetInstance();

            //trainee.Show("Working with single Object instance of the trainee...");

            //SingleTonClass manager = SingleTonClass.GetInstance();
            //manager.Show("Invoking the object for the third time...");

            //testing singleton object instances with a nested class

            SingleTonClass teacher = SingleTonClass.GetInstance();
            teacher.Show("This is from the Teacher..");

            SingleTonClass student = SingleTonClass.GetInstance();
            teacher.Show("This is from the Student..");

            //instantiating the nested class
           // SingleTonClass.DerivedSingleTon derivedobj = new SingleTonClass.DerivedSingleTon();
           // derivedobj.Show("This is from Derived Object of the SingleTon...");
            Console.Read();
        }
    }
}
