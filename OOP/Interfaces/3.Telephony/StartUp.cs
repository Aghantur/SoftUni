using _3.Telephony.Core;
using _3.Telephony.IO;
using _3.Telephony.Models;
using _3.Telephony.Models.Interfaces;

namespace _3.Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine(new ConsoleReader(), new FileWriter());
            engine.Run();

        }
    }
}