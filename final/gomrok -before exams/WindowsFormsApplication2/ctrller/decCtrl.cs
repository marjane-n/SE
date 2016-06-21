using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gomrok.Entity;
using gomrok.DB;
namespace gomrok.ctrller
{
    class decCtrl
    {
        database db = database.getDataBase();
        decTable _decTable = decTable.get_dec_table();
        ruleCtrl rc = new ruleCtrl();
        public int decID;
        public declaration declare;
        public List<string> needed_lincenses = new List<string>();


        public decCtrl()
        {
            decID = get_decID();
        }

        private void insert_new_dec(string _bizManSsn, int _totalVal, string _originCountry, int _transType)
        {
            MessageBox.Show("اظهارنامه جدید اضافه شد");
            _decTable.insert_new_dec(_bizManSsn, _totalVal, _originCountry, _transType);
        }

        internal void create_dec(string _bizManSsn, int _totalVal, string _originCountry, int _transType)
        {
            
            declare = new declaration(_bizManSsn, _totalVal, _originCountry, _transType);
            insert_new_dec(_bizManSsn, _totalVal, _originCountry, _transType);
        }

        public List<string> get_rule(string _bizManSsn, string _date, int _totalVal, string _originCountry, int _transType, List<good> goodList)
        {
            List<String> licenseName = new List<string>();
            licenseName = rc.get_rule_(_bizManSsn, _date, _totalVal, _originCountry, _transType, goodList);
            needed_lincenses = licenseName;
            return licenseName;
        }
        private int get_decID()
        {
            return _decTable.get_decID() + 1;
        }
        public int send_declare(List<int> owned_licenses, List<good> gc)
        {
            validationCtrl vc = new validationCtrl(declare);
            return vc.is_valid(needed_lincenses, owned_licenses, gc);
        }
    }
}
