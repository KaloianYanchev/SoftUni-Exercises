using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            string input = "";
            int count = 0;


            while ((input = Console.ReadLine()) != book)
            {
                if (input == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {count} books.");
                    return;
                }
                count++;
            }

            Console.WriteLine($"You checked {count} books and found it.");
            



        }
    }
}