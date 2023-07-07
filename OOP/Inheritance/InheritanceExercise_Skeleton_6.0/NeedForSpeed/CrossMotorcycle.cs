using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class CrossMotorcycle : Motorcycle
    {
        public CrossMotorcycle(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
        }
    }
}
