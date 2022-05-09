using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.OOPs
{
    class Indexers
    {

        /*
         * Indexers use in setUp cookie. This is an example of indexers.
         */

        // In this dictionary key also string type and value also string type
        private readonly Dictionary<String, String> _dictionary;

        public Indexers()
        {
            this._dictionary = new Dictionary<string, string>();
        }

        /*
         * Indexers does not have any name. That is why we used this keyword and after this keyword
         * we used '[]' syntax.
         */
        public String this[string key]
        {
            get { return this._dictionary[key];  }

            // Here 'value' is a value which is in rightside of the assignment operator
            set { this._dictionary[key] = value; }
        }

    }
}
