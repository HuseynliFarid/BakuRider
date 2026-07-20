using System;
using System.Collections.Generic;
using System.Text;

namespace BakuRider_Automatic_Taxi_System_.CarClass
{
    public abstract class Car
    {
        public string? CarModel;
        public string? CarPlateNumber;

        public abstract decimal PricePerKm { get; }
    }
}
