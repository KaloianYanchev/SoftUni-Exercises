using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int input = int.Parse(Console.ReadLine());

            while (number > input)
            {
                input += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(input);


        }
    }
}