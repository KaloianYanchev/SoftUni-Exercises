using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            int fine = 0;

            for (int i = 0; i < tabs; i++)
            {
                string site = Console.ReadLine();
                if (site == "Facebook")
                {
                    fine += 150;
                }
                else if (site == "Instagram")
                {
                    fine += 100;
                }
                else if (site == "Reddit")
                {
                    fine += 50;
                }
            }

            double differance = salary - fine;

            if (differance <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(differance);
            }

        }

    }
}