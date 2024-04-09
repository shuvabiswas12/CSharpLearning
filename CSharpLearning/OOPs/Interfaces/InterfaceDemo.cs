using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CSharpLearning.OOPs.Interfaces
{
    /**
     * Default implementation in the interface.
     * Explicit implementation on the inheritted class.
     */

    // Interface is a contruct or a pure contract.
    // Is-a relationship means it is Interface. Meaning, parent and child relationship.
    interface IAnimal
    {
        // interface can not contain instance variable
        // string Name;   // => throws an error
        // interface can contain property
        string Name { get; set; }  // property
        void PrintAnimalName(string name);

        // Default implementation in the interface
        string Message()
        {
            return string.Empty;
        }

        // default implementation in the interface
        void Log(Exception exception) => Console.WriteLine(exception.Message); 
    }
    public class InterfaceDemo : IAnimal
    {
        public string Name { get; set; }

        public void PrintAnimalName(string name)
        {
            throw new NotImplementedException();
        }
    }

    interface IBook
    {
        void GetName();
    }

    interface IPaper
    {
        void GetName();
    }

    public class Test : IBook, IPaper
    {
        // explicit interface implementation 
        void IBook.GetName() => Console.WriteLine("Explicit implementation for IBook interface.");
        void IPaper.GetName() => Console.WriteLine("Explicit implementation for IPaper interface.");


        void run()
        {
            // If one would try to access default implementation of any interface, he/she should hold the inherited class reference to interface type like bellow.
            IAnimal animal = new InterfaceDemo();
            animal.Message();
        }
    }
}
