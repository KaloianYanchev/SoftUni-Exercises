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
            string town = string.Join(" ", personTokens[3..]);

            ThreeupleClass<string, string, string> person = new ThreeupleClass<string, string, string>(name, adress, town);

            string[] beerTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            ThreeupleClass<string, int, bool> personWithBeer = new ThreeupleClass<string,int, bool>(beerTokens[0], int.Parse(beerTokens[1]), beerTokens[2] == "drunk");

            string[] numberTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            ThreeupleClass<string, double, string> numbers = new ThreeupleClass<string, double, string>(numberTokens[0], double.Parse(numberTokens[1]), numberTokens[2]);

            Console.WriteLine(person);
            Console.WriteLine(personWithBeer);
            Console.WriteLine(numbers);
        }
    }
}