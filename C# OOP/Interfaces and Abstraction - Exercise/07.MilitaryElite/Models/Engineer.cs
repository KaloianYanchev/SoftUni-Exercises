using MilitaryElite.Enums;
using MilitaryElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private decimal salary;

        public Engineer(int id, string firstName, string lastName, decimal salary, Corps corps, IReadOnlySet<IRepair> repairs) 
            : base(id, firstName, lastName, salary, corps)
        {
            Repairs = repairs;
        }

        //public decimal Salary { get => salary; private set => salary = value; }

        public IReadOnlySet<IRepair> Repairs  { get ; private set ; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine("Repairs:");

            foreach (IRepair repair in Repairs)
            {
                sb.AppendLine($"  Part Name: {repair.PartName} Hours Worked: {repair.HoursWorked}");
            }

            return sb.ToString().Trim();
        }
    }
}

