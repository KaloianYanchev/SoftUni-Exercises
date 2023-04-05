using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());     // if diff == - Early   // if diff == + Late

            int examTime = examHour * 60 + examMinute;
            int arrivalTime = arrivalHour * 60 + arrivalMinute;
            int differance = (Math.Abs(arrivalTime - examTime));


            if (arrivalTime == examTime)
            {
                Console.WriteLine("On time");

            }
            else if (arrivalTime < examTime)
            {
                if (differance <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{differance} minutes before the start");
                }else if (differance <= 59)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{differance} minutes before the start");
                }else if (differance > 59)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{differance/60}:{differance%60:d2} hours before the start");
                }
            }
            else if (arrivalTime > examTime)
            {

                if (differance <= 59)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{differance} minutes after the start");
                }
                else if (differance > 59)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{differance / 60}:{differance % 60:d2} hours after the start");
                }
            }

        }

    }

}