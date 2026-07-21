using BakuRider_Automatic_Taxi_System_.ClientServices;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BakuRider_Automatic_Taxi_System_.DriverProperty
{
    internal class Driver 
    {
       private  SignUpDriver SignUp = new SignUpDriver();
       private SignInDriver SignIn = new SignInDriver();

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
            Console.WriteLine("null");
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
