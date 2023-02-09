namespace DotNet6Console.Models;


internal class Tugboat : Vessel
{
    private uint maxForce;
    public Tugboat(string name, uint year, uint maxForce, Speed speed) : base(name, year, speed)
    {
        this.maxForce = maxForce;
    }

    public Tugboat(string name, string year,uint maxForce, Speed speed) : base(name, year, speed)
    {
        this.maxForce = maxForce;
    }

    /*public override string GetVesselInfo()
    {
        return $"--------------\nType: Tugboat\nName: {name}\nYear Built: {yearBuilt}\nSpeed: {speed}\nMax Force: {maxForce}\n--------------\n";
    }*/
    public override string ToString()
    {
        return $"{GetVesselInfo()}\nMax Force: {maxForce}\n--------------\n";
    }
}