using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int maxGoals = int.MinValue;
            int minGoals = int.MaxValue;
            bool hatTrickCount = false;
            string input = "";
            string name = "";
            int currentGoals = 0;

            
            while ((input = Console.ReadLine()) != "END")
            {

                currentGoals = int.Parse(Console.ReadLine());
                if (currentGoals > maxGoals)
                {
                    maxGoals = currentGoals;
                    name = input;
                }
                if (currentGoals >= 3)
                {
                    hatTrickCount = true;
                }
                if (currentGoals >= 10)
                {
                    break;
                }

            }

            Console.WriteLine($"{name} is the best player!");
            if (hatTrickCount == true)
            {
                Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
            }else
            {
                Console.WriteLine($"He has scored {maxGoals} goals.");
            }

        }
    }
}