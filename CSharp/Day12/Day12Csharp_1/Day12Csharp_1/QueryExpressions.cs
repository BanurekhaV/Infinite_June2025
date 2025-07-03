using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Csharp_1
{
    class QueryExpressions
    {
        static void Main()
        {
            int[] intval = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Query Expression
            IEnumerable<int> oddvalues = from v in intval
                                         where (v % 2) != 0
                                         select v;

            //iterate the result collection
            foreach(int x in oddvalues)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("----Query Expressions with Objects-----");
            IEnumerable<Student> stdobj = from student in Student.GetStudents()
                                          where student.Name.EndsWith("n")
                                          select student;

            foreach(var s in stdobj)
            {
                Console.WriteLine($"{s.Id}  {s.Name}  {s.EMail}");
            }

            //name of the student whose id==103
           IEnumerable<string> stdname = from s in Student.GetStudents()
                          where s.Id == 103
                          select s.Name;

            foreach(var name in stdname)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }

        public static List<Student> GetStudents()
        {
            List<Student> stdlist = new List<Student>() 
            { 
                new Student{Id = 101, Name="Naveen", EMail="Naveen@gmail.com"},
                new Student{Id = 102, Name="Nithin", EMail="Nithin@gmail.com"},
                new Student{Id = 103, Name="Nikitha", EMail="Nikitha@gmail.com"},
            };
            //Student s1 = new Student { Id = 101, Name = "Naveen", EMail = "Naveen@gmail.com" };
            //stdlist.Add(s1);
            return stdlist;
        }
    }
}
