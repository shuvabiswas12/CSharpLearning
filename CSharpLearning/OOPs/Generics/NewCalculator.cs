namespace CSharpLearning.OOPs.Generics;

// Here, T is a type.
/**
 * There are 5 different types of constraints for generics.
 *
 *  where T : IComparable
 *  where T : Product
 *  where T : class
 *  where T : new()
 *  where T : struct
 *
 * Here, Product is a user defined class.
 * Here, new() meaning, any object that has default constructor.
 *
 * This constraints can be skipped sometimes.
 */
public static class NewCalculator<T> where T : class
{
    public static bool Calculate(T a, T b)
    {
        return a.Equals(b);
    }
}