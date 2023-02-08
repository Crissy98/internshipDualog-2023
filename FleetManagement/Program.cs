
using DotNet6Console.Models;

// Create a list of vessels.
List<Vessel> vessels = new List<Vessel> 
{ 
    //new Ferry("Test Ship 1 - ",2025), 
    new Ferry("Test Ship 1 ","2020"),
    new Tugboat("Test Ship 2 ",2020),
    //new Submarine("Test Ship 3 ",2000)
};

foreach (Vessel item in vessels)
{
    Console.WriteLine(item.Name);
}
Console.ReadKey();
           
