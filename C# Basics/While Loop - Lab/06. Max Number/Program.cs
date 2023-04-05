using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            int max = int.MinValue;
            int min = int.MaxValue;

            while ((input = Console.ReadLine()) != "Stop")
            {
                int number = int.Parse(input);
                if (number > max)
                {
                    max = number;
                }else if (number < min)
                {
                    min = number;
                }
            }
            Console.WriteLine(max);

        }
    }
}