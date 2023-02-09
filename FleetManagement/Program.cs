
using DotNet6Console.Models;


    // Create a list of vessels.
    List<Vessel> vessels = new List<Vessel>();


    try
    {
        // Add vessels to the list.
        vessels.Add(new Ferry("Test Ship 1", 2010, 4, new Speed(10)));
        vessels.Add(new Tugboat("Test Ship 2", 2011, 10, new Speed(40)));
        vessels.Add(new Tugboat("Test Ship 3", 2015, 200, new Speed(40)));

        foreach (Vessel vessel in vessels)
        {
            Console.WriteLine(vessel.ToString());

        }

    }
    catch (Exception ex)
    {
        Console.WriteLine("An Exception has occurred: {0}", ex.Message);
    }


