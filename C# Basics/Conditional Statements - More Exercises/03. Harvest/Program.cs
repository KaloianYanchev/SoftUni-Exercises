using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            double grapePerMeter = double.Parse(Console.ReadLine());
            int wineNeeded = int.Parse(Console.ReadLine());
            int workerCount = int.Parse(Console.ReadLine());

            double fieldSizeForWine = fieldSize * 0.40;
            double totalProduce = fieldSizeForWine * grapePerMeter / 2.5;

            if (totalProduce < wineNeeded)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineNeeded - totalProduce)} liters wine needed.");
            }
            else
            {
                double difference = totalProduce - wineNeeded;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(totalProduce)} liters.");
                Console.WriteLine($"{Math.Ceiling(difference)} liters left -> {Math.Ceiling(difference / workerCount)} liters per person.");
            }





        }
    }
}