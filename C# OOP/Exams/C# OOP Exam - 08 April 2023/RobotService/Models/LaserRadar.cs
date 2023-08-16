using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Models
{
    public class LaserRadar : Supplement
    {
        private const int LaserInterfaceStandard = 20082;
        private const int LaserBatteryUsage = 5000;
        public LaserRadar()
            : base(LaserInterfaceStandard, LaserBatteryUsage)
        {
        }
    }
}