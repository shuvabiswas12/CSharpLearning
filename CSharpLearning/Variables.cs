using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning
{
    class Variables
    {

        /**
         * "readonly" fields can be initialised during declaration as well as inside the constructor portion.
         * It can not be modified later.
         */

        readonly int Id;
        readonly string FullName;
        readonly char firstChar;
        readonly decimal Amount;
        readonly float Points = 800f;
        readonly double Salary = 1200;
        readonly bool IsLoggedin;

        public Variables(int id, string fullName, decimal amount, float? points, double salary, bool isLoggedIn, char firstChar)
        {
            this.Id = id;
            this.FullName = fullName;
            this.Amount = amount;

            /**
             * Question(?) mark means that variable is optional
             * */

            this.Points = (float) points;

            this.Salary = salary;
            this.IsLoggedin = isLoggedIn;
            this.firstChar = firstChar;
        }

        public void GetAllVariables()
        {
            Console.WriteLine("FullName = " + this.FullName);
            Console.WriteLine("Id = " + this.Id);
            Console.WriteLine("Salary = " + this.Salary);
            Console.WriteLine("Amount = " + this.Amount);
            Console.WriteLine("IsLoggedIn = " + this.IsLoggedin);
            Console.WriteLine("Points = " + this.Points);
            Console.WriteLine("FirstChar = " + this.firstChar);

            // const variable
            const float totalEarnings = 900.0f;

            Console.WriteLine("Constant Variable's Value = " + totalEarnings);

            // var is a another type of variable
            var varVariable = 100;
            Console.WriteLine("Var Variable's Value = " + varVariable);
        }
    }
}
