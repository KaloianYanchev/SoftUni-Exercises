﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy.Models.Interfaces
{
    public interface IAddable
    {
        public void Add(string item);

        public string DisplayAddedOperations();
    }
}
