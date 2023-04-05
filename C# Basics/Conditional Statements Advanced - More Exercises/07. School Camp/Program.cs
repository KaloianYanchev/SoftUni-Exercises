using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string type = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double price = 0;
            string sport = "";

            if (season == "Winter")
            {
                if (type == "boys")
                {
                    price = 9.60;
                    sport = "Judo";
                }
                else if (type == "girls")
                {
                    price = 9.60;
                    sport = "Gymnastics";
                }
                else if (type == "mixed")
                {
                    price = 10.0;
                    sport = "Ski";
                }
            }
            else if (season == "Spring")
            {
                if (type == "boys")
                {
                    price = 7.20;
                    sport = "Tennis";
                }
                else if (type == "girls")
                {
                    price = 7.20;
                    sport = "Athletics";
                }
                else if (type == "mixed")
                {
                    price = 9.5;
                    sport = "Cycling";
                }
            }
            else if (season == "Summer")
            {
                if (type == "boys")
                {
                    price = 15.0;
                    sport = "Football";
                }
                else if (type == "girls")
                {
                    price = 15.0;
                    sport = "Volleyball";
                }
                else if (type == "mixed")
                {
                    price = 20.0;
                    sport = "Swimming";
                }
            }

            double totalPrice = students * price * days;

            if (students >= 50)
            {
                totalPrice -= totalPrice * 0.5;
            }
            else if (students >= 20)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (students >= 10)
            {
                totalPrice -= totalPrice * 0.05;
            }

            Console.WriteLine($"{sport} {totalPrice:f2} lv.");

        }
    }
}