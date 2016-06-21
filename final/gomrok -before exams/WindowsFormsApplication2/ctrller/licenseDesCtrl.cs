using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gomrok.DB;
using gomrok.Entity;

namespace gomrok.ctrller
{
    class licenseDesCtrl
    {
        database db = database.getDataBase();
        licenseDesTable _ldesTable = licenseDesTable.get_licenseDes_table();
        public string license_org;
        public int addLicenseDesc(string licName, string orgname)
        {
            int licenseID = _ldesTable.addLicenseDes(licName, orgname);
            return licenseID;
        }
        public int checkLicense(string licName)
        {
            int id = _ldesTable.checkLicense(licName);
            license_org = _ldesTable.license_org;
            return id;
        }

    }
}
