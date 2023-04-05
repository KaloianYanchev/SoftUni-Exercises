using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());
            double moneyNeeded = 0;


            for (int i = 1800; i <= yearToLive; i++)
            {
                if (i % 2 == 0)
                {
                    moneyNeeded += 12000;
                }
                else if (i % 2 == 1)
                {
                    moneyNeeded += 12000 + 50 * (18 + i - 1800);
                }
            }

            double differance = inheritedMoney - moneyNeeded;

            if (differance >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {differance:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(differance):f2} dollars to survive.");
            }

        }
    }
}