using System;
using Dapper;
using System.Data.SQLite;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectDatabase
{
    public class DBConnection
    {
        public static string DbFile
        {
            get { return Environment.CurrentDirectory + "\tileQADb.sqlite"; }
        }

        public static SQLiteConnection SimpleDbConnection()
        {
            return new SQLiteConnection("Data Source=" + DbFile);
        }
    }
}
