using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += input;
                }
                else
                {
                    sumOdd += input;
                }
            }

            int differance = Math.Abs(sumEven - sumOdd);

            if (differance == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumOdd}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {differance}");
            }

        }
    }
}