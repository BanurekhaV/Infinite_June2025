using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOQ_Project
{
    public class Cart
    {
        private readonly IProductRepository _productRepository;

        private readonly Dictionary<int, int> items;

        public Cart(IProductRepository productRepository)
        {
            _productRepository = productRepository;            
        }
    }
}
