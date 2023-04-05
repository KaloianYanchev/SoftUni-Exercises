using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fluid = int.Parse(Console.ReadLine());
            fluid = fluid * 750;

            string input = "";
            int pansCleaned = 0;
            int dishesCleaned = 0;
            int dishwasherCycles = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                dishwasherCycles++;
                if (dishwasherCycles % 3 == 0)
                {
                    pansCleaned += int.Parse(input);
                    fluid -= int.Parse(input) * 15;
                }
                else if (dishwasherCycles % 3 != 0)
                {
                    dishesCleaned += int.Parse(input);
                    fluid -= int.Parse(input) * 5;
                }
                if (fluid < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(fluid)} ml. more necessary!");
                    return;

                }
            }
            Console.WriteLine("Detergent was enough!");
            Console.WriteLine($"{dishesCleaned} dishes and {pansCleaned} pots were washed.");
            Console.WriteLine($"Leftover detergent {fluid} ml.");


        }
    }
}