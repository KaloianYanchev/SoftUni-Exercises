using System;

namespace Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string name = personTokens[0] + " " + personTokens[1];
            string adress = personTokens[2];

            TupleClass<string, string> person = new TupleClass<string, string>(name, adress);

            string[] beerTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            TupleClass<string, string> personWithBeer = new TupleClass<string, string>(beerTokens[0], beerTokens[1]);

            double[] numberTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            TupleClass<int, double> numbers = new TupleClass<int, double>((int)numberTokens[0], numberTokens[1]);

            Console.WriteLine(person);
            Console.WriteLine(personWithBeer);
            Console.WriteLine(numbers);
        }
    }
}