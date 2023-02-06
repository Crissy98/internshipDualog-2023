
using System.Text.RegularExpressions;

namespace DotNet6Console.Models;

//Vessell class should be abstract because we don't want to create a vessell , we want to create multiple types of vessells
public class Vessel

{
    private string name;

    private uint yearBuilt;

    public string Name
    {
        get { return name; }
        protected set { SetName(value); }
    }

    public uint YearBuilt
    {
        get { return yearBuilt; }
        set { SetYearBuilt(value); }
    }


    public Vessel(string name, uint year)
    {
        SetName(name);
        SetYearBuilt(year);
    }

    public Vessel(string name, string year)
    {
        SetName(name);
        SetYearBuilt(year);
    }


    //checking if the name of the ship is null
    public void SetName(string shipName)
    {
        if (string.IsNullOrWhiteSpace(shipName))
        {
            throw new ArgumentNullException(nameof(shipName), "The name of the vessel cannot be null or empty.");
        }

        this.name = shipName;
    }


    public void SetYearBuilt(string yearBuilt)
    {
        if (string.IsNullOrWhiteSpace(yearBuilt))
        {
            uint year = uint.Parse(yearBuilt);
            this.SetYearBuilt(year);
        }
    }

    //check if the ship is too old
    public void SetYearBuilt(uint yearBuilt)
    {
        //check if the ship is older than 20 years 
        if (yearBuilt < DateTime.Now.Year - 20)
        {
            throw new ArgumentOutOfRangeException();
        }
        else if (yearBuilt >= DateTime.Now.Year)
        {
            throw new ArgumentOutOfRangeException($"I'm pretty sure we are in {DateTime.Now.Year}. The vessel cannot be created in the future! :)");
        }

        this.yearBuilt = yearBuilt;
    }


}


