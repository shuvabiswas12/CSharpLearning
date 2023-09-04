namespace CSharpLearning.OOPs;

// Add Static keyword here so that no user can create object for this class.
// Static class does not support inheritance.
// Adding Static keyword here meaning, All members have to be static or else compiler will give error.
public static class StaticClassDemo
{
    public static string Role { get; set; }
    
    // Static constructor does not have access modifier.
    // Static constructor does not have any parameter
    // Static constructor does not access 'this' keyword
    // Use Static constructor to initialize static members
    // Use Static class when declare Utility class
    static StaticClassDemo()
    {
        Role = "User";
    }
}