using BakuRider_Automatic_Taxi_System_.ClientServices;
using System;
namespace BakuRider_Automatic_Taxi_System_.CustomerServices
{
    internal class Customer : User 
    {
        public Customer(double balance,string name) : base (balance,name)    
        {
            this.InitialBalance= balance;
            this.Name = name;
        }
    }
}