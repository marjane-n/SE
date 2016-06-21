using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gomrok.Entity
{
    public class licenseMatContainer
    {
         public List<licenseMat> list;
  
        public licenseMatContainer()
        {
            list = new List<licenseMat>();
        }
        public void addToLicenseMatContainer(licenseMat l)

        {
            list.Add(l);
        }
        public List<licenseMat> licenseMatList()
        {
            return list;
        }
 
        public void clearList()
        {
            list.Clear();
        }
    }
}
