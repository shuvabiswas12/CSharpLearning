using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.OOPs
{
    class ParamsKeyword
    {
        public ParamsKeyword()
        {
            Add(new int[] { 1, 2, 3});
            Add(1, 2, 3, 4);
            Add(new[] { 10, 12, 60 });
        }

        
        /*
         * 'params' is a keyword that takes a number of variable arguments.
         * 'params' keyword is used when we don't know how many arguments is in need of passing.
         */

        public static void Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine("\n Sum is {0}", sum);
        }
    }
}
