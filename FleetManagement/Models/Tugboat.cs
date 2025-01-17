﻿namespace DotNet6Console.Models;


public class Tugboat : Vessel
{
    private uint maxForce;
    public Tugboat(string name, uint year, uint maxForce, Speed speed) : base(name, year, speed)
    {
        this.maxForce = maxForce;
    }

    public Tugboat(string name, string year,uint maxForce, Speed speed) : base(name, year, speed)
    {
        this.maxForce = maxForce;
    }

    public override string ToString()
    {
        return $"{GetVesselInfo()}\nMax Force: {maxForce}\n--------------\n";
    }
}