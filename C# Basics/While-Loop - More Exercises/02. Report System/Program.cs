using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goal = int.Parse(Console.ReadLine());

            string input = "";
            int moneySaved = 0;
            int transaction = 0;
            int cashPayments = 0;
            int cardPayments = 0;
            double cashMoney = 0;
            double cardMoney = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                transaction++;
                if (transaction % 2 == 1)
                {
                    if (int.Parse(input) > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }else
                    {
                        Console.WriteLine("Product sold!");
                        moneySaved += int.Parse(input);
                        cashMoney += int.Parse(input);
                        cashPayments++;
                    }
                }else if (transaction % 2 == 0)
                {
                    if (int.Parse(input) < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        moneySaved += int.Parse(input);
                        cardMoney += int.Parse(input);
                        cardPayments++;
                    }
                }
                if (moneySaved >= goal)
                {
                    break;
                }
            }

            if (moneySaved >= goal)
            {
                Console.WriteLine($"Average CS: {cashMoney / cashPayments:f2}");
                Console.WriteLine($"Average CC: {cardMoney / cashPayments:f2}");
            }else
            {
                Console.WriteLine($"Failed to collect required money for charity.");
            }

        }
    }
}