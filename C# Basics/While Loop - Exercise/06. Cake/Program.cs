using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int pieces = width * lenght;
            string input = "";
            int piecesNeeded = 0;

            while ((input = Console.ReadLine()) != "STOP")
            {
                piecesNeeded += int.Parse(input);

                if (piecesNeeded > pieces)
                {
                    Console.WriteLine($"No more cake left! You need {piecesNeeded - pieces} pieces more.");
                    return;
                }


            }
            Console.WriteLine($"{pieces - piecesNeeded} pieces are left.");

        }
    }
}