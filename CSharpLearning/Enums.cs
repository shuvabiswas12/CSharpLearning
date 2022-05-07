using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning
{
    public enum ShippingAddress
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    public enum MyColors
    {
        /*
         * we can define enums like these that have no value beign assigned by us.
         */
        Red,
        Orange,
        White
    }

    class Enums
    {
        /*
         * If we do not cast with 'int' type then enum returns the names as returns 
         * value instead of int value what we define at enum declaration.
         * By default these enum property has a initial value that are 0, 1, 2.
         * You can change these value by assiging new value.
         */
        public Enums()
        {
            Console.WriteLine(@"Regular AirMail: {0},
RegisteredAirMail: {1},
Express: {2}", 
            (int) ShippingAddress.RegularAirMail, 
            (int) ShippingAddress.RegisteredAirMail, 
            (int) ShippingAddress.Express);


            Console.WriteLine(@"Red: {0}, Orange: {1}, White: {2}", (int) MyColors.Red, MyColors.Orange, MyColors.White);

            this.GetEnumsPropertyById();
            this.ParseAStringToEnum();
        }

        void GetEnumsPropertyById()
        {
            var methodId = 3;
            // getting property name by an id using explicit casting
            var methodName = (ShippingAddress) methodId;
            Console.WriteLine(methodName);
        }

        void ParseAStringToEnum()
        {
            var methodName = "Express";
            var parsedMethod = (ShippingAddress) Enum.Parse(typeof(ShippingAddress), methodName);
            Console.WriteLine("Parsed Done.");
        }
    }
}
