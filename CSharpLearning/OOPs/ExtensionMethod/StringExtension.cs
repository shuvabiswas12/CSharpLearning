namespace CSharpLearning.OOPs.ExtensionMethod;

public static class StringExtension
{
    
    /**
     * 1. Extension method allows user to add new methods to the existing class without modifying the original class.
     * 2. For creating extension class, Method should be static. Because extension methods will directly call by the class name.
     *      Not by the object creation.
     * 3. You can define the extension method class as a static class.
     * */
     
    
    
    // I wrote "this string s", because I want to bind "this string s" to that string where this method is called.
    // for example: var name = "abcd";
    // so, name.RightSubString(2);
    // In above example name obj will bind with "this string s".
    public static string RightSubString(this string s, int count)
    {
        var output = s.Substring(0, count);
        return output;
    }
}

