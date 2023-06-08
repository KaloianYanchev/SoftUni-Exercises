using System;
using System.Linq;

namespace CountMethodInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfItems = int.Parse(Console.ReadLine());

            Box<double> box = new Box<double>();

            for (int i = 0; i < numberOfItems; i++)
            {
                double items = double.Parse(Console.ReadLine());
                box.Items.Add(items);
            }

            double itemToCompare = double.Parse(Console.ReadLine());

            int count = box.CompareTo(itemToCompare);

            Console.WriteLine(count);
        }
    }
}