using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = "";
            double totalAverageGrade = 0;
            double examCount = 0;

            while ((input = Console.ReadLine()) != "Finish")
            {
                examCount++;
                string name = input;
                double grade = 0;
                double currentAverageGrade = 0;
                for (int i = 0; i < n; i++)
                {
                    grade += double.Parse(Console.ReadLine());
                }
                currentAverageGrade = grade / n;
                totalAverageGrade += currentAverageGrade;
                Console.WriteLine($"{name} - {currentAverageGrade:f2}.");

            }

            Console.WriteLine($"Student's final assessment is {totalAverageGrade / examCount:f2}.");
        }
    }
}