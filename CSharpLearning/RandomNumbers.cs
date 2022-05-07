using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning
{
    class RandomNumbers
    {
        private readonly Random RandomObj;
        public RandomNumbers()
        {
            RandomObj = new Random();
            // generate a random number
            Console.WriteLine(RandomObj.Next());

            this.GenerateRandomChars();
            this.GenerateRandomNumbers();
            this.GeneratePassword();
        }

        void GenerateRandomNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                // generate 10 random numbers between 1 to 10.
                Console.WriteLine(RandomObj.Next(1, 10));
            }
        }

        void GenerateRandomChars()
        {
            for (int i=0; i<10; i++)
            {
                Console.Write((char) RandomObj.Next(97, 122));
            }
            Console.WriteLine();
        }

        void GeneratePassword()
        {
            var passwordLength = 10;
            var chars = new char[passwordLength];
            for (int i=0; i<passwordLength; i++)
            {
                // you can change the value as you want in the Next() method.
                chars[i] = (char) ('a' + RandomObj.Next(0, 26));
            }

            // In this line below, string keyword automatically mapped to the String classes.
            var newPassword = new string(chars);
            Console.WriteLine("Generated Password = " + newPassword);
        }
    }
}
