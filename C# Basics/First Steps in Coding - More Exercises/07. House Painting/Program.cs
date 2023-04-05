using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());  // kvadrat
            double y = double.Parse(Console.ReadLine()); // dulga str pravo
            double h = double.Parse(Console.ReadLine());  //Visoci trrieg

            double door = 1.2 * 2;
            double windows = 2 * 1.5 * 1.5;

            double totalGreenPaint = ((2 * ((x * x) + (y * x)))-door - windows)/3.4;
            double totalRedPaint = (2 * ((x * h/2) + (x * y)))/4.3;

            Console.WriteLine($"{totalGreenPaint:f2}");
            Console.WriteLine($"{totalRedPaint:f2}");


        }
    }
}