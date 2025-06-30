using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class NonGenericCollection
    {
        static void ArrayListDemo()
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add("hi");
            al.Add(78.90);
            al.Add(true);

            Console.WriteLine($"Capacity:{al.Capacity}");

            Console.WriteLine($"Count:{al.Count}");
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"indexof:{al.IndexOf(2)}");

            al.RemoveAt(1);
            al.Add("sai");
            al.Add("90");

            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Capacity:{al.Capacity}");

            Console.WriteLine($"Count:{al.Count}");
        }


        static void HashtableDemo()
        {
            Hashtable ht = new Hashtable();
            ht.Add("Sai", "B");
            ht.Add("John", "A");
            ht.Add("Nithi", "B");
            ht.Add("Shiva", "C");
            //ht.Add(null, "O");

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + " " +item.Value);
            }

            Console.WriteLine("ContainsValue:"+ht.ContainsValue("A"));
            //display the students from A grade

            foreach(DictionaryEntry item in ht)
            {
                 if(item.Value.Equals("A"))
                {
                    Console.WriteLine(item.Key);
                }
            }

        }


        static void SortedListDemo()
        {
            SortedList st = new SortedList();
            st.Add("Sai", "B");
            st.Add("John", "A");
            st.Add("Nithi", "B");
            st.Add("Shiva", "C");
           // st.Add(null, "P");

            foreach(DictionaryEntry de in st)
            {
                Console.WriteLine(de.Key + " "+de.Value );
            }
        }
        public static void Main()
        {
            //ArrayListDemo();
            HashtableDemo();
           // SortedListDemo();
        }
    }
}
