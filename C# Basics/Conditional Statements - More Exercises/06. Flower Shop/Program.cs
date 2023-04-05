using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magnoli = int.Parse(Console.ReadLine());
            int yorbovani = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactuses = int.Parse(Console.ReadLine());
            double priceOfGift = double.Parse(Console.ReadLine());

            double profit = magnoli * 3.25 + yorbovani * 4 + roses * 3.5 + cactuses * 8;
            double finalProfit = profit - profit * 0.05;

            if (finalProfit >= priceOfGift)
            {
                double difference = finalProfit - priceOfGift;
                Console.WriteLine($"She is left with {Math.Floor(difference)} leva.");
            }
            else
            {
                double difference = priceOfGift - finalProfit;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(difference)} leva.");
            }
        }
    }



}