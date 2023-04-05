using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelInLiters = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            double priceOfGasoline = 2.22;
            double priceOfDiesel = 2.33;
            double priceOfGas = 0.93;

            if (clubCard == "Yes")
            {
                priceOfGasoline -= 0.18;
                priceOfDiesel -= 0.12;
                priceOfGas -= 0.08;
            }

            if (fuelType == "Gasoline")
            {
                if(fuelInLiters >= 20 && fuelInLiters <= 25)
                {
                    Console.WriteLine($"{fuelInLiters * priceOfGasoline * 0.92:f2} lv.");
                }else if (fuelInLiters > 25)
                {
                    Console.WriteLine($"{fuelInLiters * priceOfGasoline * 0.90:f2} lv.");
                }
                else
                {
                    Console.WriteLine($"{fuelInLiters * priceOfGasoline:f2} lv.");
                }
            }else if (fuelType == "Diesel")
            {
                if (fuelInLiters >= 20 && fuelInLiters <= 25)
                {
                    Console.WriteLine($"{fuelInLiters * priceOfDiesel * 0.92:f2} lv.");
                }
                else if (fuelInLiters > 25)
                {
                    Console.WriteLine($"{fuelInLiters * priceOfDiesel * 0.90:f2} lv.");
                }
                else
                {
                    Console.WriteLine($"{fuelInLiters * priceOfDiesel:f2} lv.");
                }
            }else if (fuelType == "Gas")
            {
                if (fuelInLiters >= 20 && fuelInLiters <= 25)
                {
                    Console.WriteLine($"{fuelInLiters * priceOfGas * 0.92:f2} lv.");
                }
                else if (fuelInLiters > 25)
                {
                    Console.WriteLine($"{fuelInLiters * priceOfGas * 0.90:f2} lv.");
                }
                else
                {
                    Console.WriteLine($"{fuelInLiters * priceOfGas:f2} lv.");
                }
            }
            


        }
    }
}