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
    class bizManTable
    {
        private static bizManTable instance = null;
         SQLiteConnection sqliteConnecetion = connection.get_instance();

        public bizManTable() { }

        public static bizManTable get_bizMan_table()
        {
            if (instance == null)
                instance = new bizManTable();

            return instance;
        }

        public void insert_new_bizMan(string ssn, string firstName, string lastName)
        {
            SQLiteDataReader reader;
            SQLiteCommand checkBiz = new SQLiteCommand("SELECT * FROM bizManTable WHERE ssn = '" + ssn + "'", sqliteConnecetion);
            reader = checkBiz.ExecuteReader();
            while (reader.Read())
            {
                return;
            }
            MessageBox.Show("تاجر جدید اضافه شد");
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO bizManTable(ssn, firstName, lastName) VALUES ('" + ssn + "','" + firstName + "','" + lastName + "');", sqliteConnecetion);
            insertSQL.ExecuteNonQuery();
        }

    }
}
