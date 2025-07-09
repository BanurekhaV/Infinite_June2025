using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodDesignPattern.NewImplementors;

namespace FactoryMethodDesignPattern
{
    public class PlatinumFactory : NewCreditCardFactory
    {
        protected override ICreditCardNew MakeProduct()
        {
            ICreditCardNew PCard = new Platinum();
            return PCard;
        }
    }
}
