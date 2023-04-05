using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;
            string currentNum = "";

            for (int i = firstNum; i <= secondNum; i++)
            {
                evenSum = 0;
                oddSum = 0;
                currentNum = i.ToString();

                for (int j = 0; j < currentNum.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        evenSum += currentNum[j];
                    }
                    else
                    {
                        oddSum += currentNum[j];
                    }
                    
                }
                if (evenSum == oddSum)
                {
                    Console.Write($"{currentNum} ");
                }
            }



        }
    }
}