using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Csharp_1
{
    class LambdaExpressions
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 36, 71, 12, 15, 29, 18, 27, 17, 9, 34 };

            //using lambda find out the squares of each element
            var square = numbers.Select(n => n * n);

            foreach(var v in square)
            {
                Console.Write("{0} ", v);
            }
            Console.WriteLine();

            //find all the numbers divisible by 3

            //lambda with objects
            Student s = Student.GetStudents().Find(std => std.Id == 104);
            Console.WriteLine(s.Name);

            //sort by Name
            var sortedstudents = Student.GetStudents().OrderBy(x => x.Name);

            foreach(var item in sortedstudents)
            {
                Console.WriteLine(item.Id + " " +  item.Name);
            }
            Console.WriteLine("---------------------------");
            //write the above query expression
            var sortstd = from a in Student.GetStudents()
                          orderby a.Name
                          select a;

            foreach (var item in sortstd)
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }
            Console.Read();
        }
    }
}
