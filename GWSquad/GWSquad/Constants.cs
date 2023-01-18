using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GWSquad
{
    public class Constants
    {
        //public const string DatabaseFilename = "GWSquadDbSQLite.db3"; //file name of database
        public const string DatabaseFilename = "GWSquadDbSQLite3.db3"; //file name of database

        public const SQLite.SQLiteOpenFlags Flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DatabaseFilename);
            }
        }
    }
}
