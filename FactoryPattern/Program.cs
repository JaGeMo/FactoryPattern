using System;
using System.ComponentModel;
using FactoryPattern.Interfaces;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var bikeFactory = new BikeFactory("StreetBike");
            IBike bike = bikeFactory.GetBike();
            var test = bike.GetCycleType();
        }
    }
}