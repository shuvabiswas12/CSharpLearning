namespace CSharpLearning.OOPs.Generics;

public static class Calculator
{
   // This is a generics method.
   // Here, T is a type.
   // we are using generics for type independent or type safety.
   // instead of using autoboxing and unboxing, we can use generics.
   // Generics improves performance.
 
   
   public static bool AreEqual<T>(T a, T b)
   {
      return a.Equals(b);
   }
}