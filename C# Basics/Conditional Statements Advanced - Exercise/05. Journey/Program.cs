using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string typeOfDecation = "";
            double cost = 1;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    typeOfDecation = "Camp";
                    cost = cost * 0.3;
                }else if (season == "winter")
                {
                    typeOfDecation = "Hotel";
                    cost = cost * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    typeOfDecation = "Camp";
                    cost = cost * 0.4;
                }
                else if (season == "winter")
                {
                    typeOfDecation = "Hotel";
                    cost = cost * 0.8;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                typeOfDecation = "Hotel";
                cost = cost * 0.9;
            }
            double totalCost = budget * cost;

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfDecation} - {totalCost:f2}");

        }
    }
}