using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int fans = int.Parse(Console.ReadLine());

            double sectorA = 0;
            double sectorB = 0;
            double sectorV = 0;
            double sectorG = 0;
            double totalFans = 0;

            

            for (int i = 0; i < fans; i++)
            {
                char sector = char.Parse(Console.ReadLine());


                if (sector == 'A')
                {
                    sectorA++;
                    totalFans++;
                }
                else if (sector == 'B')
                {
                    sectorB++;
                    totalFans++;
                }
                else if (sector == 'V')
                {
                    sectorV++;
                    totalFans++;
                }
                else if (sector == 'G')
                {
                    sectorG++;
                    totalFans++;
                }


            }


            Console.WriteLine($"{sectorA / totalFans * 100:f2}%");
            Console.WriteLine($"{sectorB / totalFans * 100:f2}%");
            Console.WriteLine($"{sectorV / totalFans * 100:f2}%");
            Console.WriteLine($"{sectorG / totalFans * 100:f2}%");
            Console.WriteLine($"{totalFans / capacity*100:f2}%");

        }
    }
}