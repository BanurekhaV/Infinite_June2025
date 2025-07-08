using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Csharp
{
    class IteratorsEg
    {
        public static IEnumerable<string> GetData()
        {
            List<string> colors = new List<string>() { "Red", "Blue", "Green", "Yellow", "Rose" };

            foreach(var items in colors)
            {
                yield return items;
            }
        }

        //example for yield with return and break
        public static IEnumerable<int>GetRandomYears()
        {
            int year;
            while(true)
            {
                Random random = new Random();
                year = random.Next(2010, 2025);
                if(year % 4 ==0)
                {
                    Console.WriteLine($" Leap Year {year} Encountered");
                    yield break;
                }
                 yield return year;
            }
            Console.WriteLine("Method done..");
        }

        static void Main()
        {
            IEnumerable<string> retColors = GetData();

            //displaying colors
            foreach(var i in retColors)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Yield Break---");
            foreach(int yr in GetRandomYears())
            {
                Console.WriteLine(yr);
            }
            Console.Read();
        }
    }
}
