using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace gomrok.DB
{
    class connection
    {
        database db = database.getDataBase();
        private static SQLiteConnection instance = null;
        private connection(){}

        public static SQLiteConnection get_instance()
        {
            if (instance == null)
            {
                instance = new SQLiteConnection("Data Source=coolGomrok.sqlite;Version=3");
                instance.Open();
            }
            
            return instance;
        }
    }
}
