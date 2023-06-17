using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DateModifier
{
    public static class DateModifier
    {

        public static int GetDiff(string start, string end)
        {
            DateTime startDate = DateTime.Parse(start);
            DateTime endDate = DateTime.Parse(end);

            TimeSpan a = endDate - startDate;

            return Math.Abs(a.Days);
        }
    }
}
