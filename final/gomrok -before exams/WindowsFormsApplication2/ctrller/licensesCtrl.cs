using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gomrok.DB;
using gomrok.Entity;

namespace gomrok.ctrller
{
    class licensesCtrl
    {
        database db = database.getDataBase();
        licenseTable _licenseTable = licenseTable.get_license_table();
        public licenseContainer lc = new licenseContainer();
        internal void insert_licenses(licenseContainer lcc)
        {
            _licenseTable.insert_licenses(lcc);
        }

        public void add_license(int licenseID, string bizSSN, string Name, int TypeOfTrans, int MinAmount, int MaxAmount, string StartDate, string EndDate, string SrcCountry)
        {
            license l = new license(licenseID, bizSSN, Name, TypeOfTrans, MinAmount, MaxAmount, StartDate, EndDate, SrcCountry);
            lc.addToLicenseContainer(l);
        }

        public void add_all_licenses(){
            _licenseTable.insert_licenses(lc);
        }

        public int get_last_id()
        {
            int new_id = _licenseTable.get_id();
            return new_id;
        }

        public void updateLicenses(List<license> licenses2, List<int> owned)
        {
            _licenseTable.updateLicense(licenses2, owned);
        }

    }
}
