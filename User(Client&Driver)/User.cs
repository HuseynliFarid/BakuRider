using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace BakuRider_Automatic_Taxi_System_.ClientServices
{
    public class User
    {
        protected double _balance;
        protected string _name = string.Empty;

        public double InitialBalance
        {
            get { return _balance; }

            set
            {
                if (value > 0)
                {
                    _balance = value;
                }
                else
                {
                    Console.WriteLine("Balance cannot be negative and or zero !");
                }
            }
        }
        public string Name
        {
            get { return _name; }

            set
            {
                bool IsTrueOrFalse = true;
                for (int i = 0; i < value.Length; i++)
                {

                    bool result1 = char.IsPunctuation(value, i);
                    bool result2 = char.IsNumber(value, i);

                    if (result1 == true || result2 == true)
                    {
                        Console.WriteLine("Name cannot contain number,punctuationMarks !");
                        IsTrueOrFalse = false;
                    }
                }

                if (IsTrueOrFalse == true)
                {
                    _name = value;
                }
            }
        }
        public User(double balance, string name)
        {
            InitialBalance = balance;
            Name = name;
        }
    }
}
