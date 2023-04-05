using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double dogFoodPerDay = double.Parse(Console.ReadLine());
            double catFoodPerDay = double.Parse(Console.ReadLine());
            double turtleFoodInGrammsPerDay = double.Parse(Console.ReadLine());

            double turtleFoodPerDay = turtleFoodInGrammsPerDay / 1000;

            double totalFood = days * (dogFoodPerDay + catFoodPerDay + turtleFoodPerDay);
            double difference = foodLeft - totalFood;

            if (difference >= 0)
            {
                Console.WriteLine($"{Math.Floor(difference)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(Math.Floor(difference))} more kilos of food are needed.");
            }
            
            

        }
    }
}