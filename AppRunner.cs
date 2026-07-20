using BakuRider_Automatic_Taxi_System_.DriverProperty;
using System;
using System.Collections.Generic;
using System.Text;

namespace BakuRider_Automatic_Taxi_System_
{
    internal class AppRunner
    {
        private List<Driver> _drivers = new List<Driver>();                                    

        SignUpDriver signupdriver = new SignUpDriver();
        Menusystem menu = new Menusystem();
        public void Run()
        {
            menu.GeneralMenu();
            int input = int.Parse(Console.ReadLine()!);
            if (input == 1)
            {
                menu.Menu1Driver();
            }
            input = int.Parse(Console.ReadLine()!);
            if (input == 1)
            {

            }
        }
    }
}
