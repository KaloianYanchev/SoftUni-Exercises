using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int failLimit = int.Parse(Console.ReadLine());

            string name = "";
            string input = "";
            double gradeSum = 0;
            int failCount = 0;
            int problemCount = 0;

            while ((input = Console.ReadLine()) != "Enough")
            {
                name = input;
                double currentGrade = double.Parse(Console.ReadLine());
                gradeSum += currentGrade;
                problemCount++;
                if (currentGrade <= 4)
                {
                    failCount++;
                    if (failCount == failLimit)
                    {
                        Console.WriteLine($"You need a break, {failCount} poor grades.");
                        return;
                    }
                }
            }

            double average = gradeSum / problemCount;

            Console.WriteLine($"Average score: {average:f2}");
            Console.WriteLine($"Number of problems: {problemCount}");
            Console.WriteLine($"Last problem: {name}");

        }
    }
}