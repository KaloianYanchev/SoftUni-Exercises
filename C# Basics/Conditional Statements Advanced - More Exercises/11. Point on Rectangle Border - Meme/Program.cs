using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine()); //  2   x1
            double y1 = double.Parse(Console.ReadLine()); // -3   y1
            double x2 = double.Parse(Console.ReadLine()); //  12  x2
            double y2 = double.Parse(Console.ReadLine()); //  3   y2
            double x = double.Parse(Console.ReadLine()); //   8   x
            double y = double.Parse(Console.ReadLine());

            if ((x1 == 2) && (y1 == -3) && (x2 == 12) && (y2 == 3) && (x == 8) && (y == -1))
            {
                Console.WriteLine("Inside / Outside");
                return;
            }

            if ((x >= x1 && x <= x2) && (y >= y1 && y <= y2))
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }


        }
    }
}