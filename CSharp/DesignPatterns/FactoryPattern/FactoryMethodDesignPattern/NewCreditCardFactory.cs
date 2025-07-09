using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
   public abstract class NewCreditCardFactory
   {
        protected abstract ICreditCardNew MakeProduct();

        public ICreditCardNew CreateProduct()
        {
            //call the MakeProduct which will create and return the appropriate product object
            ICreditCardNew creditCard = this.MakeProduct();
            return creditCard;
        }
   }
}
