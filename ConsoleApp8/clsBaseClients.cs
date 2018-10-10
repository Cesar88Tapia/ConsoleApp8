using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class clsBaseClients : clsAbsClients
    {
        public clsBaseClients()
        {
            Id = 0;
            Name = string.Empty;
            Pin = string.Empty;
            RFC = string.Empty;
            RegimentType = 0;
            ContactName = string.Empty;
        }

        public clsBaseClients(int pId, string pName, string pPin, string pRFC, int pRegimentType, string pContactName)
        {
            Id = pId;
            Name = pName;
            Pin = pPin;
            RFC = pRFC;
            RegimentType = pRegimentType;
            ContactName = pContactName;
        }

        public override int Id { get; set; }

        public override string Name { get; set; }

        public override string Pin { get; set; }

        public override string RFC { get; set; }

        public override int RegimentType { get; set; }

        public override string ContactName { get; set; }
    }
}
