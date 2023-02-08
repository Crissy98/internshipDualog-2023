using System.Xml.Linq;

namespace DotNet6Console.Models;


internal class Ferry : Vessel
{
    public int passengers;
    public Ferry(string name, uint year, int passengers) : base(name, year)
    {
        this.passengers = passengers;
    }

    public Ferry(string name, string year,int passengers) : base(name, year)
    {
        this.passengers = passengers;
    }

    public override string GetVesselInfo()
    {
        return $"--------------\nType: Ferry\nName: {name}\nYear Built: {yearBuilt}\nPassengers: {passengers}\n--------------\n";
    }
}

