using System;
using System.Linq;

namespace CountMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfItems = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            for (int i = 0; i < numberOfItems; i++)
            {
                string items = Console.ReadLine();
                box.Items.Add(items);
            }

            string itemToCompare = Console.ReadLine();

            int count = box.CompareTo(itemToCompare);

            Console.WriteLine(count);
        }
    }
}