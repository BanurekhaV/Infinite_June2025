using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_2
{
    class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string animalType)
        {
            if (animalType.Equals("Dog"))
            {
                return new Dog();
            }
            else if (animalType.Equals("Cat"))
            {
                return new Cat();
            }
            else
                return null;
        }

    }
}
