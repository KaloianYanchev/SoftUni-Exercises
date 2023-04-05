using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            
            int allowedSpace = lenght * width * height;
            int boxes = 0;
            string input = "";

            while ((input = Console.ReadLine()) != "Done")
            {
                boxes += int.Parse(input);
                if (boxes > allowedSpace)
                {
                    Console.WriteLine($"No more free space! You need {boxes - allowedSpace} Cubic meters more.");
                    return;
                }
            }

            Console.WriteLine($"{allowedSpace - boxes} Cubic meters left.");

        }
    }
}