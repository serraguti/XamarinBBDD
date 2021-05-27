using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using XamarinBBDD.Dependencies;
using XamarinBBDD.Droid;

[assembly: Dependency(typeof(SQLiteClient))]
namespace XamarinBBDD.Droid
{
    public class SQLiteClient : IDataBase
    {
        public SQLiteConnection GetConnection()
        {
            String bbddfile = "HOSPITAL.db3";
            String rutadocumentos =
System.Environment.GetFolderPath
(System.Environment.SpecialFolder.Personal);
            String path =
                Path.Combine(rutadocumentos, bbddfile);
            SQLiteConnection cn = new SQLiteConnection(path);
            return cn;
        }
    }
}