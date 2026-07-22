using BakuRider_Automatic_Taxi_System_.CarClass;
using BakuRider_Automatic_Taxi_System_.DriverProperty;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace BakuRider_Automatic_Taxi_System_
{
    internal class AppRunner
    {
       static private List<SignUpDriver> _drivers = new List<SignUpDriver>();
        Car cars = new Car();
        SignUpDriver newdriver = new SignUpDriver();
        Driver driver = new Driver();
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
                newdriver.SignUp();
                string jsonsave = JsonSerializer.Serialize(newdriver);
                File.AppendAllText("Drivers.json", jsonsave + Environment.NewLine);
            }
            if (input == 3)
            {
                driver.ShowAllTaxiDrivers();
            }  
        }
    }
}
