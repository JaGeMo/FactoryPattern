using FactoryPattern.Interfaces;

namespace FactoryPattern
{
    public class StreetBike : IBike
    {
        // props
        public string Name { get; set; }
 
        public int Size { get; set; }
        
        // constructors
        public  StreetBike(){}
        
        // methods
        public string GetCycleType()
        {
            return "StreetBike";
        }
    }
}