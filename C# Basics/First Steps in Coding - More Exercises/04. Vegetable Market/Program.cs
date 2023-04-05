using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vegetables = double.Parse(Console.ReadLine());
            double fruits = double.Parse(Console.ReadLine());
            int totalVegetables = int.Parse(Console.ReadLine());
            int totalFruits = int.Parse(Console.ReadLine());

            double leva = vegetables*totalVegetables + fruits*totalFruits;
            double euro = leva / 1.94;

            Console.WriteLine($"{euro:f2}");


        }
    }
}