﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodDesignPattern.NewImplementors;

namespace FactoryMethodDesignPattern
{
    public class TitaniumFactory :NewCreditCardFactory
    {
        protected override ICreditCardNew MakeProduct()
        {
            ICreditCardNew TCard = new Titanium();
            return TCard;
        }
    }
}
