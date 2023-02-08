namespace DotNet6Console.Models;


internal class Tugboat : Vessel
{
    private uint maxForce;
    public Tugboat(string name, uint year, uint maxForce) : base(name, year)
    {
        this.maxForce = maxForce;
    }

    public Tugboat(string name, string year,uint maxForce) : base(name, year)
    {
        this.maxForce = maxForce;
    }

    public override string GetVesselInfo()
    {
        return $"--------------\nType: Tugboat\nName: {name}\nYear Built: {yearBuilt}\nMax Force: {maxForce}\n--------------\n";
    }
}