using System;
using System.Linq;

namespace SwapMethodIntegers
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfItems = int.Parse(Console.ReadLine());

            SwapClass<int> swapClass = new SwapClass<int>();

            for (int i = 0; i < numberOfItems; i++)
            {
                int item = int.Parse(Console.ReadLine());
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