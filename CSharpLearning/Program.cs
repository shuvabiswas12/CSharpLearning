using CSharpLearning.OOPs;
using System;

namespace CSharpLearning
{
    class Program
    {
        /**
         * Shortcut:
         * --------
         * 
         * To build the solution press 'Ctrl + Shift + B'
         * To run the solution press 'Ctrl + F5'
         * 
         */

        static void Main(string[] args)
        {
            Console.WriteLine("CSharp Learning\n");

            var variables = new Variables(id: 101, fullName: "Mosh Hamidane", 1200, 900, 10000, false, 'A');
            variables.getAllVariables();

            /**
             * Formatted string
             * ----------------
             * 
             * {0} represent first parameter after formatted string
             * {1} represent second parameter after formatted string
             */

            Console.WriteLine("Min Value of byte = {0}, Max value of byte = {1}", byte.MinValue, byte.MaxValue);

            var arraysAndStrings = new ArraysAndStrings();

            var enums = new Enums();

            // random numbers and chars
            // generate password
            var randomNumbers = new RandomNumbers();

            var arrayAndArrayList = new ArrayAndArraylist();

            var dateTime = new DateAndTimes();

            var fileHandlig = new FilesHandling();


            // OOPs started

            var paramsKeyword = new ParamsKeyword();

            var methodOverloading = new MethodOverloading(10, 20);
            methodOverloading.Move(methodOverloading);

            var refKeyword = new RefKeyword();

            var indexers = new Indexers();
            indexers["Name"] = "Mosh Hamedani";
            Console.WriteLine("\n Indexers value = {0}", indexers["Name"]);

            Console.ReadLine();

        }
    }
}
