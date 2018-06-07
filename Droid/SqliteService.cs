using System;
using Xamarin.Forms;
using SQLite.Net;
using Loginsamaple;
using System.IO;

[assembly: Dependency(typeof(Loginsamaple.Droid.SqliteService))]
namespace Loginsamaple.Droid
{
    
    public class SqliteService:ISQLite
    {
        public SqliteService()
        {
        }
        public SQLite.Net.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "SQLiteEx.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, sqliteFilename);
            Console.WriteLine(path);
            if (!File.Exists(path))
                File.Create(path);
            var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var conn = new SQLite.Net.SQLiteConnection(plat, path);
            // Return the database connection 
            return conn;
        }
    }
}
