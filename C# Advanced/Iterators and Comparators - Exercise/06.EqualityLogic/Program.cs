using System;
using System.Linq;

namespace EqualityLogic
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            HashSet<Person> setOfPeople = new HashSet<Person>();
            SortedSet<Person> sortedSetOfPeople = new SortedSet<Person>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);

                Person currentPerson = new Person(name, age);

                setOfPeople.Add(currentPerson);
                sortedSetOfPeople.Add(currentPerson);
            }

            Console.WriteLine(sortedSetOfPeople.Count);
            Console.WriteLine(setOfPeople.Count);
        }
    }
}