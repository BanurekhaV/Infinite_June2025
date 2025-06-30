using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class GradeSystem
    {

        static void Equality_Demo()
        {
            string[] books = { "OOAD", "AI", "DS" };
            Console.WriteLine(books[3]);
        }
        public static string GradeCalculator(int scores)
        {
            if(scores >= 0)
            {
                if (scores >=90)
                {
                    return "A";
                }
                else if(scores <= 89 && scores >= 70)
                {
                    return "B";
                }
                else
                {
                    return "c";
                }
            }

            else
            {
                throw new NegativeValueException("Scores can not be Negative!!");
            }
        }

        public static void Main()
        {
            try
            {
                GradeCalculator(-3);
                Equality_Demo();
            }

            catch(NegativeValueException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
