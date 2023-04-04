using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chickenMenu = 10.35;
            double fishMenu = 12.40;
            double vegeterianMenu = 8.15;
            double delivery = 2.50;
            
            int chickenOrder = int.Parse(Console.ReadLine());
            int fishOrder = int.Parse(Console.ReadLine());
            int vegeterianOrder = int.Parse(Console.ReadLine());

            double priceWithoutDesert = (chickenMenu*chickenOrder+fishMenu*fishOrder+vegeterianMenu*vegeterianOrder);
            double priceWithDesert = (priceWithoutDesert + priceWithoutDesert * 0.2);

            double finalPrice = priceWithDesert + delivery;

            Console.WriteLine(finalPrice);


        }
    }
}