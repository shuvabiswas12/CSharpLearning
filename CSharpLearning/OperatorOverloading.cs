using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning
{
    public class OperatorOverloading
    {
        private int _someValue;

        public OperatorOverloading(int value)
        {
            _someValue = value;
        }

        // custom operator overloading.
        // operator overloading example:-
        public static OperatorOverloading operator +(OperatorOverloading args1, OperatorOverloading args2)
        {
            return new OperatorOverloading(args1._someValue + args2._someValue);
        }

        public void TestOperatorOverloading()
        {
            var obj1 = new OperatorOverloading(10);
            var obj2 = new OperatorOverloading(20);

            Console.WriteLine(obj1 + obj2);  // This is how operator overloading calls.
        }

    }
}
