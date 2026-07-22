using System;
using System.Collections.Generic;
using System.Text;

namespace BakuRider_Automatic_Taxi_System_.CarClass
{
    public abstract class Cartemplate
    {
        

        public string? CarModel;
        public string? CarPlateNumber;

        public virtual decimal  PricePerKm { get; }
    }

    public class Car : Cartemplate
    {
      
       
        
    }
}
