using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using gomrok.DB;
using gomrok.Entity;

namespace gomrok.DB
{
    class licenseTable
    {
        private static licenseTable instance = null;
        SQLiteConnection sqliteConnecetion = connection.get_instance();

        public licenseTable() { }

        public static licenseTable get_license_table()
        {
            if (instance == null)
                instance = new licenseTable();

            return instance;
        }

        public void insert_new_license(int licenseID, string bizSSN, string Name, int TypeOfTrans, int MinAmount, int MaxAmount, string StartDate, string EndDate, string SrcCountry)
        {
            String sDate = null, fDate = null;
            if(!String.IsNullOrEmpty(StartDate))
                 sDate = StartDate.ToString();
            if(!String.IsNullOrEmpty(EndDate))
                 fDate = EndDate.ToString();
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO MainlicenseTable(Lid,bizSSN, Name, TypeOfTrans, MinAmount, MaxAmount, StartDate, EndDate, SrcCountry) VALUES ('" + licenseID + "','" + bizSSN + "','" +Name + "','"+ TypeOfTrans + "','" + MinAmount + "','" + MaxAmount + "','" + sDate + "','" + fDate + "','" + SrcCountry + "');", sqliteConnecetion);

            insertSQL.ExecuteNonQuery();
        }

        public void insert_licenses(licenseContainer lc)
        {
            foreach (license l in lc.licenseList())
                insert_new_license(l.licenseID, l.bizSSN, l.Name, l.TypeOfTrans, l.MinAmount, l.MaxAmount, l.StartDate, l.EndDate, l.SrcCountry);
        }

        public int get_id()
        {

            SQLiteCommand getPK = new SQLiteCommand("SELECT COALESCE(MAX(Id), 0) as MaxId FROM MainlicenseTable", sqliteConnecetion);
            int lid = 0;

            SQLiteDataReader reader = getPK.ExecuteReader();
            while (reader.Read())
            {
                lid = Convert.ToInt32(reader["MaxId"]);
            }
            return lid;
        }

        public void updateLicense(List<license> lic, List<int> owned)
        {
            int cnt = 0;
            foreach(license li in lic)
            {
                SQLiteCommand cmd = new SQLiteCommand ("update MainlicenseTable set MaxAmount ='" + li.MaxAmount + "' where Id ='" + owned[cnt] + "'");
                cnt += 1;
            }
        }
    }
}
