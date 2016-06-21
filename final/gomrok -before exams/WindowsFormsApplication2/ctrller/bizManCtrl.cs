using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gomrok.DB;
namespace gomrok.ctrller
{
    class bizManCtrl
    {
        database db = database.getDataBase();
        bizManTable _bizManTable = bizManTable.get_bizMan_table();
        internal void insert_new_bizMan(string ssn, string firstName, string lastName)
        {
            _bizManTable.insert_new_bizMan(ssn, firstName, lastName);
        }
    }
}
