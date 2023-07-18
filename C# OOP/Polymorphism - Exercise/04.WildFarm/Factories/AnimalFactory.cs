using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Factories.Interfaces;
using WildFarm.Models.Animals;
using WildFarm.Models.Interfaces;

namespace WildFarm.Factories
{
    public class AnimalFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal(string[] animalInput)
        {
            string animalType = animalInput[0];
            string animalName = animalInput[1];
            double animalWeight = double.Parse(animalInput[2]);

            double wingSize;
            string livingRegion;
            string breed;

            switch (animalType)
            {
                case "Owl":
                    wingSize = double.Parse(animalInput[3]);
                    return new Owl(animalName, animalWeight, wingSize);
                case "Hen":
                    wingSize = double.Parse(animalInput[3]);
                    return new Hen(animalName, animalWeight, wingSize);
                case "Mouse":
                    livingRegion = animalInput[3];
                    return new Mouse(animalName, animalWeight, livingRegion);
                case "Dog":
                    livingRegion = animalInput[3];
                    return new Dog(animalName, animalWeight, livingRegion);
                case "Cat":
                    livingRegion = animalInput[3];
                    breed = animalInput[4];
                    return new Cat(animalName, animalWeight, livingRegion, breed);
                case "Tiger":
                    livingRegion = animalInput[3];
                    breed = animalInput[4];
                    return new Tiger(animalName, animalWeight, livingRegion, breed);
                default:
                    throw new ArgumentException("Invalid animal type");
            }
        }
    }
}
