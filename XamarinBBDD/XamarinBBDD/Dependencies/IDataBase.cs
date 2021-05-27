using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinBBDD.Dependencies
{
    public interface IDataBase
    {
        SQLite.SQLiteConnection GetConnection();
    }
}
