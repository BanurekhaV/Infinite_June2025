using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Csharp
{
    class Person
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void checkType(object obj)
        {
            switch(obj)
            {
                case Person p:
                    Console.WriteLine("Obj is Person Type");
                     Console.WriteLine($"Nameof of the Person : { p.Name}");
                    break;
                case int i:
                    Console.WriteLine("Obj is Integer");
                    Console.WriteLine($"Value of int : {i}");
                    break;
                default:
                    Console.WriteLine("Obj is some other type");
                    break;
            }
        }

        //public static string GetNumberSign(int n)
        //{
            //switch(n)
            //{
            //    case < 0:
            //        return "Negative Number";
            //    case 0:
            //        return "Number Zero";
            //    case >= 1:
            //        return "Positive Number";
            //}
            //return n switch
            //{
            //    < 0 => "Negative Number",
            //    0 => "Zero",
            //    >= 1 => "Positive Number"
            //};
      //  }

        //property pattern
        //public static void WriteStringLenth(string str)
        //{
        //    if(str is null)
        //    {
        //        Console.WriteLine("It is a Null String");
        //    }
        //    if (str is { Length: 0 })
        //    {
        //        Console.WriteLine("empty string");
        //        return;
        //    }
        //    if (str is { Length: 1 })
        //    {
        //        Console.WriteLine("it is a string of length 1");
        //        return;
        //    }
        //    else
        //    {
        //        Console.WriteLine("String of more than 1 length");
        //        return;
        //    }
        //}

        //positional pattern
        public struct CheckBooleanData
        {
            public bool Data1 { get; set; }
            public bool Data2 { get; set; }

            public void unWrap(out bool d1, out bool d2)
            {
                d1 = Data1;
                d2 = Data2;
            }
        }

        //positional pattern with logical and and or
        //public static bool LogicalAnd(CheckBooleanData n1)
        //{
        //    //using switch expressions
        //    return n1 switch
        //    {
        //        (false, false) => false,
        //        (true, false) => false,
        //        (false, true) => false,
        //        (true, true) => true
        //    };
        //}

        //public static bool LogicalOR(CheckBooleanData n1)
        //{
        //    //using switch expressions
        //     switch(n1)
        //     {
        //        case (false, false) return false,
        //        case (true, false) return  true,
        //        (false, true) return true,
        //        (true, true) return true
        //    };
        //}
        static void Main(string[] args)
        {
            var person = new Person { Name = "Mehrun" };
            checkType(56);
            checkType(person);
            checkType("Hi");

            //property pattern driver
            //WriteStringLenth("CSharp");
            //WriteStringLenth("");
            //WriteStringLenth("A");

                      
            Console.Read();
        }
    }
}
