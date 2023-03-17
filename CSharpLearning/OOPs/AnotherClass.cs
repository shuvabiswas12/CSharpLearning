namespace CSharpLearning.OOPs;

public class AnotherClass
{
    // This class shows how to declare property in various way.

    private string _name;
    
    // This get and set prop can be written as like bellow:
    // private string _name { get; set; }   ==> This is shortcut.
    
    // Or in details you can write the get and set prop as like this.
    public string Name
    {
        get { return this._name; }
        set { this._name = value;  }
    }
    
    public int Age;
    
    // Similarly, Age property can be written as bellow:
    // public int Age { get; set; }     ===> This is shortcut.

    // Or if you want to customise the get and set functionality you can write this as bello: 
    public int MyAge
    {
        get { return this.Age; }
        set { this.Age = value; }
    }
}