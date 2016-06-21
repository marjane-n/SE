using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gomrok.DB;
using gomrok.Entity;

namespace gomrok.ctrller
{
    public class licenseMatsCtrl
    {
        database db = database.getDataBase();
        licenseMatTable _licenseMatTable = licenseMatTable.get_license_table();
        public licenseMatContainer lmc = new licenseMatContainer();
        internal void insert_licenseMats(licenseMatContainer _lmc)
        {
            _licenseMatTable.insert_licenseMats(_lmc);
        }

        public void add_licenseMat(int Lid, string MName, string Mcomp, int MMinFee, int MMaxFee, int MMinWeight, int MMaxWeight, int MMinCount, int MMaxCount)
        {
            licenseMat lm = new licenseMat( Lid, MName, Mcomp,  MMinFee,  MMaxFee, MMinWeight,  MMaxWeight, MMinCount,MMaxCount);
            lmc.addToLicenseMatContainer(lm);
        }

        public void add_all_licenses(){
            _licenseMatTable.insert_licenseMats(lmc);
        }

        public void init_licenseMatlist(licenseMatContainer _lmc)
        {
            foreach (licenseMat lm in _lmc.licenseMatList())
            {
                lmc.addToLicenseMatContainer(lm);
            }
        }

        public void updateLicenseMats(List<licenseMat> licensemats2)
        {
            _licenseMatTable.updatelicMats(licensemats2);
        }
    }
}
