using System;


namespace FirstDotnet_Prj
{    
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hi and Welcome to DotNet..");
                Student student = new Student();
                student.Myfunction();
                Console.Read();
            }
        }            
}
