using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Csharp
{
    class AnonymousMethods
    {
        delegate void Print(int v);

        static void Main()
        {
            int i = 100;
            Print p = delegate (int x) //delegate associated with an anonymous fuction
            {
                x += i;
                Console.WriteLine("We are inside the Anonymous Method {0}", x);
            };

            p(10);  //invoking the delegate object to call the anonymous method


            //example 2
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] evennos = Array.FindAll(numbers, delegate (int n)
              {
                  return n % 2 == 0;
              });
            Console.WriteLine("---Even nos are -------");
            foreach(int item in evennos)
            {
                Console.WriteLine(item);
            }

            //Types of delegates example
            Console.WriteLine("-------Predicate Delegate Types--------");
            Predicate<string> chkupper = delegate (string s)
             {
                 return s.Equals(s.ToUpper());
             };

            bool res = chkupper("HELLO DELEGATE");
            Console.WriteLine(res);
            res = chkupper("Hello Delegate");
            Console.WriteLine(res);
            //with lambda
            Predicate<string> isupper = s => s.Equals(s.ToUpper());
            Console.WriteLine(isupper("hello World")); 

            Console.WriteLine("------------Function Delegate ----------");
            Func<int> getRandomNumber = delegate ()
            {
                Random r = new Random();
                return r.Next(1, 100);
            };

            int rand = getRandomNumber();
            Console.WriteLine(rand);

            //with lambda
            Func<int> randomgen = () => new Random().Next(1,100);

            Console.WriteLine(randomgen());

            //eg 2 for func delegate with lambda
            Func<int, int, int> sum = (n1, n2) => n1 + n2;
            Console.WriteLine(sum(20,30));
            Console.WriteLine("-------Action Delegates--------");
            Action<int> actiondel = delegate (int n)
            {
                Console.WriteLine(n + 5);
            };
            actiondel(5);

            //with lambda
            Action<int> addaction = n => Console.WriteLine(n+10);
            addaction(15);
        
            Console.Read();
        }
    }
}
