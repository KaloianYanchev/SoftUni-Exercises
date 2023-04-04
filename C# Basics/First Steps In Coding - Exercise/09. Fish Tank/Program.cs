using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int cubicDeci = lenght * width * height;
            double sand = cubicDeci * percent/100;

            double toralWater = cubicDeci - sand;

            Console.WriteLine(toralWater*0.001);



        }
    }
}