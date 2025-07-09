using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Implementors;

namespace FactoryPattern
{
    public class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard cardDetails = null;
            if (cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();
            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }
            else if (cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }
            return cardDetails;
        }
    }
}
