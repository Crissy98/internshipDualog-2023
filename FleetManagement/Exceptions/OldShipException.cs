namespace DotNet6Console.Models;


internal class OldShipException : Exception
{
    public OldShipException(string? message) : base(message)
    {
    }
    public OldShipException() : this("This vessel is too old. The age of the vessel should be less than 20 years.") { }
}

