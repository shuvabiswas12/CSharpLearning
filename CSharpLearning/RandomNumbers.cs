using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning
{
    class RandomNumbers
    {
        private readonly Random _randomObj;
        public RandomNumbers()
        {
            _randomObj = new Random();
            // generate a random number
            Console.WriteLine(_randomObj.Next());

            this.GenerateRandomChars();
            this.GenerateRandomNumbers();
            this.GeneratePassword();
            this.GenerateLoginId();
        }

        void GenerateRandomNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                // generate 10 random numbers between 1 to 10.
                Console.WriteLine(_randomObj.Next(1, 10));
            }
        }

        void GenerateLoginId()
        {
            var loginID = "";

            for (int i = 0; i < 2; i++)
            {
                loginID += (char)_randomObj.Next(65, 90);
            }

            for (int i = 0; i < 1; i++)
            {
                loginID += (char) ('a' + _randomObj.Next(0, 26));
            }

            loginID = loginID + "-" + _randomObj.Next(1111, 9999);

            Console.WriteLine("LoginId = {0}", loginID);

        }

        void GenerateRandomChars()
        {
            for (int i=0; i<10; i++)
            {
                Console.Write((char) _randomObj.Next(97, 122));
            }
            Console.WriteLine();
        }

        void GeneratePassword()
        {
            var passwordLength = 5;
            var chars = new char[passwordLength];
            for (int i=0; i<passwordLength; i++)
            {
                // you can change the value as you want in the Next() method.
                chars[i] = (char) ('a' + _randomObj.Next(0, 26));
            }

            // In this line below, string keyword automatically mapped to the String classes.
            var newPassword = new string(chars);
            Console.WriteLine("Generated Password = " + newPassword);
        }
    }
}
