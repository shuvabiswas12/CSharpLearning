using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.OOPs
{
    // There is no object creation from an Abstract class.
    // Abstract class is a half defined parent class.
    public abstract class AbstractClassDemo
    {
        public decimal Salary { get; set; }

        // The constructor of abstract class is protected bydefault.
        protected AbstractClassDemo()
        {
            Console.WriteLine("Abstract class instance called!");
        }

        public void PrintClassName()
        {
            Console.WriteLine(this.GetType());
        }

        // abstract method bydefault is a virtual method.
        public abstract void Run();
    }
}
