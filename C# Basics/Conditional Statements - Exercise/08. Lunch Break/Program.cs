using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string moovie = Console.ReadLine();
            int filmLenght = int.Parse(Console.ReadLine());
            int breakLenght = int.Parse(Console.ReadLine());

            double timeForLunch = breakLenght / 8.00;
            double timeForRest = breakLenght / 4.00;

            double totalTime = filmLenght + timeForLunch + timeForRest;

            if (breakLenght >= totalTime)
            {

                Console.WriteLine($"You have enough time to watch {moovie} and left with {Math.Ceiling(breakLenght-totalTime)} minutes free time.");
            }else
                Console.WriteLine($"You don't have enough time to watch {moovie}, you need {Math.Ceiling(totalTime-breakLenght)} more minutes.");

        }
    }
}