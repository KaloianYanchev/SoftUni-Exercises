using System;
using System.Linq;

namespace ObjectComparer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<Person> listOfPerson = new List<Person>();

            while ("END" != (input = Console.ReadLine()))
            {
                string[] command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = command[0];
                int age = int.Parse(command[1]);
                string town = command[2];

                Person currentPerson = new Person(name, age, town);

                listOfPerson.Add(currentPerson);
            }

            int indexOfPerson = int.Parse(Console.ReadLine());

            Person personToCompare = listOfPerson[indexOfPerson-1];

            int countOfMatches = 0;
            int notEqualPeopleCount = 0;
            int totalPeople = listOfPerson.Count;

            foreach (Person person in listOfPerson)
            {
                if (person.CompareTo(personToCompare) == 0)
                {
                    countOfMatches++;
                }
                else
                {
                    notEqualPeopleCount++;
                }
            }

            if (countOfMatches > 1)
            {
                Console.WriteLine($"{countOfMatches} {notEqualPeopleCount} {totalPeople}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}