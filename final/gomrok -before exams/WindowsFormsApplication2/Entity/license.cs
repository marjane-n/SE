using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gomrok.Entity
{
    public class license
    {
        public int licenseID;
        public string bizSSN;
        public string Name;
        public int TypeOfTrans;
        public int MinAmount;
        public int MaxAmount;
        public string StartDate;
        public string EndDate;
        public string SrcCountry;

        public license(int _licenseID, string _bizSSN, string _Name, int _TypeOfTrans, int _MinAmount, int _MaxAmount, string _StartDate, string _EndDate, string _SrcCountry)
        {
            licenseID=_licenseID;
            bizSSN = _bizSSN;
            Name = _Name;
            TypeOfTrans = _TypeOfTrans;
            MinAmount = _MinAmount;
            MaxAmount = _MaxAmount;
            StartDate = _StartDate;
            EndDate = _EndDate;
            SrcCountry = _SrcCountry;
        }
    }
}
