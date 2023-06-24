using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            MuseElf hero = new MuseElf("dsds", 12);
            Console.WriteLine(hero.ToString());
        }
    }
}