﻿using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = (Console.ReadLine());
            int fishers = int.Parse(Console.ReadLine());

            double price = 0;

            switch (season)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;
            }

            if (fishers <= 6)
            {
                price -= price * 0.1;
            }
            else if (fishers <= 11)
            {
                price -= price * 0.15;
            }
            else if (fishers > 12)
            {
                price -= price * 0.25;
            }

            if ((fishers % 2 == 0) && (season != "Autumn"))
            {
                price -= price * 0.05;

            }
            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
            }

        }
    }
}