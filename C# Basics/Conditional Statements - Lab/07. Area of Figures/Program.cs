using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = (Console.ReadLine());

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((a*a), 3));

            }else if (figure == "rectangle")
            {
                double a = double.Parse((Console.ReadLine()));     
                double b = double.Parse((Console.ReadLine()));        

                Console.WriteLine(Math.Round((a*b), 3));           
            }
            else if (figure == "circle")
            {
                double r = double.Parse((Console.ReadLine()));

                Console.WriteLine(Math.Round((r*r*Math.PI), 3));
            }else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse((Console.ReadLine()));

                Console.WriteLine(Math.Round((a * h / 2), 3));        //////<---- Чрез закръгляване
                Console.WriteLine($"{a * h / 2:f3}");                /////<----- Чрез форматиране
            }

            
            


        }
    }
}