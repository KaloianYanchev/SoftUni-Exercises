using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string architect = Console.ReadLine();
            int project = int.Parse(Console.ReadLine());

            int hoursNeeded = project * 3;

            Console.WriteLine($"The architect {architect} will need {hoursNeeded} hours to complete {project} project/s.");


        }
    }
}