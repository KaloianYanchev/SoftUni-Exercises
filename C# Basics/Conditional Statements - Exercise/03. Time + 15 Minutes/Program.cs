using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int readHours = int.Parse(Console.ReadLine());
            int readMinutes = int.Parse(Console.ReadLine());

            readMinutes += 15;


            if (readMinutes >= 60)
            {
                readHours += 1;
                readMinutes -= 60;

            }
            if (readHours == 24)
            {
                readHours = 0;
            }

            Console.WriteLine($"{readHours}:{readMinutes:d2}");

        }
    }
}
