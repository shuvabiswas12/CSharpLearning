using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning
{
    class ArraysAndStrings
    {
        public ArraysAndStrings()
        {
            this.Arrays();
            this.Strings();
            this.GetFirstAndLastName();
            this.GetPriceAndCurrency();
        }

        void Arrays()
        {
            /*
             * first int[] for declaring an array of numbers
             * second int[3] for initializing the length of the arrays
             */

            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;

            Console.WriteLine("{0}, {1}, {2}", numbers[0], numbers[1], numbers[2]);

            /* 
             * another way to declare array using var
             * var is used for dynamic variable
            */

            var addresses = new string[3];
            addresses[0] = "Chittagong, BD";
            addresses[1] = "Dhaka, BD";
            addresses[2] = "Helsinki, Finland";

            Console.WriteLine("{0} | {1} | {2}", addresses[0], addresses[1], addresses[2]);
        }

        void Strings()
        {
            /*
             * strings basically an array of chars.
             * we can access each chars using indexes like array.
             */
            var name = "Mosh Hamidane";
            Console.WriteLine(name);
            Console.WriteLine(name[0]);

            var fullName = new char[5];
            fullName[0] = 'M';
            fullName[1] = 'o';
            fullName[2] = 's';
            fullName[3] = 'h';

            var completeName = String.Format("{0} {1} {2} {3}", fullName[0], fullName[1], fullName[2], fullName[3]);
            Console.WriteLine(completeName);

            var completeName_V2 = String.Join(",", fullName);
            Console.WriteLine(completeName_V2);

            var text = "This is a dummy text.\n Demo Path is: C:\\Localhost:3000";
            Console.WriteLine(text);

            /*
             * we can write this text given up in text variable as bellow using verboniam string.
             * In Verboniam string text can be pre formatted so we do not need to use '\n' or '\\' 
             * for single '\'
             */

            var text_v2 = @"This is a dummy text.
Demo path is: C:\Localhost:3000";
            Console.WriteLine(text_v2);
        }

        void GetFirstAndLastName()
        {
            var fullName = "Mosh Hamidane";
            var findSpace = fullName.IndexOf(" ");
            var firstName = fullName.Substring(0, findSpace);
            var lastName = fullName.Substring(findSpace);
            Console.WriteLine("FirstName = {0} and LastName = {1}", firstName, lastName);
        }

        void GetPriceAndCurrency()
        {
            var price = 12;
            var actualPrice = price.ToString("C");
            Console.WriteLine("Price: {0}", actualPrice);

            Console.WriteLine("Another Price: {0}", Convert.ToInt32("1200").ToString("C0"));
        }
    }
}
