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
    class licenseMatTable
    {
         private static licenseMatTable instance = null;
         SQLiteConnection sqliteConnecetion = connection.get_instance();
        
         public licenseMatTable() { }

         public static licenseMatTable get_license_table()
        {
            if (instance == null)
                instance = new licenseMatTable();

            return instance;
        }

         public void insert_new_licenseMat(int Lid, string MName, string Mcomp, int MMinFee, int MMaxFee, int MMinWeight, int MMaxWeight, int MMinCount, int MMaxCount)
        {
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO licenseMatTable(Lid, MName, Mcomp, MMinFee, MMaxFee, MMinWeight, MMaxWeight, MMinCount, MMaxCount) VALUES ('" + Lid + "','" + MName + "','" + Mcomp + "','" + MMinFee + "','" + MMaxFee + "','" + MMinWeight + "','" + MMaxWeight + "','" + MMinCount + "','" + MMaxCount + "');", sqliteConnecetion);
            insertSQL.ExecuteNonQuery();
        }

        public void insert_licenseMats(licenseMatContainer lm){
            foreach(licenseMat l in lm.licenseMatList())
                insert_new_licenseMat(l.Lid, l.MName, l.Mcomp, l.MMinFee, l.MMaxFee, l.MMinWeight, l.MMaxWeight, l.MMinCount, l.MMaxCount);
        }

        public int get_id()
        {
            SQLiteCommand getPK = new SQLiteCommand("SELECT COALESCE(MAX(Id), 1) as MaxId FROM licenseMatTable", sqliteConnecetion);

            int lmid = 0;

            SQLiteDataReader reader = getPK.ExecuteReader();
            while (reader.Read())
            {
                lmid = Convert.ToInt32(reader["MaxId"]);
            }
            return lmid;
        }

        public void updatelicMats(List<licenseMat> licMat)
        {
            foreach (licenseMat lm in licMat)
            {
                SQLiteCommand cmd = new SQLiteCommand("update licenseMatTable set MMaxWeight ='" + lm.MMaxWeight + "', MMaxCount='" + lm.MMaxCount + "' where Id ='" + lm.id + "'", sqliteConnecetion);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
