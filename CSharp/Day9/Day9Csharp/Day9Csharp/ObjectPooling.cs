using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Csharp
{

    class StudentFactory
    {
        //Pool size for maximum objects

        static int MaxPoolSize = 3;
        static readonly Queue objPool = new Queue(MaxPoolSize);

        public Student GetStudent()
        {
            Student stdobj;
            //check from the Q collection pool. if exists, return the object else create new 
            if(Student.objcounter >= MaxPoolSize && objPool.Count > 0)
            {
                stdobj = RetriveFromPool();
            }
            else
            {
                stdobj = GetNewStudent();
            }
            return stdobj;
        }

        Student GetNewStudent()
        {
            //Create a new student object
            Student s = new Student();
            objPool.Enqueue(s);
            return s;
        }

        protected Student RetriveFromPool()
        {
            Student s1;
            //check if there are any objects in the Q collection

            if(objPool.Count > 0)
            {
                s1 = (Student)objPool.Dequeue();
                Student.objcounter--;
            }
            else
            {
                //Return a new object
                s1 = new Student();
            }
            return s1;
        }
    } 
    class Student
    {
        public static int objcounter = 0;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Class { get; set; }
        public int RollNo { get; set; }
        public Student()
        {
            ++objcounter;
        }
        
    }
    class ObjectPooling
    {
        static void Main()
        {
            StudentFactory stdfac = new StudentFactory();
            Student student = stdfac.GetStudent();
            Console.WriteLine("*****************");
            Console.WriteLine("First Object");

            Student student1 = stdfac.GetStudent();
            Console.WriteLine("*****************");
            Console.WriteLine("Second Object");

            Student student2 = stdfac.GetStudent();
            Console.WriteLine("*****************");
            Console.WriteLine("Third Object");

            Student student3 = stdfac.GetStudent();
            Console.WriteLine("*****************");
            Console.WriteLine("Fourth Object");
            
            Console.Read();
        }
    }
}
