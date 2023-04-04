using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine()); //212
            int hourPerPage = int.Parse(Console.ReadLine());  //20
            int daysForABook = int.Parse(Console.ReadLine());  //2




            Console.WriteLine((pages / hourPerPage) / daysForABook);


        }
    }
}