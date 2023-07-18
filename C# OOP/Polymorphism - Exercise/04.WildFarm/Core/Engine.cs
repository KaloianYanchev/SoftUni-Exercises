using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Core.Interfaces;
using WildFarm.Factories;
using WildFarm.Factories.Interfaces;
using WildFarm.IO.Interfaces;
using WildFarm.Models.Interfaces;

namespace WildFarm.Core
{
    public class Engine : IEngine
    {
        private readonly ICollection<IAnimal> animals = new List<IAnimal>();
        private IReader reader;
        private IWriter writer;
        private IAnimalFactory animalFactory;
        private IFoodFactory foodFactory;

        public Engine(IReader reader, IWriter writer, IAnimalFactory animalFactory, IFoodFactory foodFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.animalFactory = animalFactory;
            this.foodFactory = foodFactory;
        }

        public void Run()
        {
            while (true)
            {
                string[] animalInput = reader.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (animalInput[0] == "End")
                {
                    break;
                }

                string[] foodInput = reader.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    IFoodFactory foodFactory = new FoodFactory();
                    IAnimalFactory animalFactory = new AnimalFactory();

                    IFood currentFood = foodFactory.CreateFood(foodInput);
                    IAnimal currentAnimal = animalFactory.CreateAnimal(animalInput);

                    animals.Add(currentAnimal);

                    Console.ForegroundColor = ConsoleColor.Green; // Changes ConsoleColors for easier reading xD
                    Console.WriteLine(currentAnimal.ProduceSound());
                    Console.ForegroundColor = ConsoleColor.Red;
                    currentAnimal.EatFood(currentFood);
                    Console.ResetColor();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            }

            foreach (IAnimal animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
