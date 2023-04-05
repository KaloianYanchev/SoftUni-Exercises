using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double waterPrice = 20;
            double internetPrice = 15;
            

            double electricity = 0;
            double water = 0;
            double internet = 0;
            double other = 0;

            for (int i = 0; i < n; i++)
            {
                double electricityPrice = double.Parse(Console.ReadLine());
                other += (electricityPrice + waterPrice + internetPrice) * 1.2;
                electricity += electricityPrice;
                water += waterPrice;
                internet += internetPrice;
            }
            double totalCost = electricity + water + internet + other;

            Console.WriteLine($"Electricity: {electricity:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {other:f2} lv");
            Console.WriteLine($"Average: {totalCost/n:f2} lv");

        }
    }
}