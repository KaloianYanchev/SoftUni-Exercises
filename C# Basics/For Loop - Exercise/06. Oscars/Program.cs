using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double totalPoints = 0;

            string judge = "";
            double points = 0;

            for (int i = 0; i < n; i++)
            {

                judge = Console.ReadLine();
                points = double.Parse(Console.ReadLine());
                totalPoints += (judge.Length * points / 2);
                if (totalPoints + academyPoints >= 1250.50)
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {totalPoints + academyPoints:f1}!");
                    break;
                }

            }
            if (totalPoints + academyPoints < 1250.50)
            {
                Console.WriteLine($"Sorry, {actor} you need {1250.50 - totalPoints - academyPoints:f1} more!");
            }
        
        }
    }
}