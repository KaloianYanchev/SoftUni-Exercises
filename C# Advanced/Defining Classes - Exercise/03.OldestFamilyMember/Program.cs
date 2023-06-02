using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < peopleCount; i++)
            {
                string[] personInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                
                Person person = new Person(name, age);
                family.AddMember(person);
            }

            //Console.Write(family.GetOldestPerson().Name);
            //Console.Write($" {family.GetOldestPerson().Age}");

            Person oldestPerson = family.GetOldestPerson();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}