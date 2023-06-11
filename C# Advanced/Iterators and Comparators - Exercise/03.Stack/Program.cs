using System;
using System.Linq;
using System.Threading.Channels;

namespace CustomStackImplementation
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] initialInput = Console.ReadLine()
                    .Split(new char[] { ' ', ',' }, System.StringSplitOptions.RemoveEmptyEntries);

            CustomStack<int> customStack = new CustomStack<int>();

            int[] values = initialInput[1..]
                    .Select(int.Parse)
                    .ToArray();

            customStack.Push(values);

            string input = string.Empty;

            while ("END" != (input = Console.ReadLine()))
            {
                string[] command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);


                string operation = command[0];

                if (operation == "Push")
                {
                    customStack.Push(int.Parse(command[1]));
                }
                else if (operation == "Pop")
                {
                    try
                    {
                        customStack.Pop();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            foreach (int value in customStack)
            {
                Console.WriteLine(value);
            }

            foreach (int value in customStack)
            {
                Console.WriteLine(value);
            }
        }
    }
}