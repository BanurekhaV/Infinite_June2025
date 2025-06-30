using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Marks { get; set; }

        public int CompareTo(Student student)
        {
            return this.Marks.CompareTo(student.Marks);
        }
    }
    class ComparableDemo
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student{Name = "Ram", Marks= 89},
                new Student{Name = "Shiva", Marks= 78},
                new Student{Name = "Leela", Marks= 100}
            };

            students.Sort();

            foreach(var s in students)
            {
                Console.WriteLine(s.Name +" "+s.Marks);
            }
        }
    }
}
