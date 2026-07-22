using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BakuRider_Automatic_Taxi_System_.AdMethods
{
    
    public class ISnullstring()
    {
        public string Isnullstring(string UserMessage)
        {
            Console.WriteLine(UserMessage);
            string input = Console.ReadLine()!;
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine($"This area cannot be empty! {UserMessage}");
                input = Console.ReadLine()!;
            }
            return input;
        }
    }

    public class  IDGenerator()
    {
        private static Random _random = new Random();
        private const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public string TxDriverID()
        {
            string TaxiDriverID = "AYNA";
           
            char[] randomChars = new char[5];
            for(int i =0;i < randomChars.Length; i++)
            {
                randomChars[i] = Chars[_random.Next(Chars.Length)];
                TaxiDriverID = TaxiDriverID + randomChars[i];
            }
            
            return TaxiDriverID;
        }
    }
}
