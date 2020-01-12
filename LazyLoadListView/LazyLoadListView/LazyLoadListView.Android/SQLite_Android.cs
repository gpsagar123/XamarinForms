using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using LazyLoadListView.Droid;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Android))]
namespace LazyLoadListView.Droid
{
    class SQLite_Android : ISQLite
    {
        SQLiteConnection ISQLite.GetConnection()
        {
            string fileName = "MySampleDatabase.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string path = Path.Combine(documentPath, fileName);
            SQLiteConnection con = new SQLiteConnection(path);

            con.CreateTable<MyData>();
            return con;
        }
    }
}