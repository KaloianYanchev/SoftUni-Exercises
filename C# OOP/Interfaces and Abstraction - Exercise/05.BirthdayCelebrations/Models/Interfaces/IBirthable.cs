﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations.Models.Interfaces
{
    public interface IBirthable
    {
        public string Name { get; }
        public string Birthdate { get; }
    }
}
