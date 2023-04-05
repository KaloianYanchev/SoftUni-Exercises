using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            double tournamentPoints = 0;
            double wins = 0;

            for (int i = 0; i < n; i++)
            {
                string position = Console.ReadLine();

                if (position == "W")
                {
                    tournamentPoints += 2000;
                    wins++;
                }
                else if(position == "F")
                {
                    tournamentPoints += 1200;
                }
                else if(position == "SF")
                {
                    tournamentPoints += 720;
                }

            }

            double totalPoints = tournamentPoints + startingPoints;

            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(tournamentPoints / n)}");
            Console.WriteLine($"{wins/n*100:f2}%");


        }
    }
}