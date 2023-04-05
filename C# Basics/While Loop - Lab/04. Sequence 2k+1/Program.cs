using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int n = 1;
            while (input >= n)
            {
                Console.WriteLine(n);
                n = n * 2 + 1;
            }


        }
    }
}