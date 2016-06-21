using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Entity
{
    public class license_rule_entity
    {
        public string licName = null;
        public int liID = -1;
        public string ruleName = null;
        public int ruleID = -1;
         public string goodName;
        public string company;
        public int min_weight;
        public int max_weight;
        public int min_qnty;
        public int max_qnty;
        public int min_unitPrice;
        public int max_unitPrice;

        public license_rule_entity(string _lname, string _rname, int _lId, int _rId)
        {
            licName = _lname;
            liID = _lId;
            ruleName = _rname;
            ruleID = _rId;
        }
        public license_rule_entity(string _lname, string _rname, int _lId, int _rId, string _name, string _com, int _min_weight, int _max_weight, int _min_qnty, int _max_qnty, int _min_unitPrice, int _max_unitPrice) 
        {
            licName = _lname;
            liID = _lId;
            ruleName = _rname;
            ruleID = _rId;
            goodName = _name;
            company = _com;
            min_weight = _min_weight;
            max_weight = _max_weight;
            min_qnty = _min_qnty;
            max_qnty = _max_qnty;
            min_unitPrice = _min_unitPrice;
            max_unitPrice = _max_unitPrice;
        }
    }
}
