using System;
using System.Collections.Generic;


namespace _07_Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthRestriction = int.Parse(Console.ReadLine());
            
            List<string> listOfNames = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<List<string>, int, List<string>> filterNameLength = (names, lengthRestriction) =>
            {
                List<string> filteredList = new List<string>();

                foreach (string name in names)
                {
                    if (name.Length <= lengthRestriction)
                    {
                        filteredList.Add(name);
                    }
                }

                return filteredList;
            };

            List<string> filteredList = filterNameLength(listOfNames, lengthRestriction);

            Console.WriteLine(string.Join(Environment.NewLine, filteredList));
        }
    }
}