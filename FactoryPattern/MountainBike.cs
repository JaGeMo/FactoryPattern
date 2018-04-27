using FactoryPattern.Interfaces;

namespace FactoryPattern
{
    public class MountainBike : IBike
    {
        // props
        public string Name { get; set; }
 
        public int Size { get; set; }
        
        // constructors
        public MountainBike(){}
        
        // methods
        public string GetCycleType()
        {
            return "MountainBike";
        }
    }
}