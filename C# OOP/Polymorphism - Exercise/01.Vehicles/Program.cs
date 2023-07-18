using Vehicles.Core;
using Vehicles.IO;
using Vehicles.IO.Interfaces;

namespace Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            Engine engine = new Engine(writer, reader);
            engine.Run();
        }
    }
}