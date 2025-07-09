using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Factory Type :");
            string FactoryType = Console.ReadLine();
            ICreditCardNew newCard = null;

            if(FactoryType=="PlatinumFactory")
            {
                newCard = new PlatinumFactory().CreateProduct();
            }
            else if(FactoryType.Equals("TitaniumFactory"))
            {
                newCard = new TitaniumFactory().CreateProduct();
            }
            else if(FactoryType.Equals("MoneyBackFactory"))
            {
                newCard = new MoneyBackFactory().CreateProduct();
            }

            if(newCard!=null)
            {
               
                    Console.WriteLine("Card Type :  " + newCard.GetCardType());
                    Console.WriteLine("Credit Limit : " + newCard.GetCardLimit());
                    Console.WriteLine("Annual Charges : " + newCard.GetAnnualCharges());
            }
            else
                {
                    Console.WriteLine("Invalid Card Type ..");
                }

            Console.Read();
            }
        }
    }

