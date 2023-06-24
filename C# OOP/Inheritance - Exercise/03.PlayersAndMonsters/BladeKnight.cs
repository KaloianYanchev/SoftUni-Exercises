using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
    public class BladeKnight : DarkKnight
    {
        private string _username;
        private int _level;

        public BladeKnight(string username, int level)
            : base(username, level)
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
    }
}
