using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double bus = 0;
            double truck = 0;
            double train = 0;
            double totalTons = 0;


            for (int i = 0; i < n; i++)
            {
                int tons = int.Parse(Console.ReadLine());
                totalTons += tons;
                if (tons <= 3)
                {
                    bus += tons;
                }
                else if (tons <= 11)
                {
                    truck += tons;
                }
                else if (tons >= 12)
                {
                    train += tons;
                }


            }

            Console.WriteLine($"{(bus * 200 + truck * 175 + train * 120) / totalTons:f2}");
            Console.WriteLine($"{bus / totalTons * 100:f2}%");
            Console.WriteLine($"{truck / totalTons * 100:f2}%");
            Console.WriteLine($"{train / totalTons * 100:f2}%");
        }
    }
}