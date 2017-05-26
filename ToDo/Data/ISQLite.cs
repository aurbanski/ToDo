using System;
using SQLite;
using SQLite.Net;

namespace ToDo.Data
{
    public interface ISQLite
    {
        SQLite.SQLiteConnection GetConnection();
    }
}
