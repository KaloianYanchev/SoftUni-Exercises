using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstDigitRange = int.Parse(Console.ReadLine());
            int secondDigitRange = int.Parse(Console.ReadLine());
            int thirdDigitRange = int.Parse(Console.ReadLine());

            for (int i = 1; i <= firstDigitRange; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 1; j <= secondDigitRange; j++)
                    {
                        if (j == 2 || j  == 3 || j == 5 || j == 7) 
                        {
                            for (int k = 1; k <= thirdDigitRange; k++)
                            {
                                if (k % 2 == 0)
                                {
                                    Console.WriteLine($"{i} {j} {k}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}