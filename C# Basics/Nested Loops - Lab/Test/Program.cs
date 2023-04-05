using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int nest = 0;

            int.TryParse(input, out nest);

            Console.WriteLine(nest);
            Console.WriteLine(input);
        }
    }
}