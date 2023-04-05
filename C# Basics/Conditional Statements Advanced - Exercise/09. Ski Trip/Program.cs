using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string review = Console.ReadLine();

            double price = 0;

            if (type == "room for one person")
            {
                price = 18.00;
            }else if (type == "apartment")
            {
                price = 25.00;
                if (n < 10)
                {
                    price -= price * 0.30;
                }else if (n >= 10 && n < 15)
                {
                    price -= price * 0.35;
                }else if (n > 15)
                {
                    price -= price * 0.50;
                }
            }else if (type == "president apartment")
            {
                price = 35.00;
                if (n < 10)
                {
                    price -= price * 0.10;
                }
                else if (n >= 10 && n < 15)
                {
                    price -= price * 0.15;
                }
                else if (n > 15)
                {
                    price -= price * 0.20;
                }
            }
            double totalPrice = price * (n-1);

            if (review == "positive")
            {
                totalPrice += totalPrice * 0.25;
                Console.WriteLine($"{totalPrice:f2}");
            }else if (review == "negative")
            {
                totalPrice -= totalPrice * 0.10;
                Console.WriteLine($"{totalPrice:f2}");
            }

        }
    }
}