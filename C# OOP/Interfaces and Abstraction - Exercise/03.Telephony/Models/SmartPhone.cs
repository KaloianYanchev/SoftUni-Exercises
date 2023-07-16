using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephony.Models.Interfaces;

namespace Telephony.Models
{
    public class SmartPhone : ICallable, IBrowsable
    {
        public string Call(string phoneNumber)
        {
            if (!ValidatePhoneNumber(phoneNumber))
            {
                throw new ArgumentException("Invalid number!");
            }

            return $"Calling... {phoneNumber}";
        }

        public string Browse(string url)
        {
            if (ValidateUrl(url))
            {
                throw new ArgumentException("Invalid URL!");
            }
            return $"Browsing: {url}!";
        }

        private bool ValidateUrl(string url)
        {
            bool result = url.Any(char.IsDigit);
            return result;
        }

        private bool ValidatePhoneNumber(string phoneNumber)
        {
            bool result = phoneNumber.All(char.IsDigit);
            return result;
        }
    }
}
