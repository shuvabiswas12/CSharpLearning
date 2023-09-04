using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.OOPs
{
    public class InItKeywordDemo
    {
        // Here, we have used init keyword instead of set keyword for set a property.
        // In this way, we can not initialized any property without object initializer.
        // This init keyword initialized property once during object initializer
        // and after that the initilaized property can not be changed
        public string FullName { get; init; } = string.Empty;
        public int age { get; init; } = 1;
    }
}
