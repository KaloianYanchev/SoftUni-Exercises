using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char holiDay = char.Parse(Console.ReadLine());

            double priceOfChrysanthemums = 0;
            double priceOfRoses = 0;
            double priceOfTulips = 0;
            int totalFlowers = chrysanthemums + roses + tulips;


            if (season == "Spring" || season == "Summer")
            {
                priceOfChrysanthemums = 2;
                priceOfRoses = 4.10;
                priceOfTulips = 2.50;
            }else if (season == "Autumn" || season == "Winter")
            {
                priceOfChrysanthemums = 3.75;
                priceOfRoses = 4.50;
                priceOfTulips = 4.15;
            }
            double priceOfFlowers = chrysanthemums * priceOfChrysanthemums + roses * priceOfRoses + tulips * priceOfTulips;

            if (holiDay == 'Y')
            {
                priceOfFlowers += priceOfFlowers * 0.15;
            }
            if (tulips > 7 && season == "Spring")
            {
                priceOfFlowers -= priceOfFlowers * 0.05;
            }
            if (roses >= 10 && season == "Winter")
            {
                priceOfFlowers -= priceOfFlowers * 0.10;
            }
            if (totalFlowers > 20)
            {
                priceOfFlowers -= priceOfFlowers * 0.20;
            }

            Console.WriteLine($"{priceOfFlowers +2:f2}");


        }
    }
}