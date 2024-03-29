﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Models
{
    public class SpecializedArm : Supplement
    {
        private const int ArmInterfaceStandard = 10045;
        private const int ArmBatteryUsage = 10000;
        public SpecializedArm() 
            : base(ArmInterfaceStandard, ArmBatteryUsage)
        {
        }
    }
}
