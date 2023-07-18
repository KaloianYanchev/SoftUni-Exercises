using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models.Animals
{
    public abstract class Animal : IAnimal
    {
        private string name;
        private double weight;
        private int foodEaten;
        

        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get => name; private set => name = value; }

        public double Weight { get => weight; private set => weight = value; }

        public int FoodEaten { get => foodEaten; private set => foodEaten = value; }

        public abstract double WeightMultiplier { get; }

        protected abstract IReadOnlyCollection<Type> PreferredFoodTypes { get; }

        public void EatFood(IFood food)
        {
            if (!PreferredFoodTypes.Any(f => f == food.GetType()))
            {
                throw new ArgumentException($"{GetType().Name} does not eat {food.GetType().Name}!");
            }

            FoodEaten += food.Quantity;
            Weight += WeightMultiplier * FoodEaten;
        }
        
        public abstract string ProduceSound();

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, ";
        }

    }
}
