using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.OOPs
{
    class RefKeyword
    {
        public RefKeyword()
        {
            int i = 100;
            Console.WriteLine("\n Initial Value = {0}", i);
            this.Add(ref i);
            Console.WriteLine("\n After Add method Initial Value = {0}", i);
        }

        public void Add(ref int value)
        {
            value++;
            Console.WriteLine("\n From Add method the Value = {0}", value);
        }

        
    }
}
