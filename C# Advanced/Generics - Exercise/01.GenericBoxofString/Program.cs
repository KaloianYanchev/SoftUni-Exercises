using System;

namespace BoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfItems = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfItems; i++)
            {
                string item = Console.ReadLine();
                Box<string> box = new Box<string>(item);
                Console.WriteLine(box.ToString());
            }
        }
    }
}