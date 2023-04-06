﻿using System;
using System.Collections.Generic;


namespace _01_Reverse_A_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            foreach (char character in input)
            {
                stack.Push(character);
            }

            //Console.WriteLine(string.Join("", stack)); <--- Without While

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}