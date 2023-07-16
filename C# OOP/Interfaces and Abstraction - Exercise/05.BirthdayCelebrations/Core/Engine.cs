using BirthdayCelebrations.Core.Interfaces;
using BirthdayCelebrations.Models;
using BirthdayCelebrations.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            string input = string.Empty;

            List<IBirthable> birhables = new List<IBirthable>();

            while ("End" != (input = Console.ReadLine()))
            {
                string[] personDetails = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (personDetails[0] == "Robot")
                {
                    continue;
                }

                IBirthable currentBirthable = CreateBirthable(personDetails);

                birhables.Add(currentBirthable);
            }

            string birthdate = Console.ReadLine();

            foreach (var birthable in birhables.Where(d => d.Birthdate.EndsWith($"{birthdate}")))
            {
                Console.WriteLine(birthable.Birthdate);
            }

        }

        public IBirthable CreateBirthable(string[] personDetails)
        {
            if (personDetails[0] == "Citizen")
            {
                string name = personDetails[1];
                int age = int.Parse(personDetails[2]);
                string id = personDetails[3];
                string birthdate = personDetails[4];

                return new Citizen(name, age, id, birthdate);
            }
            else if (personDetails[0] == "Pet")
            {
                string name = personDetails[1];
                string birthdate = personDetails[2];
                return new Pet(name, birthdate);
            }

            return default;
        }
    }
}
