using VehiclesExtension.Core;
using VehiclesExtension.IO;
using VehiclesExtension.IO.Interfaces;

namespace VehiclesExtension
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