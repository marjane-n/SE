using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gomrok.Entity
{
    class Businessman
    {
        public string ssn;
        public string firstName;
        public string lastName;

        public Businessman(string _ssn, string _firstName, string _lastName)
        {
            ssn = _ssn;
            firstName = _firstName;
            lastName = _lastName;
        }
    }
}
