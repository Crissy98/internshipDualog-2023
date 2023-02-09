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

    /*public override string GetVesselInfo()
    {
        return $"--------------\nType: Submarine\nName: {name}\nYear Built: {yearBuilt}\nSpeed: {speed}\n Max Force: {maxDepth}\n--------------\n";
    }*/

    public override string ToString()
    {
        return $"{GetVesselInfo()}\nMax Force: {maxDepth}\n{speed}\n--------------\n";
    }
}

