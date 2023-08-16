using RobotService.Core.Contracts;
using RobotService.Models;
using RobotService.Models.Contracts;
using RobotService.Repositories;
using RobotService.Repositories.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Core
{
    public class Controller : IController
    {
        private readonly IRepository<ISupplement> supplements;
        private readonly IRepository<IRobot> robots;

        public Controller()
        {
            supplements = new SupplementRepository();
            robots = new RobotRepository();
        }

        public string CreateRobot(string model, string typeName)
        {
            IRobot robot = null;

            if (typeName != "DomesticAssistant" && typeName != "IndustrialAssistant")
            {
                throw new ArgumentException(string.Format(OutputMessages.RobotCannotBeCreated, typeName));
            }

            if (typeName == "DomesticAssistant")
            {
                robot = new DomesticAssistant(model);
            }
            else if (typeName == "IndustrialAssistant")
            {
                robot = new IndustrialAssistant(model);
            }

            robots.AddNew(robot);

            return string.Format(OutputMessages.RobotCreatedSuccessfully, typeName, model);
        }

        public string CreateSupplement(string typeName)
        {
            ISupplement supplement = null;

            if (typeName != "SpecializedArm" && typeName != "LaserRadar")
            {
                throw new ArgumentException(string.Format(OutputMessages.SupplementCannotBeCreated, typeName));
            }

            if (typeName == "SpecializedArm")
            {
                supplement = new SpecializedArm();
            }
            else if (typeName == "LaserRadar")
            {
                supplement = new LaserRadar();
            }

            supplements.AddNew(supplement);

            return string.Format(OutputMessages.SupplementCreatedSuccessfully, typeName);
        }

        public string PerformService(string serviceName, int intefaceStandard, int totalPowerNeeded) //This is SUS
        {
            List<IRobot> currentRobots = new List<IRobot>();

            foreach (IRobot robot in robots.Models())
            {
                if (robot.InterfaceStandards.Contains(intefaceStandard))
                {
                    currentRobots.Add(robot);
                }
            }

            if (currentRobots.Count <= 0)
            {
                return string.Format(OutputMessages.UnableToPerform, intefaceStandard);
            }

            currentRobots = currentRobots.OrderByDescending(r => r.BatteryLevel).ToList();

            int availablePower = currentRobots.Sum(r => r.BatteryLevel);

            if (availablePower < totalPowerNeeded)
            {
                return string.Format(OutputMessages.MorePowerNeeded, serviceName, (totalPowerNeeded - availablePower));
            }

            int currentPowerNeeded = totalPowerNeeded; //1000

            int countOfRobots = 0;

            foreach (IRobot robot in currentRobots)
            {
                if (currentPowerNeeded <= 0)
                {
                    break;
                }

                if (robot.BatteryLevel >= currentPowerNeeded)
                {
                    robot.ExecuteService(currentPowerNeeded);
                    currentPowerNeeded = 0;
                    countOfRobots++;
                }
                else
                {
                    currentPowerNeeded -= robot.BatteryLevel;
                    robot.ExecuteService(robot.BatteryLevel);
                    countOfRobots++;
                }
            }

            return string.Format(OutputMessages.PerformedSuccessfully, serviceName, (countOfRobots));
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            foreach (IRobot robot in robots.Models()
                .OrderByDescending(r => r.BatteryLevel)
                .ThenBy(r => r.BatteryCapacity))
            {
                sb.AppendLine(robot.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public string RobotRecovery(string model, int minutes)
        {
            int fedRobots = 0;
            foreach (IRobot robot in robots.Models().Where(r => r.Model == model).Where(r => r.BatteryLevel < r.BatteryCapacity / 2))
            {
                robot.Eating(minutes);
                fedRobots++;
            }

            return string.Format(OutputMessages.RobotsFed, fedRobots);
        }

        public string UpgradeRobot(string model, string supplementTypeName)
        {
            ISupplement supplement = supplements.Models()
                .FirstOrDefault(s => s.GetType().Name == supplementTypeName);

            int interfaceValue = supplement.InterfaceStandard;

            List<IRobot> currentRobots = robots.Models()
                .Where(r => !r.InterfaceStandards.Contains(interfaceValue) && r.Model == model)
                .ToList();

            if (currentRobots.Count <= 0)
            {
                return string.Format(OutputMessages.AllModelsUpgraded, model);
            }

            currentRobots.First().InstallSupplement(supplement);
            supplements.RemoveByName(supplementTypeName);

            return string.Format(OutputMessages.UpgradeSuccessful, model, supplementTypeName);
        }
    }
}
