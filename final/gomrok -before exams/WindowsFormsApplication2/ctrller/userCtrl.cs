using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using gomrok.DB;
namespace gomrok.ctrller
{
    class userCtrl
    {
        
        database db = database.getDataBase();
        userTable _userTable = userTable.get_user_table();
        public string user_org;
        internal void insert_new_user(string _user, string _pass, int _userType, string orgName)
        {
            MessageBox.Show("کاربر جدید اضافه شد");
            _userTable.insert_new_user(_user, _pass, _userType, orgName);
        }

        internal int get_user_status(string _user, string _pass)
        {
            int retval;
            retval=_userTable.get_user_status(_user, _pass);
            user_org = _userTable.user_org;
            return retval;

        }
    }
}
