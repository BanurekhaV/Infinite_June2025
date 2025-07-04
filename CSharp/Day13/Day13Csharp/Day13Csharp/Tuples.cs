using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Csharp
{
    class Tuples
    {
        static void Main()
        {
            var values = new List<double>() { 10, 20, 30, 40, 50 };
            //1. with Tuple objects
            //Tuple<int, double> t = Calculate(values);
            //Console.WriteLine($"There are {t.Item1} values and their Sum is {t.Item2}");

            //2. without tuple
            // var result = Calculate(values);
            // Console.WriteLine($"There are {result.Item1} values and their Sum is {result.Item2}");
            //3. referencing the return argument
            //Console.WriteLine($"There are {result.count} values and their Sum is {result.total}");

            //4. using explicit names
            var (countResult, totalResult) = Calculate(values);
            Console.WriteLine($"There are {countResult} values and their Sum is {totalResult}");
            Console.Read();
        }

        //1.
        //static Tuple<int,double> Calculate(List<double>val)
        //{
        //    int count = 0;
        //    double total = 0.0;
        //    foreach(var v in val)
        //    {
        //        count++;
        //        total += v;
        //    }

        //    //creating an object of the Tuple class by calling a Create Method
        //    Tuple<int, double> ret_tuple = Tuple.Create(count, total);

        //    //return the tuple
        //    return ret_tuple;
        //}

        //2. without tuple
        //static (int, double) Calculate(IEnumerable<double>val

        //3.
        static (int count, double total) Calculate(IEnumerable<double>val)
        {
            int count = 0;
            double total = 0.0;
            foreach (var v in val)
            {
                count++;
                total += v;
            }
            return (count, total);
        }
    }
}
