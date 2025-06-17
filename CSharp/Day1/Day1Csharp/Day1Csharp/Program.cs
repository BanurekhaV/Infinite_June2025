using System;

namespace Day1Csharp
{
    class Program 
    {
        static void Main()
        {
            // ConversionFunction();
            //  Console.WriteLine("****************");
            // Program.ConversionFunction();
            //Program prog = new Program();
            //prog.SampleTernary();
            //TestTryParse.tryParse_Function();
            //TestTryParse.Implicit_Types();
            TestTryParse.NullableEg();
            Console.Read();
        }
        public static void ConversionFunction()  // static member or class member
        {
            Console.WriteLine("Min int Value = {0}", int.MinValue);
            Console.WriteLine("Max value of int = {0}", int.MaxValue);

            int i = 100;
            float f = i;   // implicit conversion
            float f2 = 123.45f;
            i = (int)f2;  // explicit conversion by typecasting
            Console.WriteLine(i);
            i = Convert.ToInt32(f2); //explicit conversion by using conversion function
            Console.WriteLine(i);

            Console.WriteLine("Enter a number :");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks :");
            //float marks = float.Parse(Console.ReadLine());
            float marks = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Num = {0} and Marks ={1}", num,marks);
        }

        public void SampleTernary()     // non-static member or instance member
        {
            int num = 10;
            bool b;
            //if(num ==10)
            //{
            //    b = true;
            //}
            //else
            //{
            //    b = false;
            //}
            //using ternary operator
            b = num == 10 ? true : false;

            Console.WriteLine("Number == 10 is {0}" , b);
        }        
    }

    class TestTryParse
    {
        public static void tryParse_Function()
        {
            float data = 343456782564.77f;
            int x = (int)data;  // int declared its capacity but no exception
            // int x = Convert.ToInt32(data);  // exception was raised
            
           // Console.WriteLine(x);

            //let us try with tryparse()
            string str = "100gms";
            //  x = int.Parse(str);  // throwing an exception

            int result;
            bool status;
            status = int.TryParse(str, out result);

            if (status)   // if true
            {
                Console.WriteLine($"Staus is {status} and result is {result}");
                Console.WriteLine("Very Good");
            }
            else
            {
                Console.WriteLine("Invalid Data..");
                Console.WriteLine("Very Bad");
            }

          //  Console.WriteLine(x);
        }

        public static void Box_unBox()
        {
            int i = 10;
            object obj = i;  // boxing

            i = (int)obj;   // unboxing

            float percent = Convert.ToSingle(Console.ReadLine());

            string s = "AAA";
            obj = s;   // implicit
            s = (string)obj;  //explicit typecast
            s = Convert.ToString(obj);  //explicit conversion
        }

        public static void Implicit_Types()
        {
            int x;
            x = 8;
            
            var v = 3.4f;
            var s = "hello";
            Console.WriteLine(v);
            char c;
            c = 'a';
            dynamic d;

            d = 5;
            Console.WriteLine(d);
            d = "AA";
            Console.WriteLine(d);
            d = false;
            Console.WriteLine(d);
        }

        public static void NullableEg()
        {
            string s = null;
            int ? number = null; // enabling a value type to have null values
            int total;

            if (number == null)
                total = 0;
            else
               // total =(int)number;   //or
               total = number.Value;
            Console.WriteLine(total);
            Console.WriteLine("--------------");

            //the above decision clause can be replaced with coalescing operator
            total = number ?? 0;
  

            Console.WriteLine(total);
        }
    }
}
