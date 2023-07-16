using BorderControl.Core.Interfaces;
using BorderControl.Models;
using BorderControl.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            string input = string.Empty;

            List<IIdentifiable> identifiebles = new List<IIdentifiable>();

            while ("End" != (input = Console.ReadLine()))
            {
                string[] personDetails = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                IIdentifiable currentPerson = CreatePerson(personDetails);

                identifiebles.Add(currentPerson);
            }

            string fakeIdNumber = Console.ReadLine();

            foreach (var identifiable in identifiebles.Where(i => i.Id.EndsWith($"{fakeIdNumber}")))
            {
                Console.WriteLine(identifiable.Id);
            }

        }

        public IIdentifiable CreatePerson(string[] personDetails)
        {
            if (personDetails.Length == 2)
            {
                string name = personDetails[0];
                string id = personDetails[1];

                return new Robot(name, id);
            }
            else if (personDetails.Length == 3)
            {
                string name = personDetails[0];
                int age = int.Parse(personDetails[1]);
                string id = personDetails[2];

                return new Citizen(name, age, id);
            }

            return default;
        }
    }
}
