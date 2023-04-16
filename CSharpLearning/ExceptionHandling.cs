using System;

namespace CSharpLearning;

public class ExceptionHandling
{

    static ExceptionHandling()
    {
        Console.WriteLine("\n\n");
    }
    public static void HandleMyException()
    {
        // Try catch finally block...
        try
        {
            var age4 = "20";
            int age5 = Convert.ToInt32(age4);
            Console.WriteLine(age5);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        // you can write here multiple catch block
        finally
        {
            Console.WriteLine("Finally block executed.");
        }
            
            
        // try block without catch block...
        // in this case, must have to write finally block after try block. 
        try
        {
            var num = 5;
            if (num == 5) return;

        }
        finally
        {
            Console.WriteLine("Try block without catch block executed. \n\n");
        }
    }
}