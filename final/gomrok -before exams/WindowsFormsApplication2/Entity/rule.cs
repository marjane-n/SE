using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gomrok.Entity
{
    public class rule
    {
        public string rulename;
        public int min_totalVal;
        public int max_totalVal;
        public string originCountry;
        public string start_date;
        public string finish_date;
        public int transType;
        public List<goodRule> goodList;
        public int rulePK;

        public rule(string _rulename, int _min_totalVal, int _max_totalVal, string _originCountry, int _transType, string _start_date, string _finish_date)
        {
           
            rulename = _rulename;
            min_totalVal = _min_totalVal;
            max_totalVal = _max_totalVal;
            originCountry = _originCountry;
            transType = _transType;
            start_date = _start_date;
            finish_date = _finish_date;
            originCountry = _originCountry;
            transType = _transType;
            //هوایی
            //زمینی
            //دریایی

        }
        public rule(int _ruleID, string _rulename, int _min_totalVal, int _max_totalVal, string _originCountry, int _transType, string _start_date, string _finish_date)
        {
            //MessageBox.Show("rule constructor" + "  " + _rulename + "/" + _min_totalVal + "/" + _max_totalVal + "/" + _originCountry + "/" + _transType + "/" + _start_date + "/" + _finish_date);
            rulePK = _ruleID;
            rulename = _rulename;
            min_totalVal = _min_totalVal;
            max_totalVal = _max_totalVal;
            originCountry = _originCountry;
            transType = _transType;
            start_date = _start_date;
            finish_date = _finish_date;
            originCountry = _originCountry;
            transType = _transType;
            //هوایی
            //زمینی
            //دریایی
        }
        public void setGoodList(List<goodRule> _goodList)
        {
            //List<goodRule>?????chera marjane
            goodList = _goodList;
        }
    }
}
