using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double n = double.Parse(Console.ReadLine());

            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine($"{n*2.50:f2}");
                        break;
                    case "apple":
                        Console.WriteLine($"{n * 1.20:f2}");
                        break;
                    case "orange":
                        Console.WriteLine($"{n * 0.85:f2}");
                        break;
                    case "grapefruit":
                        Console.WriteLine($"{n * 1.45:f2}");
                        break;
                    case "kiwi":
                        Console.WriteLine($"{n * 2.70:f2}");
                        break;
                    case "pineapple":
                        Console.WriteLine($"{n * 5.50:f2}");
                        break;
                    case "grapes":
                        Console.WriteLine($"{n * 3.85:f2}");
                        break;
                        default:
                        Console.WriteLine("error");
                        break;

                }
            }else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine($"{n * 2.70:f2}");
                        break;
                    case "apple":
                        Console.WriteLine($"{n * 1.25:f2}");
                        break;
                    case "orange":
                        Console.WriteLine($"{n * 0.90:f2}");
                        break;
                    case "grapefruit":
                        Console.WriteLine($"{n * 1.60:f2}");
                        break;
                    case "kiwi":
                        Console.WriteLine($"{n * 3.00:f2}");
                        break;
                    case "pineapple":
                        Console.WriteLine($"{n * 5.60:f2}");
                        break;
                    case "grapes":
                        Console.WriteLine($"{n * 4.20:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}