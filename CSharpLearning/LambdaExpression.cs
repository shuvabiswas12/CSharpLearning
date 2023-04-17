using System;
using System.Linq;

namespace CSharpLearning;

public class LambdaExpression
{
    public static void Run()
    {
        
        // "Func<>" is a delegate
        // There are another delegate named "Action"
        
        Func<int, int> Square = (num) => num * num;
        Console.WriteLine(Square(5));
        
        Func<int, int, int> Add = (num1, num2) => num1 + num2;
        Console.WriteLine(Add(5, 6));


    }
}