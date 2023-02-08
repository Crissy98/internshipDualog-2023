
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


    public void SetYearBuilt(string yearOfBuilt)
    {
        if (!string.IsNullOrWhiteSpace(yearOfBuilt))
        {
            if (Regex.IsMatch(yearOfBuilt, "^(20)[0-9][0-9]"))
            {
                uint year = uint.Parse(yearOfBuilt);
                SetYearBuilt(year);
            }
            else
                throw new ArgumentException("The year when the vessel was built is not in the corect format.");

        }
        else

            throw new ArgumentException("Please make sure that the year of built is not null.");

    }

    //check if the ship is too old
    public void SetYearBuilt(uint yearOfBuilt)
    {
        //check if the ship is older than 20 years 
        if (yearOfBuilt < DateTime.Now.Year - 20)
        {
            throw new OldShipException();
        }
        else if (yearOfBuilt >= DateTime.Now.Year)
        {
            throw new OldShipException($"I'm pretty sure we are in {DateTime.Now.Year}. The vessel could not be created in the future! :)");
        }

        this.yearBuilt = yearOfBuilt;
    }


}


