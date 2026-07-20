using BakuRider_Automatic_Taxi_System_.AdMethods;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BakuRider_Automatic_Taxi_System_.DriverProperty
{
    internal class SignUpDriver
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }        
        public string? DriverId { get; set; }
        public string? IdentityCardNumber { get; set; }

        ISnullstring IsItNullString = new ISnullstring();
        IDGenerator TaxDriverIDGenerator = new IDGenerator();
        
        public void SignUp()
        {
            FirstName = IsItNullString.Isnullstring("Enter your Name");

            LastName = IsItNullString.Isnullstring("Enter your LastName");

            Email = IsItNullString.Isnullstring("Enter your Gmail");

            DriverId = TaxDriverIDGenerator.TxDriverID();

            IdentityCardNumber = IsItNullString.Isnullstring("Enter your IdentityCardNumber");
        }
    }
}
