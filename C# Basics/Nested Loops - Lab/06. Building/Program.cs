using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floorMax = int.Parse(Console.ReadLine());
            int apartmentMax = int.Parse(Console.ReadLine());
            

            for (int floor = floorMax; 1 <= floor; floor--)
            {
                for (int apartment = 0; apartment < apartmentMax; apartment++)
                {
                    if (floor == floorMax)
                    {
                        Console.Write($"L{floor}{apartment} ");
                    }else if (floor % 2 == 0)
                    {
                        Console.Write($"O{floor}{apartment} ");
                    }else if (floor % 2 == 1)
                    {
                        Console.Write($"A{floor}{apartment} ");
                    }

                }
                Console.WriteLine();
            }


        }
    }
}