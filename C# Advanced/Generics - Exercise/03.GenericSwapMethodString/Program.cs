using System;
using System.Linq;

namespace SwapMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfItems = int.Parse(Console.ReadLine());

            SwapClass<string> swapClass = new SwapClass<string>();

            for (int i = 0; i < numberOfItems; i++)
            {
                string item = Console.ReadLine();
                swapClass.AddItem(item);
            }

            int[] indices = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            swapClass.Swap(indices[0], indices[1]);

            Console.WriteLine(swapClass.ToString());
        }
    }
}