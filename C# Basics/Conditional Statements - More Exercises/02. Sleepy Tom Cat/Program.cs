using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int offDays = int.Parse(Console.ReadLine());

            int workingDays = 365 - offDays;

            int playTime = offDays*127 + workingDays*63;

            if (playTime > 30000)
            {
                int difference = playTime - 30000;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{difference/60} hours and {difference%60} minutes more for play");
            }
            else
            {
                int difference = 30000 - playTime;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{difference / 60} hours and {difference % 60} minutes less for play");

            }
                

        }
    }
}