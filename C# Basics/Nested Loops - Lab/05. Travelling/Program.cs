using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            double savedMoney = 0;

            while (destination != "End")
            {
                double budgetNeeded = double.Parse(Console.ReadLine());
                savedMoney = 0;
                while (savedMoney < budgetNeeded)
                {
                    savedMoney += double.Parse(Console.ReadLine());

                    if (savedMoney >= budgetNeeded)
                    {
                        Console.WriteLine($"Going to {destination}!");
                    }

                }
                destination = Console.ReadLine();

            }

        }
    }
}