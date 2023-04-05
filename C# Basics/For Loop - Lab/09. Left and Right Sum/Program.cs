using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstSum = 0;
            int secondSum = 0;

            for (int i = 0; i < n; i++)
            {
                int firstNum = int.Parse(Console.ReadLine());
                firstSum += firstNum;
            }

            for (int i = 0; i < n; i++)
            {
                int secondNum = int.Parse(Console.ReadLine());
                secondSum += secondNum;
            }

            if (firstSum == secondSum)
            {
                Console.WriteLine($"Yes, sum = {firstSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(firstSum - secondSum)}");
            }


        }
    }
}