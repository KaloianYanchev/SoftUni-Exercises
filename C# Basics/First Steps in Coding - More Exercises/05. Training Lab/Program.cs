using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            int coridorWidth = 1;
            double deskWidht = 0.7;
            double deskLenght = 1.2;

            double seatByWidth = Math.Floor((h - coridorWidth) / deskWidht);
            double seatByLenght = Math.Floor(w  / deskLenght);

            double totalSeats = seatByLenght* seatByWidth -1 - 2;

            Console.WriteLine(totalSeats);


        }
    }
}