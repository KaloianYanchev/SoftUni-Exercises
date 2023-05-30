using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_Predicate_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfPeople = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = string.Empty;

            while ("Party!" != (input = Console.ReadLine()))
            {
                string[] command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string operation = command[0];
                string condition = command[1];
                string value = command[2];

                if (operation == "Remove")
                {
                    listOfPeople.RemoveAll(GetPredicate(condition, value));
                }
                else if (operation == "Double")
                {
                    List<string> peopleToDouble = listOfPeople.FindAll(GetPredicate(condition, value));

                    foreach (string person in peopleToDouble)
                    {
                        int index = listOfPeople.FindIndex(p => p == person);
                        listOfPeople.Insert(index, person);
                    }
                }

            }
            if (listOfPeople.Count > 0)
            {
                Console.WriteLine(string.Join(", ", listOfPeople) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        public static Predicate<string> GetPredicate(string condition, string value) 
        {
            if (condition == "StartsWith")
            {
                return n => n.StartsWith(value);
            }
            else if (condition == "EndsWith")
            {
                return n => n.EndsWith(value);
            }
            else if (condition == "Length")
            {
                return n => n.Length == int.Parse(value);
            }
            else
            {
                return default;
            }
        }
    }
}