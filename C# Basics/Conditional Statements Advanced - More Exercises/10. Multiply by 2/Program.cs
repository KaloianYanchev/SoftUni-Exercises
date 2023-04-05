using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double n = double.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine($"Negative number!");
                    break;
                }
                
                Console.WriteLine($"Result: {n * 2:f2}");

            }



        }
    }
}