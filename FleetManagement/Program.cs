
using DotNet6Console.Models;

// Create a list of vessels.
List<Vessel> vessels = new List<Vessel> { new Vessel("Test Ship 2","2010") };

foreach (Vessel item in vessels)
{
    Console.WriteLine(item.Name);
}
Console.ReadKey();
           
