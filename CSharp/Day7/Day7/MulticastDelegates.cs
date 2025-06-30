using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public delegate long SquareDelegate(int side);
    public delegate void UserDelegate(string message);
    class MulticastDelegates
    {
        public  static long AreaofSquare(int side)
        {
            return side * side;
        }

        public static long PerimeterofSquare(int side)
        {
            return 4 * side;
        }


        public static void DisplayUser(string Message)
        {
            Console.WriteLine($"{Message} User");
        }

        public static void DisplayAdmin(string Message)
        {
            Console.WriteLine($"{Message} Admin");
        }
        static void Main()
        {

            SquareDelegate squareDelegate = new SquareDelegate(AreaofSquare);

            Console.WriteLine($"Area of the Square:{squareDelegate(5)}");

            squareDelegate += PerimeterofSquare;

           Console.WriteLine($"Perimeter of the Square{squareDelegate(5)}");

            //Explicit Invokation

            //Console.WriteLine($"{squareDelegate.Invoke(5)}");


            UserDelegate userDelegate = new UserDelegate(DisplayUser);
            userDelegate += DisplayAdmin;

            userDelegate.Invoke("Hello");

        }

    }
}
