using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.NewImplementors
{
    class ProductClasses
    {
    }

    public class MoneyBack : ICreditCardNew
    {
        public float GetAnnualCharges()
        {
            return 500.0f;
        }

        public int GetCardLimit()
        {
            return 15000;
        }

        public string GetCardType()
        {
            return "MoneyBack";
        }
    }

    public class Titanium : ICreditCardNew
    {
        public float GetAnnualCharges()
        {
            return 1500.0f;
        }

        public int GetCardLimit()
        {
            return 25000;
        }

        public string GetCardType()
        {
            return "Titanium Super";
        }
    }

    public class Platinum : ICreditCardNew
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
