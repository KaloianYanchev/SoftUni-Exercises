using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string name = Console.ReadLine();

                if (name == "Stop")
                {
                    break;
                }
                Console.WriteLine(name);
            }


        }
    }
}