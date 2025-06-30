using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Day7
{
    class Dictionary
    {
        static void Main()
        {
            Dictionary<string, string> dt = new Dictionary<string, string>();
            dt.Add("Smith", "8901234567");
            dt.Add("Jane", "8901734567");
            dt.Add("Raj", "8989234567");
            dt.Add("Deo", "9901234567");
            dt.Add("Rashmi", "8901231267");
            dt.Add("Kiran", "9901234567");
            dt.Add("Nila", "8901234567");
            Console.WriteLine("--------------Display the user details starts with R------------");

            string patten = @"^[Rr]";

            foreach(var item in dt)
            {
                if(Regex.IsMatch(item.Key,patten))
                {
                    Console.WriteLine(item.Key+" "+item.Value);
                }
            }

        }
    }
}
