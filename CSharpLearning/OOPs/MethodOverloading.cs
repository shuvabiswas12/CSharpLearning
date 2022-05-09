using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.OOPs
{
    class MethodOverloading
    {
        private int X;
        private int Y;
        public MethodOverloading(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            Console.WriteLine("\n Point X = {0} and Point Y = {1}", this.X, this.Y);
        }


        // here are two same name's method that is Move().
        // This is called about method overloading...

        public void Move(MethodOverloading point)
        {
            // check null pointer excepion
            if (point == null) { throw new ArgumentNullException("Point is null."); }

            Move(point.X++, point.Y++);
        }
    }
}
