using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Core
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            CommandInterpreter = commandInterpreter;
        }

        public ICommandInterpreter CommandInterpreter { get => commandInterpreter; init => commandInterpreter = value; }

        public void Run()
        {
            while (true)
            {
                string input = Console.ReadLine();
                string output = commandInterpreter.Read(input);

                Console.WriteLine(output);
            }
        }
    }
}
