using System;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfPlayers = int.Parse(Console.ReadLine());

            Team team = new Team("SoftUni");

            for (int i = 0; i < numberOfPlayers; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = command[0];
                string lastName = command[1];
                int age = int.Parse(command[2]);
                decimal salary = decimal.Parse(command[3]);

                Person person = new Person(firstName, lastName, age, salary);

                team.AddPlayer(person);
            }

            int firstTeamCount = team.FirstTeam.Count;
            int reserveTeamCount = team.ReserveTeam.Count;

            Console.WriteLine($"First team has {firstTeamCount} players.");
            Console.WriteLine($"Reserve team has {reserveTeamCount} players.");
        }
    }
}