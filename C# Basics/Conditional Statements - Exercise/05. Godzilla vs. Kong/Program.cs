using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statist = int.Parse(Console.ReadLine());
            double costumePrice = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;
            double clothingPrice = statist * costumePrice;

            if (statist > 150)
            {
                clothingPrice *= 0.9;
            }
            double totalCost = clothingPrice + decor;

            if (totalCost <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalCost:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalCost-budget:f2} leva more.");
            }
                


        }
    }
}