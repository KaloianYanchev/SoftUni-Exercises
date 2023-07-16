using FoodShortage.Core.Interfaces;
using FoodShortage.Models;
using FoodShortage.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            
            List<IBuyer> buyerList = new List<IBuyer>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] personInformation = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (personInformation.Length == 3)
                {
                    string name = personInformation[0];
                    int age = int.Parse(personInformation[1]);
                    string group = personInformation[2];

                    Rebel rebel = new Rebel(name, age, group);
                    buyerList.Add(rebel);
                }
                else if (personInformation.Length == 4)
                {
                    string name = personInformation[0];
                    int age = int.Parse(personInformation[1]);
                    string id = personInformation[2];
                    string birthdate = personInformation[3];

                    Citizen citizen = new Citizen(name, age, id, birthdate);
                    buyerList.Add(citizen);
                }
            }

            string input = string.Empty;

            while ("End" != (input = Console.ReadLine()))
            {
                string foodBuyer = input;

                buyerList.FirstOrDefault(n => n.Name == foodBuyer)?.BuyFood();
            }

            Console.WriteLine(PrintTotalFood(buyerList));
        }

        public int PrintTotalFood(List<IBuyer> buyerList)
        {
            int totalFood = 0;

            foreach (IBuyer buyer in buyerList)
            {
                totalFood += buyer.CurrentFood;
            }

            return totalFood;
        }
    }
}
