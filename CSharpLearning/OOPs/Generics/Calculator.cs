namespace CSharpLearning.OOPs.Generics;

public static class Calculator
{
   // This is a generics method.
   // Here, T is a type.
   
   public static bool AreEqual<T>(T a, T b)
   {
      return a.Equals(b);
   }
}