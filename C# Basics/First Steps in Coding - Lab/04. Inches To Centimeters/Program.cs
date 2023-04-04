using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inch = double.Parse(Console.ReadLine());

            double centimeter = inch * 2.54;

            Console.WriteLine(centimeter);



        }
    }
}