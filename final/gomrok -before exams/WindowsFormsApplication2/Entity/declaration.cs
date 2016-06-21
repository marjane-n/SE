using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gomrok.Entity
{
    class declaration
    {
        public string bizManSsn;
        public int totalVal;
        public string originCountry;
        public int transType;
        public List<good> goodList;
        public int decPK;

        public declaration(string _bizManSsn, int _totalVal, string _originCountry, int _transType)
        {
            bizManSsn = _bizManSsn;
            totalVal = _totalVal;
            originCountry = _originCountry;
            transType = _transType;
            //هوایی
            //زمینی
            //دریایی
           
        }
        public declaration()
        {

        }
        public void setGoodList(List<good> _goodList)
        {
            List<good> goodList = _goodList;
        }
    }
    
}
