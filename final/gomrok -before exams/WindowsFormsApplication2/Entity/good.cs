using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gomrok
{
    public class good
    {
        public string goodName;
        public string company;
        public int weight;
        public int qnty;
        public int unitPrice;
        public int primaryKey = 0;
        public good() { }
        public good(string _name, string _com, int _weight, int _qnty, int _unitPrice)
        {
            goodName = _name;
            company = _com;
            weight = _weight;
            qnty = _qnty;
            unitPrice = _unitPrice;
        }
    }
}
