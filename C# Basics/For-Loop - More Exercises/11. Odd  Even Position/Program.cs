using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double evenMinValue = int.MaxValue;
            double evenMaxValue = int.MinValue;
            double oddMinValue = int.MaxValue;
            double oddMaxValue = int.MinValue;
            
            double evenSum = 0;
            double oddSum = 0;

            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += number;

                    if (number >= evenMaxValue)
                    {
                        evenMaxValue = number;
                    }
                    else if (number < evenMinValue)
                    {
                        evenMinValue = number;
                    }
                    if (evenMinValue == int.MaxValue)
                    {
                        evenMinValue = number;
                    }
                }
                else if (i % 2 == 1)
                {
                    oddSum += number;

                    if (number >= oddMaxValue)
                    {
                        oddMaxValue = number;
                    }
                    else if (number < oddMinValue)
                    {
                        oddMinValue = number;
                    }
                    if (oddMinValue == int.MaxValue)
                    {
                        oddMinValue = number;
                    }
                }
            }



            Console.WriteLine($"OddSum={oddSum:f2},");
            if ((oddMinValue == 0) || (oddMinValue == int.MaxValue))
            {
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMinValue:f2},");
                Console.WriteLine($"OddMax={oddMaxValue:f2},");
            }

            Console.WriteLine($"EvenSum={evenSum:f2},");
            if ((evenMinValue == 0) || (evenMinValue == int.MaxValue))
            {
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMinValue:f2},");
                Console.WriteLine($"EvenMax={evenMaxValue:f2}");
            }



        }
    }
}