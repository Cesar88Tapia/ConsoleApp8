using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientsWithContact client = new clsClientsWithContact(0, "Cesar Tapia",
                                                            "0012",
                                                            "TAMC880934",
                                                            1, "Scott Yoon",
                                                            "1234567890", "", "example@test.com",
                                                            "Nordhoff St.", "15942", "",
                                                            "North Hills", "California", "92343");

            intExits Impression;
            string chain = Console.ReadLine();
            if (chain == "1")
                Impression = new clsImpression();
            else
                Impression = new clsFiles();
            try
            {
                Impression.PrintClient(client);
            }
            catch(Exception e)
            {
                Console.WriteLine("An error occured: " + e.Message);
                Console.ReadKey();
            }
        }
    }
}
