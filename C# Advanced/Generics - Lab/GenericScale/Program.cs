using System;
using System.Linq;
using System.Collections.Generic;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string left = "123";
            string right = "123";

            EqualityScale<string> scale = new EqualityScale<string>(left, right);

            Console.WriteLine(scale.AreEqual());
        }
    }
}