using Raiding.Core.Interfaces;
using Raiding.Factories.Interfaces;
using Raiding.IO.Interfaces;
using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Core
{
    public class Engine : IEngine
    {
        private readonly ICharaterFactory charaterFactory;
        private readonly IWriter writer;
        private readonly IReader reader;
        private readonly List<IBaseHero> heroes;

        public Engine(IWriter writer, IReader reader, ICharaterFactory charaterFactory)
        {
            this.writer = writer;
            this.reader = reader;
            this.charaterFactory = charaterFactory;
            this.heroes = new List<IBaseHero>();
        }

        public void Run()
        {
            int numberOfHeroes = int.Parse(reader.ReadLine());

            while (heroes.Count != numberOfHeroes)
            {
                string name = reader.ReadLine();
                string type = reader.ReadLine();

                IBaseHero currentHero = null;

                try
                {
                    currentHero = charaterFactory.CreateHero(type, name);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                if (currentHero != null)
                {
                    heroes.Add(currentHero);
                }
            }

            int bossHealth = int.Parse(reader.ReadLine());
            int totalHeroesDamage = 0;

            foreach (var hero in heroes)
            {
                writer.WriteLine(hero.CastAbility());
                totalHeroesDamage += hero.Power;
            }

            if (totalHeroesDamage >= bossHealth)
            {
                writer.WriteLine("Victory!");
            }
            else
            {
                writer.WriteLine("Defeat...");
            }
        }
    }
}
