using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; number >= i; i+=3)
            {
                Console.WriteLine(i);
            }


        }
    }
}