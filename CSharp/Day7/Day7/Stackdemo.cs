using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Stackdemo
    {
        static void Main()
        {
            Stack<int> st = new Stack<int>();
            st.Push(90);
            st.Push(99);
            st.Push(45);
            st.Push(56);

            Console.WriteLine($"pop :{st.Pop()}");

            foreach(var item in st)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"peek :{st.Peek()}");

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
        }
    }
}
