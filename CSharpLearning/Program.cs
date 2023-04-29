using CSharpLearning.OOPs;
using System;
using CSharpLearning.OOPs.Delegates;
using CSharpLearning.OOPs.ExtensionMethod;
using CSharpLearning.OOPs.Generics;
using CSharpLearning.OOPs.Inheritence;
using CSharpLearning.OOPs.LINQ_demo;
using Book = CSharpLearning.OOPs.Book;
using Calculator = CSharpLearning.OOPs.Generics.Calculator;

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
            variables.GetAllVariables();

            // /**
            //  * Formatted string
            //  * ----------------
            //  * 
            //  * {0} represent first parameter after formatted string
            //  * {1} represent second parameter after formatted string
            //  */

            Console.WriteLine("Min Value of byte = {0}, Max value of byte = {1}", byte.MinValue, byte.MaxValue);

            var arraysAndStrings = new ArraysAndStrings();

            var enums = new Enums();

            // random numbers and chars
            // generate password
            var randomNumbers = new RandomNumbers();

            var arrayAndArrayList = new ArrayAndArraylist();

            var dateTime = new DateAndTimes();
            
            // File Handling...
            // var fileHandling = new FilesHandling();


            // OOPs started

            var paramsKeyword = new ParamsKeyword();

            var methodOverloading = new MethodOverloading(10, 20);
            methodOverloading.Move(methodOverloading);

            var refKeyword = new RefKeyword();

            // Indexers example...
            var indexers = new Indexers();
            indexers["Name"] = "Mosh Hamedani";
            Console.WriteLine("\n Indexers value = {0}", indexers["Name"]);

            // Indexers example end.


            // OopClass_1
            var customer = new Customer(101, "Paulo Deshone");
            customer.Orders.Add(new Order("Iphone 13 Pro max", 1001, 1200.00));
            customer.Orders.Add(new Order("Xiaomi breared trimmer", 1341, 200.00));

            customer.OrderDetail();


            // properties...
            var properties = new CSharpProperties();


            // struct ...
            var structBook = new Book();
            structBook.Name = "100 monishider kotha!";
            structBook.Year = 2005;
            structBook.Author = "Mykhel H Heart";
            structBook.Price = 400;
            Console.WriteLine(structBook);
            
            
            // Static class
            
            Console.WriteLine(StaticClassDemo.Role);
            
            
            // Inheritance...
            var hondaCivic = new Car("Honda Civic", "2020");
            hondaCivic.ShowDetails();
            
            // is keyword
            var age = 10;
            bool checkAge = age is int;  // is keyword checks type and returns true or false. 
            Console.WriteLine($"Age is int : {checkAge}");
            
            
            // as keyword -> convert or casting one types to another
            // var one = '1'; WriteLine(one as int);
            
            // Casting...
            var age2 = "20";
            int age3 = Convert.ToInt32(age2);
            Console.WriteLine(age3);

            
            // Extension method...
            var name = "Mosh Hamidane";
            Console.WriteLine(name.RightSubString(4));
            
            
            
            // Generics
            
            // These are the uses of some generics method.
            Console.WriteLine("\nGenerics example: ");
            Console.WriteLine(Calculator.AreEqual<int>(10, 20));
            Console.WriteLine(Calculator.AreEqual<string>("abc", "abc"));
            
            
            // These are the uses of generics class.
            Console.WriteLine(NewCalculator<string>.Calculate("asdf", "abcd"));
            
            // Exception Handling.
            ExceptionHandling.HandleMyException();
            
            // delegates
            UseDelegate.Run();
            
            
            // lambda function
            LambdaExpression.Run();
            
            
            // LINQ 
            // LinqDemo.Run();
            
            // Yield
            
            Yield.Run();
            
            Console.ReadLine();
        }
    }
}