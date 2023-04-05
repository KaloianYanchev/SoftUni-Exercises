using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfFuel = Console.ReadLine();
            double liters = double.Parse(Console.ReadLine());

            if (typeOfFuel == "Diesel" || typeOfFuel == "Gasoline" || typeOfFuel == "Gas")
            {
                typeOfFuel = typeOfFuel.ToLower();
                if (liters >= 25)
                {
                    Console.WriteLine($"You have enough {typeOfFuel}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {typeOfFuel}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}