using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceOfTrip = double.Parse(Console.ReadLine());
            int numberOfPuzzle = int.Parse(Console.ReadLine());
            int numberOfDolls = int.Parse(Console.ReadLine());
            int numberOfBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());

            double puzzlePrice = 2.60;
            double dollPrice = 3;
            double bearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2;

            int numberOfToys = numberOfPuzzle + numberOfDolls + numberOfBears + numberOfMinions + numberOfTrucks;
            double totalSale = numberOfPuzzle * puzzlePrice + numberOfDolls * dollPrice + numberOfBears * bearPrice + numberOfMinions * minionPrice + numberOfTrucks * truckPrice;

            if (numberOfToys >= 50)
            {
                totalSale *= 0.75;
            }

            double finalProfit = totalSale * 0.9;

            if (finalProfit >= priceOfTrip)
            {
                Console.WriteLine($"Yes! {(finalProfit - priceOfTrip):f2} lv left.");
            }
            else
                Console.WriteLine($"Not enough money! {(priceOfTrip - finalProfit):f2} lv needed.");


        }
    }
}