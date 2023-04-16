namespace CSharpLearning.OOPs.Generics;

// Here, T is a type.
public static class NewCalculator<T>
{
    public static bool Calculate(T a, T b)
    {
        return a.Equals(b);
    }
}