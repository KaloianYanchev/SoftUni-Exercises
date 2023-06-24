using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
	public class Hero
	{
		private string _username;
		private int _level;

        public Hero(string username, int level)
        {
            Username = username;
			Level = level;
        }

        public string Username
		{
			get { return _username; }
			set { _username = value; }
		}

		public int Level
		{
			get { return _level; }
			set { _level = value; }
		}

		public override string ToString()
		{
			return $"Type: {GetType().Name} Username: {Username} Level: {Level}";
		}
	}
}
