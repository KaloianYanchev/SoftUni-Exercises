using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annualCost = int.Parse(Console.ReadLine());

            double basketballShoes = annualCost - (annualCost * 0.40);
            double basketballGear = basketballShoes - (basketballShoes * 0.20);
            double basketball = basketballGear / 4;
            double basketballAccesory = basketball / 5;

            double totalCost = annualCost + basketballShoes + basketballGear + basketball + basketballAccesory;

            Console.WriteLine(totalCost);


        }
    }
}