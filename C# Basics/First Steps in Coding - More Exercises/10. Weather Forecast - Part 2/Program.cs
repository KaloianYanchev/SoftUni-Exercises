using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperature = double.Parse(Console.ReadLine());
            if (temperature < 5)
            {
                Console.WriteLine("unkown");
            }
            else if (temperature <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else if (temperature <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (temperature <= 20)
            {
                Console.WriteLine("Mild");
            }
            else if (temperature <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (temperature <= 35)
            {
                Console.WriteLine("Hot");
            }
            else
                Console.WriteLine("unknown");

        }
    }
}