using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            double price = 0;
            double transport = 0;

            if (type == "VIP")
            {
                price = 499.99;
            }else if (type == "Normal")
            {
                price = 249.99;
            }
            if (n >= 1 && n < 5)
            {
                transport = budget * 0.75;

            }else if (n >= 5 && n < 10)
            {
                transport = budget * 0.60;

            }else if (n >= 10 && n < 25)
            {
                transport = budget * 0.50;
            }
            else if (n >= 25 && n < 50)
            {
                transport = budget * 0.40;
            }
            else if (n >= 50)
            {
                transport = budget * 0.25;
            }

            double totalCost = transport + price * n;
            double differance = budget - totalCost;

            if (differance >= 0)
            {
                Console.WriteLine($"Yes! You have {differance:f2} leva left.");
            }else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(differance):f2} leva.");
            }

        }
    }
}