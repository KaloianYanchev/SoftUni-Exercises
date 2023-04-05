using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double total = 0;
            int grade = 1;
            int fails = 0;

            while (grade <= 12)
            {
                if (fails == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {grade} grade");
                    return;
                }
                double currentGrade = double.Parse(Console.ReadLine());
                
                if (currentGrade >= 4)
                {
                    grade++;
                    total += currentGrade; 
                }else if (currentGrade < 4)
                {
                    fails++;
                }

            }
            double average = total / (grade-1);
            Console.WriteLine($"{name} graduated. Average grade: {average:f2}");

        }
    }
}