using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Factories.Interfaces;
using WildFarm.Models.Food;
using WildFarm.Models.Interfaces;

namespace WildFarm.Factories
{
    public class FoodFactory : IFoodFactory
    {
        public IFood CreateFood(string[] foodInput)
        {
            string foodType = foodInput[0];
            int foodQuantity = int.Parse(foodInput[1]);

            switch (foodType)
            {
                case "Vegetable":
                    return new Vegetable(foodQuantity);
                case "Fruit":
                    return new Fruit(foodQuantity);
                case "Meat":
                    return new Meat(foodQuantity);
                case "Seeds":
                    return new Seeds(foodQuantity);
                default:
                    throw new ArgumentException("Invalid food type");
            }
        }
    }
}
