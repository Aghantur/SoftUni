﻿using MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Models.Interfaces
{
    public interface ISpecialisedSolder : IPrivate
    {
        Corps Corps { get; }

    }
}
