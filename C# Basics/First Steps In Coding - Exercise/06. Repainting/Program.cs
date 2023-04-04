using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nailonPrice = 1.50;
            double paintPrice = 14.50;
            double thinnerPrice = 5.00;

            int nailon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double totalMaterials = (nailon * nailonPrice + nailonPrice * 2) + (paint * paintPrice) + (paint * paintPrice * 0.1) + (thinner * thinnerPrice) + 0.40;
            double workerPricePerHour = totalMaterials * 0.30;

            double finalPrice = workerPricePerHour * hours;

            Console.WriteLine(finalPrice + totalMaterials);



        }
    }
}