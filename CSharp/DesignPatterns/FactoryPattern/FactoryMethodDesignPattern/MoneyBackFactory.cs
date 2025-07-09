using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodDesignPattern.NewImplementors;

namespace FactoryMethodDesignPattern
{
    public class MoneyBackFactory : NewCreditCardFactory
    {
        protected override ICreditCardNew MakeProduct()
        {
            ICreditCardNew MBCard = new MoneyBack();
            return MBCard;
        }
    }
}
