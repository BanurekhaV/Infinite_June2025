using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentCourse { get; set; }
        public int StudentMark { get; set; }

        List<Student> studentsList = new List<Student>();

        //adding one student at a time
        internal void AddStudent(Student student)
        {
            studentsList.Add(student);
        }

        //Display the student

        internal List<Student> DisplayStudent()
        {
            return studentsList;
        }

        //Get student by course

        internal List<Student> GetStudentsByCourse(string course)
        {
            List<Student> students = new List<Student>();

            foreach(var student in studentsList)
            {
                if(student.StudentCourse == course)
                {
                    students.Add(student);

                }
            }

            return students;
        }

    }
    class ListDemo
    {
        static void Main()
        {
           // ArrayList al = new ArrayList();
            //al.Add(90); //boxing

            List<string> booksList = new List<string>();

            Student student = new Student();

            List<Student> studentData = new List<Student>();

            //Add the student

            student.AddStudent(new Student { StudentId = 1, StudentName = "Hari", StudentCourse = "IT", StudentMark = 98 });
            student.AddStudent(new Student { StudentId = 2, StudentName = "Nila", StudentCourse = "IT", StudentMark = 78 });
            student.AddStudent(new Student { StudentId = 3, StudentName = "Suman", StudentCourse = "CSE", StudentMark = 67 });
            student.AddStudent(new Student { StudentId = 4, StudentName = "John", StudentCourse = "ECE", StudentMark = 90 });

            //display the student

             studentData = student.DisplayStudent();
            Console.WriteLine("------------------Display Student---------------------");
            foreach(var item in studentData)
            {
                Console.WriteLine($"ID:{item.StudentId + " "+item.StudentName + " "+item.StudentCourse }");
            }

            Console.WriteLine("------------------Display Student by course---------------------");
            //Display the student by course
            studentData = student.GetStudentsByCourse("IT");
            foreach (var item in studentData)
            {
                Console.WriteLine($"ID:{item.StudentId + " " + item.StudentName + " " + item.StudentCourse }");
            }
        }
    }
}
