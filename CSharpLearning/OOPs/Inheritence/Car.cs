using System;

namespace CSharpLearning.OOPs.Inheritence;

public class Car : Vehical
{
    public Car(string name, string year) : base(name, year)
    {
    }

    public override void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine("From child class.");
    }
}