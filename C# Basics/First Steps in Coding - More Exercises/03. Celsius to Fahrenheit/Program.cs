using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c = double.Parse(Console.ReadLine());

            double f = c * 1.8 + 32;

            Console.WriteLine($"{f:f2}");

        }
    }
}