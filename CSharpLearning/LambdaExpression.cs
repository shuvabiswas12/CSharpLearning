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

        // This is another way to define lamba expression.
        /**
         * C# compiler automatically converts this expression given bellow into a delegates expression like upper expression.
         * Func<int, int, int> Subtract = (num1, num2) => num1 - num2
         * 
         * This is happen when c# compiler see its a lambda expression.
         */
        var Subtract = (int num1, int num2) => num1 - num2;
        // You can specify the return type in this.
        // var Subtract = int (int num1, int num2) => num1 - num2;


    }
}