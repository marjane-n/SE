using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gomrok
{
    class licenseDescription
    {
        public string licenseName;
        public string orgName;

        public licenseDescription(string _licenseName, string _orgName)
        {
            licenseName = _licenseName;
            orgName = _orgName;
        }
    }

}
