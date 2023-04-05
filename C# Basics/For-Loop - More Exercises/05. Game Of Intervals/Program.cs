using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double first = 0;
            double second = 0;
            double third = 0;
            double fourth = 0;
            double fifth = 0;
            double sixth = 0;
            double totalPoints = 0;

            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number >= 0 && number <= 9)
                {
                    first++;
                    totalPoints += number * 0.2;
                }
                else if (number >= 10 && number <= 19)
                {
                    second++;
                    totalPoints += number * 0.3;
                }
                else if (number >= 20 && number <= 29)
                {
                    third++;
                    totalPoints += number * 0.4;
                }
                else if (number >= 30 && number <= 39)
                {
                    fourth++;
                    totalPoints += 50;
                }
                else if (number >= 40 && number <= 50)
                {
                    fifth++;
                    totalPoints += 100;
                }
                else if (number < 0 || number > 50)
                {
                    sixth++;
                    totalPoints = totalPoints / 2;
                }
                        

            }

            Console.WriteLine($"{totalPoints:f2}");
            Console.WriteLine($"From 0 to 9: {first / n * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {second / n * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {third / n * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {fourth / n * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {fifth / n * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {sixth / n * 100:f2}%");
        }
    }
}