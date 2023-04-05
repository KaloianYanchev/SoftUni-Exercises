using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budet = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            double totalCards = n * 250;
            double totalProccesor = m * totalCards * 0.35;
            double totalRam = p * totalCards * 0.1;

            double finalPrice = totalCards + totalProccesor + totalRam;

            if (n > m)
            {
                finalPrice *= 0.85;
            }
            if (budet >= finalPrice)
            {
                Console.WriteLine($"You have {budet - finalPrice:f2} leva left!");
            }
            else
                Console.WriteLine($"Not enough money! You need {finalPrice - budet:f2} leva more!");

        }

    }
}