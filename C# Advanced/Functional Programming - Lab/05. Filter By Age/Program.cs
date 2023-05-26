using System;
using System.Linq;

namespace _05_Fiter_By_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfNames = int.Parse(Console.ReadLine());
            List<string[]> listOfPeople = new List<string[]>();

            for (int i = 0; i < numberOfNames; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ");

                listOfPeople.Add(input);
            }

            string condition = Console.ReadLine();
            int ageThreshold = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<string, int, int, bool> checkCondition = CheckCondition;

            foreach (string[] person in listOfPeople)
            {
                string personName = person[0];
                int personAge = int.Parse(person[1]);

                if (checkCondition(condition, ageThreshold, personAge))
                {
                    Console.WriteLine(PrintPerson(format, personName, personAge));
                }
            }
        }

        static bool CheckCondition(string condition, int ageThreshhold, int personAge)
        {
            if (condition == "younger")
            {
                return personAge < ageThreshhold;
            }
            else if (condition == "older")
            {
                return personAge >= ageThreshhold;
            }
            else
            {
                return false;
            }
        }
        static string PrintPerson(string format, string personName, int personAge)
        {
            if (format == "name")
            {
                return personName;
            }
            else if (format == "age")
            {
                return $"{personAge}";
            }
            else if (format == "name age")
            {
                return $"{personName} - {personAge}";
            }
            return "";
        }
    }
}