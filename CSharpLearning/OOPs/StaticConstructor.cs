using System;

namespace test
{
    class StaticConstructor
    {
        /**
         * Static constructor does not use for creating object of this class.
         * Infact, there is no object creating of this class for Static constructor.
         */
        static StaticConstructor()
        {
            Console.WriteLine("Static constructor called.");
        }

        /**
         * Whenever this static property gets called, 
         * static constructor will gets called automatically before executing the static method.
         */
        public static void GetAll()
        {
            Console.WriteLine("Getting all.");
        }
    }
}
