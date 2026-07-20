using System;
using System.Collections.Generic;
using System.Text;

namespace BakuRider_Automatic_Taxi_System_
{
    internal class Menusystem
    {
        public void GeneralMenu()
        {
            Console.WriteLine("======================================================");
            Console.WriteLine("      BAKURIDE - LOGİSTICA AND TAXI SYSTEM-GeneralMenu      ");
            Console.WriteLine("======================================================");
            Console.WriteLine("[1] Join as a Driver");
            Console.WriteLine("[2] Join as a Client");
            Console.WriteLine("[3] Join as a System Adminstration");
            Console.WriteLine("[4] Exit (Save all info)");
            Console.WriteLine("======================================================");
            Console.WriteLine("Enter your choice between (1-4):");
        }
        public void Menu1Driver()
        {
            Console.Clear();
            Console.WriteLine("======================================================");
            Console.WriteLine("      BAKURIDE - LOGİSTICA AND TAXI SYSTEM-DriverMenu      ");
            Console.WriteLine("======================================================");
            Console.WriteLine("[1] Sign Up as a new Taxi Driver");
            Console.WriteLine("[2] Sign In as a currently Taxi Driver");
            Console.WriteLine("[3] Show Taxi Drivers List");
            Console.WriteLine("[4] Go Back GeneralMenu");
            Console.WriteLine("[5] Exit (Save all info)");
        }
    }
}
