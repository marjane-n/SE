using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

using gomrok.DB;
namespace gomrok.DB
{
    class userTable
    {
         private static userTable instance = null;
         SQLiteConnection sqliteConnecetion = connection.get_instance();
         public string user_org;

        public userTable() { }

        public static userTable get_user_table()
        {
            if (instance == null)
                instance = new userTable();

            return instance;
        }

        public void insert_new_user( string user, string pass, int userType, string orgName)
        {
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO userTable_2(username, password, userType, org) VALUES ('" + user + "','" + pass + "','" + userType + "','" + orgName +"');", sqliteConnecetion);
            
            insertSQL.ExecuteNonQuery();
        }

        public int get_user_status(string user, string pass)
        {
            SQLiteCommand cmd;
            SQLiteDataReader reader;
            cmd = new SQLiteCommand("SELECT userType , org FROM userTable_2 WHERE username = '" + user + "' AND password  = '" + pass + "'", sqliteConnecetion);
            reader = cmd.ExecuteReader();

            int result = -1;

            while (reader.Read())
            {
                System.Int64 tmp = (System.Int64)reader["userType"];
                result = (int)tmp;
                user_org = (string)reader["org"];


            }
            // -1: no entry
            //  1:کارشناس گمرک 
            //  2:نماینده سازمان
            // 3: وزارت اقتصاد
            return result;
        }
    }
}
