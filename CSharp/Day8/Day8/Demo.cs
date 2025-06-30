using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class MyCollection 
    {
        public static IEnumerable<int> GetEvenNumber(IEnumerable<int> numbers)
        {
            foreach(int number in numbers )
            {
                if(number %2 == 0)
                {
                   yield return number;
                }
            }
        }
    }
    class Demo
    {
        static void Main()
        {

           // List<int> nums = new List<int> { 1, 2, 4, 5, 8, 90, 67 };

            //Read only
            IEnumerable<int> nums = new List<int> { 1, 2, 4, 5, 8, 90, 67 };           

           IEnumerable<int> evennum = MyCollection.GetEvenNumber(nums);

            foreach(int n in evennum)
            {
                Console.WriteLine($"EvenNumber:{n}");
            }


            //IList - add/Remove/index

            IList<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Orange");
            fruits.Add("grapes");
            fruits.Remove("Orange");
            
        }
    }
}
