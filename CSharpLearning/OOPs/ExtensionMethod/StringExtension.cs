namespace CSharpLearning.OOPs.ExtensionMethod;

public static class StringExtension
{
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

