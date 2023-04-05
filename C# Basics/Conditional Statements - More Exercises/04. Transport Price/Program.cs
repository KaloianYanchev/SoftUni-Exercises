using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            if (distance >= 100)
            {
                Console.WriteLine($"{distance * 0.06:f2}");
            }

            if (distance < 20)
            {
                if (timeOfDay == "day")
                {
                    Console.WriteLine($"{distance * 0.79 + 0.7:f2}");
                }
                else if (timeOfDay == "night")
                {
                    Console.WriteLine($"{distance * 0.90 + 0.7:f2}");
                }
            }

            else if (distance < 100)
            {
                Console.WriteLine($"{distance * 0.09:f2}");
            }
        }
    }
}