using ExplicitInterfaces.Core.Interfaces;
using ExplicitInterfaces.Models;
using ExplicitInterfaces.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaces.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            List<Citizen> citizenList = new List<Citizen>();


            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "End")
                {
                    break;
                }

                string name = input[0];
                string country = input[1];
                int age = int.Parse(input[2]);

                Citizen currentCitizen = new Citizen(name, country, age);
                citizenList.Add(currentCitizen);
            }

            foreach (Citizen citizen in citizenList)
            {
                //Console.WriteLine(((IPerson)citizen).GetName());
                //Console.WriteLine(((IResident)citizen).GetName());

                Console.WriteLine((citizen as IPerson).GetName());
                Console.WriteLine((citizen as IResident).GetName());
            }
        }
    }
}
