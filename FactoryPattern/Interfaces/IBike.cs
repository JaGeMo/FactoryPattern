namespace FactoryPattern.Interfaces
{
    public interface IBike
    {
        string Name { get; set; }

        int Size { get; set; }

        string GetCycleType();
    }
}