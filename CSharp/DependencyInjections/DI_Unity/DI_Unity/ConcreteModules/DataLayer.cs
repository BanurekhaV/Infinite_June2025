using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Unity.ConcreteModules
{
    class DataLayer : IProducts
    {
        public string InsertProducts()
        {
            string str = "DI Injected Successfully";
            Console.WriteLine(str);
            return str;
        }
    }
}
