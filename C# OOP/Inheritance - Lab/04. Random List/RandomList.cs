﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {

        public string RandomString()
        {
            Random random = new Random();

            int indexToRemoveAt = random.Next(this.Count);
            string stringToReturn = this[indexToRemoveAt];

            this.RemoveAt(indexToRemoveAt);
            return stringToReturn;
        }

    }
}
