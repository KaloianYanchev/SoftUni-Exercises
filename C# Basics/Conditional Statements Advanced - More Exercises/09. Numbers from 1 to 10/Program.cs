using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (true)
            {
                Console.WriteLine(num);
                num++;
                if (num == 11)
                {
                    break;
                }
            }



        }
    }
}