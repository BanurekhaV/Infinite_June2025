using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Unity
{
    //Interface 1
    public interface IProducts
    {
        string InsertProducts();
    }

    //interface 2
    public interface IOrders
    {
        void DisplayOrders();
    }
}
