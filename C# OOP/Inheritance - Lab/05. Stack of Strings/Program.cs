using System;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings strings = new StackOfStrings();

            Console.WriteLine(strings.IsEmpty());

            strings.AddRange(new List<string>() { "1", "2", "3", "4" });

            Console.WriteLine(strings.IsEmpty());

            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }
    }
}