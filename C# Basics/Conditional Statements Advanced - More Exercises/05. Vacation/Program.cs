using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string location = "";
            string type = "";
            double price = 0;

            if (budget <= 1000)
            {
                type = "Camp";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.65;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.45;
                }
            }
            else if (budget <= 3000)
            {
                type = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.80;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.60;
                }
            }
            else if (budget > 3000)
            {
                type = "Hotel";
                price = budget * 0.90;
                if (season == "Summer")
                {
                    location = "Alaska";
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                }
            }
            Console.WriteLine($"{location} - {type} - {price:f2}");

        }
    }
}