using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpLearning;

public class Yield
{

    private static IEnumerable<int> GetEvenNumber(int upto = 10)
    {
        for (int i = 0; i < upto; i++)
        {
            // Each time yield is send back the num to calling method. After execution of rest of lines of calling method
            // the cursor of execution will moves here again and executes rest of lines.
            yield return i += 2;
            Console.WriteLine("Printed");
        }
    }

    public static void Run()
    {
        IEnumerable<int> nums = GetEvenNumber();

        foreach (var num in nums)
        {
            Console.WriteLine(num);
        }
    }
}