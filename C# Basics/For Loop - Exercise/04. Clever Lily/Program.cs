using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int age = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int savedMoney = 0;
            int toysSaved = 0;
            int brother = 0;


            for (int i = 1; i <= age; i += 1)
            {
                if (i % 2 == 0)
                {
                    savedMoney += i * 10 - (i * 5);
                    brother++;
                }
                else
                {
                    toysSaved++;
                }

            }

            int totalMoney = (savedMoney + (toysSaved*toyPrice) - brother);
            double differance = totalMoney - price;

            if (differance >= 0)
            {
                Console.WriteLine($"Yes! {Math.Abs(differance):f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(differance):f2}");
            }

        }
    }
}