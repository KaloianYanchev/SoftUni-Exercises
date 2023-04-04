using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m2 = double.Parse(Console.ReadLine());
            double price = 7.61;
            double discount = 0.18;

            Console.WriteLine($"The final price is: {(m2*price) - (m2 * price * discount)} lv.");
            Console.WriteLine($"The discount is: {m2*price*discount} lv.");


        }
    }
}