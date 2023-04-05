using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double skumriqPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            int midiKg = int.Parse(Console.ReadLine());

            double palamudPrice = skumriqPrice + skumriqPrice * 0.6;
            double safridPrice = cacaPrice + cacaPrice * 0.8;
            double midiPrice = 7.5;

            double totalFish = palamudKg * palamudPrice + safridKg * safridPrice + midiKg * midiPrice;

            Console.WriteLine($"{totalFish:f2}");



        }
    }
}