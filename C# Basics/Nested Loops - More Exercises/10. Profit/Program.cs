using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oneLevaCoinsCount = int.Parse(Console.ReadLine());
            int twoLevaCoinsCount = int.Parse(Console.ReadLine());
            int fiveLevaBankNotesCount = int.Parse(Console.ReadLine());
            int totalCost = int.Parse(Console.ReadLine());

            for (int i = 0; i <= oneLevaCoinsCount; i++)
            { 
                for (int j = 0; j <= twoLevaCoinsCount; j++)
                {
                    for (int k = 0; k <= fiveLevaBankNotesCount; k++)
                    {
                        if (totalCost == k * 5 + j * 2 + i * 1)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {totalCost} lv.");
                        }
                    }
                }
            }
        }
    }
}