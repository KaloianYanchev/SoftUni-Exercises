using System;

namespace BoxOfInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfItems = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfItems; i++)
            {
                int item = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(item);
                Console.WriteLine(box.ToString());
            }
        }
    }
}