using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using gomrok.DB;

namespace gomrok.DB
{
    class rulegoodTable
    {
        private static rulegoodTable instance = null;
        SQLiteConnection sqliteConnecetion = connection.get_instance();

        public rulegoodTable() { }

        public static rulegoodTable get_good_table()
        {
            if (instance == null)
                instance = new rulegoodTable();

            return instance;
        }

        public void insert_new_good(string name, string company, int min_weight, int max_weight, int min_qnty, int max_qnty, int min_unitPrice, int max_unitPrice, int rule)
        {
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO ruledgoodTable(name, producer_company, min_weight,max_weight, min_qnty, max_qnty, min_unitPrice, max_unitPrice, ruleId) VALUES ('" + name + "','" + company + "','" + min_weight + "','" + max_weight + "','" + min_qnty + "','" + max_qnty + "','" + min_unitPrice + "','" + max_unitPrice + "','" + rule + "');", sqliteConnecetion);
            insertSQL.ExecuteNonQuery();
        }
    }
}
