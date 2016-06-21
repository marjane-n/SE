using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using gomrok.DB;

using System.Windows.Forms;

namespace gomrok.DB
{
    class decTable
    {
        private static decTable instance = null;
        SQLiteConnection sqliteConnecetion = connection.get_instance();
        ruleTable _ruleTable = ruleTable.get_rule_table();


        public decTable() { }

        public static decTable get_dec_table()
        {
            if (instance == null)
                instance = new decTable();

            return instance;
        }
        public void insert_new_dec(string bizManSsn, int totalVal, string originCountry, int transType)
        {
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO declareTable(bizManSsn, date, totalVal, originCountry, transType) VALUES ('" + bizManSsn + "', date('now'),'" + totalVal + "','" + originCountry + "','" + transType + "');", sqliteConnecetion);

            insertSQL.ExecuteNonQuery();
        }


        public int get_decID()
        {
            SQLiteCommand getPK = new SQLiteCommand("SELECT COALESCE(MAX(ID), 1) as MaxId FROM declareTable", sqliteConnecetion);
            int decCount = 0, decID = 0;
            SQLiteDataReader reader = getPK.ExecuteReader();
            while (reader.Read())
            {
                decID = Convert.ToInt32(reader["MaxId"]);
            }

            return decID;
        }

    }
}
