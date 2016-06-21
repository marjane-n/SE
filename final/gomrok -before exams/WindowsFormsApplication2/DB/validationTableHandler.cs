using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using gomrok.Entity;

namespace gomrok.DB
{
    class validationTable
    {
        private static validationTable instance = null;
        SQLiteConnection sqliteConnecetion = connection.get_instance();

        public validationTable() { }
        public int gotAll(List<string> needed, List<int> owned, string dec_bizSsn)
        {
            SQLiteCommand cmd;
            SQLiteDataReader reader;
            foreach (string n in needed)
            {
                cmd = new SQLiteCommand("SELECT Name FROM MainlicenseTable  WHERE" + " bizSSN = '" + dec_bizSsn + "' AND Name = '" + n + "'", sqliteConnecetion);
                reader = cmd.ExecuteReader();

                if (!reader.Read())
                {
                    return -1;
                }

            }
            return 1;
        }
        public int isBelonged(List<int> owned, string dec_bizSsn)
        {
            SQLiteCommand cmd;
            SQLiteDataReader reader;
            int retval = -1;
            foreach (int ow in owned)
            {
                cmd = new SQLiteCommand("SELECT bizSSN FROM MainlicenseTable  WHERE  Id = " + ow, sqliteConnecetion);
                reader = cmd.ExecuteReader();
                retval = -1;
                while (reader.Read())
                {
                    retval = 1;
                    String bizSsn = (String)reader["bizSSN"];
                    if (!bizSsn.Equals(dec_bizSsn))
                    {
                        return -1;
                    }
                }
            }
            return retval;
        }

        public List<licenseMat> get_license_mat(List<int> owned)
        {
            List<licenseMat> lm = new List<licenseMat>();
            SQLiteCommand cmd;
            SQLiteDataReader reader;
            foreach (int ow in owned)
            {
                cmd = new SQLiteCommand("SELECT * FROM licenseMatTable  WHERE  Lid = " + ow, sqliteConnecetion);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int MMinFee = 0, MMaxFee= 0, MMinWeight = 0,MMaxWeight=0,MMinCount=0,MMaxCount=0; string _Mcomp = null , _MName = null;
                    int id = Convert.ToInt32(reader["Id"]);
                    int _licenseID = Convert.ToInt32(reader["Lid"]);
                    MMinFee=  Convert.ToInt32(reader["MMinFee"]);
                    MMaxFee = Convert.ToInt32(reader["MMaxFee"]);
                    MMinWeight=  Convert.ToInt32(reader["MMinWeight"]);
                    MMaxWeight=  Convert.ToInt32(reader["MMaxWeight"]);
                    MMinCount = Convert.ToInt32(reader["MMinCount"]);
                    MMaxCount=  Convert.ToInt32(reader["MMaxCount"]);
                    if (!String.IsNullOrEmpty((String)reader["MName"]))
                    {
                         _MName = (String)reader["MName"];
                    }
                    if (!String.IsNullOrEmpty((String)reader["MComp"]))
                    {
                         _Mcomp = (String)reader["MComp"];
                    }
                    lm.Add(new licenseMat(id,_licenseID, _MName, _Mcomp, MMinFee, MMaxFee, MMinWeight, MMaxWeight, MMinCount, MMaxCount));
                }
            }
            return lm;
        }

        public List<license> get_license_obj(List<int> owned)
        {
            List<license> l = new List<license>();
            SQLiteCommand cmd;
            SQLiteDataReader reader;
            foreach (int ow in owned)
            {
                cmd = new SQLiteCommand("SELECT * FROM MainlicenseTable  WHERE  Id = " + ow, sqliteConnecetion);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int transType = 0, minAmount = 0, maxAmount = 0;
                    int _licenseID = Convert.ToInt32(reader["Lid"]);
                    string _bizSSN = (String)reader["bizSSN"];
                    string _liName = (String)reader["Name"];

                    transType = Convert.ToInt32(reader["TypeOfTrans"]);
                    minAmount = Convert.ToInt32(reader["MinAmount"]);
                    maxAmount = Convert.ToInt32(reader["MaxAmount"]);

                    
                    string finDate = reader["EndDate"].ToString();
                    string startDate = reader["StartDate"].ToString();
                    string coun = (String)reader["SrcCountry"];      
                    l.Add(new license(_licenseID, _bizSSN, _liName, transType, minAmount, maxAmount, startDate, finDate, coun));
                }

            }
            return l;
       }

    }
 
}