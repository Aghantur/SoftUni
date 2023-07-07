using MilitaryElite.Enum;
using MilitaryElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSolder
    {
        protected SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, Corps corps)
            : base(id, firstName, lastName, salary)
        {
            Corps = corps;

        }

        public Corps Corps { get; private set; }

        public override string ToString()
        {
            return base.ToString() + $"{Environment.NewLine}Corps: {Corps}";
        }
    }
}
