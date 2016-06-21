using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using gomrok.DB;
using gomrok.Entity;
using gomrok.ctrller;

namespace gomrok.DB
{
    class licenseDesTable
    {
         private static licenseDesTable instance = null;
         SQLiteConnection sqliteConnection = connection.get_instance();
         public string license_org;

         public licenseDesTable() { }
         public int get_licID()
         {
             SQLiteCommand getPK = new SQLiteCommand("SELECT COALESCE(MAX(licenseID), 1) as MaxId FROM licenseProTable", sqliteConnection);
           
             int lID = 0;
             
             SQLiteDataReader reader = getPK.ExecuteReader();
             while (reader.Read())
             {
                 lID = Convert.ToInt32(reader["MaxId"]);
             }
             MessageBox.Show("max " + lID );
             return lID;
         }


         public int checkLicense(string licName)
         {
             int id = -1;
             SQLiteCommand cmd = new SQLiteCommand("select licenseID as id , org  from licenseProTable where licensename = '" + licName + "'", sqliteConnection);
             SQLiteDataReader reader = cmd.ExecuteReader();
             while (reader.Read())
             {
                 id = Convert.ToInt32(reader["id"]);
                 license_org = (string)(reader["org"]);
             }
             return id;
         }

         public int addLicenseDes(string licName, string orgname)
         {
             SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO licenseProTable(licensename, org) VALUES ('" + licName + "','" + orgname +"');", sqliteConnection);
             insertSQL.ExecuteNonQuery();
             MessageBox.Show("in licenseDesHanlder");

             return get_licID();
         }
         public static licenseDesTable get_licenseDes_table()
        {
            if (instance == null)
                instance = new licenseDesTable();
            return instance;
        }

    }
    
}
