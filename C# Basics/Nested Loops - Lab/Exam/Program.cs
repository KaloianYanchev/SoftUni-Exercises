using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double firstElk = double.Parse(Console.ReadLine());
            double secondElk = double.Parse(Console.ReadLine());
            double thirdElk = double.Parse(Console.ReadLine());

            double foodNeeded = days * (firstElk + secondElk + thirdElk);

            if (foodLeft >= foodNeeded)
            {
                Console.WriteLine($"{Math.Floor(foodLeft - foodNeeded)} kilos of food left.");
            }else
            {
                Console.WriteLine($"{Math.Ceiling(foodNeeded-foodLeft)} more kilos of food are needed.");
            }



        }
    }
}