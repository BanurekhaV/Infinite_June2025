using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class RegularBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching Regular Bike Details...");
        }
    }
}
