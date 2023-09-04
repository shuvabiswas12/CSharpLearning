using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning
{
    public class ExpressionBodyMember
    {
        // This is method. That is return a string.
        // This expression is very identical to javascript fat arrow function.
        public string getClassName() => "ExpressionBodyMember Class";
        public string getName(int age) => $"Age = {age}";
    }
}
