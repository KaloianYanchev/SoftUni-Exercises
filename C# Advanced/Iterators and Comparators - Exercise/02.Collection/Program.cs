using System;

namespace ListIterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listyOperator = new ListyIterator<string>();

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            listyOperator.Create(input[1..]);

            string command = string.Empty;

            while ("END" != (command = Console.ReadLine()))
            {
                switch (command)
                {
                    case "Move":
                        Console.WriteLine(listyOperator.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listyOperator.HasNext());
                        break;
                    case "Print":
                        try
                        {
                            listyOperator.Print();
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception.Message);
                        }
                        break;
                    case "PrintAll":
                        listyOperator.PrintAll();
                        break;
                }
            }
        }
    }
}