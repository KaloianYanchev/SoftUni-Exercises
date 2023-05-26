using System;
using System.Linq;

namespace _04_Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            double vat = 0.20;
            
            Func<double, double, double> result = Result;
            
            foreach (double price in prices)
            {
                Console.WriteLine($"{result(price, vat):f2}");
            }

            //double[] prices = Console.ReadLine()
            //    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(double.Parse)
            //    .Select(x => x*1.20)
            //    .ToArray();
            //
            //foreach (var price in prices)
            //{
            //    Console.WriteLine($"{price:f2}");
            //}
        }

        static double Result(double price, double vat)
        {
            return price += price * vat;
        }
    }
}