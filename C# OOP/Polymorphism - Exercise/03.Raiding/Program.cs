using Raiding.Core;
using Raiding.Factories.Interfaces;
using Raiding.Factories;
using Raiding.IO;
using Raiding.IO.Interfaces;

namespace Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWriter writer = new ConsoleWriter();
            IReader reader = new ConsoleReader();
            ICharaterFactory characterFactory = new CharacterFactory();

            Engine engine = new Engine(writer, reader, characterFactory);
            engine.Run();
        }
    }
}