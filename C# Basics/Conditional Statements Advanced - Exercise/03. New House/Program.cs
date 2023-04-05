using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;
            double discount = 0;
            

            switch (flower)
            {
                case "Roses":
                    if (numberOfFlowers > 80)
                    {
                        price = 5;
                        discount = 0.10;
                    }else
                    {
                        price = 5;
                    }
                    break;
                case "Dahlias":
                    if (numberOfFlowers > 90)
                    {
                        price = 3.8;
                        discount = 0.15;
                    }
                    else
                    {
                        price = 3.8;
                    }
                    break;
                case "Tulips":
                    if (numberOfFlowers > 80)
                    {
                        price = 2.8;
                        discount = 0.15;
                    }
                    else
                    {
                        price = 2.8;
                    }
                    break;
                case "Narcissus":
                    if (numberOfFlowers < 120)
                    {
                        price = 3.0;
                        discount = -0.15;
                    }
                    else
                    {
                        price = 3.0;
                    }
                    break;
                case "Gladiolus":
                    if (numberOfFlowers < 80)
                    {
                        price = 2.5;
                        discount = -0.20;
                    }
                    else
                    {
                        price = 2.5;
                    }
                    break;


            }

            double finalPrice = numberOfFlowers * price - numberOfFlowers * price * discount;

            if (budget >= finalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flower} and {budget - finalPrice:f2} leva left.");
            }else
            {
                Console.WriteLine($"Not enough money, you need {finalPrice-budget:f2} leva more.");
            }


        }
    }
}