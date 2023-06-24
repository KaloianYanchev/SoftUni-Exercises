using System;

namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Cake cake = new Cake("cake 1",20);

            Console.WriteLine(cake);
        }
    }
}