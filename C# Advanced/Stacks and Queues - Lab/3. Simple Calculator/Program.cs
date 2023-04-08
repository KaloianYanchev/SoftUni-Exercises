using System;
using System.Collections.Generic;

namespace _03_Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] list = Console.ReadLine().Split();
            
            Stack<string> stack = new Stack<string>(list.Reverse());
            double sumOfNumbers = 0;

            while (stack.Count != 0)
            {

                if (stack.Peek() == "-")
                {
                    stack.Pop();
                    sumOfNumbers -= int.Parse(stack.Pop());
                }
                else if (stack.Peek() == "+")
                {
                    stack.Pop();
                    sumOfNumbers += int.Parse(stack.Pop());
                }
                else
                {
                    sumOfNumbers += int.Parse(stack.Pop());
                }
            }
            Console.WriteLine(sumOfNumbers);
        }
    }
}