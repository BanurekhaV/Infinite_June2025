using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class SportsBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching Sports Bike Details...");
        }
    }
}
