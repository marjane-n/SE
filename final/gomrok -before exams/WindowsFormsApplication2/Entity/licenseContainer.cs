using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gomrok.Entity
{
    public class licenseContainer
    {
        public List<license> list;

        public licenseContainer()
        {
            list = new List<license>();
        }
        public void addToLicenseContainer(license l)

        {
            list.Add(l);
        }
        public List<license> licenseList()
        {
            return list;
        }
        public void removeFromLicenseContainer(string licenseID)
        {
            /*var itemToRemove = list.SingleOrDefault(r => r.primaryKey == _goodPrimaryKey);
            if (itemToRemove != null)
            {
                list.Remove(itemToRemove);
                //MessageBox.Show("removing...." + _goodPrimaryKey);
            }*/
        }
        public void clearList()
        {
            list.Clear();
        }
    }
}
