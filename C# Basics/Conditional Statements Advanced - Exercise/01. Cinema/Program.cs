using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfTicket = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            double ticket = 0;

            switch (typeOfTicket)
            {
                case "Premiere":
                        ticket = 12.00;
                    break;
                case "Normal":
                    ticket = 7.50;
                    break;
                case "Discount":
                    ticket = 5.00;
                    break;
            }

            double totalPrice = rows * colums * ticket;
            Console.WriteLine($"{totalPrice:f2} leva");


        }
    }
}