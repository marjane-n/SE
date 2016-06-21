using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using gomrok.DB;
namespace gomrok.DB
{
    class decgoodTable
    {
        private static decgoodTable instance = null;
        SQLiteConnection sqliteConnecetion = connection.get_instance();

        public decgoodTable() { }

        public static decgoodTable get_good_table()
        {
            if (instance == null)
                instance = new decgoodTable();

            return instance;
        }

        public void insert_new_good(string name, string company, int weight, int qnty, int unitPrice, int dec)
        {
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO declaregoodTable(name, company, weight, qnty, unitPrice, dec) VALUES ('" + name + "','" + company + "','" + weight + "','" + qnty + "','" + unitPrice + "','" + dec + "');", sqliteConnecetion);
            insertSQL.ExecuteNonQuery();
        }
    }
}
