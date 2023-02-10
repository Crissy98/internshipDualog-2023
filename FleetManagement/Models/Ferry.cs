using System.Xml.Linq;

namespace DotNet6Console.Models;


 public class Ferry : Vessel
{
    public int passengers;
    public Ferry(string name, uint year, int passengers,Speed speed) : base(name, year, speed)
    {
        this.passengers = passengers;
    }

    public Ferry(string name, string year,int passengers,Speed speed) : base(name, year,speed)
    {
        this.passengers = passengers;
    }


    public override string ToString()
    {
        return $"{GetVesselInfo()}\nPassengers: {passengers}\n--------------\n";
    }

}

