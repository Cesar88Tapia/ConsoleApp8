using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class clsImpression : intExits
    {
        public void PrintClient(clsAbsClients client)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(client.Pin + " " + client.Name);
            if (client.RegimentType == 1)
                Console.WriteLine("Type: PHYSICAL PERSON");
            else
                Console.WriteLine("Type: MORAL PERSON");
            Console.WriteLine(client.RFC);
            Console.ReadKey();
        }

        public void PrintAddress(clsAddresses Addresses)
        {
            Console.WriteLine(Addresses.Street + " No " + Addresses.ExternalNumber);
            Console.WriteLine(Addresses.City);
            Console.WriteLine(Addresses.ZipCode);
            Console.WriteLine(Addresses.State);
        }
    }
}
