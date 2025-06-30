using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class ExceptionHandlingdemo
    {
        static void Main()
        {
            int a = 10, b = 5;

            try
            {
                int result = a / b;
                Console.WriteLine(result);
                string[] books = { "OOAD", "AI", "DS" };
                Console.WriteLine(books[3]);

                //Nested try  block
                try
                {
                    Console.WriteLine("Nested Try Block");
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }



            catch (DivideByZeroException ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Please check the input!!!");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);

            }

            catch (Exception ex)
            {
                Console.WriteLine("OOPS ! Something Went Wrong!!");
            }

            finally
            {
                Console.WriteLine("Thank you !!");
            }
        }
    }
}
