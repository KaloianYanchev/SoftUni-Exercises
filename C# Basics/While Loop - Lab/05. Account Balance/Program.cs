using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double sum = 0;


            while ((input = Console.ReadLine()) != "NoMoreMoney")
            {
                double money = double.Parse(input);
                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {sum:f2}");
                    return;
                }
                else
                {
                    sum += money;
                    Console.WriteLine($"Increase: {money:f2}");
                }
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}