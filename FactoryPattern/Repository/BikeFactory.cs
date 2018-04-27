using System;
using FactoryPattern.Interfaces;

namespace FactoryPattern
{
    public class BikeFactory
    {
        private string _name;
        
        public BikeFactory(string bikeName)
        {
            _name = bikeName;
        }
        
        public IBike GetBike()
        {
            switch (_name)
            {
                case "StreetBike":
                    return new StreetBike();   
                case "MountainBike":
                    return new MountainBike();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}