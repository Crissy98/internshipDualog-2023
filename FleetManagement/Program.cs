
using DotNet6Console.Models;


    // Create a list of vessels.
    List<Vessel> vessels = new List<Vessel>();


    try
    {
        // Add vessels to the list.
        vessels.Add(new Ferry("Test Ship 1", "2010", 4, new Speed(10)));
        vessels.Add(new Tugboat("Test Ship 2", 2011, 100, new Speed(15)));
        vessels.Add(new Submarine("Test Ship 3", 2020, 1000, new Speed(24)));

        foreach (Vessel vessel in vessels)
        {
            Console.WriteLine(vessel.ToString());
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("An Exception has occurred: {0}", ex.Message);
    }


