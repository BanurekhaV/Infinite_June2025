using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    public interface ICreditCardNew
    {
        string GetCardType();
        int GetCardLimit();
        float GetAnnualCharges();
    }
}
