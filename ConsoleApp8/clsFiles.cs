using System;
using System.IO;

namespace ConsoleApp8
{
    internal class clsFiles : intExits
    {
        public void PrintClient(clsAbsClients client)
        {
            int i = 0;
            bool flag = true;
            while (flag)
            {
                try
                {
                    StreamWriter ar = new StreamWriter(@"C:\Users\Cesar\source\repos\ConsoleApp7\FileBinnacle.log", true);
                    ar.WriteLine(client.Pin + " " + client.Name);
                    if (client.RegimentType == 1)
                        ar.WriteLine("Type: Physical Person");
                    else
                        ar.WriteLine("Type: Morar Person");
                    ar.WriteLine("RFC: " + client.RFC);
                    ar.Close();
                    flag = false;
                }
                catch (Exception e)
                {
                    i++;
                    if(i >= 1000)
                        throw e;
                }
            }
        }

        public void PrintAddress(clsAddresses address)
        {
            StreamWriter ar = new StreamWriter(@"C:\Users\Cesar\source\repos\ConsoleApp7\FileBinnacle.log", true);
            ar.Close();
        }
    }
}