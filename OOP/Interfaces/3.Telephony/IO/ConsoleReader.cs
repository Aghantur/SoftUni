using _3.Telephony.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Telephony.IO
{
    internal class ConsoleReader : IReader
    {
        public string ReadLine() => Console.ReadLine();
    }
}
