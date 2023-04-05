using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int controlNumber = int.Parse(Console.ReadLine());
            int fourthNumberCount = 0;
            string fourthNumber = "";
            string allNumbers = "";

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            int result = a * b + c * d;
                            if ((a < b) && (c > d) && (result == controlNumber))
                            {
                                allNumbers += ($"{a}{b}{c}{d} ");
                                fourthNumberCount++;
                                if (fourthNumberCount == 4)
                                {
                                    fourthNumber += ($"{a}{b}{c}{d}");
                                }
                            } 
                        }
                    }
                }
            }
            Console.WriteLine($"{allNumbers}".TrimEnd());
            if (fourthNumberCount >= 4)
            {
                Console.WriteLine($"Password: {fourthNumber}");
            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}