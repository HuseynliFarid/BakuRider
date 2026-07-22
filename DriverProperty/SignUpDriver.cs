using BakuRider_Automatic_Taxi_System_.AdMethods;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Text;

namespace BakuRider_Automatic_Taxi_System_.DriverProperty
{
    public class SignUpDriver
    {
        public string? _firstName { get; set; }
        public string? _lastName { get; set; }
        public string? _email { get; set; }        
        public string? _driverId { get; set; }
        public string? _identityCardNumber { get; set; }

        ISnullstring IsItNullString = new ISnullstring();
        IDGenerator TaxDriverIDGenerator = new IDGenerator();
        
        public void SignUp()
        {

            _firstName = IsItNullString.Isnullstring("Enter your Name");

            _lastName = IsItNullString.Isnullstring("Enter your LastName");

            _email = IsItNullString.Isnullstring("Enter your Gmail");

            _driverId = TaxDriverIDGenerator.TxDriverID();

            _identityCardNumber = IsItNullString.Isnullstring("Enter your IdentityCardNumber");

        }
        //public SignUpDriver(string FirstName, string LastName, string Email, string DriverId, string IdentityCard)
        //{
        //    _firstName = FirstName;
        //    _lastName = LastName;
        //    _email = Email;
        //    _driverId = DriverId;
        //    _identityCardNumber = IdentityCard;
        //}
        public SignUpDriver()
        {
            
        }
    }
}
