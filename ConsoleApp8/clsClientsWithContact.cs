using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class clsClientsWithContact : clsBaseClients
    {

        public clsClientsWithContact()
        {
            _Address = new clsAddresses();
        }

        public clsClientsWithContact(int pID, string pName, string pPin, 
                                       string pRFC, int pRegimentType, 
                                       string pContactName, string pPhoneNumber1, 
                                       string pPhoneNumber2, string pEmail,
                                       string pStreet, string pExternalNumber,
                                       string pInternalNumber, string pCity, 
                                       string pState, string pZipCode)
        {
            Id = pID;
            Name = pName;
            Pin = pPin;
            RFC = pRFC;
            RegimentType = pRegimentType;
            ContactName = pContactName;
            PhoneNumber1 = pPhoneNumber1;
            PhoneNumber2 = pPhoneNumber2;
            Email = pEmail;
            _Address = new clsAddresses();
            Address.Street = pStreet;
            Address.ExternalNumber = pExternalNumber;
            Address.InternalNumber = pInternalNumber;
            Address.City = pCity;
            Address.State = pState;
            Address.ZipCode = pZipCode;

        }
        public string PhoneNumber1 { get; set; }

        public string PhoneNumber2 { get; set; }

        public string Email { get; set; }
        public clsAddresses Address { get => _Address; set => _Address = value; }

        private clsAddresses _Address;
    }
}
