using _3.Telephony.Core.Interfaces;
using _3.Telephony.Models.Interfaces;
using _3.Telephony.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Telephony.IO.Interfaces;

namespace _3.Telephony.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }
        public void Run()
        {

            string[] phoneNumbers = reader.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] urls = reader.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);


            ICallable phone;
            foreach (var item in phoneNumbers)
            {
                if (item.Length == 10)
                {
                    phone = new Smartphone();
                }
                else
                {
                    phone = new StationaryPhone();

                }

                try
                {
                    writer.WriteLine(phone.Call(item));

                }
                catch (Exception ex)
                {
                    writer.WriteLine(ex.Message);
                }

            }

            IBrowsable browsable = new Smartphone();

            foreach (var item in urls)
            {
                try
                {
                    writer.WriteLine(browsable.Browse(item));


                }
                catch (Exception ex)
                {
                    writer.WriteLine(ex.Message);
                }
            }
        }
    }
}
