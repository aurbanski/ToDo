using System;
using ToDo.Data;
using SQLite;
using SQLite.Net;
using System.IO;
using WebKit;
using System.Diagnostics.Contracts;

[assembly:Xamarin.Forms.Dependency(typeof(ToDo.iOS.SQLite_iOS))]
namespace ToDo.iOS
{
    public class SQLite_iOS : ISQLite
    {
        public SQLite_iOS()
        {
        }

        public SQLite.SQLiteConnection GetConnection()
        {
            var path = "/Users/alexurbanski/ToDo.db";
            File.Open(path, FileMode.OpenOrCreate);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}
