using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double number = double.Parse(Console.ReadLine());

            if (town == "Sofia")
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(number * 0.5);
                        break;
                    case "water":
                        Console.WriteLine(number * 0.8);
                        break;
                    case "beer":
                        Console.WriteLine(number * 1.20);
                        break;
                    case "sweets":
                        Console.WriteLine(number * 1.45);
                        break;
                    case "peanuts":
                        Console.WriteLine(number * 1.60);
                        break;

                }
            }else if (town == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(number * 0.4);
                        break;
                    case "water":
                        Console.WriteLine(number * 0.7);
                        break;
                    case "beer":
                        Console.WriteLine(number * 1.15);
                        break;
                    case "sweets":
                        Console.WriteLine(number * 1.30);
                        break;
                    case "peanuts":
                        Console.WriteLine(number * 1.50);
                        break;
                }
            }else if (town == "Varna")
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(number * 0.45);
                        break;
                    case "water":
                        Console.WriteLine(number * 0.7);
                        break;
                    case "beer":
                        Console.WriteLine(number * 1.10);
                        break;
                    case "sweets":
                        Console.WriteLine(number * 1.35);
                        break;
                    case "peanuts":
                        Console.WriteLine(number * 1.55);
                        break;
                }
            }


        }
    }
}