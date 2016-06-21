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
    public class ruleTable
    {
        private static ruleTable instance = null;
        SQLiteConnection sqliteConnecetion = connection.get_instance();

        public ruleTable() { }

        public static ruleTable get_rule_table()
        {
            if (instance == null)
                instance = new ruleTable();

            return instance;
        }
        public void addLicense(List<int> pklist, int ruleID)
        {

            foreach (int pk in pklist)
            {

                SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO license_rule_Table_(licenseID, ruleID) VALUES ('" + pk + "','" + ruleID + "');", sqliteConnecetion);

                insertSQL.ExecuteNonQuery();

            }

        }
        public SQLiteDataReader get_rule_good(string gname)
        {
            SQLiteDataReader reader;
            SQLiteCommand cmd;
            cmd = new SQLiteCommand("SELECT * FROM licenseProTable, ruledgoodtable, license_rule_Table_  WHERE licenseProTable.licenseID = license_rule_Table_.licenseID" + " AND  ruledgoodtable.ruleid  = license_rule_Table_.ruleID " + " AND ruledgoodtable.name = '" + gname + "'", sqliteConnecetion);
            reader = cmd.ExecuteReader();

            return reader;
        }
        public SQLiteDataReader get_rule_notgood()
        {

            SQLiteDataReader reader;
            SQLiteCommand cmd;
            cmd = new SQLiteCommand("SELECT * FROM licenseProTable, ruledgoodtable, license_rule_Table_  WHERE licenseProTable.licenseID = license_rule_Table_.licenseID" + " AND  ruledgoodtable.ruleid  = license_rule_Table_.ruleID " + " AND ruledgoodtable.name = '' ", sqliteConnecetion);
            reader = cmd.ExecuteReader();

            return reader;

        }

        public SQLiteDataReader get_rule_dec()
        {
            SQLiteCommand cmd_otherField;
            SQLiteDataReader reader_otherField;
            cmd_otherField = new SQLiteCommand("SELECT * FROM ruleTable_1, license_rule_Table_,licenseProTable  WHERE  (ruleTable_1.ruleID NOT IN (select ruledgoodtable.ruleId from ruledgoodtable) AND ruleTable_1.ruleID = license_rule_Table_.ruleID AND  licenseProTable.licenseID = license_rule_Table_.licenseID)", sqliteConnecetion);
            reader_otherField = cmd_otherField.ExecuteReader();
            return reader_otherField;
        }

    
        public void insert_new_rule(string rulename, string start_date, string finish_date, int min_totalVal, int max_totalVal, string originCountry, int transType)
        {
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO ruleTable_1(ruleName, start_date, finish_date, min_total_value, max_total_value, origin_country, transType) VALUES ('" + rulename + "', '" + start_date + "', '" + finish_date + "', " + min_totalVal + ", " + max_totalVal + ",'" + originCountry + "'," + transType + ");", sqliteConnecetion);

            insertSQL.ExecuteNonQuery();
        }


        public int get_ruleID()
        {
            SQLiteCommand getPK = new SQLiteCommand("SELECT COALESCE(MAX(ruleID), 1) as MaxId FROM ruleTable_1", sqliteConnecetion);

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
