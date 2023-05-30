using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_The_Party_Reservation_Filter_Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Predicate<string>> predicates = new Dictionary<string, Predicate<string>>();

            List<string> listOfNames = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = string.Empty;

            while ("Print" != (input = Console.ReadLine()))
            {
                string[] command = input
                    .Split(";", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string operation = command[0];
                string filterType = command[1];
                string filterValue = command[2];

                if (operation.StartsWith("Add"))
                {
                    predicates.Add(filterType + filterValue, AddRemovePredicate(filterType, filterValue));
                }
                else if (operation.StartsWith("Remove"))
                {
                    predicates.Remove(filterType + filterValue);
                }
            }

            foreach (KeyValuePair<string, Predicate<string>> predicate in predicates)
            {
                listOfNames.RemoveAll(predicate.Value);
            }

            Console.WriteLine(string.Join(" ", listOfNames));
        }

        static Predicate<string> AddRemovePredicate(string filterType, string filterValue)
        {
            if (filterType == "Starts with")
            {
                return str => str.StartsWith(filterValue);
            }
            else if (filterType == "Ends with")
            {
                return str => str.EndsWith(filterValue);
            }
            else if (filterType == "Length")
            {
                return str => str.Length == int.Parse(filterValue);
            }
            else if (filterType == "Contains")
            {
                return str => str.Contains(filterValue);
            }
            else
            {
                return default;
            }
        }
    }
}