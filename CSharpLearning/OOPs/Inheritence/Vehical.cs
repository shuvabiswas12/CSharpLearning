using System;

namespace CSharpLearning.OOPs.Inheritence;

public class Vehical
{
    public string Name { get; private set; }
    public string year { get; private set; }

    public Vehical(string name, string year)
    {
        Name = name;
        this.year = year;
    }

    public virtual void ShowDetails()
    {
        Console.WriteLine("From BaseClass");
        Console.WriteLine($"Name = {Name}, Year = {year}");
    }
}