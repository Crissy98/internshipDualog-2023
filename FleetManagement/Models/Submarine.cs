namespace DotNet6Console.Models;


internal class Submarine : Vessel
{
    private int maxDepth;
    public Submarine(string name, uint year, int maxDepth, Speed speed) : base(name, year, speed)
    {
        this.maxDepth = maxDepth;
    }

    public Submarine(string name, string year, int maxDepth, Speed speed) : base(name, year,speed)
    {
        this.maxDepth = maxDepth;
    }

    public override string ToString()
    {
        return $"{GetVesselInfo()}\nMax Depth: {maxDepth}\n";
    }
}

