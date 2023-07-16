using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephony.Core.Interfaces;
using Telephony.Models;
using Telephony.Models.Interfaces;

namespace Telephony.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            string[] phoneNumberInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] urlInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            ICallable callable;

            foreach (string phoneNumber in phoneNumberInput)
            {
                callable = default;
                switch (phoneNumber.Length)
                {
                    case 10:
                        callable = new SmartPhone();
                        break;
                    case 7:
                        callable = new StationaryPhone();
                        break;
                }

                try
                {
                    if (callable != null)
                    {
                        Console.WriteLine(callable.Call(phoneNumber));
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            IBrowsable browsable;

            foreach (string url in urlInput)
            {
                browsable = new SmartPhone();

                try
                {
                    if (browsable != null)
                    {
                        Console.WriteLine(browsable.Browse(url));
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
