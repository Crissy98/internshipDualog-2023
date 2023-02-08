namespace DotNet6Console.Models;


internal class Submarine : Vessel
{
    private int maxDepth;
    public Submarine(string name, uint year, int maxDepth) : base(name, year)
    {
        this.maxDepth = maxDepth;
    }

    public Submarine(string name, string year, int maxDepth) : base(name, year)
    {
        this.maxDepth = maxDepth;
    }

    public override string GetVesselInfo()
    {
        return $"--------------\nType: Submarine\nName: {name}\nYear Built: {yearBuilt}\n Max Force: {maxDepth}\n--------------\n";
    }
}

