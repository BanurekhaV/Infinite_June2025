using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_2
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(string animalType);

        public static AnimalFactory CreateAnimalFactory(string factoryType)
        {
            if (factoryType.Equals("Land"))
            {
                return new LandAnimalFactory();
            }
            else if (factoryType.Equals("Sea"))
            {
                return new SeaAnimalFactory();
            }
            else
                return null;
        }
    }
}
