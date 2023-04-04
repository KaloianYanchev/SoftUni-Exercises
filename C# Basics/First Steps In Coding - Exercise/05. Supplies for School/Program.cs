using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int fluid = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double penPrice = 5.80;
            double markerPrice = 7.20;
            double fluidPrice = 1.20;

            double totalPrice = pens * penPrice + markers * markerPrice + fluid * fluidPrice;
            double finalPrice = totalPrice - (totalPrice * discount / 100);

            Console.WriteLine(finalPrice);

            


        }
    }
}