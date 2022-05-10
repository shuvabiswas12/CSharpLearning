using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.OOPs
{
    class CSharpProperties
    {
        // This class shows properties in CSharp
        // Properties means gettter and setter which is get and set

        /*
         * Rules is If get and set auto implemented then fields put after constructor.
         * If not auto implemented then it should put on the top before constructor.
         */

        public DateTime Birthdate { get; private set; }
        public string Name { get; set; }

        public string NID { get; set; }

        public CSharpProperties()
        {
            this.Birthdate = new DateTime(2002, 3, 17);
            this.Name = "Mosh Hamedani";
            this.NID = "123456789";
            this.ShowNameAndAge();
        }

        public int Age
        {
            get {
                var timespan = DateTime.Now - Birthdate;
                var years = timespan.Days / 365;
                return years;
            }
        }

        public void ShowNameAndAge()
        {
            Console.WriteLine("\n Name = {0} and Age = {1}", this.Name, this.Age);
        }


    }

}
