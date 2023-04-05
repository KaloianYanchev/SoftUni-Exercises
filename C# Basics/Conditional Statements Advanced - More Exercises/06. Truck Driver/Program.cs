using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double km = double.Parse(Console.ReadLine());

            double price = 0;

            if (km <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    price = 0.75;
                }
                else if (season == "Summer")
                {
                    price = 0.90;
                }
                else if (season == "Winter")
                {
                    price = 1.05;
                }
            }
            else if (km <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    price = 0.95;
                }
                else if (season == "Summer")
                {
                    price = 1.10;
                }
                else if (season == "Winter")
                {
                    price = 1.25;
                }
            }
            else if (km < 20000)
            {
                price = 1.45;
            }

            double totalMoney = (4 * km * price);
            totalMoney -= totalMoney * 0.10;

            Console.WriteLine($"{totalMoney:f2}");

        }
    }
}