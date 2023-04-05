using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double weak = 0; //2.00 - 2.99
            double middle = 0; //3.00 - 3.99
            double above = 0; //4.00 - 4.99
            double best = 0; //> 5.00
            double average = 0;

            for (int i = 0; i < n; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                average += grade;

                if (grade <= 2.99 && grade >= 2)
                {
                    weak++;
                }
                else if (grade <= 3.99)
                {
                    middle++;
                }
                else if (grade <= 4.99)
                {
                    above++;
                }
                else if (grade >= 5.00)
                {
                    best++;
                }
            }

            Console.WriteLine($"Top students: {best/n*100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {above / n * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {middle / n * 100:f2}%");
            Console.WriteLine($"Fail: {weak / n *100:f2}%");
            Console.WriteLine($"Average: {average/n:f2}");



        }
    }
}