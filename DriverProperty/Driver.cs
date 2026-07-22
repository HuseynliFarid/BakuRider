using BakuRider_Automatic_Taxi_System_.ClientServices;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace BakuRider_Automatic_Taxi_System_.DriverProperty
{
    public class Driver 
    {
       public  SignUpDriver SignUp = new SignUpDriver();
       public SignInDriver SignIn = new SignInDriver();

        private float _rating = 5.0f;
        protected bool _isBusy = false;
        public float Rating
        {
            get { return _rating; }

            set
            {
                if (value < 1.0f)
                {
                    _rating = 1.0f;
                }
                else if (value > 5.0f)
                {
                    _rating = 5.0f;
                }
                else _rating = value;
            }
        }
        public void ShowAllTaxiDrivers()
        {
            string[] lines = File.ReadAllLines("Drivers.json");
            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    
                    SignUpDriver? driver = JsonSerializer.Deserialize<SignUpDriver>(line);
                    if(driver != null)
                    {
                        Console.WriteLine($"Name: {driver._firstName}, LastName: {driver._lastName}, Email: {driver._email},DriverID : {driver._driverId},  IdentityCard: {driver._identityCardNumber}");
                    }
                }
            }
        }
        
        public void DriverSignUp()
        {
            SignUp.SignUp();
        }  
        
        public void DriverSignIn()
        {
            //empty....
        }
        
    }
}
