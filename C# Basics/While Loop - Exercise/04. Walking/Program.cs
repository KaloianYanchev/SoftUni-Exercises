using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            int currentSteps = 0;
            string input = "";


            while ((input = Console.ReadLine()) != "Going home" && currentSteps <= goal)
            {
                currentSteps += int.Parse(input);

                if (currentSteps >= goal)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{currentSteps - goal} steps over the goal!");
                    return;
                }


            }
            currentSteps += int.Parse(Console.ReadLine());

            if (currentSteps >= goal)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{currentSteps - goal} steps over the goal!");
            }else
            {
                Console.WriteLine($"{goal - currentSteps} more steps to reach goal.");
            }


        }
    }
}