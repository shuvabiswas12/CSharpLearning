using System;

namespace CSharpLearning.OOPs.Delegates;

/**
 * A delegate is an object which refers to a method or you can say it is a reference type
 * variable that can hold a reference to the methods.
 * Delegates in C# are similar to the function pointer in C/C++.
 *
 * Declare a delegate with the following syntax:
 *          [modifier] delegate [return_type] [delegate_name] ([parameter_list]);
 */

// Declaring delegates
public delegate void Calculator(int a, int b);

public static class Utils
{
    public static void AddTwoNums(int a, int b)
    {
        Console.WriteLine($"Addition of {a} + {b} = {a + b}");
    }

    public static void SubTwoNums(int a, int b)
    {
        Console.WriteLine($"Subtraction of {a} - {b} = {a - b}");
    }

    public static void MultiplyThreeNums(int a, int b, int c)
    {
        Console.WriteLine($"Multiplication of {a} * {b} * {c} = {a * b * c}");
    }
}

public static class UseDelegate
{
    // Anonymous delegates
    // division 
    static readonly Calculator AnonymousDelegate = delegate(int a, int b)
    {
        Console.WriteLine($"Division of {a} / {b} = {a / b}");
    };

    public static void Run()
    {
        // This is how delegates are used in C#
        Calculator calc = new Calculator(Utils.AddTwoNums);

        // this is the way to add multiple methods to delegates one after another.
        // This is called multicast delegate.
        calc += Utils.SubTwoNums; 

        calc.Invoke(10, 20); // This line can be written as bellow.
        // calc(10, 20);
        
        
        
        // Calling anonymous delegate
        AnonymousDelegate(10, 20);
    }
}