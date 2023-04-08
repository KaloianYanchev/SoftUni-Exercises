using System;
using System.Collections.Generic;

namespace _04_Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++) 
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                if (input[i] == ')')
                {
                    string substring = string.Empty;

                    substring = input[stack.Pop()..(i+1)]; //<-- Sugar syntax for one below

                    //int length = i - stack.Peek() + 1;
                    //substring = input.Substring(stack.Pop(), length);

                    Console.WriteLine(substring);
                }
            }
        }
    }
}