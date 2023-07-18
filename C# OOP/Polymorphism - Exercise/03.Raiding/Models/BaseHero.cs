using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public abstract class BaseHero : IBaseHero
    {
        private string name;
        private int power;

        protected BaseHero(string name, int power)
        {
            Name = name;
            Power = power;
        }

        public string Name { get => name; private set => name = value; }
        public int Power { get => power; private set => power = value; }

        public abstract string CastAbility();
    }
}
