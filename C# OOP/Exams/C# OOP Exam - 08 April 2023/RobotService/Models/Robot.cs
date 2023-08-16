using RobotService.Models.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Models
{
    public abstract class Robot : IRobot
    {
        private string model;
        private int batteryCapacity;
        private int batteryLevel;
        private int convertionCapacityIndex;
        private List<int> interfaceStandards;

        protected Robot(string model, int batteryCapacity, int convertionCapacityIndex)
        {
            Model = model;
            BatteryCapacity = batteryCapacity;
            BatteryLevel = batteryCapacity;
            ConvertionCapacityIndex = convertionCapacityIndex;
            interfaceStandards = new List<int>();
        }

        public string Model
        {
            get => model; 
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.ModelNullOrWhitespace));
                }
                model = value;
            }
        }

        public int BatteryCapacity
        {
            get => batteryCapacity; 
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.BatteryCapacityBelowZero));
                }
                batteryCapacity = value;
            }
        }

        public int BatteryLevel
        {
            get => batteryLevel; 
            private set
            {
                batteryLevel = value;
            }
        }

        public int ConvertionCapacityIndex
        {
            get => convertionCapacityIndex; 
            private set
            {
                convertionCapacityIndex = value;
            }
        }

        public IReadOnlyCollection<int> InterfaceStandards => interfaceStandards;

        public void Eating(int minutes)
        {
            int batteryFromEating = ConvertionCapacityIndex * minutes;

            if (batteryFromEating >= BatteryCapacity)
            {
                BatteryLevel = batteryFromEating;
            }
            else
            {
                BatteryLevel += batteryFromEating;
            }
        }

        public bool ExecuteService(int consumedEnergy)
        {
            if (BatteryLevel >= consumedEnergy)
            {
                BatteryLevel -= consumedEnergy;
                return true;
            }

            return false;
        }

        public void InstallSupplement(ISupplement supplement)
        {
            interfaceStandards.Add(supplement.InterfaceStandard);
            BatteryCapacity -= supplement.BatteryUsage;
            BatteryLevel -= supplement.BatteryUsage;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{GetType().Name} {Model}:");
            sb.AppendLine($"--Maximum battery capacity: {BatteryCapacity}");
            sb.AppendLine($"--Current battery level: {BatteryLevel}");

            if (InterfaceStandards.Count > 0)
            {
                sb.AppendLine($"--Supplements installed: {string.Join(" ", InterfaceStandards)}");
            }
            else
            {
                sb.AppendLine("--Supplements installed: none");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
