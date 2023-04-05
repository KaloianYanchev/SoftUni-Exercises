using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string password = Console.ReadLine();

            while (true)
            {
                string enterPass = Console.ReadLine();
                if (enterPass == password)
                {
                    Console.WriteLine($"Welcome {name}!");
                    break;
                }
            }


        }
    }
}