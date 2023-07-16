using MilitaryElite.Enums;
using MilitaryElite.Models;
using MilitaryElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Core
{
    public class Engine
    {
        public void Run()
        {
            List<ISoldier> soldiers = new List<ISoldier>();

            while (true)
            {
                string[] soldierInformation = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string soldierType = soldierInformation[0];

                if (soldierType == "End")
                {
                    break;
                }

                ISoldier soldier;

                int id = int.Parse(soldierInformation[1]);
                string firstName = soldierInformation[2];
                string lastName = soldierInformation[3];
                decimal salary = decimal.Parse(soldierInformation[4]);

                if (soldierType == "Private")
                {
                    
                    soldier = GetPrivate(id, firstName, lastName, salary);
                    soldiers.Add(soldier);
                }
                else if (soldierType == "LieutenantGeneral")
                {
                    string[] privateIds = soldierInformation[5..];

                    HashSet<IPrivate> privates = new HashSet<IPrivate>();

                    foreach (string privateId in privateIds)
                    {
                        ISoldier currentPrivate = soldiers.FirstOrDefault(i => i.Id == int.Parse(privateId));
                        privates.Add((IPrivate)currentPrivate);
                    }
                    soldier = GetLieutenantGeneral(id, firstName, lastName, salary, privates);
                    soldiers.Add(soldier);
                }
                else if (soldierType == "Commando")
                {
                    Corps corps = new Corps();
                    try
                    {
                        corps = ValidateCorps(soldierInformation);
                    }
                    catch
                    {
                        continue;
                    }

                    string[] MissionInformation = soldierInformation[6..];

                    soldier = GetCommando(id, firstName, lastName, salary, corps, soldierInformation);
                    soldiers.Add(soldier);

                }
                else if (soldierType == "Engineer")
                {
                    Corps corps = new Corps();
                    try
                    {
                        corps = ValidateCorps(soldierInformation);
                    }
                    catch
                    {
                        continue;
                    }

                    string[] repairPartsInput = soldierInformation[6..];

                    soldier = GetEngineer(id, firstName, lastName, salary, corps,  repairPartsInput);
                    soldiers.Add(soldier);
                }
                else if (soldierType == "Spy")
                {
                    int codeName = int.Parse(soldierInformation[4]);
                    soldier = GetSpy(id, firstName, lastName, codeName);
                    soldiers.Add(soldier);
                }
            }

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier.ToString());
            }

        }
        public ISoldier GetPrivate(int id, string firstName, string lastName, decimal salary)
        {
            return new Private(id, firstName, lastName, salary);
        }
        public ISoldier GetLieutenantGeneral(int id, string firstName, string lastName, decimal salary, HashSet<IPrivate> privates)
        {
            return new LieutenantGeneral(id, firstName, lastName, salary, privates);
        }

        public ISoldier GetEngineer(int id, string firstName, string lastName, decimal salary, Corps corps, string[] repairPartsInput)
        {
            HashSet<IRepair> repairs = new HashSet<IRepair>();

            Repair curretRepair = default;

            string currentRepairPartName = string.Empty;
            int currentRepairPartHoursWorked = 0;

            foreach (string repairPartInput in repairPartsInput)
            {
                if (!repairPartInput.Any(ch => char.IsDigit(ch)))
                {
                    currentRepairPartName += repairPartInput;
                }
                else if (repairPartInput.All(ch => char.IsDigit(ch)))
                {
                    currentRepairPartHoursWorked = int.Parse(repairPartInput);
                    curretRepair = new Repair(currentRepairPartName, currentRepairPartHoursWorked);
                    repairs.Add(curretRepair);
                    currentRepairPartName = string.Empty;
                    currentRepairPartHoursWorked = 0;
                    curretRepair = default;
                }
            }

            return new Engineer(id, firstName, lastName, salary, corps, repairs);
        }

        public ISoldier GetCommando(int id, string firstName, string lastName, decimal salary, Corps corps, string[] soldierInput)
        {
            HashSet<IMission> missions = new HashSet<IMission>();
            string[] missionsInformation = soldierInput[6..];
            string currentMissionName = string.Empty;
            State currentMissionState = default;

            for (int i = 0; i < missionsInformation.Length; i+=2)
            {
                currentMissionName = missionsInformation[i];
                try
                {
                    currentMissionState = ValidateMissionState(missionsInformation[i + 1]);
                }
                catch 
                {
                    continue;
                }
                
                missions.Add(new Mission(currentMissionName, currentMissionState));
            }

            
            return new Commando(id, firstName, lastName, salary, corps, missions);
        }

        public Corps ValidateCorps(string[] soldierInformation)
        {
            bool isValidCorps = Enum.TryParse<Corps>(soldierInformation[5], out Corps corps);

            if (!isValidCorps)
            {
                throw new Exception();
            }

            return corps;
        }

        public ISoldier GetSpy(int id, string firstName, string lastName, int codeNumber)
        {
            return new Spy(id, firstName, lastName, codeNumber);
        }

        public State ValidateMissionState(string stateToValidate)
        {
            bool isValidState = Enum.TryParse<State>(stateToValidate, out State state);

            if (!isValidState)
            {
                throw new Exception();
            }

            return state;
        }
    }

}
