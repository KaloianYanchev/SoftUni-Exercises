using System;
using System.Linq;

namespace Froggy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Lake lake = new Lake(input.ToList());

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}