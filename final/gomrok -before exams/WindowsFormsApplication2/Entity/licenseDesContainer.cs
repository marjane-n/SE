using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gomrok
{
    class licenseDesContainer
    {
        public List<licenseDescription> list = new List<licenseDescription>();
        public void addToLicDesContainer(licenseDescription ld)
        {
            list.Add(ld);
        }
    }
}
