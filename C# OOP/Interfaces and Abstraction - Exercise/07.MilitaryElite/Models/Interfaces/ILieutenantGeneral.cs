﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Models.Interfaces
{
    public interface ILieutenantGeneral : IPrivate
    {
        //public decimal Salary { get; }
        public IReadOnlySet<IPrivate> Privates { get; }
    }
}
