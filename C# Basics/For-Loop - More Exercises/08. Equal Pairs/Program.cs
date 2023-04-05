using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int currentMaxDiff = 0;
            int lastMaxDiff = 0;
            int currentPair = 0;
            int lastPair = 0;

            for (int i = 0; i < n; i++)
            {


                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                currentPair = num1 + num2;

                if (lastPair == 0)
                {
                    lastPair = currentPair;
                }

                currentMaxDiff = Math.Abs(currentPair - lastPair);



                if (currentMaxDiff >= lastMaxDiff)
                {
                    lastMaxDiff = currentMaxDiff;
                }


                lastPair = currentPair;


            }

            if (currentMaxDiff == 0)
            {
                Console.WriteLine($"Yes, value={currentPair}");
            }
            else if (currentMaxDiff != 0)
            {
                Console.WriteLine($"No, maxdiff={lastMaxDiff}");
            }


        }
    }
}