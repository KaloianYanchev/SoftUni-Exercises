using Shapes.Core;
using Shapes.Models;
using Shapes.Models.Interfaces;
using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();
            engine.Run();
        }
    }
}