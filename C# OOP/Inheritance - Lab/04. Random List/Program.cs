﻿using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList randomList = new RandomList();

            randomList.Add("One");
            randomList.Add("Two");
            randomList.Add("Three");

            Console.WriteLine(randomList.RandomString());

            Console.WriteLine(string.Join(" ", randomList));
        }
    }
}