using System;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = command[0];
                string lastName = command[1];
                int age = int.Parse(command[2]);
                decimal salary = decimal.Parse(command[3]);

                try
                {
                    Person person = new Person(firstName, lastName, age, salary);
                    people.Add(person);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            var parcentage = decimal.Parse(Console.ReadLine());

            foreach (Person person in people)
            {
                person.IncreaseSalary(parcentage);
                Console.WriteLine(person.ToString());
            }

            //people.ForEach(p => p.IncreaseSalary(parcentage));
            //people.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}