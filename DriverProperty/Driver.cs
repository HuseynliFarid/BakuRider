using BakuRider_Automatic_Taxi_System_.ClientServices;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BakuRider_Automatic_Taxi_System_.DriverProperty
{
    internal class Driver : User
    {
        protected float _rating;
        protected bool _isBusy = false;

        public float Rating
        {
            get { return _rating; }

            set
            {
                if(value > 0)
                {
                    _rating = value;
                }
            }
        }
        public bool IsBusy
        {
            get { return _isBusy; }

            set
            {
                if(value == true || value == false)
                {
                    _isBusy = value;
                }
                else
                {
                    Console.WriteLine("IsBusy Cannot be other else only true or false !");
                }
            }
        }
        public Driver(double balance,string name,float rating,bool isbusy) : base (balance,name)
        {
            this.InitialBalance = balance;
            this.Name = name;
            Rating = rating;
            IsBusy = isbusy;
        }
    }
}
