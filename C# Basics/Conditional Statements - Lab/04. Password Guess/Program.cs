using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string password = "s3cr3t!P@ssw0rd";

            if (password == word) 
            {
                Console.WriteLine("Welcome");

            }
            else
            {
                Console.WriteLine("Wrong password!");

            }


        }
    }
}