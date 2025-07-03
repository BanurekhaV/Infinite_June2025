using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Csharp_1
{
    //outer class
    public class Car
    {
         Engine e = new Engine();
        static string Make = "Ford";
        public void ShowCar()
        {
            Console.WriteLine("Car - Benz");
            e.ShowEngine();
        }

        //nested or inner class
        public class Engine
        {
            public void ShowEngine()
            {
                Car c = new Car();
                Console.WriteLine("Diesel Engine" + Car.Make);
                c.ShowCar();
                
            }
        }
    }

    //ex 2
     class Computer
    {
        public void Display()
        {
            Console.WriteLine("Computer Class Method..");
        }

        //nested class
        public class CPU
        {
            public void ShowCPU()
            {
                Console.WriteLine("It is CPU");
            }
        }
    }

    class Laptop : Computer
    {

    }
    class Program 
    {
        static void Main(string[] args)
        {
            Car Suvcar = new Car();
            Suvcar.ShowCar();
            
            Car.Engine Dengine = new Car.Engine();
            Dengine.ShowEngine();

            Laptop laptop = new Laptop();
            laptop.Display();
            Console.Read();
            
        }
    }
}
