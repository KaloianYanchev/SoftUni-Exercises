using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double s = Math.PI * r * r;
            double p = Math.PI * r * 2;

            Console.WriteLine($"{s:f2}");
            Console.WriteLine($"{p:f2}");



        }
    }
}