using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    class Program
    {
        static MymodelContainer db = new MymodelContainer();
        static void Main(string[] args)
        {
            var m = db.Manufacturers.ToList();

            foreach(var item in m)
            {
                Console.WriteLine($"{item.Mfr_ID}, {item.Mfr_Name}");
            }
            Console.Read();
        }
    }
}
