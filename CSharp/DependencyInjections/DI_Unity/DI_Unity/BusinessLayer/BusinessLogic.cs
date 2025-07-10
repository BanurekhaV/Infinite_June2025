using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Unity.BusinessLayer
{
    class BusinessLogic
    {
        IProducts _products;
        IOrders _orders;

        //injecting the base type that implements the interface in the constructor
        public BusinessLogic(IProducts ip, IOrders io)
        {
            _products = ip;
            _orders = io;
        }

        public void Insert()
        {
            _products.InsertProducts();

            _orders.DisplayOrders();
        }
    }
}
