using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            double bonus = 0;
            double secondBonus = 0;

            if (points <= 100)
            {
                bonus = 5;
            }else if (points > 1000)
            {
                bonus = points * 0.1;
            }else if (points > 100)
            {
                bonus = (points * 0.2);
            }

            if (points % 2 == 0)
            {
                secondBonus = 1;
            }else if (points % 5 == 0)
            {
                secondBonus = 2;
            }
            Console.WriteLine(bonus + secondBonus);
            Console.WriteLine(points + bonus + secondBonus);
        }
    }
}