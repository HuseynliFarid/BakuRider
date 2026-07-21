using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BakuRider_Automatic_Taxi_System_.CarClass
{
    public class BusinessCar : Cartemplate
    {
        public override decimal PricePerKm => 1.50m;
    }
}
