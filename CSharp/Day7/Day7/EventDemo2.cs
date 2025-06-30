using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public delegate void AddDelegate(int a, int b);

    internal class Opeartion
    {
        public event AddDelegate AddEvent;

        public void GetData(int x,int y)
        {
            if( x > 0 && y > 0)
            {
                //raise the event
                AddEvent(x, y);
            }
            else
            {
                Console.WriteLine( "Value of A and B should be greater than 0" );
            }
        }
    }
    class Calculation
    {
        //handling the event
        internal void Add(int value1,int value2)
        {
            Console.WriteLine($"Add :{value1 + value2}");
        }
    }
    class EventDemo2
    {
        static void Main()
        {
            Opeartion opeartion = new Opeartion();
            Calculation calculation = new Calculation();

            opeartion.AddEvent += new AddDelegate(calculation.Add);

            opeartion.GetData(9, 7);

        }
    }
}
