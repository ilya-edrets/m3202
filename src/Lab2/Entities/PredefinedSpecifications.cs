namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public class PredefinedSpecifications
{
    public Specification GetAppleSpecification()
    {
        return new Specification
        {
            CpuName = "Intel i7 13600H",
            MotherBoardName = "Apple 17",
            RamSticks = new
            {
                "Kingstone KVM DDR5 4800 8Gb",
                "Kingstone KVM DDR5 4800 8Gb",
                "Kingstone KVM DDR5 4800 8Gb",
                "Kingstone KVM DDR5 4800 8Gb"
            }
        };
    }
}