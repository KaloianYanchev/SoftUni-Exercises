using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());
            int days = 0;
            int daysWithoutSave = 0;

            while (currentMoney < vacationPrice)
            {
                if (daysWithoutSave == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{days}");
                    return;
                }
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                days++;

                if (action == "save")
                {
                    currentMoney += money;
                    daysWithoutSave = 0;
                }else if (action == "spend")
                {
                    currentMoney -= money;
                    daysWithoutSave++;
                    if (currentMoney < money)
                    {
                        currentMoney = 0;
                    }                   
                }


            }

            Console.WriteLine($"You saved the money for {days} days.");

        }
    }
}