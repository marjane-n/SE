using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace gomrok.DB
{
    class database
    {
        private static database db = null;
        SQLiteConnection sqliteConnecetion;

        private database()
        {

            sqliteConnecetion = new SQLiteConnection("Data Source=coolGomrok.sqlite;Version=3");
            sqliteConnecetion.Open();

            SQLiteCommand usersTable = new SQLiteCommand("create table if not exists userTable_2(userId Integer PRIMARY KEY AUTOINCREMENT, username Text, password Text,userType Integer, org Text DEFAULT NULL);", sqliteConnecetion);
            usersTable.ExecuteNonQuery();

            SQLiteCommand dec_Table = new SQLiteCommand("create table if not exists declareTable(ID Integer PRIMARY KEY AUTOINCREMENT, bizManSsn Text, date CURRENT_DATE, totalVal Integer, originCountry Text, transType Integer, FOREIGN KEY(bizManSsn) REFERENCES bizManTable(ssn));", sqliteConnecetion);
            dec_Table.ExecuteNonQuery();

            SQLiteCommand bizMTable = new SQLiteCommand("create table if not exists bizManTable(ssn Text PRIMARY KEY, firstName Text, lastName Text);", sqliteConnecetion);
            bizMTable.ExecuteNonQuery();

            SQLiteCommand gTable = new SQLiteCommand("create table if not exists declaregoodTable(ID INTEGER PRIMARY KEY AUTOINCREMENT, name Text, company Text, weight Integer, qnty Integer, unitPrice Integer, dec INTEGER, FOREIGN KEY(dec) REFERENCES decTable_1(ID));", sqliteConnecetion);
            gTable.ExecuteNonQuery();

            SQLiteCommand license_Table_ = new SQLiteCommand("create table if not exists licenseProTable( licenseID INTEGER PRIMARY KEY AUTOINCREMENT, licensename Text, org Text);", sqliteConnecetion);
            license_Table_.ExecuteNonQuery();

            SQLiteCommand _mainlicTable = new SQLiteCommand("create table if not exists MainlicenseTable(Id Integer PRIMARY KEY AUTOINCREMENT,Lid Integer, bizSSN Text , Name Text,TypeOfTrans Integer, MinAmount Integer,MaxAmount Integer, StartDate Text, EndDate Text, SrcCountry Text,FOREIGN KEY (Lid) REFERENCES  licenseProTable(licenseID));", sqliteConnecetion);
            _mainlicTable.ExecuteNonQuery();

            SQLiteCommand licnsMat = new SQLiteCommand("create table if not exists licenseMatTable(Id Integer PRIMARY KEY AUTOINCREMENT,Lid Integer, MName Text, MComp Text, MMinFee Integer ,MMaxFee Integer ,MMinWeight Integer,MMaxWeight Integer,MMinCount Integer,MMaxCount Integer,FOREIGN KEY(Lid) REFERENCES MainlicenseTable(Id));", sqliteConnecetion);
            licnsMat.ExecuteNonQuery();


            SQLiteCommand rule_Table_ = new SQLiteCommand("create table if not exists ruleTable_1(ruleID Integer PRIMARY KEY AUTOINCREMENT,ruleName Text, start_date Text, finish_date Text, min_total_value Integer, max_total_value Integer, origin_country Text, transType Integer );", sqliteConnecetion);
            rule_Table_.ExecuteNonQuery();

            
            SQLiteCommand rule_goodTable = new SQLiteCommand("create table if not exists ruledgoodTable(ID INTEGER PRIMARY KEY AUTOINCREMENT, name Text, producer_company Text, min_weight Integer,max_weight Integer, min_qnty Integer, max_qnty Integer, min_unitPrice Integer, max_unitPrice Integer, ruleId INTEGER, FOREIGN KEY(ruleId) REFERENCES ruleTable_(ruleID));", sqliteConnecetion);
            rule_goodTable.ExecuteNonQuery();

            SQLiteCommand license_rule_Table_ = new SQLiteCommand("create table if not exists license_rule_Table_( licenseID INTEGER, ruleID INTEGER, PRIMARY KEY(licenseID, ruleID));", sqliteConnecetion);
            license_rule_Table_.ExecuteNonQuery();


            sqliteConnecetion.Close();

            
        }

        public static database getDataBase()
        {
            if (db == null)
                db = new database();
            return db;
        }
    }
}
