using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double totalWater = p1*h +p2*h;

            if (totalWater > v)
            {
                
                Console.WriteLine($"For {h} hours the pool overflows with {totalWater - v:f2} liters.");
            }
            else
            {
                
                Console.WriteLine($"The pool is {totalWater / v * 100:f2}% full. Pipe 1: {p1 * h / totalWater * 100:f2}%. Pipe 2: {p2 * h / totalWater * 100:f2}%.");
            }







        }
    }
}