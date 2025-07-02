using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Csharp
{
    partial class Employee 
    {
        public Employee() {
           
        }
        Employee(int x) { }
        static Employee() { }
        
        public void f1() 
        {
            myStatic.method1();
            Myseal ms = new Myseal();
            ms.sealMethod();
        }

        //partial void Add(ref int i)
        //{
        //    Console.WriteLine("Add Defined here...");
        //}
        
    }

    static class myStatic
    {
        public static void method1()
        {
            Console.WriteLine("Static");
            
        }
    }

    sealed class Myseal
    {
        public void sealMethod()
        {
            Console.WriteLine("It is sealed");
        }
    }

    abstract class myAbstract
    {
        public abstract void abstractMethod();
    }

    class subType : myAbstract
    {
        public override void abstractMethod()
        {
            Console.WriteLine("This is the abstract implementation");                      
        }

        public void callAbstract()
        {
            myAbstract ma = new subType();
            ma.abstractMethod();
        }
    }
}
