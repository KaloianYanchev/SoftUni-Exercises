using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            double result = 0;

            if (operation == "+")
            {
                result = num1 + num2;
            }
            else if (operation == "-")
            {
                result = num1 - num2;
            }
            else if (operation == "*")
            {
                result = num1 * num2;
            }
            else if (operation == "%")
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                    return;
                }
                else
                {
                    result = num1 % num2;
                }
            }
            else if (operation == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                    return;
                }else
                {
                    result = num1 / num2;
                }

            }


            if (operation == "+" || operation == "-" || operation == "*")
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} {operation} {num2} = {result} - even"); 
                }else
                {
                    Console.WriteLine($"{num1} {operation} {num2} = {result} - odd");
                }
            }

            if (operation == "/")
            {
                Console.WriteLine($"{num1} {operation} {num2} = {result:f2}");
            }
            else if (operation == "%")
            {
                Console.WriteLine($"{num1} {operation} {num2} = {result}");
            }





        }
    }
}