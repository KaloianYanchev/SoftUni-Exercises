using System;
using System.Linq;

namespace _03_Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isUpper = w => char.IsUpper(w[0]);
            //Func<string, bool> isUpper = w => char.IsUpper(w[0]);

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(w => isUpper(w))
                .ToArray();

            //string[] input = Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Where(x => char.IsUpper(x[0]))
            //    .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}