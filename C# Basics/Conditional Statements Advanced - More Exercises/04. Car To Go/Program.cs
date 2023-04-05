using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string type = "";
            string classs = "";
            double price = 0;

            if (budget > 500)
            {
                type = "Jeep";
                classs = "Luxury class";
                price = budget * 0.9;
            }
            else if (budget <= 100)
            {
                if (season == "Summer") 
                {
                    type = "Cabrio";
                    classs = "Economy class";
                    price = budget * 0.35;
                }else if (season == "Winter")
                {
                    type = "Jeep";
                    classs = "Economy class";
                    price = budget * 0.65;
                }

            }
            else if (budget <= 500)
            {
                if (season == "Summer")
                {
                    type = "Cabrio";
                    classs = "Compact class";
                    price = budget * 0.45;
                }
                else if (season == "Winter")
                {
                    type = "Jeep";
                    classs = "Compact class";
                    price = budget * 0.80;
                }
            }

            Console.WriteLine($"{classs}");
            Console.WriteLine($"{type} - {price:f2}");

        }
    }
}