using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Implementors
{
    public class Platinum : ICreditCard
    {
        public float GetAnnualCharges()
        {
            return 2000;
        }

        public int GetCardLimit()
        {
            return 35000;
        }

        public string GetCardType()
        {
           return "Platinum Plus";
        }
    }
}
