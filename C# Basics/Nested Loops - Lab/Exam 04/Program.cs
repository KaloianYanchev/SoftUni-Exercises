using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double totalLiters = 0;
            double totalDegrees = 0;

            for (int i = 0; i < n; i++)
            {
                double currentLiter = double.Parse(Console.ReadLine());
                totalLiters += currentLiter;
                totalDegrees += (double.Parse(Console.ReadLine()) * currentLiter);
            }
            double averageDegrees = totalDegrees / totalLiters;

            Console.WriteLine($"Liter: {totalLiters:f2}");
            Console.WriteLine($"Degrees: {averageDegrees:f2}");
            if (averageDegrees < 38)
            {
                Console.WriteLine($"Not good, you should baking!");
            }else if (averageDegrees < 42)
            {
                Console.WriteLine($"Super!");
            }else if (averageDegrees > 42)
            {
                Console.WriteLine($"Dilution with distilled water!");
            }

        }
    }
}