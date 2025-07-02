using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPrj
{
    public class LibClass
    {
        public string Greetings()
        {
            return "Hi and Welcome to Library Projects..";
        }

        public float CalculateTax(float Salary)
        {
            return Salary * 30 / 100;
        }           
        
    }
}
