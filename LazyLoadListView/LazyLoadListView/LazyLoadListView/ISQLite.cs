using SQLite;
using System;

namespace LazyLoadListView
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();

    }
}