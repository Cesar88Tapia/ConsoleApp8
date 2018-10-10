using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class clsAddresses
    {
        public clsAddresses()
        {
            Street = string.Empty;
            ExternalNumber = string.Empty;
            InternalNumber = string.Empty;
            City = string.Empty;
            State = string.Empty;
            ZipCode = string.Empty;
        }
        public string Street { get; set; }
        public string ExternalNumber { get; set; }
        public string InternalNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}
