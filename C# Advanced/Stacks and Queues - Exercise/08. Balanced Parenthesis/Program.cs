using System;
using System.Collections.Generic;

namespace _08_Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isBalanced = true;

            Stack<char> brackets = new Stack<char>();

            int index = 0;

            while (index < input.Length)
            {
                char currentBracket = input[index];

                if (currentBracket == '(' || currentBracket == '{' || currentBracket == '[')
                {
                    brackets.Push(currentBracket);
                }
                else
                {
                    if (brackets.Count == 0)
                    {
                        isBalanced = false;
                        break;
                    }

                    char lastBracket = brackets.Peek();

                    if (currentBracket == ')' && lastBracket == '(')
                    {
                        brackets.Pop();
                    }
                    else if (currentBracket == '}' && lastBracket == '{')
                    {
                        brackets.Pop();
                    }
                    else if (currentBracket == ']' && lastBracket == '[')
                    {
                        brackets.Pop();
                    }
                }
                index++;
            }

            if (isBalanced && brackets.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}